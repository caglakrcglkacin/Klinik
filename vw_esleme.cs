using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisplayNameAttribute = System.ComponentModel.DisplayNameAttribute;


namespace Klinik
{
    [DisplayName("vw_esle")]
    public class vw_esleme
    {
        public int Id { get; set; }
        public string Bolum { get; set; }
        public string DoktorAdi { get; set; }
        public string RandevuSaati { get; set; }
        public bool RandevusuVarmi { get; set; }
        public DateTime Tarih { get; set; }

    }
}
