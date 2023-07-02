using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    [DisplayName("tbl_hasta")]
    public class Hasta
    {
        public int Id { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public string HastaTelefon { get; set; }
        public DateTime DoğumTarihi { get; set; }

    }
}
