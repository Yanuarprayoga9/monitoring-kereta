using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseAppp.ui
{
    public partial class SplashScreen : Form
    {
        int counter;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
            {
                timer1.Enabled = false;
                SelamatDatang greet = new SelamatDatang();
                greet.Show();
                this.Hide();
            }

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
