namespace Frontend
{
    partial class Step2
    {
        private GroupBox grpRaceDetails;
        private Label lblSize;
        private Label lblSpeed;
        private Label lblLanguages;
        private Label lblFeatures;
        private TextBox txtDescription;

        private System.ComponentModel.IContainer components = null;
        private Label lblRace;
        private ComboBox cmbRace;
        private CheckBox chkDarkvision;
        private Label lblProficiencies;
        private CheckedListBox lstProficiencies;
        private Label lblBonusStat1;
        private ComboBox cmbBonusStat1;
        private Label lblBonusStat2;
        private ComboBox cmbBonusStat2;

        private void InitializeComponent()
        {
            lblRace = new Label();
            cmbRace = new ComboBox();
            chkDarkvision = new CheckBox();
            lblProficiencies = new Label();
            lstProficiencies = new CheckedListBox();
            lblBonusStat1 = new Label();
            cmbBonusStat1 = new ComboBox();
            lblBonusStat2 = new Label();
            cmbBonusStat2 = new ComboBox();
            grpRaceDetails = new GroupBox();
            lblSize = new Label();
            lblSpeed = new Label();
            lblLanguages = new Label();
            lblFeatures = new Label();
            txtDescription = new TextBox();
            grpRaceDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblRace
            // 
            lblRace.Location = new Point(20, 20);
            lblRace.Name = "lblRace";
            lblRace.Size = new Size(100, 23);
            lblRace.TabIndex = 0;
            lblRace.Text = "Select Race:";
            // 
            // cmbRace
            // 
            cmbRace.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRace.Location = new Point(120, 20);
            cmbRace.Name = "cmbRace";
            cmbRace.Size = new Size(180, 23);
            cmbRace.TabIndex = 1;
            // 
            // chkDarkvision
            // 
            chkDarkvision.Location = new Point(10, 16);
            chkDarkvision.Name = "chkDarkvision";
            chkDarkvision.Size = new Size(104, 24);
            chkDarkvision.TabIndex = 2;
            chkDarkvision.Text = "Darkvision";
            // 
            // lblProficiencies
            // 
            lblProficiencies.Location = new Point(20, 227);
            lblProficiencies.Name = "lblProficiencies";
            lblProficiencies.Size = new Size(100, 23);
            lblProficiencies.TabIndex = 3;
            lblProficiencies.Text = "Racial Proficiencies:";
            // 
            // lstProficiencies
            // 
            lstProficiencies.CheckOnClick = true;
            lstProficiencies.Location = new Point(20, 252);
            lstProficiencies.Name = "lstProficiencies";
            lstProficiencies.Size = new Size(280, 58);
            lstProficiencies.TabIndex = 4;
            // 
            // lblBonusStat1
            // 
            lblBonusStat1.Location = new Point(20, 327);
            lblBonusStat1.Name = "lblBonusStat1";
            lblBonusStat1.Size = new Size(100, 23);
            lblBonusStat1.TabIndex = 5;
            lblBonusStat1.Text = "Select +2 Bonus:";
            // 
            // cmbBonusStat1
            // 
            cmbBonusStat1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBonusStat1.Location = new Point(140, 327);
            cmbBonusStat1.Name = "cmbBonusStat1";
            cmbBonusStat1.Size = new Size(160, 23);
            cmbBonusStat1.TabIndex = 6;
            // 
            // lblBonusStat2
            // 
            lblBonusStat2.Location = new Point(20, 367);
            lblBonusStat2.Name = "lblBonusStat2";
            lblBonusStat2.Size = new Size(100, 23);
            lblBonusStat2.TabIndex = 7;
            lblBonusStat2.Text = "Select +1 Bonus:";
            // 
            // cmbBonusStat2
            // 
            cmbBonusStat2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBonusStat2.Location = new Point(140, 367);
            cmbBonusStat2.Name = "cmbBonusStat2";
            cmbBonusStat2.Size = new Size(160, 23);
            cmbBonusStat2.TabIndex = 8;
            // 
            // grpRaceDetails
            // 
            grpRaceDetails.Controls.Add(lblSize);
            grpRaceDetails.Controls.Add(lblSpeed);
            grpRaceDetails.Controls.Add(chkDarkvision);
            grpRaceDetails.Controls.Add(lblLanguages);
            grpRaceDetails.Controls.Add(lblFeatures);
            grpRaceDetails.Controls.Add(txtDescription);
            grpRaceDetails.Location = new Point(20, 45);
            grpRaceDetails.Name = "grpRaceDetails";
            grpRaceDetails.Size = new Size(300, 180);
            grpRaceDetails.TabIndex = 9;
            grpRaceDetails.TabStop = false;
            grpRaceDetails.Text = "Race Details";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(10, 20);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(33, 15);
            lblSize.TabIndex = 0;
            lblSize.Text = "Size: ";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(10, 40);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(45, 15);
            lblSpeed.TabIndex = 1;
            lblSpeed.Text = "Speed: ";
            // 
            // lblLanguages
            // 
            lblLanguages.AutoSize = true;
            lblLanguages.Location = new Point(10, 60);
            lblLanguages.Name = "lblLanguages";
            lblLanguages.Size = new Size(70, 15);
            lblLanguages.TabIndex = 2;
            lblLanguages.Text = "Languages: ";
            // 
            // lblFeatures
            // 
            lblFeatures.AutoSize = true;
            lblFeatures.Location = new Point(10, 80);
            lblFeatures.Name = "lblFeatures";
            lblFeatures.Size = new Size(57, 15);
            lblFeatures.TabIndex = 3;
            lblFeatures.Text = "Features: ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(10, 98);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(275, 70);
            txtDescription.TabIndex = 4;
            // 
            // Step2
            // 
            Controls.Add(lblRace);
            Controls.Add(cmbRace);
            Controls.Add(lblProficiencies);
            Controls.Add(lstProficiencies);
            Controls.Add(lblBonusStat1);
            Controls.Add(cmbBonusStat1);
            Controls.Add(lblBonusStat2);
            Controls.Add(cmbBonusStat2);
            Controls.Add(grpRaceDetails);
            Name = "Step2";
            Size = new Size(340, 480);
            grpRaceDetails.ResumeLayout(false);
            grpRaceDetails.PerformLayout();
            ResumeLayout(false);
        }
    }
}
