using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    public interface IsqlConnet
    {
        void Insert(string datatable, Dictionary<string, object> Veriler);
        void Delete(string datatable, int Id);
        void Update(string datatable, int Id, Dictionary<string, object> Veriler);
        DataTable GetIdValue(string dataname, int Id);
    }
}
