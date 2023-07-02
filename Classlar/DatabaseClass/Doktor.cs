using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    [DisplayName("tbl_doktor")]
    public class Doktor
    {
        public int Id { get; set; }
        public int BölümId { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }
        public string DoktorTelefon { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
