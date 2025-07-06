namespace TheGamemastersChronicler
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblCurrentDate = new Label();
            btnAdvanceOneDay = new Button();
            btnAdvanceNDays = new Button();
            contextMenuCharacterGrid = new ContextMenuStrip(components);
            toolStripCharacterGridEdit = new ToolStripMenuItem();
            toolStripCharacterGridDelete = new ToolStripMenuItem();
            toolStripCharacterGridDuplicate = new ToolStripMenuItem();
            colName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            txtDaysToAdvance = new TextBox();
            btnCreateCharacter = new Button();
            btnmanualdatechange = new Button();
            MainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewProject = new ToolStripMenuItem();
            SaveProject = new ToolStripMenuItem();
            LoadProject = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            SettingMenuEventProbability = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLoadJsonEvents = new Button();
            dgvCharacters = new DataGridView();
            btnGenerateRandChar = new Button();
            contextMenuCharacterGrid.SuspendLayout();
            MainMenuStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.Anchor = AnchorStyles.Bottom;
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentDate.Location = new Point(375, 28);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(281, 29);
            lblCurrentDate.TabIndex = 0;
            lblCurrentDate.Text = "Current Date: 0000-001";
            // 
            // btnAdvanceOneDay
            // 
            btnAdvanceOneDay.Anchor = AnchorStyles.None;
            btnAdvanceOneDay.BackColor = SystemColors.ButtonHighlight;
            btnAdvanceOneDay.FlatAppearance.BorderColor = Color.FromArgb(239, 240, 228);
            btnAdvanceOneDay.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdvanceOneDay.Location = new Point(8, 6);
            btnAdvanceOneDay.Margin = new Padding(3, 2, 3, 2);
            btnAdvanceOneDay.Name = "btnAdvanceOneDay";
            btnAdvanceOneDay.Size = new Size(71, 45);
            btnAdvanceOneDay.TabIndex = 1;
            btnAdvanceOneDay.Text = "Advance 1 Day";
            btnAdvanceOneDay.UseVisualStyleBackColor = false;
            btnAdvanceOneDay.Click += btnAdvanceOneDay_Click;
            // 
            // btnAdvanceNDays
            // 
            btnAdvanceNDays.Anchor = AnchorStyles.None;
            btnAdvanceNDays.BackColor = SystemColors.ButtonHighlight;
            btnAdvanceNDays.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdvanceNDays.Location = new Point(243, 6);
            btnAdvanceNDays.Margin = new Padding(3, 2, 3, 2);
            btnAdvanceNDays.Name = "btnAdvanceNDays";
            btnAdvanceNDays.Size = new Size(71, 44);
            btnAdvanceNDays.TabIndex = 2;
            btnAdvanceNDays.Text = "Advance # Days";
            btnAdvanceNDays.UseVisualStyleBackColor = false;
            btnAdvanceNDays.Click += btnAdvanceNDays_Click;
            // 
            // contextMenuCharacterGrid
            // 
            contextMenuCharacterGrid.Items.AddRange(new ToolStripItem[] { toolStripCharacterGridEdit, toolStripCharacterGridDelete, toolStripCharacterGridDuplicate });
            contextMenuCharacterGrid.Name = "contextMenuStrip1";
            contextMenuCharacterGrid.ShowImageMargin = false;
            contextMenuCharacterGrid.Size = new Size(102, 70);
            // 
            // toolStripCharacterGridEdit
            // 
            toolStripCharacterGridEdit.Font = new Font("Microsoft Sans Serif", 9F);
            toolStripCharacterGridEdit.Name = "toolStripCharacterGridEdit";
            toolStripCharacterGridEdit.Size = new Size(101, 22);
            toolStripCharacterGridEdit.Text = "Edit";
            toolStripCharacterGridEdit.Click += toolStripCharacterGridEdit_Click_1;
            // 
            // toolStripCharacterGridDelete
            // 
            toolStripCharacterGridDelete.Font = new Font("Microsoft Sans Serif", 9F);
            toolStripCharacterGridDelete.Name = "toolStripCharacterGridDelete";
            toolStripCharacterGridDelete.Size = new Size(101, 22);
            toolStripCharacterGridDelete.Text = "Delete";
            toolStripCharacterGridDelete.Click += toolStripCharacterGridDelete_Click;
            // 
            // toolStripCharacterGridDuplicate
            // 
            toolStripCharacterGridDuplicate.Font = new Font("Microsoft Sans Serif", 9F);
            toolStripCharacterGridDuplicate.Name = "toolStripCharacterGridDuplicate";
            toolStripCharacterGridDuplicate.Size = new Size(101, 22);
            toolStripCharacterGridDuplicate.Text = "Duplicate";
            toolStripCharacterGridDuplicate.Click += toolStripCharacterGridDuplicate_Click;
            // 
            // colName
            // 
            colName.Name = "colName";
            // 
            // colAge
            // 
            colAge.Name = "colAge";
            // 
            // colLocation
            // 
            colLocation.Name = "colLocation";
            // 
            // txtDaysToAdvance
            // 
            txtDaysToAdvance.Anchor = AnchorStyles.None;
            txtDaysToAdvance.BackColor = Color.FromArgb(239, 240, 228);
            txtDaysToAdvance.BorderStyle = BorderStyle.FixedSingle;
            txtDaysToAdvance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDaysToAdvance.Location = new Point(98, 15);
            txtDaysToAdvance.Name = "txtDaysToAdvance";
            txtDaysToAdvance.Size = new Size(123, 26);
            txtDaysToAdvance.TabIndex = 4;
            txtDaysToAdvance.Text = "# of Days";
            txtDaysToAdvance.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCreateCharacter
            // 
            btnCreateCharacter.Anchor = AnchorStyles.None;
            btnCreateCharacter.BackColor = SystemColors.ButtonHighlight;
            btnCreateCharacter.FlatAppearance.BorderColor = Color.FromArgb(239, 240, 228);
            btnCreateCharacter.Font = new Font("Microsoft Sans Serif", 9F);
            btnCreateCharacter.Location = new Point(804, 7);
            btnCreateCharacter.Margin = new Padding(3, 2, 3, 2);
            btnCreateCharacter.Name = "btnCreateCharacter";
            btnCreateCharacter.Size = new Size(162, 43);
            btnCreateCharacter.TabIndex = 5;
            btnCreateCharacter.Text = "Create a New Character";
            btnCreateCharacter.UseVisualStyleBackColor = false;
            btnCreateCharacter.Click += btnCreateCharacter_Click;
            // 
            // btnmanualdatechange
            // 
            btnmanualdatechange.Anchor = AnchorStyles.None;
            btnmanualdatechange.Location = new Point(714, 6);
            btnmanualdatechange.Name = "btnmanualdatechange";
            btnmanualdatechange.Size = new Size(67, 44);
            btnmanualdatechange.TabIndex = 6;
            btnmanualdatechange.Text = "Change the Date";
            btnmanualdatechange.UseVisualStyleBackColor = true;
            btnmanualdatechange.Click += btnmanualdatechange_Click;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Font = new Font("Microsoft Sans Serif", 9F);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(982, 24);
            MainMenuStrip.TabIndex = 9;
            MainMenuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewProject, SaveProject, LoadProject });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // NewProject
            // 
            NewProject.Name = "NewProject";
            NewProject.Size = new Size(143, 22);
            NewProject.Text = "New Project";
            NewProject.Click += NewProject_Click;
            // 
            // SaveProject
            // 
            SaveProject.Name = "SaveProject";
            SaveProject.Size = new Size(143, 22);
            SaveProject.Text = "Save Project";
            SaveProject.Click += SaveProject_Click;
            // 
            // LoadProject
            // 
            LoadProject.Name = "LoadProject";
            LoadProject.Size = new Size(143, 22);
            LoadProject.Text = "Load Project";
            LoadProject.Click += LoadProject_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SettingMenuEventProbability });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(63, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // SettingMenuEventProbability
            // 
            SettingMenuEventProbability.Name = "SettingMenuEventProbability";
            SettingMenuEventProbability.Size = new Size(164, 22);
            SettingMenuEventProbability.Text = "Event Probability";
            SettingMenuEventProbability.Click += settingsToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.891455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.8960743F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.353349F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.03002F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.429562F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.399538F));
            tableLayoutPanel1.Controls.Add(btnAdvanceOneDay, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAdvanceNDays, 2, 0);
            tableLayoutPanel1.Controls.Add(btnLoadJsonEvents, 5, 2);
            tableLayoutPanel1.Controls.Add(dgvCharacters, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCurrentDate, 3, 0);
            tableLayoutPanel1.Controls.Add(btnCreateCharacter, 5, 0);
            tableLayoutPanel1.Controls.Add(btnmanualdatechange, 4, 0);
            tableLayoutPanel1.Controls.Add(btnGenerateRandChar, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDaysToAdvance, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.17764F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.6447144F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3772459F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(982, 517);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // btnLoadJsonEvents
            // 
            btnLoadJsonEvents.Anchor = AnchorStyles.None;
            btnLoadJsonEvents.Location = new Point(829, 464);
            btnLoadJsonEvents.Name = "btnLoadJsonEvents";
            btnLoadJsonEvents.Size = new Size(113, 45);
            btnLoadJsonEvents.TabIndex = 8;
            btnLoadJsonEvents.Text = "Load Event File";
            btnLoadJsonEvents.UseVisualStyleBackColor = true;
            btnLoadJsonEvents.Click += btnLoadJsonEvents_Click;
            // 
            // dgvCharacters
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 244, 228);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCharacters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCharacters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCharacters.BackgroundColor = Color.FromArgb(251, 250, 246);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(239, 244, 228);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 220, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCharacters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCharacters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvCharacters, 6);
            dgvCharacters.ContextMenuStrip = contextMenuCharacterGrid;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 241, 228);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(190, 220, 240);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCharacters.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCharacters.Dock = DockStyle.Fill;
            dgvCharacters.EnableHeadersVisualStyles = false;
            dgvCharacters.Location = new Point(3, 59);
            dgvCharacters.Margin = new Padding(3, 2, 3, 2);
            dgvCharacters.Name = "dgvCharacters";
            dgvCharacters.RowHeadersWidth = 51;
            dgvCharacters.ScrollBars = ScrollBars.Vertical;
            dgvCharacters.Size = new Size(976, 396);
            dgvCharacters.TabIndex = 3;
            dgvCharacters.CellContentClick += dgvCharacters_CellContentClick;
            // 
            // btnGenerateRandChar
            // 
            btnGenerateRandChar.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(btnGenerateRandChar, 2);
            btnGenerateRandChar.Location = new Point(53, 464);
            btnGenerateRandChar.Name = "btnGenerateRandChar";
            btnGenerateRandChar.Size = new Size(126, 46);
            btnGenerateRandChar.TabIndex = 7;
            btnGenerateRandChar.Text = "Generate Random Character";
            btnGenerateRandChar.UseVisualStyleBackColor = true;
            btnGenerateRandChar.Click += btnGenerateRandChar_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 224, 214);
            ClientSize = new Size(982, 541);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MainMenuStrip);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            contextMenuCharacterGrid.ResumeLayout(false);
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentDate;
        private Button btnAdvanceOneDay;
        private Button btnAdvanceNDays;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colLocation;
        private TextBox txtDaysToAdvance;
        private Button btnCreateCharacter;
        private Button btnmanualdatechange;
        private ContextMenuStrip contextMenuCharacterGrid;
        private ToolStripMenuItem toolStripCharacterGridDelete;
        private ToolStripMenuItem toolStripCharacterGridDuplicate;
        private ToolStripMenuItem toolStripCharacterGridEdit;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem SaveProject;
        private ToolStripMenuItem LoadProject;
        private ToolStripMenuItem NewProject;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem SettingMenuEventProbability;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvCharacters;
        private Button btnLoadJsonEvents;
        private Button btnGenerateRandChar;
    }
}
