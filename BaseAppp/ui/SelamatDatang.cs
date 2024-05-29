using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseAppp.ui
{
    public partial class SelamatDatang : Form
    {
        public SelamatDatang()
        {
            InitializeComponent();
        }

        private void lanjutkan_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
