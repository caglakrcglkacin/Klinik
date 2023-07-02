using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisplayNameAttribute = System.ComponentModel.DisplayNameAttribute;


namespace Klinik
{
    [DisplayName("vw_rapor")]
    public class vw_Rapor
    {
        public int Id { get; set; }
        public string  HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public DateTime VerilmeTarihi { get; set; }
        public DateTime Baslangıctarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string VerilmeNedeni { get; set; }
        public string RaporSuresi { get; set; }
    }
}
