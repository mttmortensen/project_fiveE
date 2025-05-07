namespace Frontend
{
    partial class Step3
    {

        private TextBox txtClassDescription;
        private System.ComponentModel.IContainer components = null;
        private Label lblClass;
        private ComboBox cmbClass;
        private GroupBox grpClassDetails;
        private Label lblHitDie;
        private Label lblPrimaryAbility;
        private Label lblSavingThrows;
        private Label lblFeatures;

        private Label lblSubclass;
        private ComboBox cmbSubclass;
        private GroupBox grpSubclassDetails;
        private TextBox txtSubclassDescription;
        private Label lblEntryLevel;
        private Label lblSubclassFeatures;
        private CheckedListBox lstBonusProficiencies;
        private CheckedListBox lstBonusSpells;

        private void InitializeComponent()
        {
            this.lblClass = new Label();
            this.cmbClass = new ComboBox();
            this.grpClassDetails = new GroupBox();
            this.lblHitDie = new Label();
            this.lblPrimaryAbility = new Label();
            this.lblSavingThrows = new Label();
            this.lblFeatures = new Label();

            this.SuspendLayout();

            // Label: Class
            this.lblClass.Text = "Select Class:";
            this.lblClass.Location = new System.Drawing.Point(20, 20);

            // ComboBox: Class
            this.cmbClass.Location = new System.Drawing.Point(120, 20);
            this.cmbClass.Width = 180;
            this.cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);

            // GroupBox: Class Details
            this.grpClassDetails.Text = "Class Details";
            this.grpClassDetails.Location = new System.Drawing.Point(20, 60);
            this.grpClassDetails.Size = new System.Drawing.Size(300, 150);

            // Label: Hit Die
            this.lblHitDie.Text = "Hit Die: ";
            this.lblHitDie.Location = new System.Drawing.Point(10, 20);
            this.lblHitDie.AutoSize = true;

            // Label: Primary Ability
            this.lblPrimaryAbility.Text = "Primary Ability: ";
            this.lblPrimaryAbility.Location = new System.Drawing.Point(10, 40);
            this.lblPrimaryAbility.AutoSize = true;

            // Label: Saving Throws
            this.lblSavingThrows.Text = "Saving Throws: ";
            this.lblSavingThrows.Location = new System.Drawing.Point(10, 60);
            this.lblSavingThrows.AutoSize = true;

            // Label: Features
            this.lblFeatures.Text = "Features: ";
            this.lblFeatures.Location = new System.Drawing.Point(10, 80);
            this.lblFeatures.AutoSize = true;

            // TextBox: Class Description
            this.txtClassDescription = new TextBox();
            this.txtClassDescription.Multiline = true;
            this.txtClassDescription.ReadOnly = true;
            this.txtClassDescription.ScrollBars = ScrollBars.Vertical;
            this.txtClassDescription.Location = new System.Drawing.Point(10, 100);
            this.txtClassDescription.Size = new System.Drawing.Size(275, 40);

            // Label: Subclass
            this.lblSubclass = new Label();
            this.lblSubclass.Text = "Select Subclass:";
            this.lblSubclass.Location = new System.Drawing.Point(20, 230);

            // ComboBox: Subclass
            this.cmbSubclass = new ComboBox();
            this.cmbSubclass.Location = new System.Drawing.Point(120, 230);
            this.cmbSubclass.Width = 180;
            this.cmbSubclass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSubclass.SelectedIndexChanged += new System.EventHandler(this.cmbSubclass_SelectedIndexChanged);

            // GroupBox: Subclass Details
            this.grpSubclassDetails = new GroupBox();
            this.grpSubclassDetails.Text = "Subclass Details";
            this.grpSubclassDetails.Location = new System.Drawing.Point(20, 270);
            this.grpSubclassDetails.Size = new System.Drawing.Size(300, 160);

            // TextBox: Subclass Description
            this.txtSubclassDescription = new TextBox();
            this.txtSubclassDescription.Multiline = true;
            this.txtSubclassDescription.ReadOnly = true;
            this.txtSubclassDescription.ScrollBars = ScrollBars.Vertical;
            this.txtSubclassDescription.Location = new System.Drawing.Point(10, 60);
            this.txtSubclassDescription.Size = new System.Drawing.Size(275, 70);

            // Label: Entry Level
            this.lblEntryLevel = new Label();
            this.lblEntryLevel.Text = "Entry Level: ";
            this.lblEntryLevel.Location = new System.Drawing.Point(10, 20);
            this.lblEntryLevel.AutoSize = true;

            // Label: Subclass Features
            this.lblSubclassFeatures = new Label();
            this.lblSubclassFeatures.Text = "Features: ";
            this.lblSubclassFeatures.Location = new System.Drawing.Point(10, 40);
            this.lblSubclassFeatures.AutoSize = true;

            // CheckedListBox: Bonus Proficiencies
            this.lstBonusProficiencies = new CheckedListBox();
            this.lstBonusProficiencies.CheckOnClick = true;
            this.lstBonusProficiencies.Location = new System.Drawing.Point(10, 70);
            this.lstBonusProficiencies.Size = new System.Drawing.Size(275, 50);

            // CheckedListBox: Bonus Spells
            this.lstBonusSpells = new CheckedListBox();
            this.lstBonusSpells.CheckOnClick = true;
            this.lstBonusSpells.Location = new System.Drawing.Point(10, 130);
            this.lstBonusSpells.Size = new System.Drawing.Size(275, 50);

            // TextBox: Subclass Description (moved lower)
            this.txtSubclassDescription.Location = new System.Drawing.Point(10, 190);
            this.txtSubclassDescription.Size = new System.Drawing.Size(275, 60);

            this.grpClassDetails.Controls.Add(this.lblHitDie);
            this.grpClassDetails.Controls.Add(this.lblPrimaryAbility);
            this.grpClassDetails.Controls.Add(this.lblSavingThrows);
            this.grpClassDetails.Controls.Add(this.lblFeatures);
            this.grpClassDetails.Controls.Add(this.txtClassDescription);
            this.grpClassDetails.Size = new System.Drawing.Size(300, 160);
            
            // Add controls to subclass group box
            this.grpSubclassDetails.Size = new System.Drawing.Size(300, 270);
            this.grpSubclassDetails.Controls.Add(this.lblEntryLevel);
            this.grpSubclassDetails.Controls.Add(this.lblSubclassFeatures);
            this.grpSubclassDetails.Controls.Add(this.lstBonusProficiencies);
            this.grpSubclassDetails.Controls.Add(this.lstBonusSpells);
            this.grpSubclassDetails.Controls.Add(this.txtSubclassDescription);
            this.grpSubclassDetails.Controls.Add(this.txtSubclassDescription);

            this.Controls.Add(this.lblSubclass);
            this.Controls.Add(this.cmbSubclass);
            this.Controls.Add(this.grpSubclassDetails);


            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.grpClassDetails);

            this.Size = new System.Drawing.Size(340, 560);
            this.ResumeLayout(false);
        }
    }

}
