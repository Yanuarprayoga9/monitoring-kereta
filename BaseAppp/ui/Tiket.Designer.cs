namespace BaseAppp.ui
{
    partial class Tiket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tiket_gridview_dashboard = new System.Windows.Forms.DataGridView();
            this.id_tiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota_keberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota_tujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam_keberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam_sampai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_keberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilih_bulan = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tiket_gridview_dashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // tiket_gridview_dashboard
            // 
            this.tiket_gridview_dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tiket_gridview_dashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tiket,
            this.kota_keberangkatan,
            this.kota_tujuan,
            this.kursi,
            this.harga,
            this.jam_keberangkatan,
            this.jam_sampai,
            this.tanggal_keberangkatan});
            this.tiket_gridview_dashboard.Location = new System.Drawing.Point(-148, 171);
            this.tiket_gridview_dashboard.Name = "tiket_gridview_dashboard";
            this.tiket_gridview_dashboard.RowHeadersWidth = 51;
            this.tiket_gridview_dashboard.RowTemplate.Height = 24;
            this.tiket_gridview_dashboard.Size = new System.Drawing.Size(1096, 150);
            this.tiket_gridview_dashboard.TabIndex = 6;
            // 
            // id_tiket
            // 
            this.id_tiket.DataPropertyName = "id_tiket";
            this.id_tiket.HeaderText = "Kode Tiket";
            this.id_tiket.MinimumWidth = 6;
            this.id_tiket.Name = "id_tiket";
            this.id_tiket.Width = 125;
            // 
            // kota_keberangkatan
            // 
            this.kota_keberangkatan.DataPropertyName = "kota_keberangkatan";
            this.kota_keberangkatan.HeaderText = "Kota Keberangkatan";
            this.kota_keberangkatan.MinimumWidth = 6;
            this.kota_keberangkatan.Name = "kota_keberangkatan";
            this.kota_keberangkatan.Width = 125;
            // 
            // kota_tujuan
            // 
            this.kota_tujuan.DataPropertyName = "kota_tujuan";
            this.kota_tujuan.HeaderText = "Kota Tujuan";
            this.kota_tujuan.MinimumWidth = 6;
            this.kota_tujuan.Name = "kota_tujuan";
            this.kota_tujuan.Width = 125;
            // 
            // kursi
            // 
            this.kursi.DataPropertyName = "kursi";
            this.kursi.HeaderText = "Kursi";
            this.kursi.MinimumWidth = 6;
            this.kursi.Name = "kursi";
            this.kursi.Width = 125;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 125;
            // 
            // jam_keberangkatan
            // 
            this.jam_keberangkatan.DataPropertyName = "jam_keberangkatan";
            this.jam_keberangkatan.HeaderText = "Jam Keberangkatan";
            this.jam_keberangkatan.MinimumWidth = 6;
            this.jam_keberangkatan.Name = "jam_keberangkatan";
            this.jam_keberangkatan.Width = 125;
            // 
            // jam_sampai
            // 
            this.jam_sampai.DataPropertyName = "jam_sampai";
            this.jam_sampai.HeaderText = "Jam Sampai";
            this.jam_sampai.MinimumWidth = 6;
            this.jam_sampai.Name = "jam_sampai";
            this.jam_sampai.Width = 125;
            // 
            // tanggal_keberangkatan
            // 
            this.tanggal_keberangkatan.DataPropertyName = "tanggal_keberangkatan";
            this.tanggal_keberangkatan.HeaderText = "Tgl Keberangkatan";
            this.tanggal_keberangkatan.MinimumWidth = 6;
            this.tanggal_keberangkatan.Name = "tanggal_keberangkatan";
            this.tanggal_keberangkatan.Width = 125;
            // 
            // pilih_bulan
            // 
            this.pilih_bulan.Location = new System.Drawing.Point(717, 130);
            this.pilih_bulan.Name = "pilih_bulan";
            this.pilih_bulan.Size = new System.Drawing.Size(200, 22);
            this.pilih_bulan.TabIndex = 5;
            // 
            // Tiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.tiket_gridview_dashboard);
            this.Controls.Add(this.pilih_bulan);
            this.Name = "Tiket";
            this.Text = "Tiket";
            this.Load += new System.EventHandler(this.Tiket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiket_gridview_dashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tiket_gridview_dashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota_keberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota_tujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kursi;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam_keberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam_sampai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_keberangkatan;
        private System.Windows.Forms.DateTimePicker pilih_bulan;
    }
}