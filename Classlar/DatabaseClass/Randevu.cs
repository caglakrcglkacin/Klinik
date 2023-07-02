using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    [DisplayName("tbl_randevu")]
    public class Randevu
    {
        public int Id { get; set; }
        public int BolumId { get; set; }
        public int DoktorId { get; set; }
        public int HastaId { get; set; }
        public int RandevuSaatId { get; set; } 
        public bool RandevuGeldimi { get; set; }    
        public DateTime OlusturmaTarihi { get; set; }   
        public DateTime Randevutarihi { get; set; }
        
    }
}
