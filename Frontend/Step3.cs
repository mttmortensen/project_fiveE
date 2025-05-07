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

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
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
            }
        }

        public int SelectedClassID =>
            cmbClass.SelectedItem is Step3ClassModel selected ? selected.ClassID : -1;
    }
}
