using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGamemastersChronicler.Random_Generator_Management
{
    public partial class RandomGeneratorsForm : Form
    {
        public RandomGeneratorsForm()
        {
            InitializeComponent();
            RefreshAllGenerators();
        }

        private void RefreshAllGenerators()
        {
            rdmgenNameResultBox.Items.Clear();
            rdmgenSurnameResultBox.Items.Clear();
            rdmgenStatResultBox.Items.Clear();
            rdmgenAgeResultBox.Items.Clear();
            rdmgenSpeciesResultBox.Items.Clear();
            rdmgenProfessionResultBox.Items.Clear();
            rdmgenPersonalityResultBox.Items.Clear();
            rdmgenVoiceResultBox.Items.Clear();
            rdmgenTrvlSkillResultBox.Items.Clear();
            rdmgen1ResultBox.Items.Clear();
            rdmgen2ResultBox.Items.Clear();
            rdmgen3ResultBox.Items.Clear();

            int fixedCount = 2;

            var nameResults = RandomGenerators.GenerateNames(fixedCount);
            var surnameResults = RandomGenerators.GenerateSurnames(fixedCount);
            var statResults = new List<string>();  // Filler for stats - hex values now
            for (int i = 0; i < fixedCount; i++)
            {
                int statValue = new Random().Next(1, 16);
                string hexValue = statValue.ToString("X"); // Convert to uppercase hex
                statResults.Add($"Stat_{i + 1}: 0x{hexValue}");
            }

            var ageResults = RandomGenerators.GenerateAges(fixedCount);
            var speciesResults = RandomGenerators.GenerateSpecies(fixedCount);
            var professionResults = RandomGenerators.GenerateProfession(fixedCount);
            var personalityResults = RandomGenerators.GeneratePersonality(fixedCount);
            var voiceResults = RandomGenerators.GenerateVoice(fixedCount);
            var trvlSkillResults = RandomGenerators.GeneratetrvlSkill(fixedCount);

            foreach (var name in nameResults) rdmgenNameResultBox.Items.Add(name);
            foreach (var surname in surnameResults) rdmgenSurnameResultBox.Items.Add(surname);
            foreach (var stat in statResults) rdmgenStatResultBox.Items.Add(stat);
            foreach (var age in ageResults) rdmgenAgeResultBox.Items.Add(age);
            foreach (var species in speciesResults) rdmgenSpeciesResultBox.Items.Add(species);
            foreach (var profession in professionResults) rdmgenProfessionResultBox.Items.Add(profession);
            foreach (var personality in personalityResults) rdmgenPersonalityResultBox.Items.Add(personality);
            foreach (var voice in voiceResults) rdmgenVoiceResultBox.Items.Add(voice);
            foreach (var skill in trvlSkillResults) rdmgenTrvlSkillResultBox.Items.Add(skill);

            // You can optionally fill rdmgen1ResultBox, rdmgen2ResultBox, rdmgen3ResultBox here if you have content for them
        }

        private void btnrdmgenReroll_Click(object sender, EventArgs e)
        {
            RefreshAllGenerators();
        }

    }
}
