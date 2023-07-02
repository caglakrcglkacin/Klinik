using DevExpress.DashboardCommon.Native;
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
    public class SqlInsertGetAll : IsqlGetall
    {
        SqlCommand cmd;
        public SqlInsertGetAll()
        {

            cmd = new SqlCommand();

        }
        public DataTable Getall(string Datatabele)
        {
            sqlconnet connet = new sqlconnet();

            string sql = $"SELECT * FROM {Datatabele}";
            var cmd = connet.GetSqlCommand(sql);

            SqlDataReader dr = cmd.ExecuteReader();

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);

            return dt;
        }

        public DataTable GetPrint(string Datatable, int Id)
        {
            sqlconnet sql = new sqlconnet();
            string Data = $"SELECT * FROM {Datatable} WHERE Id={Id}";
            var cmd = sql.GetSqlCommand(Data);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            return dt;
        }

        public DataTable GetWach(string Datatable,int Id)
        {
            sqlconnet connet = new sqlconnet();

            string sql = $"SELECT * FROM {Datatable} where RandevusuVarmi = {Id} ";
            var cmd = connet.GetSqlCommand(sql);

            SqlDataReader dr = cmd.ExecuteReader();

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);

            return dt;
        }
    }
}
