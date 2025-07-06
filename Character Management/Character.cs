using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheGamemastersChronicler
{
    public class Character
    {
        public string character_Name { get; set; }
        public int character_Age { get; set; }
        public string character_Location { get; set; }

        [Browsable(false)]
        public List<string> character_Events { get; set; } = new List<string>();
        public string LatestEvent => character_Events?.LastOrDefault() ?? "";
        [Browsable(false)]
        public string ImageFilePath { get; set; }  

        [Browsable(false)]
        public List<string> character_Notes { get; set; } = new List<string>();

        [Browsable(false)]
        public List<string> character_Relationships { get; set; } = new List<string>();
        
        [Browsable(false)]
        public int maxFriends = 10;
        [Browsable(false)]
        public int maxRivals = 5;
        [Browsable(false)]
        public int maxLovers = 1;
        [Browsable(false)]
        public int maxSpouses = 1;
        [Browsable(false)]
        public int maxChildren = 5;

        [Browsable(false)]
        public string character_FileName
        {
            get
            {
                var invalidChars = Path.GetInvalidFileNameChars();
                var safeName = string.Join("_", character_Name.Split(invalidChars, StringSplitOptions.RemoveEmptyEntries));
                return $"{safeName}.txt";
            }
        }

        // Categorized relationships for internal logic
        public List<string> Friends => character_Relationships.Where(r => r.StartsWith("Friend: ")).ToList();
        public List<string> Rivals => character_Relationships.Where(r => r.StartsWith("Rival: ")).ToList();
        public List<string> Lovers => character_Relationships.Where(r => r.StartsWith("Lover: ")).ToList();
        public List<string> Spouses => character_Relationships.Where(r => r.StartsWith("Spouse: ")).ToList();
        public List<string> Children => character_Relationships.Where(r => r.StartsWith("Child: ")).ToList();



        [Browsable(false)]
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Name: {character_Name}");
                writer.WriteLine($"Age: {character_Age}");
                writer.WriteLine($"Location: {character_Location}");
                writer.WriteLine("Events:");
                foreach (string e in character_Events)
                    writer.WriteLine($"- {e}");
                writer.WriteLine("Notes:");
                foreach (string n in character_Notes)
                    writer.WriteLine($"- {n}");
                writer.WriteLine("Relationships:");
                foreach (string r in character_Relationships)
                    writer.WriteLine($"- {r}");
                writer.WriteLine($"Picture File Path: {ImageFilePath ?? ""}");
            }
        }


    }
}
