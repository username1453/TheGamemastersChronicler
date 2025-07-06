using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TheGamemastersChronicler
{
    public static class EventPools
    {
        private static Random rng => Random.Shared;

        private static Dictionary<int, PersonalDevelopmentEvent> _personalDevelopmentGroup;
        private static Dictionary<int, TransformingEvent> _transformingEventsGroup;
        private static Dictionary<int, RivalryEvent> _rivalEventsGroup;
        private static Dictionary<int, MundaneEvent> _mundaneEventsGroup;
        private static Dictionary<int, SettingEvent> _settingEventsGroup;

        public static IReadOnlyDictionary<int, PersonalDevelopmentEvent> PersonalDevelopmentGroup => _personalDevelopmentGroup;
        public static IReadOnlyDictionary<int, TransformingEvent> TransformingEventsGroup => _transformingEventsGroup;
        public static IReadOnlyDictionary<int, RivalryEvent> RivalryEventsGroup => _rivalEventsGroup;
        public static IReadOnlyDictionary<int, MundaneEvent> MundaneEventsGroup => _mundaneEventsGroup;
        public static IReadOnlyDictionary<int, SettingEvent> SettingEventsGroup => _settingEventsGroup;

        public static void LoadEventData(string combinedFilePath)
        {
            if (!File.Exists(combinedFilePath))
                throw new FileNotFoundException($"Could not find event data file: {combinedFilePath}");

            var json = File.ReadAllText(combinedFilePath);

            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                var root = doc.RootElement;

                _personalDevelopmentGroup = DeserializeGroup<PersonalDevelopmentEvent>(root, "PersonalDevelopmentGroup");
                _transformingEventsGroup = DeserializeGroup<TransformingEvent>(root, "TransformingEventsGroup");
                _rivalEventsGroup = DeserializeGroup<RivalryEvent>(root, "RivalEventsGroup");
                _mundaneEventsGroup = DeserializeGroup<MundaneEvent>(root, "MundaneEventsGroup");
                _settingEventsGroup = DeserializeGroup<SettingEvent>(root, "SettingSpecificEventsGroup");
            }
        }

        private static Dictionary<int, T> DeserializeGroup<T>(JsonElement root, string groupName)
        {
            if (!root.TryGetProperty(groupName, out JsonElement groupElement))
                throw new Exception($"JSON does not contain expected property '{groupName}'.");

            var dict = new Dictionary<int, T>();

            foreach (var property in groupElement.EnumerateObject())
            {
                if (int.TryParse(property.Name, out int key))
                {
                    T value = JsonSerializer.Deserialize<T>(property.Value.GetRawText());
                    dict[key] = value;
                }
            }

            return dict;
        }


        public static string GetRandomPersonalDevelopmentEvent()
        {
            int roll = rng.Next(1, PersonalDevelopmentGroup.Count + 1);
            var eventRow = PersonalDevelopmentGroup[roll];
            var categories = new List<string> { "SingleLife", "LoveLife", "Relationships", "Changes", "Friendships", "TurningPoint" };
            string chosenCategory = categories[rng.Next(categories.Count)];
            var property = typeof(PersonalDevelopmentEvent).GetProperty(chosenCategory);
            string chosenEvent = property?.GetValue(eventRow)?.ToString() ?? "No event found";

            //Debug.WriteLine($"Roll: {roll}, Category: {chosenCategory}, Event: {chosenEvent}");

            return chosenEvent ?? "No event found";
        }

        public static string GetRandomTransformingEvent()
        {
            int roll = rng.Next(1, TransformingEventsGroup.Count + 1);
            var eventRow = TransformingEventsGroup[roll];
            var categories = new List<string> { "Health", "Career", "Financial", "LawAndCrime", "SocialConflict", "MajorEvent" };
            string chosenCategory = categories[rng.Next(categories.Count)];
            var property = typeof(TransformingEvent).GetProperty(chosenCategory);
            string chosenEvent = property?.GetValue(eventRow)?.ToString() ?? "No event found";

            //Debug.WriteLine($"Roll: {roll}, Category: {chosenCategory}, Event: {chosenEvent}");

            return chosenEvent ?? "No event found";
        }
        public static string GetRandomRivalryEvent()
        {
            int roll = rng.Next(1, RivalryEventsGroup.Count + 1);
            var eventRow = RivalryEventsGroup[roll];
            var categories = new List<string> { "AddRivals", "Sabotage", "Reputation", "CollaborConflict", "Resolution", "Escalation" };
            string chosenCategory = categories[rng.Next(categories.Count)];
            var property = typeof(RivalryEvent).GetProperty(chosenCategory);
            string chosenEvent = property?.GetValue(eventRow)?.ToString() ?? "No event found";

            //Debug.WriteLine($"Roll: {roll}, Category: {chosenCategory}, Event: {chosenEvent}");

            return chosenEvent ?? "No event found";
        }

        public static string GetRandomMundaneEvent()
        {
            int roll = rng.Next(1, MundaneEventsGroup.Count + 1);
            var eventRow = MundaneEventsGroup[roll];
            var categories = new List<string> { "NewHobbies", "NewEntertainments", "PopularCulture", "LocalEvents", "MediaAndTrends", "PersonalIndulgence" };
            string chosenCategory = categories[rng.Next(categories.Count)];
            var property = typeof(MundaneEvent).GetProperty(chosenCategory);
            string chosenEvent = property?.GetValue(eventRow)?.ToString() ?? "No event found";

            //Debug.WriteLine($"Roll: {roll}, Category: {chosenCategory}, Event: {chosenEvent}");

            return chosenEvent ?? "No event found";
        }
        public static string GetRandomSettingEvent()
        {
            int roll = rng.Next(1, SettingEventsGroup.Count + 1);
            var eventRow = SettingEventsGroup[roll];
            var categories = new List<string> { "Disruption", "Society", "ConflictDanger", "Frontier", "PersonalRelationships", "CrimeSecretsJustice" };
            string chosenCategory = categories[rng.Next(categories.Count)];
            var property = typeof(SettingEvent).GetProperty(chosenCategory);
            string chosenEvent = property?.GetValue(eventRow)?.ToString() ?? "No event found";

            //Debug.WriteLine($"Roll: {roll}, Category: {chosenCategory}, Event: {chosenEvent}");

            return chosenEvent ?? "No event found";
        }
    }
    public class PersonalDevelopmentEvent
    {
        public string? SingleLife { get; set; }
        public string? LoveLife { get; set; }
        public string? Relationships { get; set; }
        public string? Changes { get; set; }
        public string? Friendships { get; set; }
        public string? TurningPoint { get; set; }
    }

    public class TransformingEvent
    {
        public string? Health { get; set; }
        public string? Career { get; set; }
        public string? Financial { get; set; }
        public string? LawAndCrime { get; set; }
        public string? SocialConflict { get; set; }
        public string? MajorEvent { get; set; }
    }

    public class RivalryEvent
    {
        public string? AddRivals { get; set; }
        public string? Sabotage { get; set; }
        public string? Reputation { get; set; }
        public string? CollaborConflict { get; set; }
        public string? Resolution { get; set; }
        public string? Escalation { get; set; }
    }

    public class MundaneEvent
    {
        public string? NewHobbies { get; set; }
        public string? NewEntertainments { get; set; }
        public string? PopularCulture { get; set; }
        public string? LocalEvents { get; set; }
        public string? MediaAndTrends { get; set; }
        public string? PersonalIndulgence { get; set; }
    }
    public class SettingEvent
    {
        public string? Disruption { get; set; }
        public string? Society { get; set; }
        public string? ConflictDanger { get; set; }
        public string? Frontier { get; set; }
        public string? PersonalRelationships { get; set; }
        public string? CrimeSecretsJustice { get; set; }
    }
}

