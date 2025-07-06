using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TheGamemastersChronicler.Event_Management
{
    public class TagProcessor
    {
        private readonly string settingsFolderPath;
        private readonly Random random = new Random();

        public TagProcessor(string settingsFolderPath)
        {
            this.settingsFolderPath = settingsFolderPath;
        }

        public string ProcessTags(string eventText, Character character, int year, int dayOfYear)
        {
            var tagPattern = @"\[(.*?)\]";
            var matches = Regex.Matches(eventText, tagPattern);

            foreach (Match match in matches)
            {
                string tag = match.Groups[1].Value;

                if (tag.StartsWith("T"))
                {
                    string tableResult = ProcessTableTag(tag);
                    eventText = eventText.Replace($"[{tag}]", tableResult);
                }
                else
                {
                    ProcessRelationshipTag(tag, character, year, dayOfYear);
                    eventText = eventText.Replace($"[{tag}]", ""); // remove relationship tag from display
                }
            }

            return eventText;
        }

        private Dictionary<string, List<string>>? tableCache = null;

        private string ProcessTableTag(string tag)
        {
            // Load the table dictionary once
            if (tableCache == null)
            {
                string tablePath = Path.Combine(settingsFolderPath, "T_Tables.json");
                if (!File.Exists(tablePath))
                    return "[MISSING TABLE FILE]";

                string json = File.ReadAllText(tablePath);
                tableCache = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);
                if (tableCache == null)
                    return "[TABLE LOAD ERROR]";
            }

            if (!tableCache.TryGetValue(tag, out var table))
                return $"[MISSING TABLE: {tag}]";

            if (table.Count == 0)
                return $"[EMPTY TABLE: {tag}]";

            return table[random.Next(table.Count)];
        }

        private void ProcessRelationshipTag(string tag, Character character, int year, int dayOfYear)
        {
            string relationshipdate = $"Year {year}, Day {dayOfYear}";

            switch (tag.ToLower())
            {
                case "+1 lover":
                    character.character_Relationships.Add($"Lover: {relationshipdate}");
                    break;

                case "1 lover":
                    // Check if there is already a spouse
                    if (character.character_Relationships.Any(r => r.StartsWith("Spouse:")))
                    {
                        // Skip adding lover because married
                        //Debug.WriteLine($"[TAG PROCESSOR] Cannot assign '1 lover' because character is married.");
                    }
                    else
                    {
                        character.character_Relationships.RemoveAll(r => r.StartsWith("Lover:"));
                        character.character_Relationships.Add($"Lover: {relationshipdate}");
                    }
                    break;

                case "1 spouse":
                    // Check if there is already a spouse
                    if (character.character_Relationships.Any(r => r.StartsWith("Spouse:")))
                    {
                        // Skip adding Spouse because married
                        //Debug.WriteLine($"[TAG PROCESSOR] Cannot assign 'Spouse' because character is married.");
                    }
                    else
                    {
                        character.character_Relationships.RemoveAll(r => r.StartsWith("Lover:") || r.StartsWith("Spouse:"));
                        character.character_Relationships.Add($"Spouse: {relationshipdate}");
                    }
                    break;

                case "-1 spouse":
                    if (character.Spouses.Count > 0)
                        character.character_Relationships.Remove(character.Spouses[0]);
                    break;

                case "+1 friend":
                    if (character.Friends.Count < character.maxFriends)
                        character.character_Relationships.Add($"Friend: {relationshipdate}");
                    break;

                case "-1 friend":
                    if (character.Friends.Count > 0)
                        character.character_Relationships.Remove(character.Friends[0]);
                    break;

                case "+1 child":
                    if (character.Children.Count < character.maxChildren)
                        character.character_Relationships.Add($"Child: {relationshipdate}");
                    break;

                case "+1 rival":
                    if (character.Rivals.Count < character.maxRivals)
                        character.character_Relationships.Add($"Rival: {relationshipdate}");
                    break;

                case "-1 rival":
                    if (character.Rivals.Count > 0)
                        character.character_Relationships.Remove(character.Rivals[0]);
                    break;

                case "50/50 +1 rival or +1 friend":
                    if (random.Next(100) < 50)
                    {
                        if (character.Rivals.Count < character.maxRivals)
                            character.character_Relationships.Add($"Rival: {relationshipdate}");
                    }
                    else
                    {
                        if (character.Friends.Count < character.maxFriends)
                            character.character_Relationships.Add($"Friend: {relationshipdate}");
                    }
                    break;
            }
        }
    }
}