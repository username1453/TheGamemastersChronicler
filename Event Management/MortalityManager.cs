using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGamemastersChronicler
{
    public class MortalityManager
    {
        private readonly string mortalityFilePath;
        private readonly List<(int minAge, int maxAge, double annualDeathChance)> mortalityRules = new();

        public MortalityManager(string filePath)
        {
            mortalityFilePath = filePath;
            EnsureMortalityFileExists();
            LoadMortalityRules();
        }

        private void EnsureMortalityFileExists()
        {
            if (!File.Exists(mortalityFilePath))
            {
                var defaultRules = new[]
                {
                    "0-4: 0.006",
                    "5-29: 0.002",
                    "30-49: 0.002",
                    "50-69: 0.01",
                    "70-89: 0.02",
                    "90+: 0.05",
                }
            ;
                File.WriteAllLines(mortalityFilePath, defaultRules);
            }
        }

        private void LoadMortalityRules()
        {
            mortalityRules.Clear();

            foreach (var line in File.ReadLines(mortalityFilePath))
            {
                var trimmed = line.Trim();
                if (string.IsNullOrWhiteSpace(trimmed) || trimmed.StartsWith("#"))
                    continue;

                var parts = trimmed.Split(':');
                if (parts.Length != 2)
                    continue;

                var ageRange = parts[0].Trim();
                var chanceText = parts[1].Trim();

                if (!double.TryParse(chanceText, out double chance))
                    continue;

                if (ageRange.Contains("+"))
                {
                    if (int.TryParse(ageRange.Replace("+", "").Trim(), out int min))
                    {
                        mortalityRules.Add((min, int.MaxValue, chance));
                    }
                }
                else if (ageRange.Contains("-"))
                {
                    var bounds = ageRange.Split('-');
                    if (bounds.Length == 2 &&
                        int.TryParse(bounds[0].Trim(), out int min) &&
                        int.TryParse(bounds[1].Trim(), out int max))
                    {
                        mortalityRules.Add((min, max, chance));
                    }
                }
            }
        }

        public bool CheckIfCharacterDies(int age, Random rng)
        {
            foreach (var (minAge, maxAge, chance) in mortalityRules)
            {
                if (age >= minAge && age <= maxAge)
                {
                    return rng.NextDouble() < chance;
                }
            }

            return false;
        }
    }
}  
