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
            lblClass = new Label();
            cmbClass = new ComboBox();
            grpClassDetails = new GroupBox();
            lblHitDie = new Label();
            lblPrimaryAbility = new Label();
            lblSavingThrows = new Label();
            lblFeatures = new Label();
            txtClassDescription = new TextBox();
            lblSubclass = new Label();
            cmbSubclass = new ComboBox();
            grpSubclassDetails = new GroupBox();
            lblEntryLevel = new Label();
            lblSubclassFeatures = new Label();
            lstBonusProficiencies = new CheckedListBox();
            lstBonusSpells = new CheckedListBox();
            txtSubclassDescription = new TextBox();
            grpClassDetails.SuspendLayout();
            grpSubclassDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblClass
            // 
            lblClass.Location = new Point(20, 20);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(100, 23);
            lblClass.TabIndex = 3;
            lblClass.Text = "Select Class:";
            // 
            // cmbClass
            // 
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.Location = new Point(120, 20);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(180, 23);
            cmbClass.TabIndex = 4;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // grpClassDetails
            // 
            grpClassDetails.Controls.Add(lblHitDie);
            grpClassDetails.Controls.Add(lblPrimaryAbility);
            grpClassDetails.Controls.Add(lblSavingThrows);
            grpClassDetails.Controls.Add(lblFeatures);
            grpClassDetails.Controls.Add(txtClassDescription);
            grpClassDetails.Location = new Point(20, 60);
            grpClassDetails.Name = "grpClassDetails";
            grpClassDetails.Size = new Size(300, 160);
            grpClassDetails.TabIndex = 5;
            grpClassDetails.TabStop = false;
            grpClassDetails.Text = "Class Details";
            // 
            // lblHitDie
            // 
            lblHitDie.AutoSize = true;
            lblHitDie.Location = new Point(10, 20);
            lblHitDie.Name = "lblHitDie";
            lblHitDie.Size = new Size(49, 15);
            lblHitDie.TabIndex = 0;
            lblHitDie.Text = "Hit Die: ";
            // 
            // lblPrimaryAbility
            // 
            lblPrimaryAbility.AutoSize = true;
            lblPrimaryAbility.Location = new Point(10, 40);
            lblPrimaryAbility.Name = "lblPrimaryAbility";
            lblPrimaryAbility.Size = new Size(91, 15);
            lblPrimaryAbility.TabIndex = 1;
            lblPrimaryAbility.Text = "Primary Ability: ";
            // 
            // lblSavingThrows
            // 
            lblSavingThrows.AutoSize = true;
            lblSavingThrows.Location = new Point(10, 60);
            lblSavingThrows.Name = "lblSavingThrows";
            lblSavingThrows.Size = new Size(90, 15);
            lblSavingThrows.TabIndex = 2;
            lblSavingThrows.Text = "Saving Throws: ";
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
            // txtClassDescription
            // 
            txtClassDescription.Location = new Point(10, 100);
            txtClassDescription.Multiline = true;
            txtClassDescription.Name = "txtClassDescription";
            txtClassDescription.ReadOnly = true;
            txtClassDescription.ScrollBars = ScrollBars.Vertical;
            txtClassDescription.Size = new Size(275, 40);
            txtClassDescription.TabIndex = 4;
            // 
            // lblSubclass
            // 
            lblSubclass.Location = new Point(20, 230);
            lblSubclass.Name = "lblSubclass";
            lblSubclass.Size = new Size(100, 23);
            lblSubclass.TabIndex = 0;
            lblSubclass.Text = "Select Subclass:";
            // 
            // cmbSubclass
            // 
            cmbSubclass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubclass.Location = new Point(120, 230);
            cmbSubclass.Name = "cmbSubclass";
            cmbSubclass.Size = new Size(180, 23);
            cmbSubclass.TabIndex = 1;
            cmbSubclass.SelectedIndexChanged += cmbSubclass_SelectedIndexChanged;
            // 
            // grpSubclassDetails
            // 
            grpSubclassDetails.Controls.Add(lblEntryLevel);
            grpSubclassDetails.Controls.Add(lblSubclassFeatures);
            grpSubclassDetails.Controls.Add(lstBonusProficiencies);
            grpSubclassDetails.Controls.Add(lstBonusSpells);
            grpSubclassDetails.Controls.Add(txtSubclassDescription);
            grpSubclassDetails.Location = new Point(20, 270);
            grpSubclassDetails.Name = "grpSubclassDetails";
            grpSubclassDetails.Size = new Size(300, 270);
            grpSubclassDetails.TabIndex = 2;
            grpSubclassDetails.TabStop = false;
            grpSubclassDetails.Text = "Subclass Details";
            // 
            // lblEntryLevel
            // 
            lblEntryLevel.AutoSize = true;
            lblEntryLevel.Location = new Point(10, 20);
            lblEntryLevel.Name = "lblEntryLevel";
            lblEntryLevel.Size = new Size(70, 15);
            lblEntryLevel.TabIndex = 0;
            lblEntryLevel.Text = "Entry Level: ";
            // 
            // lblSubclassFeatures
            // 
            lblSubclassFeatures.AutoSize = true;
            lblSubclassFeatures.Location = new Point(10, 40);
            lblSubclassFeatures.Name = "lblSubclassFeatures";
            lblSubclassFeatures.Size = new Size(57, 15);
            lblSubclassFeatures.TabIndex = 1;
            lblSubclassFeatures.Text = "Features: ";
            // 
            // lstBonusProficiencies
            // 
            lstBonusProficiencies.CheckOnClick = true;
            lstBonusProficiencies.Location = new Point(10, 70);
            lstBonusProficiencies.Name = "lstBonusProficiencies";
            lstBonusProficiencies.Size = new Size(275, 40);
            lstBonusProficiencies.TabIndex = 2;
            // 
            // lstBonusSpells
            // 
            lstBonusSpells.CheckOnClick = true;
            lstBonusSpells.Location = new Point(10, 130);
            lstBonusSpells.Name = "lstBonusSpells";
            lstBonusSpells.Size = new Size(275, 40);
            lstBonusSpells.TabIndex = 3;
            // 
            // txtSubclassDescription
            // 
            txtSubclassDescription.Location = new Point(10, 190);
            txtSubclassDescription.Multiline = true;
            txtSubclassDescription.Name = "txtSubclassDescription";
            txtSubclassDescription.ReadOnly = true;
            txtSubclassDescription.ScrollBars = ScrollBars.Vertical;
            txtSubclassDescription.Size = new Size(275, 60);
            txtSubclassDescription.TabIndex = 4;
            // 
            // Step3
            // 
            Controls.Add(lblSubclass);
            Controls.Add(cmbSubclass);
            Controls.Add(grpSubclassDetails);
            Controls.Add(lblClass);
            Controls.Add(cmbClass);
            Controls.Add(grpClassDetails);
            Name = "Step3";
            Size = new Size(340, 560);
            grpClassDetails.ResumeLayout(false);
            grpClassDetails.PerformLayout();
            grpSubclassDetails.ResumeLayout(false);
            grpSubclassDetails.PerformLayout();
            ResumeLayout(false);
        }
    }

}
