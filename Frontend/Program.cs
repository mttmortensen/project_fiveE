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
                Text = "Test: Step 1",
                Width = 400,
                Height = 400
            };

            var step1 = new Step1();
            step1.Dock = DockStyle.Fill;

            testForm.Controls.Add(step1);
            Application.Run(testForm);
        }
    }
}