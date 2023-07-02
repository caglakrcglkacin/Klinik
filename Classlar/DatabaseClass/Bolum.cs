using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisplayNameAttribute = System.ComponentModel.DisplayNameAttribute;

namespace Klinik
{
    [DisplayName("tbl_bolum")]
    public class Bolums
    {
        public int Id { get; set; }
        public string Bolum { get; set; }
    }
}
