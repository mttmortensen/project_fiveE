namespace Frontend
{
    partial class Step2
    {
        private ComboBox cmbRace;
        private Label lblSelectRace;
        private GroupBox grpRaceDetails;
        private Label lblDarkvision;
        private Label lblProficiencies;
        private Label lblBonuses;

        private void InitializeComponent()
        {
            cmbRace = new ComboBox();
            lblSelectRace = new Label();
            grpRaceDetails = new GroupBox();
            lblDarkvision = new Label();
            lblProficiencies = new Label();
            lblBonuses = new Label();
            grpRaceDetails.SuspendLayout();
            SuspendLayout();
            // 
            // cmbRace
            // 
            cmbRace.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRace.Location = new Point(120, 20);
            cmbRace.Name = "cmbRace";
            cmbRace.Size = new Size(180, 23);
            cmbRace.TabIndex = 1;
            cmbRace.SelectedIndexChanged += cmbRace_SelectedIndexChanged;
            // 
            // lblSelectRace
            // 
            lblSelectRace.Location = new Point(20, 20);
            lblSelectRace.Name = "lblSelectRace";
            lblSelectRace.Size = new Size(100, 23);
            lblSelectRace.TabIndex = 0;
            lblSelectRace.Text = "Select a Race:";
            // 
            // grpRaceDetails
            // 
            grpRaceDetails.Controls.Add(lblDarkvision);
            grpRaceDetails.Controls.Add(lblProficiencies);
            grpRaceDetails.Controls.Add(lblBonuses);
            grpRaceDetails.Location = new Point(20, 60);
            grpRaceDetails.Name = "grpRaceDetails";
            grpRaceDetails.Size = new Size(280, 120);
            grpRaceDetails.TabIndex = 2;
            grpRaceDetails.TabStop = false;
            grpRaceDetails.Text = "Race Details";
            // 
            // lblDarkvision
            // 
            lblDarkvision.AutoSize = true;
            lblDarkvision.Location = new Point(10, 25);
            lblDarkvision.Name = "lblDarkvision";
            lblDarkvision.Size = new Size(126, 15);
            lblDarkvision.TabIndex = 0;
            lblDarkvision.Text = "Darkvision: [API DATA]";
            // 
            // lblProficiencies
            // 
            lblProficiencies.AutoSize = true;
            lblProficiencies.Location = new Point(10, 50);
            lblProficiencies.Name = "lblProficiencies";
            lblProficiencies.Size = new Size(138, 15);
            lblProficiencies.TabIndex = 1;
            lblProficiencies.Text = "Proficiencies: [API DATA]";
            // 
            // lblBonuses
            // 
            lblBonuses.AutoSize = true;
            lblBonuses.Location = new Point(10, 75);
            lblBonuses.Name = "lblBonuses";
            lblBonuses.Size = new Size(115, 15);
            lblBonuses.TabIndex = 2;
            lblBonuses.Text = "Bonuses: [API DATA]";
            // 
            // Step2
            // 
            ClientSize = new Size(324, 161);
            Controls.Add(lblSelectRace);
            Controls.Add(cmbRace);
            Controls.Add(grpRaceDetails);
            Name = "Step2";
            grpRaceDetails.ResumeLayout(false);
            grpRaceDetails.PerformLayout();
            ResumeLayout(false);
        }
    }
}
