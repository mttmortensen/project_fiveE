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
            ac_label = new Label();
            background_label = new Label();
            background_textBox = new RichTextBox();
            skill_label = new Label();
            level_label = new Label();
            sex_label = new Label();
            textBox1 = new TextBox();
            sex_f_button = new RadioButton();
            character_name_label = new Label();
            lvl_drop_drown = new ComboBox();
            skill_textBox = new RichTextBox();
            proficiencies_label = new Label();
            proficiencies_textBox = new RichTextBox();
            equipment_textBox = new RichTextBox();
            equipment_label = new Label();
            xp_label = new Label();
            xp_textbox = new TextBox();
            hp_label = new Label();
            hp_textbox = new TextBox();
            maxhp_label = new Label();
            maxhp_textBox = new TextBox();
            textBox3 = new TextBox();
            sex_m_rButton = new RadioButton();
            character_title_label = new Label();
            basicInfo_label = new Label();
            raceInfo_title = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            richTextBox2 = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5020008F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(ac_label, 6, 3);
            tableLayoutPanel1.Controls.Add(background_label, 3, 2);
            tableLayoutPanel1.Controls.Add(background_textBox, 5, 2);
            tableLayoutPanel1.Controls.Add(skill_label, 0, 1);
            tableLayoutPanel1.Controls.Add(level_label, 5, 0);
            tableLayoutPanel1.Controls.Add(sex_label, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(sex_f_button, 4, 0);
            tableLayoutPanel1.Controls.Add(character_name_label, 0, 0);
            tableLayoutPanel1.Controls.Add(lvl_drop_drown, 6, 0);
            tableLayoutPanel1.Controls.Add(skill_textBox, 1, 1);
            tableLayoutPanel1.Controls.Add(proficiencies_label, 3, 1);
            tableLayoutPanel1.Controls.Add(proficiencies_textBox, 5, 1);
            tableLayoutPanel1.Controls.Add(equipment_textBox, 1, 2);
            tableLayoutPanel1.Controls.Add(equipment_label, 0, 2);
            tableLayoutPanel1.Controls.Add(xp_label, 0, 3);
            tableLayoutPanel1.Controls.Add(xp_textbox, 1, 3);
            tableLayoutPanel1.Controls.Add(hp_label, 2, 3);
            tableLayoutPanel1.Controls.Add(hp_textbox, 3, 3);
            tableLayoutPanel1.Controls.Add(maxhp_label, 4, 3);
            tableLayoutPanel1.Controls.Add(maxhp_textBox, 5, 3);
            tableLayoutPanel1.Controls.Add(textBox3, 7, 3);
            tableLayoutPanel1.Controls.Add(sex_m_rButton, 3, 0);
            tableLayoutPanel1.Location = new Point(12, 106);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(783, 263);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ac_label
            // 
            ac_label.Anchor = AnchorStyles.Top;
            ac_label.AutoSize = true;
            ac_label.Font = new Font("Segoe UI", 12F);
            ac_label.Location = new Point(614, 195);
            ac_label.Name = "ac_label";
            ac_label.Size = new Size(33, 21);
            ac_label.TabIndex = 22;
            ac_label.Text = "AC:";
            // 
            // background_label
            // 
            background_label.Anchor = AnchorStyles.Top;
            background_label.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(background_label, 2);
            background_label.Font = new Font("Segoe UI", 12F);
            background_label.Location = new Point(340, 130);
            background_label.Name = "background_label";
            background_label.Size = new Size(96, 21);
            background_label.TabIndex = 14;
            background_label.Text = "Background:";
            // 
            // background_textBox
            // 
            background_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(background_textBox, 2);
            background_textBox.Location = new Point(488, 140);
            background_textBox.Name = "background_textBox";
            background_textBox.Size = new Size(188, 44);
            background_textBox.TabIndex = 15;
            background_textBox.Text = "";
            // 
            // skill_label
            // 
            skill_label.Anchor = AnchorStyles.Top;
            skill_label.AutoSize = true;
            skill_label.Font = new Font("Segoe UI", 12F);
            skill_label.Location = new Point(24, 65);
            skill_label.Name = "skill_label";
            skill_label.Size = new Size(49, 21);
            skill_label.TabIndex = 8;
            skill_label.Text = "Skills:";
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
            // sex_f_button
            // 
            sex_f_button.Anchor = AnchorStyles.Top;
            sex_f_button.AutoSize = true;
            sex_f_button.Font = new Font("Segoe UI", 12F);
            sex_f_button.Location = new Point(397, 3);
            sex_f_button.Name = "sex_f_button";
            sex_f_button.Size = new Size(78, 25);
            sex_f_button.TabIndex = 3;
            sex_f_button.TabStop = true;
            sex_f_button.Text = "Female";
            sex_f_button.UseVisualStyleBackColor = true;
            // 
            // character_name_label
            // 
            character_name_label.Anchor = AnchorStyles.Top;
            character_name_label.AutoSize = true;
            character_name_label.Font = new Font("Segoe UI", 12F);
            character_name_label.Location = new Point(21, 0);
            character_name_label.Name = "character_name_label";
            character_name_label.Size = new Size(55, 21);
            character_name_label.TabIndex = 0;
            character_name_label.Text = "Name:";
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
            // skill_textBox
            // 
            skill_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(skill_textBox, 2);
            skill_textBox.Location = new Point(100, 75);
            skill_textBox.Name = "skill_textBox";
            skill_textBox.Size = new Size(188, 44);
            skill_textBox.TabIndex = 9;
            skill_textBox.Text = "";
            // 
            // proficiencies_label
            // 
            proficiencies_label.Anchor = AnchorStyles.Top;
            proficiencies_label.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(proficiencies_label, 2);
            proficiencies_label.Font = new Font("Segoe UI", 12F);
            proficiencies_label.Location = new Point(338, 65);
            proficiencies_label.Name = "proficiencies_label";
            proficiencies_label.Size = new Size(100, 21);
            proficiencies_label.TabIndex = 10;
            proficiencies_label.Text = "Proficiencies:";
            // 
            // proficiencies_textBox
            // 
            proficiencies_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(proficiencies_textBox, 2);
            proficiencies_textBox.Location = new Point(488, 75);
            proficiencies_textBox.Name = "proficiencies_textBox";
            proficiencies_textBox.Size = new Size(188, 44);
            proficiencies_textBox.TabIndex = 11;
            proficiencies_textBox.Text = "";
            // 
            // equipment_textBox
            // 
            equipment_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(equipment_textBox, 2);
            equipment_textBox.Location = new Point(100, 140);
            equipment_textBox.Name = "equipment_textBox";
            equipment_textBox.Size = new Size(188, 44);
            equipment_textBox.TabIndex = 13;
            equipment_textBox.Text = "";
            // 
            // equipment_label
            // 
            equipment_label.Anchor = AnchorStyles.Top;
            equipment_label.AutoSize = true;
            equipment_label.Font = new Font("Segoe UI", 12F);
            equipment_label.Location = new Point(4, 130);
            equipment_label.Name = "equipment_label";
            equipment_label.Size = new Size(88, 21);
            equipment_label.TabIndex = 12;
            equipment_label.Text = "Equipment:";
            // 
            // xp_label
            // 
            xp_label.Anchor = AnchorStyles.Top;
            xp_label.AutoSize = true;
            xp_label.Font = new Font("Segoe UI", 12F);
            xp_label.Location = new Point(33, 195);
            xp_label.Name = "xp_label";
            xp_label.Size = new Size(31, 21);
            xp_label.TabIndex = 16;
            xp_label.Text = "XP:";
            // 
            // xp_textbox
            // 
            xp_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            xp_textbox.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xp_textbox.Location = new Point(100, 198);
            xp_textbox.Name = "xp_textbox";
            xp_textbox.Size = new Size(91, 22);
            xp_textbox.TabIndex = 17;
            // 
            // hp_label
            // 
            hp_label.Anchor = AnchorStyles.Top;
            hp_label.AutoSize = true;
            hp_label.Font = new Font("Segoe UI", 12F);
            hp_label.Location = new Point(226, 195);
            hp_label.Name = "hp_label";
            hp_label.Size = new Size(33, 21);
            hp_label.TabIndex = 18;
            hp_label.Text = "HP:";
            // 
            // hp_textbox
            // 
            hp_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hp_textbox.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hp_textbox.Location = new Point(294, 198);
            hp_textbox.Name = "hp_textbox";
            hp_textbox.Size = new Size(91, 22);
            hp_textbox.TabIndex = 19;
            // 
            // maxhp_label
            // 
            maxhp_label.Anchor = AnchorStyles.Top;
            maxhp_label.AutoSize = true;
            maxhp_label.Font = new Font("Segoe UI", 12F);
            maxhp_label.Location = new Point(403, 195);
            maxhp_label.Name = "maxhp_label";
            maxhp_label.Size = new Size(66, 21);
            maxhp_label.TabIndex = 20;
            maxhp_label.Text = "Max HP:";
            // 
            // maxhp_textBox
            // 
            maxhp_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maxhp_textBox.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxhp_textBox.Location = new Point(488, 198);
            maxhp_textBox.Name = "maxhp_textBox";
            maxhp_textBox.Size = new Size(91, 22);
            maxhp_textBox.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(682, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(98, 22);
            textBox3.TabIndex = 23;
            // 
            // sex_m_rButton
            // 
            sex_m_rButton.Anchor = AnchorStyles.Top;
            sex_m_rButton.AutoSize = true;
            sex_m_rButton.Font = new Font("Segoe UI", 12F);
            sex_m_rButton.Location = new Point(308, 3);
            sex_m_rButton.Name = "sex_m_rButton";
            sex_m_rButton.Size = new Size(62, 25);
            sex_m_rButton.TabIndex = 5;
            sex_m_rButton.TabStop = true;
            sex_m_rButton.Text = "Male";
            sex_m_rButton.UseVisualStyleBackColor = true;
            // 
            // character_title_label
            // 
            character_title_label.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            character_title_label.Location = new Point(12, 9);
            character_title_label.Name = "character_title_label";
            character_title_label.Size = new Size(795, 40);
            character_title_label.TabIndex = 1;
            character_title_label.Text = "New Character";
            // 
            // basicInfo_label
            // 
            basicInfo_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            basicInfo_label.Location = new Point(12, 63);
            basicInfo_label.Name = "basicInfo_label";
            basicInfo_label.Size = new Size(795, 40);
            basicInfo_label.TabIndex = 2;
            basicInfo_label.Text = "Basic Info:";
            // 
            // raceInfo_title
            // 
            raceInfo_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            raceInfo_title.Location = new Point(12, 385);
            raceInfo_title.Name = "raceInfo_title";
            raceInfo_title.Size = new Size(795, 40);
            raceInfo_title.TabIndex = 3;
            raceInfo_title.Text = "Race Info:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 3, 0);
            tableLayoutPanel2.Controls.Add(comboBox2, 4, 0);
            tableLayoutPanel2.Controls.Add(label4, 2, 1);
            tableLayoutPanel2.Controls.Add(textBox4, 4, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(richTextBox1, 1, 2);
            tableLayoutPanel2.Controls.Add(label6, 4, 2);
            tableLayoutPanel2.Controls.Add(richTextBox2, 5, 2);
            tableLayoutPanel2.Location = new Point(12, 423);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(783, 196);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(22, 65);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // comboBox1
            // 
            tableLayoutPanel2.SetColumnSpan(comboBox1, 2);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(313, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // comboBox2
            // 
            tableLayoutPanel2.SetColumnSpan(comboBox2, 2);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(391, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 23);
            comboBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label4, 2);
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(210, 65);
            label4.Name = "label4";
            label4.Size = new Size(162, 21);
            label4.TabIndex = 6;
            label4.Text = "Ability Score Bonuses:";
            // 
            // textBox4
            // 
            tableLayoutPanel2.SetColumnSpan(textBox4, 2);
            textBox4.Location = new Point(391, 68);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 130);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 10;
            label5.Text = "Skills:";
            label5.Click += this.label5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(richTextBox1, 2);
            richTextBox1.Location = new Point(100, 141);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(188, 44);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += this.richTextBox1_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(412, 130);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 12;
            label6.Text = "Skills:";
            label6.Click += label6_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(richTextBox2, 2);
            richTextBox2.Location = new Point(488, 141);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(188, 44);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 949);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(raceInfo_title);
            Controls.Add(basicInfo_label);
            Controls.Add(character_title_label);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(823, 611);
            Name = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label character_name_label;
        private Label sex_label;
        private RadioButton sex_f_button;
        private TextBox textBox1;
        private RadioButton sex_m_rButton;
        private Label level_label;
        private ComboBox lvl_drop_drown;
        private Label character_title_label;
        private Label basicInfo_label;
        private Label skill_label;
        private RichTextBox skill_textBox;
        private RichTextBox proficiencies_textBox;
        private Label proficiencies_label;
        private Label background_label;
        private RichTextBox background_textBox;
        private RichTextBox equipment_textBox;
        private Label equipment_label;
        private Label xp_label;
        private TextBox xp_textbox;
        private Label hp_label;
        private TextBox hp_textbox;
        private Label ac_label;
        private Label maxhp_label;
        private TextBox maxhp_textBox;
        private TextBox textBox3;
        private Label raceInfo_title;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label6;
        private RichTextBox richTextBox2;
    }
}
