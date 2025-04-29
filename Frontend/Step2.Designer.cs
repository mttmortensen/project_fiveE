namespace Frontend
{
    partial class rootForm_step2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rootScrollablePanel_step2 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rootScrollablePanel_step2.SuspendLayout();
            SuspendLayout();
            // 
            // rootScrollablePanel_step2
            // 
            rootScrollablePanel_step2.AutoScroll = true;
            rootScrollablePanel_step2.Controls.Add(groupBox2);
            rootScrollablePanel_step2.Controls.Add(groupBox1);
            rootScrollablePanel_step2.Dock = DockStyle.Fill;
            rootScrollablePanel_step2.Location = new Point(0, 0);
            rootScrollablePanel_step2.Name = "rootScrollablePanel_step2";
            rootScrollablePanel_step2.Size = new Size(807, 711);
            rootScrollablePanel_step2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(14, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(783, 511);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(21, 545);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(769, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // rootForm_step2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(807, 711);
            Controls.Add(rootScrollablePanel_step2);
            Name = "rootForm_step2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Step 2: Create a New Character";
            rootScrollablePanel_step2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel rootScrollablePanel_step2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}