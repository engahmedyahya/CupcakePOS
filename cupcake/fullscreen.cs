using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace cupcake
{
    public partial class fullscreen : MetroForm
    {
        public fullscreen()
        {
            InitializeComponent();
        }

        private void fullscreen_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            cupcake main = (cupcake)Application.OpenForms["cupcake"];
            main.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
