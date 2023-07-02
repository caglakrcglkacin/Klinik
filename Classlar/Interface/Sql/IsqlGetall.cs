using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    public interface IsqlGetall
    {
        DataTable Getall(string Datatabele);
        DataTable GetWach(string Datatable,int Id);
        DataTable GetPrint(string Datatable, int Id);
    }
}
