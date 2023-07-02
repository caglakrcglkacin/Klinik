using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DisplayNameAttribute = System.ComponentModel.DisplayNameAttribute;
using System.Threading.Tasks;

namespace Klinik
{
    [DisplayName("tbl_rapor")]
    public class Rapor
    {
        public int Id { get; set; }
        public int HastaId { get; set; }
        public DateTime VerilmeTarihi { get; set; }
        public DateTime Baslangıctarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public string VerilmeNedeni { get; set; }
        public string RaporSuresi { get; set; }
           

    }
}
