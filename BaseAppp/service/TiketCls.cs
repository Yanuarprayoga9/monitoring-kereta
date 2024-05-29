using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BaseApp.config;


namespace BaseAppp.service
{
    internal class TiketCls
    {
        private string _id_prodi;
        private string _id_jurusan;
        private string _nama_prodi;
        DataTable data;

        ConnDB server;
        string Query;
        public int Id { get; set; }
        public string Nama { get; set; }
        public TiketCls()
        {

            server = new ConnDB();
            data = new DataTable();
            Query = "";
        }
        public DataTable getTicket()
        {
            Query = $"SELECT t.id_tiket, CONCAT(sa.kota_stasiun, '-', st.kota_stasiun) as kota, k.nama_kursi as kursi, k.tipe_kursi as tipe_kursi, k.harga_kursi as harga, CONCAT(t.awal_jam, '-', t.akhir_jam) as jam, t.tanggal as tanggal_keberangkatan FROM tiket t JOIN kursi k ON k.id_kursi = t.id_kursi JOIN kondektur kn ON kn.id_kondektur = t.id_kondektur JOIN kereta kr ON kr.id_kereta = t.id_kereta JOIN stasiun sa ON sa.id_stasiun = t.id_stasiun_awal JOIN stasiun st ON st.id_stasiun = t.id_stasiun_tujuan ";
            return server.execQuery(Query);
        }
        public DataTable getDetailTicket(string id)
        {
            Query = $"SELECT t.id_tiket, sa.kota_stasiun as kota_keberangkatan, st.kota_stasiun as kota_tujuan, k.nama_kursi as kursi, k.harga_kursi as harga, t.awal_jam as jam_keberangkatan, t.akhir_jam as jam_sampai, t.tanggal as tanggal_keberangkatan FROM tiket t JOIN kursi k ON k.id_kursi = t.id_kursi JOIN kondektur kn ON kn.id_kondektur = t.id_kondektur JOIN kereta kr ON kr.id_kereta = t.id_kereta JOIN stasiun sa ON sa.id_stasiun = t.id_stasiun_awal JOIN stasiun st ON st.id_stasiun = t.id_stasiun_tujuan WHERE t.id_tiket = '{id}';";
            return server.execQuery(Query);
        }

    }
}
