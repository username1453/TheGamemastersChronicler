using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;
using TheGamemastersChronicler.Character_Management;
using TheGamemastersChronicler.Date_Management;
using TheGamemastersChronicler.Event_Management;
using TheGamemastersChronicler.Project_Management;

namespace TheGamemastersChronicler
{

    public partial class MainPage : Form
    {
        private string characterDirectory; //this is the character file location
        private int dayOfYear = 1; //default day and year
        private int year = 3000;

        private SortableBindingList<Character> characters = new SortableBindingList<Character>(); //to allow grid sorting
        private readonly string settingsFolderPath = Path.Combine(Application.StartupPath, "Settings");
        private readonly string mortalityFilePath; //file with random chance of death
        private MortalityManager mortalityManager; //import mortality code class
        private readonly string deceasedDirectory; //location of dead people
        private DateAdvancer dateAdvancer; //advance days code and everything calls the generation code


        public MainPage()
        {
            InitializeComponent();
            // Load saved date from settings
            year = Properties.Settings.Default.CurrentYear;
            dayOfYear = Properties.Settings.Default.CurrentDay;

            // Ensure Settings folder exists
            if (!Directory.Exists(settingsFolderPath))
                Directory.CreateDirectory(settingsFolderPath);

            // Copy the embedded JSON if needed
            InitialJSONFiles.CopyDefaultJsonToSettings(settingsFolderPath);

            // Initialize the mortalityFilePath with the folder included
            mortalityFilePath = Path.Combine(settingsFolderPath, "mortality.txt");

            // New mortality manager handles file creation
            mortalityManager = new MortalityManager(mortalityFilePath);

            InitializeCharacterDirectory();
            InitializeCharacters();
            deceasedDirectory = Path.Combine(characterDirectory, "Deceased");
            if (!Directory.Exists(deceasedDirectory))
                Directory.CreateDirectory(deceasedDirectory);
            UpdateDateLabel();
            SetupDataGridView();
            string lastPath = Properties.Settings.Default.LastUsedEventFile;
            if (!string.IsNullOrEmpty(lastPath) && File.Exists(lastPath))
            {
                btnLoadJsonEvents.Text = $"Loaded: {Path.GetFileName(lastPath)}";
            }
            dateAdvancer = new DateAdvancer(mortalityManager, characterDirectory, deceasedDirectory, settingsFolderPath); //date advancement code class, check Date Management
        }

        //bring in initial characters on startup
        private void InitializeCharacters()
        {
            characters.Clear();

            foreach (var file in Directory.GetFiles(characterDirectory, "*.txt"))
            {
                var character = LoadCharacterFromFile(file);
                if (character != null)
                    characters.Add(character);
            }
        }


        //read character files
        private Character? LoadCharacterFromFile(string filepath)
        {
            return CharacterFileManager.ParseCharacterFile(filepath);
        }

        private void UpdateDateLabel()
        {
            lblCurrentDate.Text = $"Year {year}, Day {dayOfYear}";
            UpdateCurrentDate(year, dayOfYear);
        }

        public static void UpdateCurrentDate(int year, int dayOfYear)
        {
            Properties.Settings.Default.CurrentYear = year;
            Properties.Settings.Default.CurrentDay = dayOfYear;
            Properties.Settings.Default.Save();
        }

        private void RefreshFromSettings()
        {
            year = Properties.Settings.Default.CurrentYear;
            dayOfYear = Properties.Settings.Default.CurrentDay;
            UpdateDateLabel();
        }

        //This is the viewer for the table with character info
        private void SetupDataGridView()
        {
            dgvCharacters.DataSource = null;
            dgvCharacters.DataSource = characters;

            foreach (DataGridViewColumn col in dgvCharacters.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            dgvCharacters.Columns["character_Name"].HeaderText = "Name";
            dgvCharacters.Columns["character_Age"].HeaderText = "Age";
            dgvCharacters.Columns["character_Location"].HeaderText = "Location";

            dgvCharacters.AutoResizeColumns();
            dgvCharacters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCharacters.ReadOnly = true;
            dgvCharacters.MultiSelect = false;

            dgvCharacters.CellDoubleClick -= DgvCharacters_CellDoubleClick; // remove old handlers first
            dgvCharacters.CellDoubleClick += DgvCharacters_CellDoubleClick; //add handler back
        }

        private void btnAdvanceOneDay_Click(object sender, EventArgs e)
        {
            AdvanceDays(1);
        }

        private void btnAdvanceNDays_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDaysToAdvance.Text, out int days) && days > 0)
            {
                AdvanceDays(days);
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for days to advance.");
            }
        }

        //It actually changes the date and manages most of the actions tied to that date (so nearly everything)
        private void AdvanceDays(int days)
        {
            var result = dateAdvancer.AdvanceDays(characters.ToList(), year, dayOfYear, days);

            year = result.Year;
            dayOfYear = result.DayOfYear;

            foreach (var character in result.ModifiedCharacters)
            {
                if (result.DeadCharacters.Contains(character))
                    CharacterFileManager.SaveCharacter(character, deceasedDirectory);
                else
                    CharacterFileManager.SaveCharacter(character, characterDirectory);
            }

            foreach (var dead in result.DeadCharacters)
            {
                characters.Remove(dead);
            }

            UpdateDateLabel();
            SetupDataGridView();
            MessageBox.Show($"Advanced {days} days!");
        }



        private void DgvCharacters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < characters.Count)
            {
                var character = characters[e.RowIndex];

                using (var characterForm = new CharacterDetailForm(character))
                {
                    if (characterForm.ShowDialog() == DialogResult.OK)
                    {
                        SetupDataGridView(); // refresh grid after editing
                    }
                }
            }
        }

        //unusued, but maybe there's a use for it? Thinking of maybe editing a single cell
        private void dgvCharacters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //create directory on first use
        private void InitializeCharacterDirectory()
        {
            characterDirectory = Path.Combine(Application.StartupPath, "Characters");

            if (!Directory.Exists(characterDirectory))
            {
                Directory.CreateDirectory(characterDirectory);
            }
        }

        //create a character.
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            var newCharacterForm = new CreateCharacterForm();
            if (newCharacterForm.ShowDialog() == DialogResult.OK)
            {
                var newCharacter = newCharacterForm.CreatedCharacter;
                characters.Add(newCharacter);
                CharacterFileManager.SaveCharacter(newCharacter, characterDirectory);
                SetupDataGridView(); // Refresh the display
            }
        }

        //manually changes date, intentionally does not trigger advance days
        private void btnmanualdatechange_Click(object sender, EventArgs e)
        {
            using var manualDateForm = new ManualDateChangeForm(year, dayOfYear);
            if (manualDateForm.ShowDialog() == DialogResult.OK)
            {
                year = manualDateForm.SelectedYearValue;
                dayOfYear = manualDateForm.SelectedDayValue;
                UpdateDateLabel();
            }
        }

        //should save date to setting, but says it's not referenced, appears to be working? Think because it's saved in settings
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Save current date to settings
            Properties.Settings.Default.CurrentYear = year;
            Properties.Settings.Default.CurrentDay = dayOfYear;
            Properties.Settings.Default.Save();
        }

        //Generate random test characters
        private void btnGenerateRandChar_Click(object sender, EventArgs e)
        {
            var newCharacters = CharacterGenerator.GenerateMultipleCharacters(10);

            foreach (var character in newCharacters)
            {
                characters.Add(character);
                CharacterFileManager.SaveCharacter(character, characterDirectory);
            }

            SetupDataGridView(); // Refresh display
            MessageBox.Show($"test characters generated.");
        }

        //the button that opens the explorer menu to select the event list
        private void btnLoadJsonEvents_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                dlg.Filter = "JSON files (*.json)|*.json";
                dlg.Title = "Select Event Data JSON file";

                // Pre-fill with previously used file if it exists
                if (!string.IsNullOrEmpty(Properties.Settings.Default.LastUsedEventFile) &&
                    File.Exists(Properties.Settings.Default.LastUsedEventFile))
                {
                    dlg.FileName = Properties.Settings.Default.LastUsedEventFile;
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        EventPools.LoadEventData(dlg.FileName);

                        // Save the file path to user settings
                        Properties.Settings.Default.LastUsedEventFile = dlg.FileName;
                        Properties.Settings.Default.Save();

                        // Change button text to show just the filename
                        btnLoadJsonEvents.Text = $"Loaded: {Path.GetFileName(dlg.FileName)}";

                        MessageBox.Show($"Loaded event data from:\n{dlg.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading event data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            var lastFile = Properties.Settings.Default.LastUsedEventFile;
            if (!string.IsNullOrEmpty(lastFile) && File.Exists(lastFile))
            {
                try
                {
                    EventPools.LoadEventData(lastFile);
                    btnLoadJsonEvents.Text = $"Loaded: {Path.GetFileName(lastFile)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading previous event file:\n{ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void toolStripCharacterGridDelete_Click(object sender, EventArgs e)
        {
            if (dgvCharacters.SelectedRows.Count > 0)
            {
                var character = characters[dgvCharacters.SelectedRows[0].Index];

                // Confirm deleting the character from the list (in memory)
                if (MessageBox.Show($"Delete character {character.character_Name} from list?",
                                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Remove from in-memory collection
                    characters.Remove(character);
                    SetupDataGridView();

                    // Confirm deleting the character file from disk
                    var filePath = Path.Combine(characterDirectory, character.character_FileName); // Adjust extension & folder as needed
                    if (File.Exists(filePath))
                    {
                        if (MessageBox.Show($"Delete character file from disk?\n{filePath}",
                                            "Confirm Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            try
                            {
                                File.Delete(filePath);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Failed to delete file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void toolStripCharacterGridDuplicate_Click(object sender, EventArgs e)
        {
            if (dgvCharacters.SelectedRows.Count > 0)
            {
                var original = characters[dgvCharacters.SelectedRows[0].Index];

                var duplicateForm = new CreateCharacterForm(original);
                if (duplicateForm.ShowDialog() == DialogResult.OK)
                {
                    var newCharacter = duplicateForm.CreatedCharacter;
                    characters.Add(newCharacter);
                    CharacterFileManager.SaveCharacter(newCharacter, characterDirectory);
                    SetupDataGridView();
                }
            }
        }

        private void toolStripCharacterGridEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvCharacters.SelectedRows.Count > 0)
            {
                var character = characters[dgvCharacters.SelectedRows[0].Index];
                using var characterForm = new CharacterDetailForm(character);
                if (characterForm.ShowDialog() == DialogResult.OK)
                {
                    SetupDataGridView();
                }
            }
        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveProject(characterDirectory, deceasedDirectory);
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            ProjectManager.LoadProject(characterDirectory, deceasedDirectory);
            InitializeCharacters();
            RefreshFromSettings();

        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            ProjectManager.NewProject(characterDirectory, deceasedDirectory);
            characters.Clear();
            RefreshFromSettings();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new EventProbabilitySetting())
            {
                settingsForm.ShowDialog();
            }
        }
    }
}

