namespace Frontend
{
    partial class Step3
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblClass;
        private ComboBox cmbClass;
        private GroupBox grpClassDetails;
        private Label lblHitDie;
        private Label lblPrimaryAbility;
        private Label lblSavingThrows;
        private Label lblFeatures;

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

            this.grpClassDetails.Controls.Add(this.lblHitDie);
            this.grpClassDetails.Controls.Add(this.lblPrimaryAbility);
            this.grpClassDetails.Controls.Add(this.lblSavingThrows);
            this.grpClassDetails.Controls.Add(this.lblFeatures);

            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.grpClassDetails);

            this.Size = new System.Drawing.Size(340, 240);
            this.ResumeLayout(false);
        }
    }

}
