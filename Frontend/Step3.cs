using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Step3 : UserControl
    {
        private List<Step3ClassModel> classList = new();
        private List<Step3SubclassModel> subclassList = new();


        public Step3()
        {
            InitializeComponent();
            LoadClassDataFromApi();
        }

        private async void LoadClassDataFromApi()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync("http://localhost:5000/classes");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                classList = JsonSerializer.Deserialize<List<Step3ClassModel>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                cmbClass.DataSource = classList;
                cmbClass.DisplayMember = "ClassName";
                cmbClass.ValueMember = "ClassID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes:\n" + ex.Message);
            }
        }

        private async void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedItem is Step3ClassModel selected)
            {
                lblHitDie.Text = $"Hit Die: {selected.HitDie}";
                lblPrimaryAbility.Text = $"Primary Ability: {selected.PrimaryAbility}";
                lblSavingThrows.Text = selected.SavingThrows != null
                    ? $"Saving Throws: {string.Join(", ", selected.SavingThrows)}"
                    : "Saving Throws: None";

                lblFeatures.Text = selected.ClassFeatures != null
                    ? $"Features: {string.Join(", ", selected.ClassFeatures)}"
                    : "Features: None";

                txtClassDescription.Text = !string.IsNullOrWhiteSpace(selected.Descriptions)
                    ? selected.Descriptions
                    : "No description available.";

                await LoadSubclassesForClass(selected.ClassID);
            }
        }

        private async Task LoadSubclassesForClass(int classId)
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync($"http://localhost:5000/subclasses?classId={classId}");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                subclassList = JsonSerializer.Deserialize<List<Step3SubclassModel>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                cmbSubclass.DataSource = subclassList;
                cmbSubclass.DisplayMember = "SubclassName";
                cmbSubclass.ValueMember = "SubclassID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subclasses:\n" + ex.Message);
            }
        }

        private void cmbSubclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubclass.SelectedItem is Step3SubclassModel selected)
            {
                lblEntryLevel.Text = $"Entry Level: {selected.EntryLevel}";
                lblSubclassFeatures.Text = selected.SubclassFeatures != null
                    ? $"Features: {string.Join(", ", selected.SubclassFeatures)}"
                    : "Features: None";

                txtSubclassDescription.Text = !string.IsNullOrWhiteSpace(selected.Descriptions)
                    ? selected.Descriptions
                    : "No description available.";

                // MOCK Bonus Options for now (until backend sends options?)
                lstBonusProficiencies.Items.Clear();
                lstBonusProficiencies.Items.AddRange(new object[] { "Arcana", "Stealth", "Athletics" });

                lstBonusSpells.Items.Clear();
                lstBonusSpells.Items.AddRange(new object[] { "Shield", "Mage Armor", "Detect Magic" });
            }
        }



        // Using for POST later
        public int SelectedClassID =>
            cmbClass.SelectedItem is Step3ClassModel selected ? selected.ClassID : -1;

        public int SelectedSubclassID =>
            cmbSubclass.SelectedItem is Step3SubclassModel selected ? selected.SubclassID : -1;

    }
}
