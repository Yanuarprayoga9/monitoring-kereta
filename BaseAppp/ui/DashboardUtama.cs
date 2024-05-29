using BaseApp.service;
using BaseAppp.service;
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
    public partial class DashboardUtama : Form
    {
        PenggunaCls user = new PenggunaCls();
        TiketCls tiket = new TiketCls();
        public DashboardUtama()
        {
            InitializeComponent();
        }

        void viewGrid()
        {
         
                tiket_gridview_dashboard.DataSource = tiket.getTicket();
            
            
        }
        private void DashboardUtama_Load(object sender, EventArgs e)
        {
            greet_label.Text = "Halo, Selamat Datang "+Login.Instance.usernameGlobal.Text;
            if (!user.apakahAdmin(Login.Instance.usernameGlobal.Text))
            {
                navigasiadmin.Visible = false;
                MessageBox.Show("Anda bukan admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pilih_bulan.Format = DateTimePickerFormat.Custom;
            pilih_bulan.CustomFormat = "MM/yyyy";
            pilih_bulan.ShowUpDown = true;
            viewGrid();
        }

        private void tiket_gridview_dashboard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.tiket_gridview_dashboard.Rows[e.RowIndex];
                string kirimDetailTiket =  baris.Cells[0].Value.ToString();
                DetailTiket detailTiket = new DetailTiket(kirimDetailTiket);
                detailTiket.Show();


            }

        }
    }
}
