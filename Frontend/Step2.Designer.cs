namespace Frontend
{
    partial class Step2
    {
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
            this.lblRace = new Label();
            this.cmbRace = new ComboBox();
            this.chkDarkvision = new CheckBox();
            this.lblProficiencies = new Label();
            this.lstProficiencies = new CheckedListBox();
            this.lblBonusStat1 = new Label();
            this.cmbBonusStat1 = new ComboBox();
            this.lblBonusStat2 = new Label();
            this.cmbBonusStat2 = new ComboBox();

            this.SuspendLayout();

            // Label: Race
            this.lblRace.Text = "Select Race:";
            this.lblRace.Location = new System.Drawing.Point(20, 20);

            // ComboBox: Race
            this.cmbRace.Location = new System.Drawing.Point(120, 20);
            this.cmbRace.Width = 180;
            this.cmbRace.DropDownStyle = ComboBoxStyle.DropDownList;

            // CheckBox: Darkvision
            this.chkDarkvision.Text = "Darkvision";
            this.chkDarkvision.Location = new System.Drawing.Point(20, 60);

            // Label: Proficiencies
            this.lblProficiencies.Text = "Racial Proficiencies:";
            this.lblProficiencies.Location = new System.Drawing.Point(20, 100);

            // CheckedListBox: Proficiencies
            this.lstProficiencies.Location = new System.Drawing.Point(20, 125);
            this.lstProficiencies.Size = new System.Drawing.Size(280, 60);
            this.lstProficiencies.CheckOnClick = true;

            // Label: Ability Bonus 1
            this.lblBonusStat1.Text = "Select +2 Bonus:";
            this.lblBonusStat1.Location = new System.Drawing.Point(20, 200);

            // ComboBox: Bonus Stat 1
            this.cmbBonusStat1.Location = new System.Drawing.Point(140, 200);
            this.cmbBonusStat1.Width = 160;
            this.cmbBonusStat1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Label: Ability Bonus 2
            this.lblBonusStat2.Text = "Select +1 Bonus:";
            this.lblBonusStat2.Location = new System.Drawing.Point(20, 240);

            // ComboBox: Bonus Stat 2
            this.cmbBonusStat2.Location = new System.Drawing.Point(140, 240);
            this.cmbBonusStat2.Width = 160;
            this.cmbBonusStat2.DropDownStyle = ComboBoxStyle.DropDownList;

            // Add controls to UserControl
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.chkDarkvision);
            this.Controls.Add(this.lblProficiencies);
            this.Controls.Add(this.lstProficiencies);
            this.Controls.Add(this.lblBonusStat1);
            this.Controls.Add(this.cmbBonusStat1);
            this.Controls.Add(this.lblBonusStat2);
            this.Controls.Add(this.cmbBonusStat2);

            // Set UserControl size
            this.Size = new System.Drawing.Size(340, 300);
            this.ResumeLayout(false);
        }
    }
}
