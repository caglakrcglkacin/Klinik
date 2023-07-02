using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    public class SqlInsert : IsqlConnet
    {
        SqlCommand cmd;
        public SqlInsert()
        {

            cmd = new SqlCommand();

        }
        public void Delete(string datatable, int Id)
        {
            sqlconnet sql = new sqlconnet();
            string Data = $"DELETE {datatable} WHERE Id = {Id}";
            var cmd = sql.GetSqlCommand(Data);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public DataTable GetIdValue(string dataname, int Id)
        {
            sqlconnet sql = new sqlconnet();
            string Data = $"SELECT * FROM {dataname} WHERE Id={Id}";
            var cmd = sql.GetSqlCommand(Data);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            return dt;
        }

        public void Insert(string datatable, Dictionary<string, object> Veriler)
        {
            sqlconnet connet = new sqlconnet();
            var Data = connet.GetSqlCommand("");
            string Komut = "INSERT INTO {0} ({1}) Values ({2}) ";
            string sutun = "";
            string Sutunparametre = "";
            foreach (var item in Veriler)
            {
                sutun += item.Key + ",";
                Sutunparametre += "@" + item.Key + ",";
                Data.Parameters.AddWithValue("@" + item.Key, item.Value);

            }
            sutun = sutun.TrimEnd(',');
            Sutunparametre = Sutunparametre.TrimEnd(',');
            Komut = String.Format(Komut, datatable, sutun, Sutunparametre);

            Data.CommandText = Komut;
            Data.ExecuteNonQuery();
            Data.Connection.Close();
            Data.Dispose();
        }

        public void Update(string datatable, int Id, Dictionary<string, object> Veriler)
        {
            sqlconnet sql = new sqlconnet();
            var Data = sql.GetSqlCommand("");
            string Komut = "UPDATE {0} SET {1} WHERE Id = {2}";
            string sutun = "";

            foreach (var item in Veriler)
            {
                sutun += item.Key + " = " + "@" + item.Key + ",";
                Data.Parameters.AddWithValue("@" + item.Key, item.Value);

            }
            sutun = sutun.TrimEnd(',');
            Komut = String.Format(Komut, datatable, sutun, Id);
            Data.CommandText = Komut;
            Data.ExecuteNonQuery();
            Data.Connection.Close();
            Data.Dispose();
        }
    }
}
