namespace Frontend
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form testForm = new Form
            {
                Text = "D&D Character Creator",
                Width = 400,
                Height = 450
            };

            Panel container = new Panel
            {
                Dock = DockStyle.Fill
            };

            Button btnNext = new Button
            {
                Text = "Next",
                Dock = DockStyle.Bottom
            };

            Button btnBack = new Button
            {
                Text = "Back",
                Dock = DockStyle.Bottom
            };

            testForm.Controls.Add(container);
            testForm.Controls.Add(btnNext);
            testForm.Controls.Add(btnBack);

            var wizard = new WizardController(container);

            btnNext.Click += (s, e) => wizard.NextStep();
            btnBack.Click += (s, e) => wizard.PreviousStep();

            Application.Run(testForm);

        }
    }
}