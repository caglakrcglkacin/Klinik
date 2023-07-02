using DevExpress.ExpressApp.Reports.Win;
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
    public partial class Doktor_Ekle : Form
    {
        public Doktor_Ekle()
        {
            InitializeComponent();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            Doktor ekle = new Doktor();
            ekle.DoktorAdi = txtadi.Text;
            ekle.DoktorSoyadi = txtsoyadi.Text;
            ekle.DoktorTelefon = txttelefon.Text;
            ekle.DogumTarihi = dtdogum.DateTime;
            var bolum = cmbbolum.SelectedItem.ToString();
            BaseGetall<Bolums> goster = new BaseGetall<Bolums>();
            var dt = goster.Getall();
            foreach (var item in dt)
            {
                var deger = item.Bolum;
                if (deger == bolum)
                {
                    ekle.BölümId = item.Id;
                }
                
            }
           Base<Doktor> doktor = new Base<Doktor>();
            doktor.Insert(ekle);
            this.Close();
        }

        private void Doktor_Ekle_Load(object sender, EventArgs e)
        {
            BaseGetall<Bolums> goster = new BaseGetall<Bolums>();
            var dt = goster.Getall();
            foreach (var item in dt)
            {
                cmbbolum.Properties.Items.Add(item.Bolum);
            }
        }
    }
}
