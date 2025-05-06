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

            // Wrap Steps in a basic Form
            Form testForm = new Form
            {
                Text = "Test: Step 3",
                Width = 400,
                Height = 400
            };

            var step = new Step3();
            step.Dock = DockStyle.Fill;

            testForm.Controls.Add(step);
            Application.Run(testForm);
        }
    }
}