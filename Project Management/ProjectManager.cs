using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TheGamemastersChronicler.Character_Management;

namespace TheGamemastersChronicler.Project_Management
{
        public static class ProjectManager
        {
        public static void NewProject(string characterDirectory, string deceasedCharacterDirectory)
        {
            var result = MessageBox.Show(
                "This will clear all current data and start a new project. Are you sure?",
                "New Project",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            // Delete entire Characters directory (which includes Deceased)
            if (Directory.Exists(characterDirectory))
                Directory.Delete(characterDirectory, recursive: true);

            // Recreate Characters and Deceased subfolder
            Directory.CreateDirectory(characterDirectory);
            Directory.CreateDirectory(deceasedCharacterDirectory);

            // Reset application settings to defaults
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();

            MessageBox.Show("New project initialized. You can now add new characters.", "New Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SaveProject(string characterDirectory, string deceasedCharacterDirectory)
            {
                using (var folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Select a folder to save your project";

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string projectFolder = folderDialog.SelectedPath;
                        SaveProjectFiles(projectFolder, characterDirectory, deceasedCharacterDirectory);
                    }
                }
            }

        private static void SaveProjectFiles(string projectFolder, string charactersSource, string deceasedSource)
        {
            string charactersDest = Path.Combine(projectFolder, "Characters");
            string deceasedDest = Path.Combine(projectFolder, "DeceasedCharacters");

            // Check if either folder exists → prompt before deleting
            if (Directory.Exists(charactersDest) || Directory.Exists(deceasedDest))
            {
                var result = MessageBox.Show("This will overwrite existing project data. Continue?",
                                             "Confirm Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return; // cancel save
            }

            // Fully clear and recreate Characters folder
            if (Directory.Exists(charactersDest))
                Directory.Delete(charactersDest, recursive: true);
            Directory.CreateDirectory(charactersDest);

            // Fully clear and recreate DeceasedCharacters folder
            if (Directory.Exists(deceasedDest))
                Directory.Delete(deceasedDest, recursive: true);
            Directory.CreateDirectory(deceasedDest);

            // Copy character files
            foreach (var file in Directory.GetFiles(charactersSource, "*.txt"))
            {
                string destFile = Path.Combine(charactersDest, Path.GetFileName(file));
                File.Copy(file, destFile, overwrite: true);
            }

            // Copy deceased character files
            foreach (var file in Directory.GetFiles(deceasedSource, "*.txt"))
            {
                string destFile = Path.Combine(deceasedDest, Path.GetFileName(file));
                File.Copy(file, destFile, overwrite: true);
            }

            // Save project settings
            string settingsFile = Path.Combine(projectFolder, "project_settings.json");
            SaveSettingsToFile(settingsFile, charactersSource, deceasedSource);
        }


        private static void SaveSettingsToFile(string filePath, string charactersSource, string deceasedSource)
        {
            var settings = new
            {
                CharacterDirectory = charactersSource,
                DeceasedDirectory = deceasedSource,
                LastSaved = DateTime.Now.ToString("u"),
                LastUsedEventFile = Properties.Settings.Default.LastUsedEventFile,
                CurrentYear = Properties.Settings.Default.CurrentYear,
                CurrentDay = Properties.Settings.Default.CurrentDay,

                // Adding the event probabilities
                OverallChance = Properties.Settings.Default.OverallChance,
                PersonalChance = Properties.Settings.Default.PersonalChance,
                TransformingChance = Properties.Settings.Default.TransformingChance,
                RivalChance = Properties.Settings.Default.RivalChance,
                MundaneChance = Properties.Settings.Default.MundaneChance,
                SettingChance = Properties.Settings.Default.SettingChance
            };

            string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static void LoadProject(string targetCharacterDirectory, string targetDeceasedDirectory)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a saved project folder";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string projectFolder = folderDialog.SelectedPath;

                    string charactersSource = Path.Combine(projectFolder, "Characters");
                    string deceasedSource = Path.Combine(projectFolder, "DeceasedCharacters");
                    string settingsFile = Path.Combine(projectFolder, "project_settings.json");

                    if (!File.Exists(settingsFile))
                    {
                        MessageBox.Show("No project_settings.json found in selected folder.", "Load Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Load and deserialize settings
                    var settingsJson = File.ReadAllText(settingsFile);
                    var settings = JsonSerializer.Deserialize<ProjectSettings>(settingsJson);

                    if (settings == null)
                    {
                        MessageBox.Show("Failed to parse project settings.", "Load Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        // Clear old data before copying
                        if (Directory.Exists(targetCharacterDirectory))
                        {
                            RemoveReadOnlyAttributes(targetCharacterDirectory);
                            Directory.Delete(targetCharacterDirectory, recursive: true);
                        }
                        Directory.CreateDirectory(targetCharacterDirectory);

                        if (Directory.Exists(targetDeceasedDirectory))
                        {
                            RemoveReadOnlyAttributes(targetDeceasedDirectory);
                            Directory.Delete(targetDeceasedDirectory, recursive: true);
                        }
                        Directory.CreateDirectory(targetDeceasedDirectory);

                        // Copy character files from saved project to current project directories
                        CopyFiles(charactersSource, targetCharacterDirectory);
                        CopyFiles(deceasedSource, targetDeceasedDirectory);

                        // Update application settings from loaded project
                        Properties.Settings.Default.LastUsedEventFile = settings.LastUsedEventFile ?? string.Empty;
                        Properties.Settings.Default.CurrentYear = settings.CurrentYear;
                        Properties.Settings.Default.CurrentDay = settings.CurrentDay;
                        // Load event probability settings
                        Properties.Settings.Default.OverallChance = settings.OverallChance;
                        Properties.Settings.Default.PersonalChance = settings.PersonalChance;
                        Properties.Settings.Default.TransformingChance = settings.TransformingChance;
                        Properties.Settings.Default.RivalChance = settings.RivalChance;
                        Properties.Settings.Default.MundaneChance = settings.MundaneChance;
                        Properties.Settings.Default.SettingChance = settings.SettingChance;

                        Properties.Settings.Default.Save();

                        MessageBox.Show($"Project loaded successfully!\nLast saved: {settings.LastSaved}", "Load Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to load project:\n{ex.Message}", "Load Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private static void RemoveReadOnlyAttributes(string directoryPath)
        {
            if (!Directory.Exists(directoryPath)) return;

            var directoryInfo = new DirectoryInfo(directoryPath);
            foreach (var file in directoryInfo.GetFiles("*", SearchOption.AllDirectories))
            {
                if ((file.Attributes & FileAttributes.ReadOnly) != 0)
                    file.Attributes &= ~FileAttributes.ReadOnly;
            }
        }

        private static void CopyFiles(string sourceDir, string targetDir)
        {
            if (!Directory.Exists(sourceDir))
                return;

            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir, "*.txt"))
            {
                string destFile = Path.Combine(targetDir, Path.GetFileName(file));
                File.Copy(file, destFile, overwrite: true);
            }
        }

        private class ProjectSettings
        {
            public string CharacterDirectory { get; set; }
            public string DeceasedDirectory { get; set; }
            public string LastSaved { get; set; }
            public string LastUsedEventFile { get; set; }
            public int CurrentYear { get; set; }
            public int CurrentDay { get; set; }

            // Added event probabilities
            public int OverallChance { get; set; }
            public int PersonalChance { get; set; }
            public int TransformingChance { get; set; }
            public int RivalChance { get; set; }
            public int MundaneChance { get; set; }
            public int SettingChance { get; set; }
        }

    }
}
