using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinik
{
    public partial class RandevuListele : Form
    {
        public RandevuListele()
        {
            InitializeComponent();
        }

        private void RandevuListele_Load(object sender, EventArgs e)
        {
            BaseGetall<Vw_Randevu> Nt = new BaseGetall<Vw_Randevu>();
            gridControl1.DataSource = Nt.Getall();
        }
    }
}
