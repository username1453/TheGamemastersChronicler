using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;


namespace TheGamemastersChronicler
{
    public partial class CharacterDetailForm : Form
    {
        public Character CharacterSheet { get; private set; }
        private string selectedImagePath;  // Store selected image path

        public CharacterDetailForm()
        {
            InitializeComponent();
        }

        private Character currentCharacter;

        public CharacterDetailForm(Character character)
        {
            InitializeComponent();
            detailtxtName.ReadOnly = true;
            currentCharacter = character;

            // Populate the form with existing character data
            detailtxtName.Text = character.character_Name;
            detailnumericAge.Value = character.character_Age;
            detailtxtLocation.Text = character.character_Location;
            detailtxtEvents.Lines = character.character_Events.ToArray();
            detailtxtNotes.Lines = character.character_Notes.ToArray();
            detailtxtRelationships.Lines = character.character_Relationships.ToArray();


            if (!string.IsNullOrEmpty(character.ImageFilePath) && File.Exists(character.ImageFilePath))
            {
                detailpictureBox.Image = Image.FromFile(character.ImageFilePath);
                selectedImagePath = character.ImageFilePath;
            }
        }


        private void detailcharactersheetbtnSubmit_Click(object sender, EventArgs e)
        {
            currentCharacter.character_Name = detailtxtName.Text.Trim();
            currentCharacter.character_Age = (int)detailnumericAge.Value;
            currentCharacter.character_Location = detailtxtLocation.Text.Trim();
            currentCharacter.character_Events = detailtxtEvents.Lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToList();
            currentCharacter.character_Notes = detailtxtNotes.Lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToList();
            currentCharacter.character_Relationships = detailtxtRelationships.Lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToList();
            currentCharacter.ImageFilePath = selectedImagePath;  // Save the image path

            string filePath = Path.Combine(AppConfig.CharacterDirectory, currentCharacter.character_FileName);
            currentCharacter.SaveToFile(filePath);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOpentxtFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Build the full path to the file
                string filePath = Path.Combine(AppConfig.CharacterDirectory, currentCharacter.character_FileName);

                if (File.Exists(filePath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true // important for default app launch
                    });
                }
                else
                {
                    MessageBox.Show("Character file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void detailpictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Character Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;

                    // To avoid locking the file, load into memory
                    using (FileStream fs = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                    {
                        detailpictureBox.Image = Image.FromStream(fs);
                    }
                }
            }
        }
    }

}
