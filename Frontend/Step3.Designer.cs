namespace Frontend
{
    partial class Step3
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblClass;
        private ComboBox cmbClass;
        private Label lblSubclass;
        private ComboBox cmbSubclass;

        private void InitializeComponent()
        {
            this.lblClass = new Label();
            this.cmbClass = new ComboBox();
            this.lblSubclass = new Label();
            this.cmbSubclass = new ComboBox();

            this.SuspendLayout();

            // Label: Class
            this.lblClass.Text = "Select Class:";
            this.lblClass.Location = new System.Drawing.Point(20, 20);

            // ComboBox: Class
            this.cmbClass.Location = new System.Drawing.Point(120, 20);
            this.cmbClass.Width = 180;
            this.cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);

            // Label: Subclass
            this.lblSubclass.Text = "Select Subclass:";
            this.lblSubclass.Location = new System.Drawing.Point(20, 60);

            // ComboBox: Subclass
            this.cmbSubclass.Location = new System.Drawing.Point(120, 60);
            this.cmbSubclass.Width = 180;
            this.cmbSubclass.DropDownStyle = ComboBoxStyle.DropDownList;

            // Add controls
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblSubclass);
            this.Controls.Add(this.cmbSubclass);

            this.Size = new System.Drawing.Size(340, 120);
            this.ResumeLayout(false);
        }
    }
}
