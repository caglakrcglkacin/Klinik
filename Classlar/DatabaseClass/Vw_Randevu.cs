using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    [DisplayName("vw_randevus")]
    public class Vw_Randevu
    {
        public int Id { get; set; }
        public string Bolum { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public string RandevuSaati { get; set; }

    }
}
