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
            character_title = new Label();
            character_info = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // character_title
            // 
            character_title.Dock = DockStyle.Top;
            character_title.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            character_title.Location = new Point(0, 0);
            character_title.Name = "character_title";
            character_title.Size = new Size(800, 39);
            character_title.TabIndex = 0;
            character_title.Text = "New Character";
            // 
            // character_info
            // 
            character_info.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            character_info.Location = new Point(0, 42);
            character_info.Name = "character_info";
            character_info.Size = new Size(800, 39);
            character_info.TabIndex = 1;
            character_info.Text = "Character Info:";
            character_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(192, 112);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(249, 112);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(171, 81);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(171, 29);
            label1.TabIndex = 4;
            label1.Text = "Sex:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 108);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First, Last";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(0, 81);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(171, 29);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(345, 79);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(124, 31);
            label3.TabIndex = 7;
            label3.Text = "Starting Level:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(345, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(9, 198);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(171, 93);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(character_info);
            Controls.Add(character_title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label character_title;
        private Label character_info;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
    }
}
