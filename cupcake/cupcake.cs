using System;
using MetroFramework.Forms;

namespace cupcake
{
    public partial class cupcake : MetroForm
    {
        public cupcake()
        {
            InitializeComponent();
        }

        private void cupcake_Load(object sender, EventArgs e)
        {
            fullscreen full = new fullscreen();
            full.ShowDialog();
        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
