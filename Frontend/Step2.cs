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
    public partial class Step2 : Form
    {
        public Step2()
        {
            InitializeComponent();
        }
        private void cmbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder logic
            lblDarkvision.Text = "Darkvision: [API DATA]";
            lblProficiencies.Text = "Proficiencies: [API DATA]";
            lblBonuses.Text = "Bonuses: [API DATA]";
        }

    }
}
