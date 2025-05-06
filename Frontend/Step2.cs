using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace Frontend
{
    public partial class Step2 : UserControl
    {
        public Step2()
        {
            InitializeComponent();
            LoadRaceDataFromApi();
        }
        private async void LoadRaceDataFromApi()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync("http://localhost:5000/races");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var raceList = JsonSerializer.Deserialize<List<Step2RaceModel>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                cmbRace.DataSource = raceList;
                cmbRace.DisplayMember = "RaceName";
                cmbRace.ValueMember = "RaceID";

                cmbRace.SelectedIndexChanged += (s, e) =>
                {
                    if (cmbRace.SelectedItem is Step2RaceModel selectedRace)
                    {
                        ShowRaceDetails(selectedRace);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load races:\n" + ex.Message);
            }

            // Still load static ability bonus and proficiencies
            string[] stats = { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };
            cmbBonusStat1.Items.AddRange(stats);
            cmbBonusStat2.Items.AddRange(stats);

            lstProficiencies.Items.AddRange(new object[]
            {
                "Perception", "History", "Nature", "Athletics" // Temporary until API provides them per race
            });
        }

        private void ShowRaceDetails(Step2RaceModel race)
        {
            if (race == null)
                return;

            // Fill each label and description field
            lblSize.Text = $"Size: {race.RaceSize}";
            lblSpeed.Text = $"Speed: {race.Speed} ft";

            lblLanguages.Text = race.Languages != null && race.Languages.Count > 0
                ? $"Languages: {string.Join(", ", race.Languages)}"
                : "Languages: None";

            lblFeatures.Text = race.RacialFeatures != null && race.RacialFeatures.Count > 0
                ? $"Features: {string.Join(", ", race.RacialFeatures)}"
                : "Features: None";

            txtDescription.Text = !string.IsNullOrWhiteSpace(race.Description)
                ? race.Description
                : "No description available.";
        }




        // Property to build CharacterRace object for backend
        public CharacterRaceModel GetCharacterRace()
        {
            var selectedRace = cmbRace.SelectedItem as Step2RaceModel;

            return new CharacterRaceModel
            {
                RaceID = selectedRace?.RaceID ?? -1,
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

