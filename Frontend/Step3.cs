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
    public partial class Step3 : UserControl
    {
        // Placeholder for Class → Subclass map
        private Dictionary<string, List<string>> classToSubclass = new();

        public Step3()
        {
            InitializeComponent();
            LoadClassData();
        }

        private void LoadClassData()
        {
            // Mock classes
            cmbClass.Items.AddRange(new object[] { "Fighter", "Wizard", "Cleric" });

            // Mock subclasses
            classToSubclass["Fighter"] = new List<string> { "Champion", "Battle Master", "Eldritch Knight" };
            classToSubclass["Wizard"] = new List<string> { "Evocation", "Illusion", "Necromancy" };
            classToSubclass["Cleric"] = new List<string> { "Life Domain", "War Domain", "Trickery Domain" };
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSubclass.Items.Clear();

            if (cmbClass.SelectedItem is string selectedClass &&
                classToSubclass.TryGetValue(selectedClass, out var subclasses))
            {
                cmbSubclass.Items.AddRange(subclasses.ToArray());
                if (cmbSubclass.Items.Count > 0)
                    cmbSubclass.SelectedIndex = 0;
            }
        }

        // Pull the selected IDs (for now using name indexes as stand-ins)
        public int SelectedClassID => cmbClass.SelectedIndex + 1;
        public int SelectedSubclassID => cmbSubclass.SelectedIndex + 1;
    }
}
