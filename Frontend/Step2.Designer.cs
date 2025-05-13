using System.Drawing;
using System.Windows.Forms;

namespace Frontend
{
    partial class Step2
    {
        private Label lblRace;
        private ComboBox cmbRace;

        private Label lblSize;
        private Label lblSpeed;
        private Label lblCreatureType;
        private Label lblDarkvision;
        private Label lblDescription;

        private Label lblTraits;
        private CheckedListBox lstTraits;

        private Label lblLanguages;
        private CheckedListBox lstLanguages;

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
            lblSize = new Label();
            lblSpeed = new Label();
            lblCreatureType = new Label();
            lblDarkvision = new Label();
            lblDescription = new Label();
            lblTraits = new Label();
            lstTraits = new CheckedListBox();
            lblLanguages = new Label();
            lstLanguages = new CheckedListBox();
            lblProficiencies = new Label();
            lstProficiencies = new CheckedListBox();
            lblBonusStat1 = new Label();
            cmbBonusStat1 = new ComboBox();
            lblBonusStat2 = new Label();
            cmbBonusStat2 = new ComboBox();
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
            // lblSize
            // 
            lblSize.Location = new Point(20, 55);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(200, 20);
            lblSize.TabIndex = 2;
            // 
            // lblSpeed
            // 
            lblSpeed.Location = new Point(20, 75);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(200, 20);
            lblSpeed.TabIndex = 4;
            // 
            // lblCreatureType
            // 
            lblCreatureType.Location = new Point(20, 95);
            lblCreatureType.Name = "lblCreatureType";
            lblCreatureType.Size = new Size(300, 20);
            lblCreatureType.TabIndex = 5;
            // 
            // lblDarkvision
            // 
            lblDarkvision.Location = new Point(20, 115);
            lblDarkvision.Name = "lblDarkvision";
            lblDarkvision.Size = new Size(400, 23);
            lblDarkvision.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(20, 135);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(500, 23);
            lblDescription.TabIndex = 7;
            // 
            // lblTraits
            // 
            lblTraits.Location = new Point(20, 145);
            lblTraits.Name = "lblTraits";
            lblTraits.Size = new Size(100, 23);
            lblTraits.TabIndex = 7;
            lblTraits.Text = "Available Traits:";
            // 
            // lstTraits
            // 
            lstTraits.Location = new Point(20, 171);
            lstTraits.Name = "lstTraits";
            lstTraits.Size = new Size(280, 58);
            lstTraits.TabIndex = 8;
            // 
            // lblLanguages
            // 
            lblLanguages.Location = new Point(20, 232);
            lblLanguages.Name = "lblLanguages";
            lblLanguages.Size = new Size(190, 23);
            lblLanguages.TabIndex = 9;
            lblLanguages.Text = "Available Languages:";
            // 
            // lstLanguages
            // 
            lstLanguages.Location = new Point(20, 258);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(280, 58);
            lstLanguages.TabIndex = 10;
            // 
            // lblProficiencies
            // 
            lblProficiencies.Location = new Point(20, 319);
            lblProficiencies.Name = "lblProficiencies";
            lblProficiencies.Size = new Size(200, 23);
            lblProficiencies.TabIndex = 11;
            lblProficiencies.Text = "Available Proficiencies:";
            // 
            // lstProficiencies
            // 
            lstProficiencies.Location = new Point(20, 345);
            lstProficiencies.Name = "lstProficiencies";
            lstProficiencies.Size = new Size(280, 58);
            lstProficiencies.TabIndex = 12;
            // 
            // lblBonusStat1
            // 
            lblBonusStat1.Location = new Point(20, 429);
            lblBonusStat1.Name = "lblBonusStat1";
            lblBonusStat1.Size = new Size(100, 23);
            lblBonusStat1.TabIndex = 13;
            lblBonusStat1.Text = "Select +2 Bonus:";
            // 
            // cmbBonusStat1
            // 
            cmbBonusStat1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBonusStat1.Location = new Point(140, 429);
            cmbBonusStat1.Name = "cmbBonusStat1";
            cmbBonusStat1.Size = new Size(160, 23);
            cmbBonusStat1.TabIndex = 14;
            // 
            // lblBonusStat2
            // 
            lblBonusStat2.Location = new Point(20, 459);
            lblBonusStat2.Name = "lblBonusStat2";
            lblBonusStat2.Size = new Size(100, 23);
            lblBonusStat2.TabIndex = 15;
            lblBonusStat2.Text = "Select +1 Bonus:";
            // 
            // cmbBonusStat2
            // 
            cmbBonusStat2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBonusStat2.Location = new Point(140, 459);
            cmbBonusStat2.Name = "cmbBonusStat2";
            cmbBonusStat2.Size = new Size(160, 23);
            cmbBonusStat2.TabIndex = 16;
            // 
            // Step2
            // 
            Controls.Add(lblRace);
            Controls.Add(cmbRace);
            Controls.Add(lblSize);
            Controls.Add(lblSpeed);
            Controls.Add(lblCreatureType);
            Controls.Add(lblDarkvision);
            Controls.Add(lblDescription);
            Controls.Add(lblTraits);
            Controls.Add(lstTraits);
            Controls.Add(lblLanguages);
            Controls.Add(lstLanguages);
            Controls.Add(lblProficiencies);
            Controls.Add(lstProficiencies);
            Controls.Add(lblBonusStat1);
            Controls.Add(cmbBonusStat1);
            Controls.Add(lblBonusStat2);
            Controls.Add(cmbBonusStat2);
            Name = "Step2";
            Size = new Size(340, 536);
            ResumeLayout(false);
        }
    }
}