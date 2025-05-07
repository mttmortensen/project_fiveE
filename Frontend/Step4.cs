using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Step4 : UserControl
    {
        public Step4()
        {
            InitializeComponent();
        }

        private int ParseScore(string text)
        {
            if (int.TryParse(text, out int result))
                return result;

            throw new FormatException($"'{text}' is not a valid number.");
        } 
        
        // This will be used in POST later but not sure if we need to do it here
        public Dictionary<string, int> GetAbilityScores()
        {
            var scores = new Dictionary<string, int>();

            try
            {
                scores["Strength"] = ParseScore(txtStrength.Text);
                scores["Dexterity"] = ParseScore(txtDexterity.Text);
                scores["Constitution"] = ParseScore(txtConstitution.Text);
                scores["Intelligence"] = ParseScore(txtIntelligence.Text);
                scores["Wisdom"] = ParseScore(txtWisdom.Text);
                scores["Charisma"] = ParseScore(txtCharisma.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading ability scores: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return scores;
        }
    }
}
