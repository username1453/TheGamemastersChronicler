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
    public partial class ManualDateChangeForm : Form
    {
        // Properties to expose the chosen values from the numeric controls
        public int SelectedYearValue => (int)SelectedYear.Value;
        public int SelectedDayValue => (int)SelectedDay.Value;

        public ManualDateChangeForm(int currentYear, int currentDay)
        {
            InitializeComponent();

            // Set the numeric controls to the current date values
            SelectedYear.Value = currentYear;
            SelectedDay.Value = currentDay;

            btnDateChangeOK.Click += (s, e) => DialogResult = DialogResult.OK;
            btnDateChangeCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }
    }

}
