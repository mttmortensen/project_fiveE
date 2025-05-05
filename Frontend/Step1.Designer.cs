namespace Frontend
{
    partial class Step1
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
            lblCharacterName = new Label();
            txtCharacterName = new TextBox();
            lblPlayerName = new Label();
            txtPlayerName = new TextBox();
            lblAge = new Label();
            numAge = new NumericUpDown();
            lblAlignment = new Label();
            cmbAlignment = new ComboBox();
            lblBackground = new Label();
            txtBackground = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // lblCharacterName
            // 
            lblCharacterName.Location = new Point(20, 20);
            lblCharacterName.Name = "lblCharacterName";
            lblCharacterName.Size = new Size(100, 23);
            lblCharacterName.TabIndex = 0;
            lblCharacterName.Text = "Character Name:";
            // 
            // txtCharacterName
            // 
            txtCharacterName.Location = new Point(140, 20);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.Size = new Size(150, 23);
            txtCharacterName.TabIndex = 1;
            // 
            // lblPlayerName
            // 
            lblPlayerName.Location = new Point(20, 60);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(100, 23);
            lblPlayerName.TabIndex = 2;
            lblPlayerName.Text = "Player Name:";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(140, 60);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(150, 23);
            txtPlayerName.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(20, 100);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age:";
            // 
            // numAge
            // 
            numAge.Location = new Point(140, 100);
            numAge.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(60, 23);
            numAge.TabIndex = 5;
            numAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAlignment
            // 
            lblAlignment.Location = new Point(20, 140);
            lblAlignment.Name = "lblAlignment";
            lblAlignment.Size = new Size(100, 23);
            lblAlignment.TabIndex = 6;
            lblAlignment.Text = "Alignment:";
            // 
            // cmbAlignment
            // 
            cmbAlignment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlignment.Items.AddRange(new object[] { "Lawful Good", "Neutral Good", "Chaotic Good", "Lawful Neutral", "True Neutral", "Chaotic Neutral", "Lawful Evil", "Neutral Evil", "Chaotic Evil" });
            cmbAlignment.Location = new Point(140, 140);
            cmbAlignment.Name = "cmbAlignment";
            cmbAlignment.Size = new Size(150, 23);
            cmbAlignment.TabIndex = 7;
            // 
            // lblBackground
            // 
            lblBackground.Location = new Point(20, 180);
            lblBackground.Name = "lblBackground";
            lblBackground.Size = new Size(100, 23);
            lblBackground.TabIndex = 8;
            lblBackground.Text = "Background:";
            // 
            // txtBackground
            // 
            txtBackground.Location = new Point(140, 180);
            txtBackground.Name = "txtBackground";
            txtBackground.Size = new Size(150, 23);
            txtBackground.TabIndex = 9;
            // 
            // Step1
            // 
            ClientSize = new Size(304, 201);
            Controls.Add(lblCharacterName);
            Controls.Add(txtCharacterName);
            Controls.Add(lblPlayerName);
            Controls.Add(txtPlayerName);
            Controls.Add(lblAge);
            Controls.Add(numAge);
            Controls.Add(lblAlignment);
            Controls.Add(cmbAlignment);
            Controls.Add(lblBackground);
            Controls.Add(txtBackground);
            Name = "Step1";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
