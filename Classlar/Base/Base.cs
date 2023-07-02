using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    public class Base<T> : Ibase<T> where T : new()
    {
        public void Delete(int Id)
        {
            Ortak<T> getir = new Ortak<T>();
            string tablename = getir.GetTableName();
            SqlInsert sql = new SqlInsert();
            sql.Delete(tablename, Id);
        }

        public T GetAll(int Id)
        {
            Ortak<T> getir = new Ortak<T>();
            string tablename = getir.GetTableName();
            SqlInsert sql = new SqlInsert();
            System.Data.DataTable data = sql.GetIdValue(tablename, Id);
            T Veri = new T();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Veri = getir.DataGetir(data.Rows[i]);
            }
            return Veri;
        }

        public void Insert(T data)
        {
            Ortak<T> getir = new Ortak<T>();
            string tablename = getir.GetTableName();
            Dictionary<string, object> dict = getir.Veri(data);
            SqlInsert sql = new SqlInsert();
            sql.Insert(tablename, dict);
        }

        public void Update(T data, int Id)
        {
            Ortak<T> getir = new Ortak<T>();
            string tablename = getir.GetTableName();
            Dictionary<string, object> dict = getir.Veri(data);
            SqlInsert sql = new SqlInsert();
            sql.Update(tablename, Id, dict);
        }
    }
}
