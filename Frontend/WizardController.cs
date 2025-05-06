using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public class WizardController
    {
        private readonly List<UserControl> steps = new();
        private readonly Control container;
        private int currentStepIndex = 0;

        public WizardController(Control hostContainer)
        {
            container = hostContainer ?? throw new ArgumentNullException(nameof(hostContainer));
            InitializeSteps();
            ShowStep(currentStepIndex);
        }

        private void InitializeSteps()
        {
            // Having steps here in order
            steps.Add(new Step1());
            steps.Add(new Step2());
            steps.Add(new Step3());
        }

        public void NextStep()
        {
            if (currentStepIndex < steps.Count - 1)
            {
                currentStepIndex++;
                ShowStep(currentStepIndex);
            }
        }

        public void PreviousStep()
        {
            if (currentStepIndex > 0)
            {
                currentStepIndex--;
                ShowStep(currentStepIndex);
            }
        }

        private void ShowStep(int index)
        {
            container.Controls.Clear();
            var step = steps[index];
            step.Dock = DockStyle.Fill;
            container.Controls.Add(step);
        }

        // We can expose the current step if needed later
        public UserControl CurrentStep => steps[currentStepIndex];
        public int StepCount => steps.Count;
        public int CurrentIndex => currentStepIndex;
    }
}
