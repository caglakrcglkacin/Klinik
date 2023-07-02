using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    public class BaseGetall<T> : IbaseGetall<T> where T : new()
    {
        public List<T> Getall()
        {
            Ortak<T> getir = new Ortak<T>();
            string tableName = getir.GetTableName();

            List<T> vaLue = new List<T>();
            SqlInsertGetAll sql = new SqlInsertGetAll();
            DataTable data = sql.Getall(tableName);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                T veri = getir.DataGetir(dr);
                vaLue.Add(veri);
            }
            return vaLue;
        }

        public List<T> GetPrint(int Id)
        {
            Ortak<T> getir = new Ortak<T>();
            string tablename = getir.GetTableName();
            SqlInsertGetAll sql = new SqlInsertGetAll();
            System.Data.DataTable data = sql.GetPrint(tablename, Id);
            List<T> Veri = new List<T>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                T re = getir.DataGetir(dr);
                Veri.Add(re);

            }
            return Veri;
        }

        public List<T> GetWatch(int Id)
        {
            Ortak<T> getir = new Ortak<T>();
            string tablename = getir.GetTableName();
            SqlInsertGetAll sql = new SqlInsertGetAll();
            System.Data.DataTable data = sql.GetWach(tablename,Id);
            List<T> Veri = new List<T>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                T re = getir.DataGetir(dr);
                Veri.Add(re);

            }
            return Veri;
        }
    }
}
