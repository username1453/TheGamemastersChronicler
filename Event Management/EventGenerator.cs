using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGamemastersChronicler
{
    internal class EventGenerator
    {
        private static Random rng => Random.Shared;

        // Overall chance to generate any event
        public static decimal chanceOfAnyEvent = Properties.Settings.Default.OverallChance;

        // Odds must add up to 100 
        public static decimal ChancePersonal { get; set; } = Properties.Settings.Default.PersonalChance;
        public static decimal ChanceTransforming { get; set; } = Properties.Settings.Default.TransformingChance;
        public static decimal ChanceRival { get; set; } = Properties.Settings.Default.RivalChance;
        public static decimal ChanceMundane { get; set; } = Properties.Settings.Default.MundaneChance;
        public static decimal ChanceSetting { get; set; } = Properties.Settings.Default.SettingChance;

        // Call this method once per day advanced
        public static string? GenerateDailyEvent(Character character, int year, int dayOfYear, string settingsFolderPath)
        {
            int eventHappensRoll = rng.Next(1, 101);

            if (eventHappensRoll > chanceOfAnyEvent)
                return null;

            string? rawEventText = null;
            int chanceRoll = rng.Next(1, 101);

            if (chanceRoll <= ChancePersonal)
                rawEventText = EventPools.GetRandomPersonalDevelopmentEvent();
            else if (chanceRoll <= ChancePersonal + ChanceTransforming)
                rawEventText = EventPools.GetRandomTransformingEvent();
            else if (chanceRoll <= ChancePersonal + ChanceTransforming + ChanceRival)
                rawEventText = EventPools.GetRandomRivalryEvent();
            else if (chanceRoll <= ChancePersonal + ChanceTransforming + ChanceRival + ChanceMundane)
                rawEventText = EventPools.GetRandomMundaneEvent();
            else if (chanceRoll <= ChancePersonal + ChanceTransforming + ChanceRival + ChanceMundane + ChanceSetting)
                rawEventText = EventPools.GetRandomSettingEvent();

            if (rawEventText == null) return null;

            var tagProcessor = new TheGamemastersChronicler.Event_Management.TagProcessor(settingsFolderPath);
            string processedEvent = tagProcessor.ProcessTags(rawEventText, character, year, dayOfYear);

            return processedEvent;
        }
    }
}
