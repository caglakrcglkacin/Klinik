using DevExpress.Web.ASPxHtmlEditor.Internal;
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
    public partial class Esles : Form
    {
        public Esles()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            BaseGetall<Doktor> doktor = new BaseGetall<Doktor>();
            var ds = doktor.Getall();
            foreach (var item in ds)
            {
                
               cmbdoktor.Properties.Items.Add(item.DoktorAdi);

            }
            BaseGetall<RandevuSaatis> saat = new BaseGetall<RandevuSaatis>();
            gridControl1.DataSource = saat.Getall();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (cmbdoktor.SelectedItem.ToString() == null)
                return;
            if (dttarih.DateTime.ToString() == null)
                return;
            if (gridView1.SelectedRowsCount < 1)
                return;
            DialogResult mesaj = MessageBox.Show(dttarih.DateTime+"Eklemek İstediğiniz Gün Ve Saat Eklemek istermisiniz","Deger",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes)
            {
                Eslesme es = new Eslesme();
                var doktor = cmbdoktor.SelectedItem.ToString();
                BaseGetall<Doktor> doktors = new BaseGetall<Doktor>();
                var ds = doktors.Getall();
                foreach (var item in ds)
                {
                    var deger = item.DoktorAdi;
                    if (doktor == deger)
                    {
                        es.DoktorId = item.Id;
                        es.BolumId = item.BölümId;
                    }

                }
                var Sı = gridView1.FocusedValue;
                int td = Convert.ToInt32(Sı);
                es.SaatId = td;
                es.Tarih = dttarih.DateTime;
                es.RandevusuVarmi = false;               

                Base<Eslesme> ekle = new Base<Eslesme>();
                ekle.Insert(es);
                MessageBox.Show("Ekleme Yapıldı");
            }
            else
            {
                MessageBox.Show("Ekleme Yapılmadı");
            }
           
        }     
    }
}
