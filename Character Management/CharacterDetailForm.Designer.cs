namespace TheGamemastersChronicler
{
    partial class CharacterDetailForm
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
            detailtxtName = new TextBox();
            detailnamelabel = new Label();
            detailnumericAge = new NumericUpDown();
            detailagelabel = new Label();
            detailtxtLocation = new TextBox();
            detaillocationlabel = new Label();
            detailtxtEvents = new TextBox();
            detaillabel1 = new Label();
            detailtxtNotes = new TextBox();
            detailnoteslabel = new Label();
            detailcharactersheetbtnSubmit = new Button();
            btnOpentxtFile = new Button();
            detailtxtRelationships = new TextBox();
            detailrelationslabel = new Label();
            detailpictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)detailnumericAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailpictureBox).BeginInit();
            SuspendLayout();
            // 
            // detailtxtName
            // 
            detailtxtName.Font = new Font("Microsoft Sans Serif", 9F);
            detailtxtName.Location = new Point(36, 55);
            detailtxtName.Name = "detailtxtName";
            detailtxtName.Size = new Size(213, 21);
            detailtxtName.TabIndex = 0;
            // 
            // detailnamelabel
            // 
            detailnamelabel.AutoSize = true;
            detailnamelabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            detailnamelabel.Location = new Point(36, 24);
            detailnamelabel.Name = "detailnamelabel";
            detailnamelabel.Size = new Size(131, 18);
            detailnamelabel.TabIndex = 1;
            detailnamelabel.Text = "Character Name";
            // 
            // detailnumericAge
            // 
            detailnumericAge.Font = new Font("Microsoft Sans Serif", 9F);
            detailnumericAge.Location = new Point(310, 55);
            detailnumericAge.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            detailnumericAge.Name = "detailnumericAge";
            detailnumericAge.Size = new Size(55, 21);
            detailnumericAge.TabIndex = 2;
            detailnumericAge.TextAlign = HorizontalAlignment.Center;
            detailnumericAge.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // detailagelabel
            // 
            detailagelabel.AutoSize = true;
            detailagelabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            detailagelabel.Location = new Point(285, 24);
            detailagelabel.Name = "detailagelabel";
            detailagelabel.Size = new Size(115, 18);
            detailagelabel.TabIndex = 3;
            detailagelabel.Text = "Character Age";
            // 
            // detailtxtLocation
            // 
            detailtxtLocation.Font = new Font("Microsoft Sans Serif", 9F);
            detailtxtLocation.Location = new Point(36, 106);
            detailtxtLocation.Name = "detailtxtLocation";
            detailtxtLocation.Size = new Size(213, 21);
            detailtxtLocation.TabIndex = 4;
            // 
            // detaillocationlabel
            // 
            detaillocationlabel.AutoSize = true;
            detaillocationlabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            detaillocationlabel.Location = new Point(36, 85);
            detaillocationlabel.Name = "detaillocationlabel";
            detaillocationlabel.Size = new Size(213, 18);
            detaillocationlabel.TabIndex = 5;
            detaillocationlabel.Text = "Character Current Location";
            // 
            // detailtxtEvents
            // 
            detailtxtEvents.Font = new Font("Microsoft Sans Serif", 9F);
            detailtxtEvents.Location = new Point(65, 205);
            detailtxtEvents.Multiline = true;
            detailtxtEvents.Name = "detailtxtEvents";
            detailtxtEvents.ScrollBars = ScrollBars.Vertical;
            detailtxtEvents.Size = new Size(490, 99);
            detailtxtEvents.TabIndex = 6;
            // 
            // detaillabel1
            // 
            detaillabel1.AutoSize = true;
            detaillabel1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            detaillabel1.Location = new Point(230, 184);
            detaillabel1.Name = "detaillabel1";
            detaillabel1.Size = new Size(170, 18);
            detaillabel1.TabIndex = 7;
            detaillabel1.Text = "Character Life Events";
            // 
            // detailtxtNotes
            // 
            detailtxtNotes.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailtxtNotes.Location = new Point(12, 338);
            detailtxtNotes.Multiline = true;
            detailtxtNotes.Name = "detailtxtNotes";
            detailtxtNotes.ScrollBars = ScrollBars.Vertical;
            detailtxtNotes.Size = new Size(283, 71);
            detailtxtNotes.TabIndex = 8;
            // 
            // detailnoteslabel
            // 
            detailnoteslabel.AutoSize = true;
            detailnoteslabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            detailnoteslabel.Location = new Point(65, 317);
            detailnoteslabel.Name = "detailnoteslabel";
            detailnoteslabel.Size = new Size(132, 18);
            detailnoteslabel.TabIndex = 9;
            detailnoteslabel.Text = "Character Notes";
            // 
            // detailcharactersheetbtnSubmit
            // 
            detailcharactersheetbtnSubmit.Location = new Point(122, 415);
            detailcharactersheetbtnSubmit.Name = "detailcharactersheetbtnSubmit";
            detailcharactersheetbtnSubmit.Size = new Size(75, 23);
            detailcharactersheetbtnSubmit.TabIndex = 10;
            detailcharactersheetbtnSubmit.Text = "Save";
            detailcharactersheetbtnSubmit.UseVisualStyleBackColor = true;
            detailcharactersheetbtnSubmit.Click += detailcharactersheetbtnSubmit_Click;
            // 
            // btnOpentxtFile
            // 
            btnOpentxtFile.Location = new Point(444, 415);
            btnOpentxtFile.Name = "btnOpentxtFile";
            btnOpentxtFile.Size = new Size(75, 23);
            btnOpentxtFile.TabIndex = 11;
            btnOpentxtFile.Text = "Open .txt";
            btnOpentxtFile.UseVisualStyleBackColor = true;
            btnOpentxtFile.Click += btnOpentxtFile_Click;
            // 
            // detailtxtRelationships
            // 
            detailtxtRelationships.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailtxtRelationships.Location = new Point(327, 338);
            detailtxtRelationships.Multiline = true;
            detailtxtRelationships.Name = "detailtxtRelationships";
            detailtxtRelationships.ScrollBars = ScrollBars.Vertical;
            detailtxtRelationships.Size = new Size(283, 71);
            detailtxtRelationships.TabIndex = 12;
            // 
            // detailrelationslabel
            // 
            detailrelationslabel.AutoSize = true;
            detailrelationslabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            detailrelationslabel.Location = new Point(366, 317);
            detailrelationslabel.Name = "detailrelationslabel";
            detailrelationslabel.Size = new Size(189, 18);
            detailrelationslabel.TabIndex = 13;
            detailrelationslabel.Text = "Character Relationships";
            // 
            // detailpictureBox
            // 
            detailpictureBox.BorderStyle = BorderStyle.Fixed3D;
            detailpictureBox.Image = Properties.Resources.Male_head_silhouette;
            detailpictureBox.Location = new Point(421, 24);
            detailpictureBox.Name = "detailpictureBox";
            detailpictureBox.Size = new Size(172, 158);
            detailpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            detailpictureBox.TabIndex = 14;
            detailpictureBox.TabStop = false;
            detailpictureBox.Click += detailpictureBox_Click;
            // 
            // CharacterDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 224, 214);
            ClientSize = new Size(622, 450);
            Controls.Add(detailpictureBox);
            Controls.Add(detailrelationslabel);
            Controls.Add(detailtxtRelationships);
            Controls.Add(btnOpentxtFile);
            Controls.Add(detailcharactersheetbtnSubmit);
            Controls.Add(detailnoteslabel);
            Controls.Add(detailtxtNotes);
            Controls.Add(detaillabel1);
            Controls.Add(detailtxtEvents);
            Controls.Add(detaillocationlabel);
            Controls.Add(detailtxtLocation);
            Controls.Add(detailagelabel);
            Controls.Add(detailnumericAge);
            Controls.Add(detailnamelabel);
            Controls.Add(detailtxtName);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CharacterDetailForm";
            Text = "NPC Character Sheet";
            ((System.ComponentModel.ISupportInitialize)detailnumericAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox detailtxtName;
        private Label detailnamelabel;
        private NumericUpDown detailnumericAge;
        private Label detailagelabel;
        private TextBox detailtxtLocation;
        private Label detaillocationlabel;
        private TextBox detailtxtEvents;
        private Label detaillabel1;
        private TextBox detailtxtNotes;
        private Label detailnoteslabel;
        private Button detailcharactersheetbtnSubmit;
        private Button btnOpentxtFile;
        private TextBox detailtxtRelationships;
        private Label detailrelationslabel;
        private PictureBox detailpictureBox;
    }
}