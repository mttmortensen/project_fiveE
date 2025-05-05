namespace Frontend
{
    partial class rootForm_step1
    {
        private Label lblCharacterName;
        private TextBox txtCharacterName;
        private Label lblPlayerName;
        private TextBox txtPlayerName;
        private Label lblAge;
        private NumericUpDown numAge;
        private Label lblAlignment;
        private ComboBox cmbAlignment;
        private Label lblBackground;
        private TextBox txtBackground;

        private void InitializeComponent()
        {
            this.lblCharacterName = new Label();
            this.txtCharacterName = new TextBox();
            this.lblPlayerName = new Label();
            this.txtPlayerName = new TextBox();
            this.lblAge = new Label();
            this.numAge = new NumericUpDown();
            this.lblAlignment = new Label();
            this.cmbAlignment = new ComboBox();
            this.lblBackground = new Label();
            this.txtBackground = new TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();

            // Character Name
            this.lblCharacterName.Text = "Character Name:";
            this.lblCharacterName.Location = new System.Drawing.Point(20, 20);
            this.txtCharacterName.Location = new System.Drawing.Point(140, 20);
            this.txtCharacterName.Width = 150;

            // Player Name
            this.lblPlayerName.Text = "Player Name:";
            this.lblPlayerName.Location = new System.Drawing.Point(20, 60);
            this.txtPlayerName.Location = new System.Drawing.Point(140, 60);
            this.txtPlayerName.Width = 150;

            // Age
            this.lblAge.Text = "Age:";
            this.lblAge.Location = new System.Drawing.Point(20, 100);
            this.numAge.Location = new System.Drawing.Point(140, 100);
            this.numAge.Width = 60;
            this.numAge.Minimum = 1;
            this.numAge.Maximum = 999;

            // Alignment
            this.lblAlignment.Text = "Alignment:";
            this.lblAlignment.Location = new System.Drawing.Point(20, 140);
            this.cmbAlignment.Location = new System.Drawing.Point(140, 140);
            this.cmbAlignment.Width = 150;
            this.cmbAlignment.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbAlignment.Items.AddRange(new object[]
            {
                "Lawful Good", "Neutral Good", "Chaotic Good",
                "Lawful Neutral", "True Neutral", "Chaotic Neutral",
                "Lawful Evil", "Neutral Evil", "Chaotic Evil"
            });

            // Background
            this.lblBackground.Text = "Background:";
            this.lblBackground.Location = new System.Drawing.Point(20, 180);
            this.txtBackground.Location = new System.Drawing.Point(140, 180);
            this.txtBackground.Width = 150;

            // Add controls
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAlignment);
            this.Controls.Add(this.cmbAlignment);
            this.Controls.Add(this.lblBackground);
            this.Controls.Add(this.txtBackground);

            // Control sizing
            this.Size = new System.Drawing.Size(320, 240);

            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
