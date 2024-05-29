namespace BaseAppp.ui
{
    partial class DashboardUtama
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
            this.components = new System.ComponentModel.Container();
            this.navigasiadmin = new System.Windows.Forms.MenuStrip();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penggunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekapPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.greet_label = new System.Windows.Forms.Label();
            this.pilih_bulan = new System.Windows.Forms.DateTimePicker();
            this.tiket_gridview_dashboard = new System.Windows.Forms.DataGridView();
            this.id_tiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipe_kursi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_keberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navigasiadmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiket_gridview_dashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // navigasiadmin
            // 
            this.navigasiadmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navigasiadmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem,
            this.penggunaToolStripMenuItem,
            this.rekapPenjualanToolStripMenuItem});
            this.navigasiadmin.Location = new System.Drawing.Point(0, 0);
            this.navigasiadmin.Name = "navigasiadmin";
            this.navigasiadmin.Size = new System.Drawing.Size(1342, 28);
            this.navigasiadmin.TabIndex = 0;
            this.navigasiadmin.Text = "menuStrip1";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.ticketToolStripMenuItem.Text = "ticket";
            // 
            // penggunaToolStripMenuItem
            // 
            this.penggunaToolStripMenuItem.Name = "penggunaToolStripMenuItem";
            this.penggunaToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.penggunaToolStripMenuItem.Text = "pengguna";
            // 
            // rekapPenjualanToolStripMenuItem
            // 
            this.rekapPenjualanToolStripMenuItem.Name = "rekapPenjualanToolStripMenuItem";
            this.rekapPenjualanToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.rekapPenjualanToolStripMenuItem.Text = "rekap penjualan";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Location = new System.Drawing.Point(12, 46);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(41, 16);
            this.greet_label.TabIndex = 2;
            this.greet_label.Text = "nama";
            // 
            // pilih_bulan
            // 
            this.pilih_bulan.Location = new System.Drawing.Point(880, 217);
            this.pilih_bulan.Name = "pilih_bulan";
            this.pilih_bulan.Size = new System.Drawing.Size(200, 22);
            this.pilih_bulan.TabIndex = 3;
            // 
            // tiket_gridview_dashboard
            // 
            this.tiket_gridview_dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tiket_gridview_dashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tiket,
            this.kota,
            this.kursi,
            this.tipe_kursi,
            this.harga,
            this.jam,
            this.tanggal_keberangkatan});
            this.tiket_gridview_dashboard.Location = new System.Drawing.Point(15, 258);
            this.tiket_gridview_dashboard.Name = "tiket_gridview_dashboard";
            this.tiket_gridview_dashboard.RowHeadersWidth = 51;
            this.tiket_gridview_dashboard.RowTemplate.Height = 24;
            this.tiket_gridview_dashboard.Size = new System.Drawing.Size(1272, 150);
            this.tiket_gridview_dashboard.TabIndex = 4;
            this.tiket_gridview_dashboard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tiket_gridview_dashboard_CellClick);
            // 
            // id_tiket
            // 
            this.id_tiket.DataPropertyName = "id_tiket";
            this.id_tiket.HeaderText = "Kode Tiket";
            this.id_tiket.MinimumWidth = 6;
            this.id_tiket.Name = "id_tiket";
            this.id_tiket.Width = 125;
            // 
            // kota
            // 
            this.kota.DataPropertyName = "kota";
            this.kota.HeaderText = "Kota Keberangkatan";
            this.kota.MinimumWidth = 6;
            this.kota.Name = "kota";
            this.kota.Width = 125;
            // 
            // kursi
            // 
            this.kursi.DataPropertyName = "kursi";
            this.kursi.HeaderText = "Kursi";
            this.kursi.MinimumWidth = 6;
            this.kursi.Name = "kursi";
            this.kursi.Width = 125;
            // 
            // tipe_kursi
            // 
            this.tipe_kursi.DataPropertyName = "tipe_kursi";
            this.tipe_kursi.HeaderText = "Tipe";
            this.tipe_kursi.MinimumWidth = 6;
            this.tipe_kursi.Name = "tipe_kursi";
            this.tipe_kursi.Width = 125;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 125;
            // 
            // jam
            // 
            this.jam.DataPropertyName = "jam";
            this.jam.HeaderText = "Jam";
            this.jam.MinimumWidth = 6;
            this.jam.Name = "jam";
            this.jam.Width = 125;
            // 
            // tanggal_keberangkatan
            // 
            this.tanggal_keberangkatan.DataPropertyName = "tanggal_keberangkatan";
            this.tanggal_keberangkatan.HeaderText = "Tgl Keberangkatan";
            this.tanggal_keberangkatan.MinimumWidth = 6;
            this.tanggal_keberangkatan.Name = "tanggal_keberangkatan";
            this.tanggal_keberangkatan.Width = 125;
            // 
            // DashboardUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 450);
            this.Controls.Add(this.tiket_gridview_dashboard);
            this.Controls.Add(this.pilih_bulan);
            this.Controls.Add(this.greet_label);
            this.Controls.Add(this.navigasiadmin);
            this.MainMenuStrip = this.navigasiadmin;
            this.Name = "DashboardUtama";
            this.Text = "DashboardUtama";
            this.Load += new System.EventHandler(this.DashboardUtama_Load);
            this.navigasiadmin.ResumeLayout(false);
            this.navigasiadmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiket_gridview_dashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navigasiadmin;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penggunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rekapPenjualanToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.DateTimePicker pilih_bulan;
        private System.Windows.Forms.DataGridView tiket_gridview_dashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn kursi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipe_kursi;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_keberangkatan;
    }
}