namespace Frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += ScreenForm_Load;
        }

        private void ScreenForm_Load(object sender, EventArgs e)
        {
            // Get the screen where the form is displayed
            Screen screen = Screen.FromControl(this);

            // Calculate the size as a percentage of the screen's working area
            float widthPercentage = 0.8f; // 80% of screen width
            float heightPercentage = 0.8f; // 80% of screen height

            int width = (int)(screen.WorkingArea.Width * widthPercentage);
            int height = (int)(screen.WorkingArea.Height * heightPercentage);

            // Set the form size
            this.Size = new Size(width, height);

            // Optionally center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
