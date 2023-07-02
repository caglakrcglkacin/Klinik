using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    public class Ortak<T> where T : new()
    {
        public Dictionary<string, object> Veri(T data)
        {
            Dictionary<string, object> keys = new Dictionary<string, object>();
            var isim = typeof(T);
            var dizi = isim.GetProperties();
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i].Name != "Id")
                {
                    keys.Add(dizi[i].Name, dizi[i].GetValue(data, null));
                }
            }
            return keys;
        }
        public T DataGetir(DataRow satir)
        {
            var isim = typeof(T);
            var dizi = isim.GetProperties();
            T veris = new T();

            for (int j = 0; j < satir.Table.Columns.Count; j++)
            {
                DataColumn sutun = satir.Table.Columns[j];
                object data = satir[sutun];
                isim.GetProperty(sutun.ColumnName).SetValue(veris, data);
            }
            return veris;
        }
        public string GetTableName()
        {
            var isim = typeof(T);
            string tableName = "";
            var ozellik = isim.GetCustomAttributes(typeof(DisplayNameAttribute), true);
            if (ozellik[0] is DisplayNameAttribute)
            {
                tableName = ((DisplayNameAttribute)ozellik[0]).DisplayName;
            }
            return tableName;
        }

    }
}
