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
    public partial class DetailTiket : Form
    {
        public string kodetiket = "";
        TiketCls tiket = new TiketCls();
        public DetailTiket(string kodeTiket)
        {
            InitializeComponent();
            kodetiket = kodeTiket;
        }

        private void DetailTiket_Load(object sender, EventArgs e)
        {
            DataTable detailTiket = tiket.getDetailTicket(kodetiket);


            // Pastikan hasil query tidak null dan memiliki setidaknya satu baris
            if (detailTiket != null && detailTiket.Rows.Count > 0)
            {
                DataRow row = detailTiket.Rows[0]; // Hanya mengambil baris pertama (asumsi hanya satu hasil)

                // Menampilkan detail tiket dalam label-label
                labelKotaKeberangkatan.Text = row["kota_keberangkatan"].ToString();
            }else
            {
                labelKotaKeberangkatan.Text = "data tidak ditemukan";

            }
        }
    }
}
