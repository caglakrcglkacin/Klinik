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
    public partial class RandevuSaatiEkle : Form
    {
        public RandevuSaatiEkle()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            RandevuSaatis ekle = new RandevuSaatis();
            ekle.RandevuSaati = txtbolum.Text;
            ekle.Secildimi = "False";
            Base<RandevuSaatis> ınsert = new Base<RandevuSaatis>();
            ınsert.Insert(ekle);
            this.Close();
        }
    }
}
