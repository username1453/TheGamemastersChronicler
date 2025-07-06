namespace TheGamemastersChronicler
{
    partial class CreateCharacterForm
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
            txtName = new TextBox();
            createcharacternamelabel = new Label();
            numericAge = new NumericUpDown();
            createcharacteragelabel = new Label();
            txtLocation = new TextBox();
            createcharacterlocationlabel = new Label();
            txtEvents = new TextBox();
            label1 = new Label();
            txtNotes = new TextBox();
            createcharacternoteslabel = new Label();
            btnSubmit = new Button();
            txtRelationships = new TextBox();
            createcharacterrelationslabel = new Label();
            pictureBox = new PictureBox();
            btnRandomGenerator = new Button();
            ((System.ComponentModel.ISupportInitialize)numericAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 9F);
            txtName.Location = new Point(27, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 21);
            txtName.TabIndex = 0;
            // 
            // createcharacternamelabel
            // 
            createcharacternamelabel.AutoSize = true;
            createcharacternamelabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            createcharacternamelabel.Location = new Point(27, 24);
            createcharacternamelabel.Name = "createcharacternamelabel";
            createcharacternamelabel.Size = new Size(131, 18);
            createcharacternamelabel.TabIndex = 1;
            createcharacternamelabel.Text = "Character Name";
            // 
            // numericAge
            // 
            numericAge.Font = new Font("Microsoft Sans Serif", 9F);
            numericAge.Location = new Point(311, 54);
            numericAge.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericAge.Name = "numericAge";
            numericAge.Size = new Size(55, 21);
            numericAge.TabIndex = 2;
            numericAge.TextAlign = HorizontalAlignment.Center;
            numericAge.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // createcharacteragelabel
            // 
            createcharacteragelabel.AutoSize = true;
            createcharacteragelabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            createcharacteragelabel.Location = new Point(278, 24);
            createcharacteragelabel.Name = "createcharacteragelabel";
            createcharacteragelabel.Size = new Size(115, 18);
            createcharacteragelabel.TabIndex = 3;
            createcharacteragelabel.Text = "Character Age";
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Microsoft Sans Serif", 9F);
            txtLocation.Location = new Point(27, 113);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(213, 21);
            txtLocation.TabIndex = 4;
            // 
            // createcharacterlocationlabel
            // 
            createcharacterlocationlabel.AutoSize = true;
            createcharacterlocationlabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            createcharacterlocationlabel.Location = new Point(27, 92);
            createcharacterlocationlabel.Name = "createcharacterlocationlabel";
            createcharacterlocationlabel.Size = new Size(213, 18);
            createcharacterlocationlabel.TabIndex = 5;
            createcharacterlocationlabel.Text = "Character Current Location";
            // 
            // txtEvents
            // 
            txtEvents.Font = new Font("Microsoft Sans Serif", 9F);
            txtEvents.Location = new Point(61, 204);
            txtEvents.Multiline = true;
            txtEvents.Name = "txtEvents";
            txtEvents.ScrollBars = ScrollBars.Vertical;
            txtEvents.Size = new Size(490, 99);
            txtEvents.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label1.Location = new Point(223, 183);
            label1.Name = "label1";
            label1.Size = new Size(170, 18);
            label1.TabIndex = 7;
            label1.Text = "Character Life Events";
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(12, 338);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(283, 71);
            txtNotes.TabIndex = 8;
            // 
            // createcharacternoteslabel
            // 
            createcharacternoteslabel.AutoSize = true;
            createcharacternoteslabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            createcharacternoteslabel.Location = new Point(72, 317);
            createcharacternoteslabel.Name = "createcharacternoteslabel";
            createcharacternoteslabel.Size = new Size(132, 18);
            createcharacternoteslabel.TabIndex = 9;
            createcharacternoteslabel.Text = "Character Notes";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(61, 415);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtRelationships
            // 
            txtRelationships.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRelationships.Location = new Point(327, 338);
            txtRelationships.Multiline = true;
            txtRelationships.Name = "txtRelationships";
            txtRelationships.ScrollBars = ScrollBars.Vertical;
            txtRelationships.Size = new Size(283, 71);
            txtRelationships.TabIndex = 11;
            // 
            // createcharacterrelationslabel
            // 
            createcharacterrelationslabel.AutoSize = true;
            createcharacterrelationslabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            createcharacterrelationslabel.Location = new Point(377, 317);
            createcharacterrelationslabel.Name = "createcharacterrelationslabel";
            createcharacterrelationslabel.Size = new Size(189, 18);
            createcharacterrelationslabel.TabIndex = 12;
            createcharacterrelationslabel.Text = "Character Relationships";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = Properties.Resources.Male_head_silhouette;
            pictureBox.Location = new Point(426, 28);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(172, 158);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 13;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // btnRandomGenerator
            // 
            btnRandomGenerator.Location = new Point(432, 415);
            btnRandomGenerator.Name = "btnRandomGenerator";
            btnRandomGenerator.Size = new Size(134, 23);
            btnRandomGenerator.TabIndex = 14;
            btnRandomGenerator.Text = "Random Generators";
            btnRandomGenerator.UseVisualStyleBackColor = true;
            btnRandomGenerator.Click += btnRandomGenerator_Click;
            // 
            // CreateCharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 224, 214);
            ClientSize = new Size(622, 450);
            Controls.Add(btnRandomGenerator);
            Controls.Add(pictureBox);
            Controls.Add(createcharacterrelationslabel);
            Controls.Add(txtRelationships);
            Controls.Add(btnSubmit);
            Controls.Add(createcharacternoteslabel);
            Controls.Add(txtNotes);
            Controls.Add(label1);
            Controls.Add(txtEvents);
            Controls.Add(createcharacterlocationlabel);
            Controls.Add(txtLocation);
            Controls.Add(createcharacteragelabel);
            Controls.Add(numericAge);
            Controls.Add(createcharacternamelabel);
            Controls.Add(txtName);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CreateCharacterForm";
            Text = "Create a Character Form";
            ((System.ComponentModel.ISupportInitialize)numericAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label createcharacternamelabel;
        private NumericUpDown numericAge;
        private Label createcharacteragelabel;
        private TextBox txtLocation;
        private Label createcharacterlocationlabel;
        private TextBox txtEvents;
        private Label label1;
        private TextBox txtNotes;
        private Label createcharacternoteslabel;
        private Button btnSubmit;
        private TextBox txtRelationships;
        private Label createcharacterrelationslabel;
        private PictureBox pictureBox;
        private Button btnRandomGenerator;
    }
}