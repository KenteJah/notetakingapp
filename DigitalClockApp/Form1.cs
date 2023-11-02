namespace DigitalClockApp
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void greyButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Gray;
        }

        private void turqoiseButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Turquoise;
        }

        private void aquaButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Aqua;
        }

        private void violetButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Violet;
        }

        private void indigoButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Indigo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Gill Sans", 72, FontStyle.Bold);
        }

        private void styleButton2_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Palatino Linotype", 72, FontStyle.Bold);
        }

        private void styleButton3_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Goudy Old Style", 72, FontStyle.Bold);
        }
    }
}