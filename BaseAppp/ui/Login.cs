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
    using BaseApp.service;
    public partial class Login : Form
    {
        PenggunaCls user = new PenggunaCls();
        public static Login Instance;

        public TextBox usernameGlobal; 
        public Login()
        {
            InitializeComponent();
            Instance = this;
            usernameGlobal = user_name_text;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(user.login(user_name_text.Text,password_text.Text)) {
            
            DashboardUtama dashboardUtama = new DashboardUtama();
                this.Hide();
                dashboardUtama.Show();
            }else
            {
                MessageBox.Show("Username atau Password Salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                user_name_text.SelectAll();
                user_name_text.Focus();

            }
        }

        private void login_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                
                login_btn.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin akan keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            login_btn.KeyPress += login_btn_KeyPress;

        }
    }
}
