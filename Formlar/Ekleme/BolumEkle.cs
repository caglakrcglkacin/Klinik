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
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            Bolums ekle = new Bolums();
            ekle.Bolum = txtbolum.Text;
            Base<Bolums> ınsert = new Base<Bolums>();
            ınsert.Insert(ekle);
            this.Close();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
