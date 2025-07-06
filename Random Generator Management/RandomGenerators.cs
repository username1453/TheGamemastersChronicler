using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGamemastersChronicler.Random_Generator_Management
{
    public static class RandomGenerators
    {
        private static Random rng = new Random();

        public static List<string> GenerateNames(int count)
        {
            var names = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int index = rng.Next(GeneratorPools.GivenNames.Count);
                names.Add(GeneratorPools.GivenNames[index]);
            }
            return names;
        }

        public static List<string> GenerateSurnames(int count)
        {
            var surnames = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int index = rng.Next(GeneratorPools.Surnames.Count);
                surnames.Add(GeneratorPools.Surnames[index]);
            }
            return surnames;
        }

        public static List<int> GenerateAges(int count)
        {
            var ages = new List<int>();
            for (int i = 0; i < count; i++)
            {
                ages.Add(rng.Next(5, 102)); // 5 to max 101
            }
            return ages;
        }

        public static List<string> GenerateSpecies(int count)
        {
            var species = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int index = rng.Next(GeneratorPools.Species.Count);
                species.Add(GeneratorPools.Species[index]);
            }
            return species;
        }

        public static List<string> GenerateProfession(int count)
        {
            var profession = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int index = rng.Next(GeneratorPools.Profession.Count);
                profession.Add(GeneratorPools.Profession[index]);
            }
            return profession;
        }

        public static List<string> GeneratePersonality(int count)
        {
            var personality = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int index = rng.Next(GeneratorPools.Personality.Count);
                personality.Add(GeneratorPools.Personality[index]);
            }
            return personality;
        }

        public static List<string> GenerateVoice(int count)
        {
            var voice = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int index = rng.Next(GeneratorPools.Voice.Count);
                voice.Add(GeneratorPools.Voice[index]);
            }
            return voice;
        }

        public static List<string> GeneratetrvlSkill(int count)
        {
            var trvlskill = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int index = rng.Next(GeneratorPools.trvlSkill.Count);
                trvlskill.Add(GeneratorPools.trvlSkill[index]);
            }
            return trvlskill;
        }

        // You can add: GenerateAlienNames(), GenerateCityNames(), etc.
    }
}
