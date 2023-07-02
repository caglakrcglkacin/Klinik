using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    [DisplayName("tbl_rs")]
    public class RandevuSaatis
    {
        public  int Id { get; set; }    
        public string RandevuSaati { get; set; }
        public string Secildimi { get;set; }
    }
}
