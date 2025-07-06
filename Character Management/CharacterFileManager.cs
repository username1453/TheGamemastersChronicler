using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGamemastersChronicler.Character_Management
{
    public static class CharacterFileManager
    {
        public static List<Character> LoadAllCharacters(string directoryPath)
        {
            var characters = new List<Character>();

            foreach (var file in Directory.GetFiles(directoryPath, "*.txt"))
            {
                var character = ParseCharacterFile(file);
                if (character != null)
                    characters.Add(character);
            }

            return characters;
        }

        public static void SaveCharacter(Character character, string directoryPath)
        {
            string filePath = Path.Combine(directoryPath, character.character_FileName);

            using (StreamWriter writer = new(filePath, false))
            {
                writer.WriteLine($"Name: {character.character_Name}");
                writer.WriteLine($"Age: {character.character_Age}");
                writer.WriteLine($"Location: {character.character_Location}");

                writer.WriteLine("Events:");
                foreach (var ev in character.character_Events)
                    writer.WriteLine($"  - {ev}");

                writer.WriteLine("Notes:");
                foreach (var note in character.character_Notes)
                    writer.WriteLine($"  - {note}");

                writer.WriteLine("Relationships:");
                foreach (var relationship in character.character_Relationships)
                    writer.WriteLine($"  - {relationship}");
                writer.WriteLine($"Picture File Path: {character.ImageFilePath}");
            }
        }

        public static Character? ParseCharacterFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                var character = new Character();
                string? currentSection = null;

                foreach (var rawLine in lines)
                {
                    var line = rawLine.Trim();

                    if (line.StartsWith("Name:"))
                        character.character_Name = line.Substring(5).Trim();
                    else if (line.StartsWith("Age:"))
                        character.character_Age = int.Parse(line.Substring(4).Trim());
                    else if (line.StartsWith("Location:"))
                        character.character_Location = line.Substring(9).Trim();
                    else if (line.StartsWith("Events:"))
                        currentSection = "Events";
                    else if (line.StartsWith("Notes:"))
                        currentSection = "Notes";
                    else if (line.StartsWith("Relationships:"))
                        currentSection = "Relationships";
                    else if (line.StartsWith("Picture File Path:"))
                    {
                        character.ImageFilePath = line.Substring("Picture File Path:".Length).Trim();
                    }
                    else if (line.StartsWith("- "))
                    {
                        if (currentSection == "Events")
                            character.character_Events.Add(line.Substring(2).Trim());
                        else if (currentSection == "Notes")
                            character.character_Notes.Add(line.Substring(2).Trim());
                        else if (currentSection == "Relationships")
                            character.character_Relationships.Add(line.Substring(2).Trim());
                    }
                }

                return character;
            }
            catch
            {
                // Optional: log error or show message
                return null;
            }
        }
    }
}
