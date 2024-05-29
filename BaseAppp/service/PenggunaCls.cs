using BaseApp.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaseApp.service
{
    internal class PenggunaCls
    {
        DataTable data;

        ConnDB server;
        string Query;



        public PenggunaCls()
        {
            
            server = new ConnDB();
            data = new DataTable();
            Query = "";
        }

        public bool login(string uid,string pwd)
        {
            bool cek = false;
            Query = $"select * from pengguna where username='{uid}' AND password ='{pwd}'";
            data = server.execQuery(Query);
            if (data.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;

        }

        public bool apakahAdmin(string uid)
        {
            bool cek = false;
            Query = $"select * from pengguna where username='{uid}' AND role='admin'";
            data = server.execQuery(Query);
            if (data.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;

        }

    }
}
