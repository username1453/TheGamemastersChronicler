using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGamemastersChronicler.Date_Management
{
    public class DateAdvancer
    {
        private readonly MortalityManager mortalityManager;
        private readonly string characterDirectory;
        private readonly string deceasedDirectory;
        private readonly string settingsFolderPath;

        public DateAdvancer(MortalityManager mortalityManager, string characterDirectory, string deceasedDirectory, string settingsFolderPath)
        {
            this.mortalityManager = mortalityManager;
            this.characterDirectory = characterDirectory;
            this.deceasedDirectory = deceasedDirectory;
            this.settingsFolderPath = settingsFolderPath;
        }

        public AdvanceResult AdvanceDays(List<Character> characters, int year, int dayOfYear, int days)
        {
            ConcurrentBag<Character> modifiedCharacters = new();
            List<Character> deadCharacters = new();

            Random rng = new();

            for (int i = 0; i < days; i++)
            {
                dayOfYear++;

                if (dayOfYear > 365)
                {
                    dayOfYear = 1;
                    year++;

                    foreach (var character in characters.ToList())
                    {
                        character.character_Age++;
                        modifiedCharacters.Add(character);

                        if (mortalityManager.CheckIfCharacterDies(character.character_Age, rng))
                        {
                            lock (character)
                            {
                                character.character_Events.Add($"[Year {year}]: Died of old age.");
                                character.character_Notes.Add("Status: Deceased.");
                            }

                            MoveToDeceased(character);
                            deadCharacters.Add(character);
                            modifiedCharacters.Add(character);
                        }
                    }
                }

                Parallel.ForEach(characters, character =>
                {
                    string? dailyEvent = EventGenerator.GenerateDailyEvent(character, year, dayOfYear, settingsFolderPath);

                    if (!string.IsNullOrEmpty(dailyEvent))
                    {
                        string datedEvent = $"[Day {dayOfYear}, Year {year}]: {dailyEvent}";
                        lock (character)
                        {
                            character.character_Events.Add(datedEvent);
                        }
                        modifiedCharacters.Add(character);
                    }
                });
            }

            return new AdvanceResult
            {
                Year = year,
                DayOfYear = dayOfYear,
                ModifiedCharacters = modifiedCharacters.Distinct().ToList(),
                DeadCharacters = deadCharacters
            };
        }

        private void MoveToDeceased(Character character)
        {
            string sourceFile = Path.Combine(characterDirectory, $"{character.character_Name}.txt");
            string destFile = Path.Combine(deceasedDirectory, $"{character.character_Name}.txt");

            if (File.Exists(sourceFile))
            {
                File.Move(sourceFile, destFile, overwrite: true);
            }
        }
    }

    public class AdvanceResult
    {
        public int Year { get; set; }
        public int DayOfYear { get; set; }
        public List<Character> ModifiedCharacters { get; set; } = new();
        public List<Character> DeadCharacters { get; set; } = new();
    }
}
