namespace Frontend
{
    partial class RootForm
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
            scrollablePanel = new Panel();
            mainTableLayoutPanel = new TableLayoutPanel();
            newcharacter_title = new Label();
            basicinfo_label = new Label();
            character_name_label = new Label();
            textBox1 = new TextBox();
            sex_label = new Label();
            sex_f_button = new RadioButton();
            sex_m_rButton = new RadioButton();
            level_label = new Label();
            lvl_drop_drown = new ComboBox();
            skill_label = new Label();
            skill_textBox = new RichTextBox();
            equipment_label = new Label();
            background_label = new Label();
            equipment_textBox = new RichTextBox();
            xp_label = new Label();
            hp_label = new Label();
            xp_textbox = new TextBox();
            hp_textbox = new TextBox();
            maxhp_label = new Label();
            maxhp_textBox = new TextBox();
            ac_label = new Label();
            textBox3 = new TextBox();
            raceinfo_label = new Label();
            racename_label = new Label();
            racename_comboBox = new ComboBox();
            racesize_label = new Label();
            racesize_comboBox = new ComboBox();
            speed_label = new Label();
            r_speed_textBox = new TextBox();
            label4 = new Label();
            absb_textBox = new TextBox();
            languages_label = new Label();
            racefeatures_label = new Label();
            languages_textBox = new RichTextBox();
            r_features_textBox = new RichTextBox();
            classinfo_label = new Label();
            classname_label = new Label();
            classname_comboBox = new ComboBox();
            hitdie_label = new Label();
            hitdie_comboBox = new ComboBox();
            primaryability_label = new Label();
            primaryability_textBox = new TextBox();
            savingthrow_label = new Label();
            skillchoices_label = new Label();
            savingthrow_textBox = new TextBox();
            skillchoices_comboBox = new ComboBox();
            classfeatures_label = new Label();
            classfeatures_textBox = new RichTextBox();
            cancel_button = new Button();
            next_button = new Button();
            proficiencies_textBox = new RichTextBox();
            background_textBox = new RichTextBox();
            proficiencies_label = new Label();
            scrollablePanel.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // scrollablePanel
            // 
            scrollablePanel.Controls.Add(mainTableLayoutPanel);
            scrollablePanel.Dock = DockStyle.Fill;
            scrollablePanel.Location = new Point(0, 0);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(807, 1061);
            scrollablePanel.TabIndex = 0;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainTableLayoutPanel.ColumnCount = 8;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayoutPanel.Controls.Add(newcharacter_title, 0, 0);
            mainTableLayoutPanel.Controls.Add(basicinfo_label, 0, 1);
            mainTableLayoutPanel.Controls.Add(character_name_label, 0, 2);
            mainTableLayoutPanel.Controls.Add(textBox1, 1, 2);
            mainTableLayoutPanel.Controls.Add(sex_label, 2, 2);
            mainTableLayoutPanel.Controls.Add(sex_f_button, 3, 2);
            mainTableLayoutPanel.Controls.Add(sex_m_rButton, 4, 2);
            mainTableLayoutPanel.Controls.Add(level_label, 5, 2);
            mainTableLayoutPanel.Controls.Add(lvl_drop_drown, 6, 2);
            mainTableLayoutPanel.Controls.Add(skill_label, 0, 3);
            mainTableLayoutPanel.Controls.Add(skill_textBox, 1, 3);
            mainTableLayoutPanel.Controls.Add(equipment_label, 0, 4);
            mainTableLayoutPanel.Controls.Add(background_label, 2, 4);
            mainTableLayoutPanel.Controls.Add(equipment_textBox, 1, 4);
            mainTableLayoutPanel.Controls.Add(xp_label, 0, 5);
            mainTableLayoutPanel.Controls.Add(hp_label, 2, 5);
            mainTableLayoutPanel.Controls.Add(xp_textbox, 1, 5);
            mainTableLayoutPanel.Controls.Add(hp_textbox, 3, 5);
            mainTableLayoutPanel.Controls.Add(maxhp_label, 4, 5);
            mainTableLayoutPanel.Controls.Add(maxhp_textBox, 5, 5);
            mainTableLayoutPanel.Controls.Add(ac_label, 6, 5);
            mainTableLayoutPanel.Controls.Add(textBox3, 7, 5);
            mainTableLayoutPanel.Controls.Add(raceinfo_label, 0, 6);
            mainTableLayoutPanel.Controls.Add(racename_label, 0, 7);
            mainTableLayoutPanel.Controls.Add(racename_comboBox, 1, 7);
            mainTableLayoutPanel.Controls.Add(racesize_label, 2, 7);
            mainTableLayoutPanel.Controls.Add(racesize_comboBox, 3, 7);
            mainTableLayoutPanel.Controls.Add(speed_label, 0, 8);
            mainTableLayoutPanel.Controls.Add(r_speed_textBox, 1, 8);
            mainTableLayoutPanel.Controls.Add(label4, 2, 8);
            mainTableLayoutPanel.Controls.Add(absb_textBox, 3, 8);
            mainTableLayoutPanel.Controls.Add(languages_label, 0, 9);
            mainTableLayoutPanel.Controls.Add(racefeatures_label, 2, 9);
            mainTableLayoutPanel.Controls.Add(languages_textBox, 1, 9);
            mainTableLayoutPanel.Controls.Add(r_features_textBox, 3, 9);
            mainTableLayoutPanel.Controls.Add(classinfo_label, 0, 10);
            mainTableLayoutPanel.Controls.Add(classname_label, 0, 11);
            mainTableLayoutPanel.Controls.Add(classname_comboBox, 1, 11);
            mainTableLayoutPanel.Controls.Add(hitdie_label, 2, 11);
            mainTableLayoutPanel.Controls.Add(hitdie_comboBox, 3, 11);
            mainTableLayoutPanel.Controls.Add(primaryability_label, 0, 12);
            mainTableLayoutPanel.Controls.Add(primaryability_textBox, 1, 12);
            mainTableLayoutPanel.Controls.Add(savingthrow_label, 2, 12);
            mainTableLayoutPanel.Controls.Add(skillchoices_label, 0, 13);
            mainTableLayoutPanel.Controls.Add(savingthrow_textBox, 3, 12);
            mainTableLayoutPanel.Controls.Add(skillchoices_comboBox, 1, 13);
            mainTableLayoutPanel.Controls.Add(classfeatures_label, 2, 13);
            mainTableLayoutPanel.Controls.Add(classfeatures_textBox, 3, 13);
            mainTableLayoutPanel.Controls.Add(cancel_button, 3, 14);
            mainTableLayoutPanel.Controls.Add(next_button, 4, 14);
            mainTableLayoutPanel.Controls.Add(proficiencies_textBox, 4, 3);
            mainTableLayoutPanel.Controls.Add(background_textBox, 4, 4);
            mainTableLayoutPanel.Controls.Add(proficiencies_label, 3, 3);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 15;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(807, 1061);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // newcharacter_title
            // 
            newcharacter_title.Anchor = AnchorStyles.Left;
            newcharacter_title.AutoSize = true;
            mainTableLayoutPanel.SetColumnSpan(newcharacter_title, 8);
            newcharacter_title.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newcharacter_title.Location = new Point(3, 12);
            newcharacter_title.Name = "newcharacter_title";
            newcharacter_title.Size = new Size(261, 45);
            newcharacter_title.TabIndex = 27;
            newcharacter_title.Text = "New Character:";
            // 
            // basicinfo_label
            // 
            basicinfo_label.Anchor = AnchorStyles.Left;
            basicinfo_label.AutoSize = true;
            mainTableLayoutPanel.SetColumnSpan(basicinfo_label, 8);
            basicinfo_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            basicinfo_label.Location = new Point(3, 89);
            basicinfo_label.Name = "basicinfo_label";
            basicinfo_label.Size = new Size(133, 32);
            basicinfo_label.TabIndex = 26;
            basicinfo_label.Text = "Basic Info:";
            // 
            // character_name_label
            // 
            character_name_label.Anchor = AnchorStyles.Left;
            character_name_label.AutoSize = true;
            character_name_label.Font = new Font("Segoe UI", 12F);
            character_name_label.Location = new Point(3, 164);
            character_name_label.Name = "character_name_label";
            character_name_label.Size = new Size(55, 21);
            character_name_label.TabIndex = 28;
            character_name_label.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(103, 164);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First, Last";
            textBox1.Size = new Size(94, 22);
            textBox1.TabIndex = 31;
            // 
            // sex_label
            // 
            sex_label.Anchor = AnchorStyles.Left;
            sex_label.AutoSize = true;
            sex_label.Font = new Font("Segoe UI", 12F);
            sex_label.Location = new Point(203, 164);
            sex_label.Name = "sex_label";
            sex_label.Size = new Size(37, 21);
            sex_label.TabIndex = 29;
            sex_label.Text = "Sex:";
            // 
            // sex_f_button
            // 
            sex_f_button.Anchor = AnchorStyles.Left;
            sex_f_button.AutoSize = true;
            sex_f_button.Font = new Font("Segoe UI", 12F);
            sex_f_button.Location = new Point(303, 162);
            sex_f_button.Name = "sex_f_button";
            sex_f_button.Size = new Size(78, 25);
            sex_f_button.TabIndex = 30;
            sex_f_button.TabStop = true;
            sex_f_button.Text = "Female";
            sex_f_button.UseVisualStyleBackColor = true;
            // 
            // sex_m_rButton
            // 
            sex_m_rButton.Anchor = AnchorStyles.Left;
            sex_m_rButton.AutoSize = true;
            sex_m_rButton.Font = new Font("Segoe UI", 12F);
            sex_m_rButton.Location = new Point(403, 162);
            sex_m_rButton.Name = "sex_m_rButton";
            sex_m_rButton.Size = new Size(62, 25);
            sex_m_rButton.TabIndex = 32;
            sex_m_rButton.TabStop = true;
            sex_m_rButton.Text = "Male";
            sex_m_rButton.UseVisualStyleBackColor = true;
            // 
            // level_label
            // 
            level_label.Anchor = AnchorStyles.Left;
            level_label.AutoSize = true;
            level_label.Font = new Font("Segoe UI", 12F);
            level_label.Location = new Point(503, 164);
            level_label.Name = "level_label";
            level_label.Size = new Size(49, 21);
            level_label.TabIndex = 33;
            level_label.Text = "Level:";
            // 
            // lvl_drop_drown
            // 
            lvl_drop_drown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lvl_drop_drown.FormattingEnabled = true;
            lvl_drop_drown.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            lvl_drop_drown.Location = new Point(603, 163);
            lvl_drop_drown.Name = "lvl_drop_drown";
            lvl_drop_drown.Size = new Size(94, 23);
            lvl_drop_drown.TabIndex = 34;
            lvl_drop_drown.Text = "1";
            // 
            // skill_label
            // 
            skill_label.Anchor = AnchorStyles.Left;
            skill_label.AutoSize = true;
            skill_label.Font = new Font("Segoe UI", 12F);
            skill_label.Location = new Point(3, 234);
            skill_label.Name = "skill_label";
            skill_label.Size = new Size(49, 21);
            skill_label.TabIndex = 35;
            skill_label.Text = "Skills:";
            // 
            // skill_textBox
            // 
            mainTableLayoutPanel.SetColumnSpan(skill_textBox, 2);
            skill_textBox.Dock = DockStyle.Fill;
            skill_textBox.Location = new Point(103, 213);
            skill_textBox.Name = "skill_textBox";
            skill_textBox.Size = new Size(194, 64);
            skill_textBox.TabIndex = 36;
            skill_textBox.Text = "";
            // 
            // equipment_label
            // 
            equipment_label.Anchor = AnchorStyles.Left;
            equipment_label.AutoSize = true;
            equipment_label.Font = new Font("Segoe UI", 12F);
            equipment_label.Location = new Point(3, 304);
            equipment_label.Name = "equipment_label";
            equipment_label.Size = new Size(88, 21);
            equipment_label.TabIndex = 39;
            equipment_label.Text = "Equipment:";
            // 
            // background_label
            // 
            background_label.Anchor = AnchorStyles.Left;
            background_label.AutoSize = true;
            background_label.Font = new Font("Segoe UI", 12F);
            background_label.Location = new Point(303, 294);
            background_label.Name = "background_label";
            background_label.Size = new Size(93, 42);
            background_label.TabIndex = 41;
            background_label.Text = "Background:";
            // 
            // equipment_textBox
            // 
            mainTableLayoutPanel.SetColumnSpan(equipment_textBox, 2);
            equipment_textBox.Dock = DockStyle.Fill;
            equipment_textBox.Location = new Point(103, 283);
            equipment_textBox.Name = "equipment_textBox";
            equipment_textBox.Size = new Size(194, 64);
            equipment_textBox.TabIndex = 40;
            equipment_textBox.Text = "";
            // 
            // xp_label
            // 
            xp_label.Anchor = AnchorStyles.Left;
            xp_label.AutoSize = true;
            xp_label.Font = new Font("Segoe UI", 12F);
            xp_label.Location = new Point(3, 374);
            xp_label.Name = "xp_label";
            xp_label.Size = new Size(31, 21);
            xp_label.TabIndex = 43;
            xp_label.Text = "XP:";
            // 
            // hp_label
            // 
            hp_label.Anchor = AnchorStyles.Left;
            hp_label.AutoSize = true;
            hp_label.Font = new Font("Segoe UI", 12F);
            hp_label.Location = new Point(203, 374);
            hp_label.Name = "hp_label";
            hp_label.Size = new Size(33, 21);
            hp_label.TabIndex = 45;
            hp_label.Text = "HP:";
            // 
            // xp_textbox
            // 
            xp_textbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            xp_textbox.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xp_textbox.Location = new Point(103, 374);
            xp_textbox.Name = "xp_textbox";
            xp_textbox.Size = new Size(94, 22);
            xp_textbox.TabIndex = 44;
            // 
            // hp_textbox
            // 
            hp_textbox.Anchor = AnchorStyles.Left;
            hp_textbox.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hp_textbox.Location = new Point(303, 374);
            hp_textbox.Name = "hp_textbox";
            hp_textbox.Size = new Size(7, 22);
            hp_textbox.TabIndex = 46;
            // 
            // maxhp_label
            // 
            maxhp_label.Anchor = AnchorStyles.Left;
            maxhp_label.AutoSize = true;
            maxhp_label.Font = new Font("Segoe UI", 12F);
            maxhp_label.Location = new Point(403, 374);
            maxhp_label.Name = "maxhp_label";
            maxhp_label.Size = new Size(66, 21);
            maxhp_label.TabIndex = 47;
            maxhp_label.Text = "Max HP:";
            // 
            // maxhp_textBox
            // 
            maxhp_textBox.Anchor = AnchorStyles.Left;
            maxhp_textBox.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxhp_textBox.Location = new Point(503, 374);
            maxhp_textBox.Name = "maxhp_textBox";
            maxhp_textBox.Size = new Size(5, 22);
            maxhp_textBox.TabIndex = 48;
            // 
            // ac_label
            // 
            ac_label.Anchor = AnchorStyles.Left;
            ac_label.AutoSize = true;
            ac_label.Font = new Font("Segoe UI", 12F);
            ac_label.Location = new Point(603, 374);
            ac_label.Name = "ac_label";
            ac_label.Size = new Size(33, 21);
            ac_label.TabIndex = 49;
            ac_label.Text = "AC:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(703, 374);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(101, 22);
            textBox3.TabIndex = 50;
            // 
            // raceinfo_label
            // 
            raceinfo_label.Anchor = AnchorStyles.Left;
            raceinfo_label.AutoSize = true;
            mainTableLayoutPanel.SetColumnSpan(raceinfo_label, 8);
            raceinfo_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            raceinfo_label.Location = new Point(3, 439);
            raceinfo_label.Name = "raceinfo_label";
            raceinfo_label.Size = new Size(129, 32);
            raceinfo_label.TabIndex = 63;
            raceinfo_label.Text = "Race Info:";
            // 
            // racename_label
            // 
            racename_label.Anchor = AnchorStyles.Left;
            racename_label.AutoSize = true;
            racename_label.Font = new Font("Segoe UI", 12F);
            racename_label.Location = new Point(3, 514);
            racename_label.Name = "racename_label";
            racename_label.Size = new Size(92, 21);
            racename_label.TabIndex = 51;
            racename_label.Text = "Race Name:";
            racename_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // racename_comboBox
            // 
            racename_comboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            racename_comboBox.FormattingEnabled = true;
            racename_comboBox.Location = new Point(103, 513);
            racename_comboBox.Name = "racename_comboBox";
            racename_comboBox.Size = new Size(94, 23);
            racename_comboBox.TabIndex = 52;
            // 
            // racesize_label
            // 
            racesize_label.Anchor = AnchorStyles.Left;
            racesize_label.AutoSize = true;
            racesize_label.Font = new Font("Segoe UI", 12F);
            racesize_label.Location = new Point(203, 514);
            racesize_label.Name = "racesize_label";
            racesize_label.Size = new Size(78, 21);
            racesize_label.TabIndex = 53;
            racesize_label.Text = "Race Size:";
            racesize_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // racesize_comboBox
            // 
            racesize_comboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            racesize_comboBox.FormattingEnabled = true;
            racesize_comboBox.Location = new Point(303, 513);
            racesize_comboBox.Name = "racesize_comboBox";
            racesize_comboBox.Size = new Size(94, 23);
            racesize_comboBox.TabIndex = 54;
            // 
            // speed_label
            // 
            speed_label.Anchor = AnchorStyles.Left;
            speed_label.AutoSize = true;
            speed_label.Font = new Font("Segoe UI", 12F);
            speed_label.Location = new Point(3, 584);
            speed_label.Name = "speed_label";
            speed_label.Size = new Size(56, 21);
            speed_label.TabIndex = 55;
            speed_label.Text = "Speed:";
            speed_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // r_speed_textBox
            // 
            r_speed_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            r_speed_textBox.Location = new Point(103, 583);
            r_speed_textBox.Name = "r_speed_textBox";
            r_speed_textBox.Size = new Size(94, 23);
            r_speed_textBox.TabIndex = 56;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(203, 563);
            label4.Name = "label4";
            label4.Size = new Size(71, 63);
            label4.TabIndex = 57;
            label4.Text = "Ability Score Bonuses:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // absb_textBox
            // 
            absb_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            absb_textBox.Location = new Point(303, 583);
            absb_textBox.Name = "absb_textBox";
            absb_textBox.Size = new Size(94, 23);
            absb_textBox.TabIndex = 58;
            // 
            // languages_label
            // 
            languages_label.Anchor = AnchorStyles.Left;
            languages_label.AutoSize = true;
            languages_label.Font = new Font("Segoe UI", 12F);
            languages_label.Location = new Point(3, 654);
            languages_label.Name = "languages_label";
            languages_label.Size = new Size(88, 21);
            languages_label.TabIndex = 59;
            languages_label.Text = "Languages:";
            languages_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // racefeatures_label
            // 
            racefeatures_label.Anchor = AnchorStyles.Left;
            racefeatures_label.AutoSize = true;
            racefeatures_label.Font = new Font("Segoe UI", 12F);
            racefeatures_label.Location = new Point(203, 644);
            racefeatures_label.Name = "racefeatures_label";
            racefeatures_label.Size = new Size(72, 42);
            racefeatures_label.TabIndex = 61;
            racefeatures_label.Text = "Racial Features:";
            racefeatures_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // languages_textBox
            // 
            languages_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            languages_textBox.Location = new Point(103, 660);
            languages_textBox.Name = "languages_textBox";
            languages_textBox.Size = new Size(94, 9);
            languages_textBox.TabIndex = 60;
            languages_textBox.Text = "";
            // 
            // r_features_textBox
            // 
            r_features_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            r_features_textBox.Location = new Point(303, 660);
            r_features_textBox.Name = "r_features_textBox";
            r_features_textBox.Size = new Size(94, 9);
            r_features_textBox.TabIndex = 62;
            r_features_textBox.Text = "";
            // 
            // classinfo_label
            // 
            classinfo_label.Anchor = AnchorStyles.Left;
            classinfo_label.AutoSize = true;
            mainTableLayoutPanel.SetColumnSpan(classinfo_label, 8);
            classinfo_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classinfo_label.Location = new Point(3, 719);
            classinfo_label.Name = "classinfo_label";
            classinfo_label.Size = new Size(132, 32);
            classinfo_label.TabIndex = 76;
            classinfo_label.Text = "Class Info:";
            // 
            // classname_label
            // 
            classname_label.Anchor = AnchorStyles.Left;
            classname_label.AutoSize = true;
            classname_label.Font = new Font("Segoe UI", 12F);
            classname_label.Location = new Point(3, 784);
            classname_label.Name = "classname_label";
            classname_label.Size = new Size(55, 42);
            classname_label.TabIndex = 64;
            classname_label.Text = "Class Name:";
            // 
            // classname_comboBox
            // 
            classname_comboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            classname_comboBox.FormattingEnabled = true;
            classname_comboBox.Location = new Point(103, 793);
            classname_comboBox.Name = "classname_comboBox";
            classname_comboBox.Size = new Size(94, 23);
            classname_comboBox.TabIndex = 65;
            // 
            // hitdie_label
            // 
            hitdie_label.Anchor = AnchorStyles.Left;
            hitdie_label.AutoSize = true;
            hitdie_label.Font = new Font("Segoe UI", 12F);
            hitdie_label.Location = new Point(203, 794);
            hitdie_label.Name = "hitdie_label";
            hitdie_label.Size = new Size(60, 21);
            hitdie_label.TabIndex = 66;
            hitdie_label.Text = "Hit Die:";
            // 
            // hitdie_comboBox
            // 
            hitdie_comboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hitdie_comboBox.FormattingEnabled = true;
            hitdie_comboBox.Location = new Point(303, 793);
            hitdie_comboBox.Name = "hitdie_comboBox";
            hitdie_comboBox.Size = new Size(94, 23);
            hitdie_comboBox.TabIndex = 67;
            // 
            // primaryability_label
            // 
            primaryability_label.Anchor = AnchorStyles.Left;
            primaryability_label.AutoSize = true;
            primaryability_label.Font = new Font("Segoe UI", 12F);
            primaryability_label.Location = new Point(3, 854);
            primaryability_label.Name = "primaryability_label";
            primaryability_label.Size = new Size(69, 42);
            primaryability_label.TabIndex = 68;
            primaryability_label.Text = "Primary Ability:";
            // 
            // primaryability_textBox
            // 
            primaryability_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            primaryability_textBox.Location = new Point(103, 863);
            primaryability_textBox.Name = "primaryability_textBox";
            primaryability_textBox.Size = new Size(94, 23);
            primaryability_textBox.TabIndex = 69;
            // 
            // savingthrow_label
            // 
            savingthrow_label.Anchor = AnchorStyles.Left;
            savingthrow_label.AutoSize = true;
            savingthrow_label.Font = new Font("Segoe UI", 12F);
            savingthrow_label.Location = new Point(203, 854);
            savingthrow_label.Name = "savingthrow_label";
            savingthrow_label.Size = new Size(64, 42);
            savingthrow_label.TabIndex = 70;
            savingthrow_label.Text = "Saving Throws:";
            // 
            // skillchoices_label
            // 
            skillchoices_label.Anchor = AnchorStyles.Left;
            skillchoices_label.AutoSize = true;
            skillchoices_label.Font = new Font("Segoe UI", 12F);
            skillchoices_label.Location = new Point(3, 924);
            skillchoices_label.Name = "skillchoices_label";
            skillchoices_label.Size = new Size(67, 42);
            skillchoices_label.TabIndex = 74;
            skillchoices_label.Text = "Skill Choices:";
            // 
            // savingthrow_textBox
            // 
            savingthrow_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            savingthrow_textBox.Location = new Point(303, 863);
            savingthrow_textBox.Name = "savingthrow_textBox";
            savingthrow_textBox.Size = new Size(94, 23);
            savingthrow_textBox.TabIndex = 71;
            // 
            // skillchoices_comboBox
            // 
            skillchoices_comboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            skillchoices_comboBox.FormattingEnabled = true;
            skillchoices_comboBox.Location = new Point(103, 933);
            skillchoices_comboBox.Name = "skillchoices_comboBox";
            skillchoices_comboBox.Size = new Size(94, 23);
            skillchoices_comboBox.TabIndex = 75;
            // 
            // classfeatures_label
            // 
            classfeatures_label.Anchor = AnchorStyles.Left;
            classfeatures_label.AutoSize = true;
            classfeatures_label.Font = new Font("Segoe UI", 12F);
            classfeatures_label.Location = new Point(203, 924);
            classfeatures_label.Name = "classfeatures_label";
            classfeatures_label.Size = new Size(72, 42);
            classfeatures_label.TabIndex = 72;
            classfeatures_label.Text = "Class Features:";
            // 
            // classfeatures_textBox
            // 
            classfeatures_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            classfeatures_textBox.Location = new Point(303, 940);
            classfeatures_textBox.Name = "classfeatures_textBox";
            classfeatures_textBox.Size = new Size(94, 10);
            classfeatures_textBox.TabIndex = 73;
            classfeatures_textBox.Text = "";
            // 
            // cancel_button
            // 
            cancel_button.Anchor = AnchorStyles.None;
            cancel_button.Location = new Point(329, 996);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(41, 49);
            cancel_button.TabIndex = 78;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = true;
            // 
            // next_button
            // 
            next_button.Anchor = AnchorStyles.None;
            next_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            next_button.FlatStyle = FlatStyle.Flat;
            next_button.Location = new Point(429, 996);
            next_button.Name = "next_button";
            next_button.Size = new Size(41, 49);
            next_button.TabIndex = 77;
            next_button.Text = "Next";
            next_button.UseVisualStyleBackColor = true;
            // 
            // proficiencies_textBox
            // 
            mainTableLayoutPanel.SetColumnSpan(proficiencies_textBox, 2);
            proficiencies_textBox.Dock = DockStyle.Fill;
            proficiencies_textBox.Location = new Point(403, 213);
            proficiencies_textBox.Name = "proficiencies_textBox";
            proficiencies_textBox.Size = new Size(194, 64);
            proficiencies_textBox.TabIndex = 38;
            proficiencies_textBox.Text = "";
            // 
            // background_textBox
            // 
            mainTableLayoutPanel.SetColumnSpan(background_textBox, 2);
            background_textBox.Dock = DockStyle.Fill;
            background_textBox.Location = new Point(403, 283);
            background_textBox.Name = "background_textBox";
            background_textBox.Size = new Size(194, 64);
            background_textBox.TabIndex = 42;
            background_textBox.Text = "";
            // 
            // proficiencies_label
            // 
            proficiencies_label.Anchor = AnchorStyles.Left;
            proficiencies_label.AutoSize = true;
            proficiencies_label.Font = new Font("Segoe UI", 12F);
            proficiencies_label.Location = new Point(303, 224);
            proficiencies_label.Name = "proficiencies_label";
            proficiencies_label.Size = new Size(90, 42);
            proficiencies_label.TabIndex = 37;
            proficiencies_label.Text = "Proficiencies:";
            // 
            // RootForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(807, 1061);
            Controls.Add(scrollablePanel);
            Name = "RootForm";
            StartPosition = FormStartPosition.CenterScreen;
            scrollablePanel.ResumeLayout(false);
            scrollablePanel.PerformLayout();
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel scrollablePanel;
        private TableLayoutPanel mainTableLayoutPanel;
        private Label newcharacter_title;
        private Label basicinfo_label;
        private Label ac_label;
        private Label background_label;
        private Label skill_label;
        private RichTextBox skill_textBox;
        private RichTextBox equipment_textBox;
        private Label equipment_label;
        private Label xp_label;
        private TextBox xp_textbox;
        private Label hp_label;
        private TextBox hp_textbox;
        private Label maxhp_label;
        private TextBox maxhp_textBox;
        private TextBox textBox3;
        private Label proficiencies_label;
        private RichTextBox proficiencies_textBox;
        private RichTextBox background_textBox;
        private Label character_name_label;
        private TextBox textBox1;
        private Label sex_label;
        private RadioButton sex_f_button;
        private RadioButton sex_m_rButton;
        private Label level_label;
        private ComboBox lvl_drop_drown;
        private TextBox r_speed_textBox;
        private Label speed_label;
        private Label languages_label;
        private RichTextBox languages_textBox;
        private RichTextBox r_features_textBox;
        private ComboBox racesize_comboBox;
        private ComboBox racename_comboBox;
        private Label label4;
        private Label racefeatures_label;
        private TextBox absb_textBox;
        private Label racesize_label;
        private Label raceinfo_label;
        private Label racename_label;
        private Label skillchoices_label;
        private Label primaryability_label;
        private Label classname_label;
        private Label savingthrow_label;
        private TextBox savingthrow_textBox;
        private RichTextBox classfeatures_textBox;
        private Label classfeatures_label;
        private ComboBox skillchoices_comboBox;
        private TextBox primaryability_textBox;
        private ComboBox classname_comboBox;
        private Label hitdie_label;
        private ComboBox hitdie_comboBox;
        private Label classinfo_label;
        private Button cancel_button;
        private Button next_button;
    }
}
