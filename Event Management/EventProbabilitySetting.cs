using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGamemastersChronicler
{
    public partial class EventProbabilitySetting : Form
    {
        public EventProbabilitySetting()
        {
            InitializeComponent();
        }
        private void EventProbabilitySetting_Load(object sender, EventArgs e)
        {
            SettingControlOverallChance.Value = Properties.Settings.Default.OverallChance;
            SettingControlPersonalChance.Value = Properties.Settings.Default.PersonalChance;
            SettingControlTransformingChance.Value = Properties.Settings.Default.TransformingChance;
            SettingControlRivalChance.Value = Properties.Settings.Default.RivalChance;
            SettingControlMundaneChance.Value = Properties.Settings.Default.MundaneChance;
            SettingControlSettingChance.Value = Properties.Settings.Default.SettingChance;
        }

        private void btnEventProbabilitySubmit_Click(object sender, EventArgs e)
        {
                        decimal total = (decimal)SettingControlPersonalChance.Value +
                        (decimal)SettingControlTransformingChance.Value +
                        (decimal)SettingControlRivalChance.Value +
                        (decimal)SettingControlMundaneChance.Value +
                        (decimal)SettingControlSettingChance.Value;

            if (total != 100)
            {
                MessageBox.Show("The event category probabilities must add up to 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save to EventGenerator (runtime use)
            EventGenerator.chanceOfAnyEvent = (decimal)SettingControlOverallChance.Value;
            EventGenerator.ChancePersonal = (decimal)SettingControlPersonalChance.Value;
            EventGenerator.ChanceTransforming = (decimal)SettingControlTransformingChance.Value;
            EventGenerator.ChanceRival = (decimal)SettingControlRivalChance.Value;
            EventGenerator.ChanceMundane = (decimal)SettingControlMundaneChance.Value;
            EventGenerator.ChanceSetting = (decimal)SettingControlSettingChance.Value;

            // Save to persistent app settings
            Properties.Settings.Default.OverallChance = EventGenerator.chanceOfAnyEvent;
            Properties.Settings.Default.PersonalChance = EventGenerator.ChancePersonal;
            Properties.Settings.Default.TransformingChance = EventGenerator.ChanceTransforming;
            Properties.Settings.Default.RivalChance = EventGenerator.ChanceRival;
            Properties.Settings.Default.MundaneChance = EventGenerator.ChanceMundane;
            Properties.Settings.Default.SettingChance = EventGenerator.ChanceSetting;

            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
