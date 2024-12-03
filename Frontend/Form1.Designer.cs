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
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9992046F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0032F));
            tableLayoutPanel1.Controls.Add(sex_label, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(sex_m_rButton, 3, 0);
            tableLayoutPanel1.Controls.Add(sex_f_button, 4, 0);
            tableLayoutPanel1.Controls.Add(character_label, 0, 0);
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
            sex_label.Font = new Font("Courier New", 24F, FontStyle.Bold);
            sex_label.Location = new Point(344, 0);
            sex_label.Name = "sex_label";
            sex_label.Size = new Size(91, 36);
            sex_label.TabIndex = 2;
            sex_label.Text = "Sex:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(159, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First, Last";
            textBox1.Size = new Size(150, 22);
            textBox1.TabIndex = 4;
            // 
            // sex_m_rButton
            // 
            sex_m_rButton.AutoSize = true;
            sex_m_rButton.Font = new Font("Courier New", 20.25F);
            sex_m_rButton.Location = new Point(471, 3);
            sex_m_rButton.Name = "sex_m_rButton";
            sex_m_rButton.Size = new Size(95, 34);
            sex_m_rButton.TabIndex = 5;
            sex_m_rButton.TabStop = true;
            sex_m_rButton.Text = "Male";
            sex_m_rButton.UseVisualStyleBackColor = true;
            // 
            // sex_f_button
            // 
            sex_f_button.AutoSize = true;
            sex_f_button.Font = new Font("Courier New", 20.25F);
            sex_f_button.Location = new Point(627, 3);
            sex_f_button.Name = "sex_f_button";
            sex_f_button.Size = new Size(127, 34);
            sex_f_button.TabIndex = 3;
            sex_f_button.TabStop = true;
            sex_f_button.Text = "Female";
            sex_f_button.UseVisualStyleBackColor = true;
            // 
            // character_label
            // 
            character_label.Anchor = AnchorStyles.Top;
            character_label.AutoSize = true;
            character_label.Font = new Font("Courier New", 24F, FontStyle.Bold);
            character_label.Location = new Point(23, 0);
            character_label.Name = "character_label";
            character_label.Size = new Size(110, 36);
            character_label.TabIndex = 0;
            character_label.Text = "Name:";
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
    }
}
