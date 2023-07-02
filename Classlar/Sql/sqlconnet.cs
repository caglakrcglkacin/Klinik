using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    public class sqlconnet
    {
        public SqlConnection sql()
        {
            string BaglantiAdresi = "Server=.;Database=Klinik;User Id=cgl;Password=cagla77441100;";
            SqlConnection con = new SqlConnection(BaglantiAdresi);
            con.Open();
            return con;

        }
        public SqlCommand GetSqlCommand(string data)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = data;
            cmd.Connection = sql();

            return cmd;

        }
    }
}
