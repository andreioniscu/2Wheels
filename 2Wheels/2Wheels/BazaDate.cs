using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Wheels
{
    public class BazaDate
    {
        private NpgsqlConnection conn;
        public BazaDate(string ip, string port, string database, string user, string password)
        {
            this.conn = new NpgsqlConnection("Host="+ip+";Username="+user+";Password="+password+";Database="+database);
        }
        public void connect()
        {
            this.conn.Open();
        }
        public NpgsqlConnection getConexiune()
        {
            return this.conn;
        }
        public void execNonQuery(string sql)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conn);
            cmd.ExecuteNonQuery();
        }
        public string returnString(string sql)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conn);
            string retur = cmd.ExecuteScalar().ToString().Trim();
            return retur;
        }

        public double returnDouble(string sql)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conn);
            string retur = cmd.ExecuteScalar().ToString().Trim();
            return double.Parse(retur);
        }
        public DateTime returnDateTime(string sql)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conn);
            string retur = cmd.ExecuteScalar().ToString().Trim();
            return DateTime.Parse(retur);
        }

        public DataTable returnDataTable(string sql)
        {
            NpgsqlCommand cmd = new NpgsqlCommand( sql, this.conn);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);
            DataTable retur = new DataTable();
            dataAdapter.Fill(retur);
            return retur;
        }
    }
}
