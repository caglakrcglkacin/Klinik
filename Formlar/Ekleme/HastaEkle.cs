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
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            Hasta ekle = new Hasta();
            ekle.HastaAdi = txthastaadi.Text;
            ekle.HastaSoyadi = txtsoyadi.Text;
            ekle.HastaTelefon = txttelefon.Text;
            ekle.DoğumTarihi = dtdogum.DateTime;
            Base<Hasta> ınsert = new Base<Hasta>();
            ınsert.Insert(ekle);
            this.Close();
        }
    }
}
