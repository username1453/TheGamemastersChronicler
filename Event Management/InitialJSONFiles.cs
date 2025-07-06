using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TheGamemastersChronicler.Event_Management
{
    public static class InitialJSONFiles
    {
        public static void CopyDefaultJsonToSettings(string settingsFolderPath)
        {
            CopyEmbeddedResourceIfMissing(settingsFolderPath, "TravellerDictionary.json");
            CopyEmbeddedResourceIfMissing(settingsFolderPath, "FantasyDictionary.json");
            CopyEmbeddedResourceIfMissing(settingsFolderPath, "T_Tables.json");
        }

        private static void CopyEmbeddedResourceIfMissing(string targetFolder, string fileName)
        {
            string targetFile = Path.Combine(targetFolder, fileName);

            if (!File.Exists(targetFile))
            {
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = $"TheGamemastersChronicler.{fileName}";

                using Stream stream = assembly.GetManifestResourceStream(resourceName);
                if (stream == null)
                {
                    MessageBox.Show($"Embedded JSON resource not found: {fileName}. Double-check the resource name.");
                    return;
                }

                using var reader = new StreamReader(stream);
                File.WriteAllText(targetFile, reader.ReadToEnd());
            }
        }
    }
}
