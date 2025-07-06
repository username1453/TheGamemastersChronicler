namespace TheGamemastersChronicler
{
    partial class EventProbabilitySetting
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
            btnEventProbabilitySubmit = new Button();
            SettingControlOverallChance = new NumericUpDown();
            SettingControlPersonalChance = new NumericUpDown();
            SettingControlTransformingChance = new NumericUpDown();
            SettingControlRivalChance = new NumericUpDown();
            SettingControlMundaneChance = new NumericUpDown();
            lblSettingControlOverall = new Label();
            SettingControlSettingChance = new NumericUpDown();
            lblSettingControlPersonal = new Label();
            lblSettingControlTransforming = new Label();
            lblSettingControlRival = new Label();
            lblSettingControlMundane = new Label();
            lblSettingControlSetting = new Label();
            EventProbabilityExplainer = new Label();
            ((System.ComponentModel.ISupportInitialize)SettingControlOverallChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlPersonalChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlTransformingChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlRivalChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlMundaneChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlSettingChance).BeginInit();
            SuspendLayout();
            // 
            // btnEventProbabilitySubmit
            // 
            btnEventProbabilitySubmit.Location = new Point(113, 200);
            btnEventProbabilitySubmit.Name = "btnEventProbabilitySubmit";
            btnEventProbabilitySubmit.Size = new Size(101, 24);
            btnEventProbabilitySubmit.TabIndex = 0;
            btnEventProbabilitySubmit.Text = "Save";
            btnEventProbabilitySubmit.UseVisualStyleBackColor = true;
            btnEventProbabilitySubmit.Click += btnEventProbabilitySubmit_Click;
            // 
            // SettingControlOverallChance
            // 
            SettingControlOverallChance.DecimalPlaces = 2;
            SettingControlOverallChance.Location = new Point(45, 36);
            SettingControlOverallChance.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            SettingControlOverallChance.Name = "SettingControlOverallChance";
            SettingControlOverallChance.Size = new Size(59, 21);
            SettingControlOverallChance.TabIndex = 1;
            SettingControlOverallChance.Value = Properties.Settings.Default.OverallChance;
            // 
            // SettingControlPersonalChance
            // 
            SettingControlPersonalChance.DecimalPlaces = 2;
            SettingControlPersonalChance.Location = new Point(248, 36);
            SettingControlPersonalChance.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            SettingControlPersonalChance.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            SettingControlPersonalChance.Name = "SettingControlPersonalChance";
            SettingControlPersonalChance.Size = new Size(63, 21);
            SettingControlPersonalChance.TabIndex = 2;
            SettingControlPersonalChance.Value = Properties.Settings.Default.PersonalChance;
            // 
            // SettingControlTransformingChance
            // 
            SettingControlTransformingChance.DecimalPlaces = 2;
            SettingControlTransformingChance.Location = new Point(248, 65);
            SettingControlTransformingChance.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            SettingControlTransformingChance.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            SettingControlTransformingChance.Name = "SettingControlTransformingChance";
            SettingControlTransformingChance.Size = new Size(63, 21);
            SettingControlTransformingChance.TabIndex = 3;
            SettingControlTransformingChance.Value = Properties.Settings.Default.TransformingChance;
            // 
            // SettingControlRivalChance
            // 
            SettingControlRivalChance.DecimalPlaces = 2;
            SettingControlRivalChance.Location = new Point(248, 94);
            SettingControlRivalChance.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            SettingControlRivalChance.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            SettingControlRivalChance.Name = "SettingControlRivalChance";
            SettingControlRivalChance.Size = new Size(63, 21);
            SettingControlRivalChance.TabIndex = 4;
            SettingControlRivalChance.Value = Properties.Settings.Default.RivalChance;
            // 
            // SettingControlMundaneChance
            // 
            SettingControlMundaneChance.DecimalPlaces = 2;
            SettingControlMundaneChance.Location = new Point(248, 123);
            SettingControlMundaneChance.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            SettingControlMundaneChance.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            SettingControlMundaneChance.Name = "SettingControlMundaneChance";
            SettingControlMundaneChance.Size = new Size(63, 21);
            SettingControlMundaneChance.TabIndex = 5;
            SettingControlMundaneChance.Value = Properties.Settings.Default.MundaneChance;
            // 
            // lblSettingControlOverall
            // 
            lblSettingControlOverall.AutoSize = true;
            lblSettingControlOverall.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSettingControlOverall.Location = new Point(25, 18);
            lblSettingControlOverall.Name = "lblSettingControlOverall";
            lblSettingControlOverall.Size = new Size(107, 15);
            lblSettingControlOverall.TabIndex = 6;
            lblSettingControlOverall.Text = "Overall Event %";
            // 
            // SettingControlSettingChance
            // 
            SettingControlSettingChance.DecimalPlaces = 2;
            SettingControlSettingChance.Location = new Point(248, 152);
            SettingControlSettingChance.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            SettingControlSettingChance.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            SettingControlSettingChance.Name = "SettingControlSettingChance";
            SettingControlSettingChance.Size = new Size(63, 21);
            SettingControlSettingChance.TabIndex = 7;
            SettingControlSettingChance.Value = Properties.Settings.Default.SettingChance;
            // 
            // lblSettingControlPersonal
            // 
            lblSettingControlPersonal.AutoSize = true;
            lblSettingControlPersonal.Location = new Point(139, 38);
            lblSettingControlPersonal.Name = "lblSettingControlPersonal";
            lblSettingControlPersonal.Size = new Size(103, 15);
            lblSettingControlPersonal.TabIndex = 8;
            lblSettingControlPersonal.Text = "Personal Event %";
            // 
            // lblSettingControlTransforming
            // 
            lblSettingControlTransforming.AutoSize = true;
            lblSettingControlTransforming.Location = new Point(115, 67);
            lblSettingControlTransforming.Name = "lblSettingControlTransforming";
            lblSettingControlTransforming.Size = new Size(127, 15);
            lblSettingControlTransforming.TabIndex = 9;
            lblSettingControlTransforming.Text = "Transforming Event %";
            // 
            // lblSettingControlRival
            // 
            lblSettingControlRival.AutoSize = true;
            lblSettingControlRival.Location = new Point(161, 96);
            lblSettingControlRival.Name = "lblSettingControlRival";
            lblSettingControlRival.Size = new Size(81, 15);
            lblSettingControlRival.TabIndex = 10;
            lblSettingControlRival.Text = "Rival Event %";
            // 
            // lblSettingControlMundane
            // 
            lblSettingControlMundane.AutoSize = true;
            lblSettingControlMundane.Location = new Point(135, 125);
            lblSettingControlMundane.Name = "lblSettingControlMundane";
            lblSettingControlMundane.Size = new Size(107, 15);
            lblSettingControlMundane.TabIndex = 11;
            lblSettingControlMundane.Text = "Mundane Event %";
            // 
            // lblSettingControlSetting
            // 
            lblSettingControlSetting.AutoSize = true;
            lblSettingControlSetting.Location = new Point(150, 154);
            lblSettingControlSetting.Name = "lblSettingControlSetting";
            lblSettingControlSetting.Size = new Size(92, 15);
            lblSettingControlSetting.TabIndex = 12;
            lblSettingControlSetting.Text = "Setting Event %";
            // 
            // EventProbabilityExplainer
            // 
            EventProbabilityExplainer.AutoSize = true;
            EventProbabilityExplainer.Location = new Point(12, 82);
            EventProbabilityExplainer.Name = "EventProbabilityExplainer";
            EventProbabilityExplainer.Size = new Size(114, 105);
            EventProbabilityExplainer.TabIndex = 13;
            EventProbabilityExplainer.Text = "Default values: \r\nOverall 1%, \r\nPersonal 17%, \r\nTransforming 22%, \r\nRival 8%, \r\nMundane 40%, \r\nSetting 13%";
            // 
            // EventProbabilitySetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 224, 214);
            ClientSize = new Size(366, 241);
            Controls.Add(EventProbabilityExplainer);
            Controls.Add(lblSettingControlSetting);
            Controls.Add(lblSettingControlMundane);
            Controls.Add(lblSettingControlRival);
            Controls.Add(lblSettingControlTransforming);
            Controls.Add(lblSettingControlPersonal);
            Controls.Add(SettingControlSettingChance);
            Controls.Add(lblSettingControlOverall);
            Controls.Add(SettingControlMundaneChance);
            Controls.Add(SettingControlRivalChance);
            Controls.Add(SettingControlTransformingChance);
            Controls.Add(SettingControlPersonalChance);
            Controls.Add(SettingControlOverallChance);
            Controls.Add(btnEventProbabilitySubmit);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "EventProbabilitySetting";
            Text = "Event Probability Settings";
            Load += EventProbabilitySetting_Load;
            ((System.ComponentModel.ISupportInitialize)SettingControlOverallChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlPersonalChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlTransformingChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlRivalChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlMundaneChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingControlSettingChance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEventProbabilitySubmit;
        private NumericUpDown SettingControlOverallChance;
        private NumericUpDown SettingControlPersonalChance;
        private NumericUpDown SettingControlTransformingChance;
        private NumericUpDown SettingControlRivalChance;
        private NumericUpDown SettingControlMundaneChance;
        private NumericUpDown SettingControlSettingChance;
        private Label lblSettingControlOverall;
        private Label lblSettingControlPersonal;
        private Label lblSettingControlTransforming;
        private Label lblSettingControlRival;
        private Label lblSettingControlMundane;
        private Label lblSettingControlSetting;
        private Label EventProbabilityExplainer;
    }
}