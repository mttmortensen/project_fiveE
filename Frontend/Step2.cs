using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Step2 : UserControl
    {
        public Step2()
        {
            InitializeComponent();
            LoadStaticOptions();
        }
        private void LoadStaticOptions()
        {
            // Placeholder: Populate race dropdown
            cmbRace.Items.AddRange(new object[] { "Elf", "Gnome", "Human" });

            // Placeholder: Populate proficiencies
            lstProficiencies.Items.AddRange(new object[]
            {
                "Perception", "History", "Nature", "Athletics"
            });

            // Populate ability score options
            string[] stats = { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };
            cmbBonusStat1.Items.AddRange(stats);
            cmbBonusStat2.Items.AddRange(stats);
        }

        // Property to build CharacterRace object for backend
        public CharacterRaceModel GetCharacterRace()
        {
            return new CharacterRaceModel
            {
                RaceID = cmbRace.SelectedIndex + 1, // Placeholder
                Darkvision = chkDarkvision.Checked,
                RacialProficiencies = new List<string>(lstProficiencies.CheckedItems.Cast<string>()),
                AbilityScoreBonuses = new List<string>
                {
                    $"{cmbBonusStat1.SelectedItem}:2",
                    $"{cmbBonusStat2.SelectedItem}:1"
                }
            };
        }
        public class CharacterRaceModel
        {
            public int RaceID { get; set; }
            public bool Darkvision { get; set; }
            public List<string> RacialProficiencies { get; set; }
            public List<string> AbilityScoreBonuses { get; set; }
        }
    }
}

