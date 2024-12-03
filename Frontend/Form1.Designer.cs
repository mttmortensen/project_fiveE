namespace Frontend
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            sex_label = new Label();
            textBox1 = new TextBox();
            sex_m_rButton = new RadioButton();
            sex_f_button = new RadioButton();
            character_label = new Label();
            level_label = new Label();
            lvl_drop_drown = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5020008F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(level_label, 5, 0);
            tableLayoutPanel1.Controls.Add(sex_label, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(sex_m_rButton, 3, 0);
            tableLayoutPanel1.Controls.Add(sex_f_button, 4, 0);
            tableLayoutPanel1.Controls.Add(character_label, 0, 0);
            tableLayoutPanel1.Controls.Add(lvl_drop_drown, 6, 0);
            tableLayoutPanel1.Location = new Point(12, 119);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(783, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sex_label
            // 
            sex_label.Anchor = AnchorStyles.Top;
            sex_label.AutoSize = true;
            sex_label.Font = new Font("Segoe UI", 12F);
            sex_label.Location = new Point(224, 0);
            sex_label.Name = "sex_label";
            sex_label.Size = new Size(37, 21);
            sex_label.TabIndex = 2;
            sex_label.Text = "Sex:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(100, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First, Last";
            textBox1.Size = new Size(91, 22);
            textBox1.TabIndex = 4;
            // 
            // sex_m_rButton
            // 
            sex_m_rButton.AutoSize = true;
            sex_m_rButton.Font = new Font("Segoe UI", 12F);
            sex_m_rButton.Location = new Point(294, 3);
            sex_m_rButton.Name = "sex_m_rButton";
            sex_m_rButton.Size = new Size(62, 25);
            sex_m_rButton.TabIndex = 5;
            sex_m_rButton.TabStop = true;
            sex_m_rButton.Text = "Male";
            sex_m_rButton.UseVisualStyleBackColor = true;
            // 
            // sex_f_button
            // 
            sex_f_button.AutoSize = true;
            sex_f_button.Font = new Font("Segoe UI", 12F);
            sex_f_button.Location = new Point(391, 3);
            sex_f_button.Name = "sex_f_button";
            sex_f_button.Size = new Size(78, 25);
            sex_f_button.TabIndex = 3;
            sex_f_button.TabStop = true;
            sex_f_button.Text = "Female";
            sex_f_button.UseVisualStyleBackColor = true;
            // 
            // character_label
            // 
            character_label.Anchor = AnchorStyles.Top;
            character_label.AutoSize = true;
            character_label.Font = new Font("Segoe UI", 12F);
            character_label.Location = new Point(21, 0);
            character_label.Name = "character_label";
            character_label.Size = new Size(55, 21);
            character_label.TabIndex = 0;
            character_label.Text = "Name:";
            // 
            // level_label
            // 
            level_label.Anchor = AnchorStyles.Top;
            level_label.AutoSize = true;
            level_label.Font = new Font("Segoe UI", 12F);
            level_label.Location = new Point(509, 0);
            level_label.Name = "level_label";
            level_label.Size = new Size(49, 21);
            level_label.TabIndex = 6;
            level_label.Text = "Level:";
            // 
            // lvl_drop_drown
            // 
            tableLayoutPanel1.SetColumnSpan(lvl_drop_drown, 2);
            lvl_drop_drown.FormattingEnabled = true;
            lvl_drop_drown.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            lvl_drop_drown.Location = new Point(585, 3);
            lvl_drop_drown.Name = "lvl_drop_drown";
            lvl_drop_drown.Size = new Size(195, 23);
            lvl_drop_drown.TabIndex = 7;
            lvl_drop_drown.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 572);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(823, 611);
            Name = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label character_label;
        private Label sex_label;
        private RadioButton sex_f_button;
        private TextBox textBox1;
        private RadioButton sex_m_rButton;
        private Label level_label;
        private ComboBox lvl_drop_drown;
    }
}
