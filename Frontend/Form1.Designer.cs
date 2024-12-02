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
            character_title.Text = "Title";
            // 
            // character_info
            // 
            character_info.Dock = DockStyle.Top;
            character_info.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            character_info.Location = new Point(0, 39);
            character_info.Name = "character_info";
            character_info.Size = new Size(800, 39);
            character_info.TabIndex = 1;
            character_info.Text = "Character Info:";
            character_info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(character_info);
            Controls.Add(character_title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label character_title;
        public Label label1;
        private Label character_info;
    }
}
