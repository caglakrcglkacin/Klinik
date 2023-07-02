using DevExpress.Web.Bootstrap.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinik
{
    public partial class RandevuEkle : Form
    {
        public int index = 0;
        public RandevuEkle(int bs)
        {
            index = bs;
            InitializeComponent();
        }

        private void RandevuEkle_Load(object sender, EventArgs e)
        {
            cmbdoktor.Enabled = false;
            BaseGetall<Bolums> goster = new BaseGetall<Bolums>();
            var dt = goster.Getall();
            foreach (var item in dt)
            {
                cmbbolum.Properties.Items.Add(item.Bolum);
            }
            BaseGetall<RandevuSaatis> saat = new BaseGetall<RandevuSaatis>();
            var ds = saat.Getall();
            foreach (var item in ds)
            {
                var ct = item.Secildimi;
                if (ct == "False")
                {
                    cmbrandevus.Properties.Items.Add(item.RandevuSaati);
                }
                
            }
            Base<Hasta> duzenle = new Base<Hasta>();
            var bk = duzenle.GetAll(index);
            txthasta.Text = bk.HastaAdi + bk.HastaSoyadi;
        }

        private void dropDownButton2_Click(object sender, EventArgs e)
        {
            Randevu ekle = new Randevu();
            var bolum = cmbbolum.SelectedItem.ToString();
            var doktor = cmbdoktor.SelectedItem.ToString();
            var saat = cmbrandevus.SelectedItem.ToString();
            Base<Hasta> duzenle = new Base<Hasta>();
            var bk = duzenle.GetAll(index);
            ekle.HastaId =bk.Id;
            cmbdoktor.Enabled = false;
            BaseGetall<Bolums> goster = new BaseGetall<Bolums>();
            var dt = goster.Getall();
            var Dı = 0;
            var yt = 0;
            ekle.OlusturmaTarihi = DateTime.Now;
            foreach (var item in dt)
            {
                
                var deger = item.Bolum;
                if (bolum == deger)
                {
                    ekle.BolumId = item.Id;
                                    
                    
                }
            }
            BaseGetall<Doktor> doktors = new BaseGetall<Doktor>();
            var ds = doktors.Getall();
            foreach (var item in ds)
            {
                Dı = item.Id;
                var deger = item.DoktorAdi;
                if (doktor == deger)
                {
                    ekle.DoktorId = item.Id;
                    yt = item.Id;
                }
            }
            BaseGetall<RandevuSaatis> saats = new BaseGetall<RandevuSaatis>();
            var my = saats.Getall();
            foreach (var item in my)
            {
                BaseGetall<Doktor> don = new BaseGetall<Doktor>();
                var ck = don.Getall();
                var sayacs = 0;
                for (int i = 1; i <=ck.Count; i++)
                {
                    sayacs++;
                    
                }
                RandevuSaatis deg = new RandevuSaatis();
                var ct = item.RandevuSaati;
                var saatId = 0;
                if (ct == saat )
                {
                   ekle.RandevuSaatId = item.Id;
                    var ıd = item.Id;
                    saatId = item.Id;
                   
                    deg.RandevuSaati = saat;
                  
                }
                if (sayacs == ck.Count)
                {
                    deg.Secildimi = "True";
                }
                Base<RandevuSaatis> st = new Base<RandevuSaatis>();
                st.Update(deg, saatId);

            }
            ekle.Randevutarihi = dtranddevu.DateTime;
            ekle.RandevuGeldimi = false;
            Base<Randevu> ınsert = new Base<Randevu>();
            ınsert.Insert(ekle);
            this.Close();
        }

        private void textEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            var bolum = cmbbolum.SelectedItem.ToString();
            BaseGetall<Bolums> goster = new BaseGetall<Bolums>();
            var dt = goster.Getall();
            var ıd = 0;
            foreach (var item in dt)
            {

                var deger = item.Bolum;
                if (bolum == deger)
                {
                   
                    ıd = item.Id;

                }
            }
            BaseGetall<Doktor> doktor = new BaseGetall<Doktor>();
            var ds = doktor.Getall();
            foreach (var item in ds)
            {
                if (ıd == item.BölümId)
                {
                    cmbdoktor.Enabled = true;
                    cmbdoktor.Properties.Items.Add(item.DoktorAdi);

                }
            }

        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            new HastaSec().ShowDialog();
            

        }
    }
}
