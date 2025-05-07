namespace Frontend
{
    partial class Step4
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox grpAbilityScores;
        private Label lblStrength;
        private Label lblDexterity;
        private Label lblConstitution;
        private Label lblIntelligence;
        private Label lblWisdom;
        private Label lblCharisma;

        private TextBox txtStrength;
        private TextBox txtDexterity;
        private TextBox txtConstitution;
        private TextBox txtIntelligence;
        private TextBox txtWisdom;
        private TextBox txtCharisma;

        private void InitializeComponent()
        {
            this.grpAbilityScores = new GroupBox();
            this.lblStrength = new Label();
            this.lblDexterity = new Label();
            this.lblConstitution = new Label();
            this.lblIntelligence = new Label();
            this.lblWisdom = new Label();
            this.lblCharisma = new Label();

            this.txtStrength = new TextBox();
            this.txtDexterity = new TextBox();
            this.txtConstitution = new TextBox();
            this.txtIntelligence = new TextBox();
            this.txtWisdom = new TextBox();
            this.txtCharisma = new TextBox();

            this.grpAbilityScores.SuspendLayout();
            this.SuspendLayout();

            // GroupBox: Ability Scores
            this.grpAbilityScores.Text = "Ability Scores";
            this.grpAbilityScores.Location = new System.Drawing.Point(20, 20);
            this.grpAbilityScores.Size = new System.Drawing.Size(300, 250);

            // Strength
            this.lblStrength.Text = "Strength:";
            this.lblStrength.Location = new System.Drawing.Point(10, 25);
            this.txtStrength.Location = new System.Drawing.Point(120, 22);
            this.txtStrength.Size = new System.Drawing.Size(50, 20);
            this.txtStrength.Text = "10";

            // Dexterity
            this.lblDexterity.Text = "Dexterity:";
            this.lblDexterity.Location = new System.Drawing.Point(10, 55);
            this.txtDexterity.Location = new System.Drawing.Point(120, 52);
            this.txtDexterity.Size = new System.Drawing.Size(50, 20);
            this.txtDexterity.Text = "10";

            // Constitution
            this.lblConstitution.Text = "Constitution:";
            this.lblConstitution.Location = new System.Drawing.Point(10, 85);
            this.txtConstitution.Location = new System.Drawing.Point(120, 82);
            this.txtConstitution.Size = new System.Drawing.Size(50, 20);
            this.txtConstitution.Text = "10";

            // Intelligence
            this.lblIntelligence.Text = "Intelligence:";
            this.lblIntelligence.Location = new System.Drawing.Point(10, 115);
            this.txtIntelligence.Location = new System.Drawing.Point(120, 112);
            this.txtIntelligence.Size = new System.Drawing.Size(50, 20);
            this.txtIntelligence.Text = "10";

            // Wisdom
            this.lblWisdom.Text = "Wisdom:";
            this.lblWisdom.Location = new System.Drawing.Point(10, 145);
            this.txtWisdom.Location = new System.Drawing.Point(120, 142);
            this.txtWisdom.Size = new System.Drawing.Size(50, 20);
            this.txtWisdom.Text = "10";

            // Charisma
            this.lblCharisma.Text = "Charisma:";
            this.lblCharisma.Location = new System.Drawing.Point(10, 175);
            this.txtCharisma.Location = new System.Drawing.Point(120, 172);
            this.txtCharisma.Size = new System.Drawing.Size(50, 20);
            this.txtCharisma.Text = "10";

            // Add controls
            this.grpAbilityScores.Controls.Add(this.lblStrength);
            this.grpAbilityScores.Controls.Add(this.txtStrength);
            this.grpAbilityScores.Controls.Add(this.lblDexterity);
            this.grpAbilityScores.Controls.Add(this.txtDexterity);
            this.grpAbilityScores.Controls.Add(this.lblConstitution);
            this.grpAbilityScores.Controls.Add(this.txtConstitution);
            this.grpAbilityScores.Controls.Add(this.lblIntelligence);
            this.grpAbilityScores.Controls.Add(this.txtIntelligence);
            this.grpAbilityScores.Controls.Add(this.lblWisdom);
            this.grpAbilityScores.Controls.Add(this.txtWisdom);
            this.grpAbilityScores.Controls.Add(this.lblCharisma);
            this.grpAbilityScores.Controls.Add(this.txtCharisma);

            this.Controls.Add(this.grpAbilityScores);

            // UserControl
            this.Size = new System.Drawing.Size(340, 300);
            this.grpAbilityScores.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
