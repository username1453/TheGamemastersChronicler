namespace TheGamemastersChronicler
{
    partial class ManualDateChangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectedDay = new NumericUpDown();
            SelectedYear = new NumericUpDown();
            labelSelectedDay = new Label();
            labelSelectedYear = new Label();
            btnDateChangeCancel = new Button();
            btnDateChangeOK = new Button();
            ((System.ComponentModel.ISupportInitialize)SelectedDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectedYear).BeginInit();
            SuspendLayout();
            // 
            // SelectedDay
            // 
            SelectedDay.Location = new Point(41, 28);
            SelectedDay.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            SelectedDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SelectedDay.Name = "SelectedDay";
            SelectedDay.Size = new Size(69, 21);
            SelectedDay.TabIndex = 0;
            SelectedDay.TextAlign = HorizontalAlignment.Center;
            SelectedDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SelectedYear
            // 
            SelectedYear.Location = new Point(139, 27);
            SelectedYear.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            SelectedYear.Name = "SelectedYear";
            SelectedYear.Size = new Size(94, 21);
            SelectedYear.TabIndex = 1;
            SelectedYear.TextAlign = HorizontalAlignment.Center;
            SelectedYear.Value = new decimal(new int[] { 1500, 0, 0, 0 });
            // 
            // labelSelectedDay
            // 
            labelSelectedDay.AutoSize = true;
            labelSelectedDay.Location = new Point(41, 9);
            labelSelectedDay.Name = "labelSelectedDay";
            labelSelectedDay.Size = new Size(28, 15);
            labelSelectedDay.TabIndex = 2;
            labelSelectedDay.Text = "Day";
            // 
            // labelSelectedYear
            // 
            labelSelectedYear.AutoSize = true;
            labelSelectedYear.Location = new Point(139, 9);
            labelSelectedYear.Name = "labelSelectedYear";
            labelSelectedYear.Size = new Size(32, 15);
            labelSelectedYear.TabIndex = 3;
            labelSelectedYear.Text = "Year";
            // 
            // btnDateChangeCancel
            // 
            btnDateChangeCancel.Location = new Point(139, 54);
            btnDateChangeCancel.Name = "btnDateChangeCancel";
            btnDateChangeCancel.Size = new Size(75, 23);
            btnDateChangeCancel.TabIndex = 4;
            btnDateChangeCancel.Text = "Cancel";
            btnDateChangeCancel.UseMnemonic = false;
            btnDateChangeCancel.UseVisualStyleBackColor = true;
            // 
            // btnDateChangeOK
            // 
            btnDateChangeOK.Location = new Point(41, 55);
            btnDateChangeOK.Name = "btnDateChangeOK";
            btnDateChangeOK.Size = new Size(66, 23);
            btnDateChangeOK.TabIndex = 5;
            btnDateChangeOK.Text = "Accept";
            btnDateChangeOK.UseVisualStyleBackColor = true;
            // 
            // ManualDateChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 224, 214);
            ClientSize = new Size(263, 96);
            Controls.Add(btnDateChangeOK);
            Controls.Add(btnDateChangeCancel);
            Controls.Add(labelSelectedYear);
            Controls.Add(labelSelectedDay);
            Controls.Add(SelectedYear);
            Controls.Add(SelectedDay);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ManualDateChangeForm";
            Text = "Date Change";
            ((System.ComponentModel.ISupportInitialize)SelectedDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectedYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown SelectedDay;
        private NumericUpDown SelectedYear;
        private Label labelSelectedDay;
        private Label labelSelectedYear;
        private Button btnDateChangeCancel;
        private Button btnDateChangeOK;
    }
}