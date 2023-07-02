using DevExpress.Xpo;
using DevExpress.XtraSpreadsheet.Import.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisplayNameAttribute = System.ComponentModel.DisplayNameAttribute;

namespace Klinik
{
    [DisplayName("tbl_esle")]
    public class Eslesme
    {
        public int Id { get; set; }
        public int SaatId { get; set; }
        public int DoktorId { get; set; }   
        public int BolumId { get; set; }    
        public bool RandevusuVarmi { get; set; }
        public DateTime Tarih { get; set; }
    }
}
