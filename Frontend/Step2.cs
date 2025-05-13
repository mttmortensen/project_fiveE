using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load races:\n" + ex.Message);
            }

            cmbRace.SelectedIndexChanged += CmbRace_SelectedIndexChanged;
        }

        private void CmbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRace.SelectedItem is Step2RaceModel selectedRace)
            {
                ShowRaceDetails(selectedRace);
                LoadRaceOptions(selectedRace.RaceID);
            }
        }

        private void ShowRaceDetails(Step2RaceModel race)
        {
            lblSize.Text = $"Size: {race.RaceSize}";
            lblSpeed.Text = $"Speed: {race.RaceSpeed} ft";
            lblCreatureType.Text = $"Type: {string.Join(", ", race.RaceCreatureType)}";
            lblDarkvision.Text = $"Darkvision: {race.DarkVision}";
            lblDescription.Text = $"Description: {race.Description}";
        }

        private async void LoadRaceOptions(int raceId)
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync($"http://localhost:5000/character-race-options?raceId={raceId}");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var options = JsonSerializer.Deserialize<List<CharacterRaceOptionsModel>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })?.FirstOrDefault();

                if (options != null)
                {
                    lstTraits.Items.Clear();
                    foreach (var trait in options.AvailableTraits)
                        lstTraits.Items.Add(trait);

                    lstLanguages.Items.Clear();
                    foreach (var lang in options.AvailableLanguages)
                        lstLanguages.Items.Add(lang);

                    lstProficiencies.Items.Clear();
                    foreach (var prof in options.AvailableProficiencies)
                        lstProficiencies.Items.Add(prof);

                    cmbBonusStat1.Items.Clear();
                    cmbBonusStat2.Items.Clear();

                    if (options.AvailableAbilityScoreBonuses != null)
                    {
                        foreach (var stat in options.AvailableAbilityScoreBonuses)
                        {
                            cmbBonusStat1.Items.Add(stat);
                            cmbBonusStat2.Items.Add(stat);
                        }
                    }

                    cmbBonusStat1.SelectedIndex = -1;
                    cmbBonusStat2.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load race options:\n" + ex.Message);
            }
        }

    }

    public class Step2RaceModel
    {
        public int RaceID { get; set; }
        public string RaceName { get; set; }
        public string RaceSize { get; set; }
        public int RaceSpeed { get; set; }
        public string Description { get; set; }
        public string RaceCreatureType { get; set; }
        public int DarkVision { get; set; }
    }

    public class CharacterRaceOptionsModel
    {
        public int CharRaceID { get; set; }
        public int RaceID { get; set; }
        public List<string> AvailableTraits { get; set; }
        public List<string> AvailableLanguages { get; set; }
        public List<string> AvailableProficiencies { get; set; }
        public List<string> AvailableAbilityScoreBonuses { get; set; }
    }
}