using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheGamemastersChronicler.Random_Generator_Management;

namespace TheGamemastersChronicler
{
    public partial class CreateCharacterForm : Form
    {
        public Character CreatedCharacter { get; private set; }
        private string selectedImagePath;  // Store selected image path

        public CreateCharacterForm()
        {
            InitializeComponent();
        }

        // Constructor to accept an existing character (for duplication)
        public CreateCharacterForm(Character characterToCopy) : this()
        {
            if (characterToCopy != null)
            {
                // Pre-fill the form fields
                txtName.Text = characterToCopy.character_Name + " Copy";  // Append 'Copy' by default
                numericAge.Value = characterToCopy.character_Age;
                txtLocation.Text = characterToCopy.character_Location;
                txtEvents.Lines = characterToCopy.character_Events.ToArray();
                txtNotes.Lines = characterToCopy.character_Notes.ToArray();
                txtRelationships.Lines = characterToCopy.character_Relationships.ToArray();

                if (!string.IsNullOrEmpty(characterToCopy.ImageFilePath) && File.Exists(characterToCopy.ImageFilePath))
                {
                    pictureBox.Image = Image.FromFile(characterToCopy.ImageFilePath);
                    selectedImagePath = characterToCopy.ImageFilePath;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var character = new Character
            {
                character_Name = txtName.Text.Trim(),
                character_Age = (int)numericAge.Value,
                character_Location = txtLocation.Text.Trim(),
                character_Events = txtEvents.Lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToList(),
                character_Notes = txtNotes.Lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToList(),
                character_Relationships = txtRelationships.Lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToList(),
                ImageFilePath = selectedImagePath  // Save the image path
            };

            CreatedCharacter = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
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
                        pictureBox.Image = Image.FromStream(fs);
                    }
                }
            }
        }

        private void SetDefaultPicture()
        {
            string defaultImagePath = Path.Combine(Application.StartupPath, "Male_head_silhouette.png");

            if (File.Exists(defaultImagePath))
            {
                pictureBox.Image = Image.FromFile(defaultImagePath);
                selectedImagePath = defaultImagePath;
            }
            else
            {
                pictureBox.Image = Properties.Resources.Male_head_silhouette; // If you add a resource
                selectedImagePath = null;  // No file path for embedded resources
            }
        }

        private void btnRandomGenerator_Click(object sender, EventArgs e)
        {
            // Create a new instance of RandomGeneratorsForm
            RandomGeneratorsForm randomForm = new RandomGeneratorsForm();

            // Show the form as a non-modal window, can't use modal
            randomForm.Show();

        }
    }

}
