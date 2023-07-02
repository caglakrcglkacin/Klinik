using DevExpress.XtraDiagram.Base;
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
    public partial class Rekle : Form
    {
        public Rekle()
        {
            InitializeComponent();
        }

        private void Rekle_Load(object sender, EventArgs e)
        {

            //BaseGetall<vw_esleme> eslemes = new BaseGetall<vw_esleme>();
            //gridControl1.DataSource = eslemes.Getall();
            BaseGetall<vw_esleme> eslemes = new BaseGetall<vw_esleme>();
            gridControl1.DataSource = eslemes.GetWatch(0);

            BaseGetall<Hasta> hasta = new BaseGetall<Hasta>();
            var hs = hasta.Getall();
            foreach (var item in hs)
            {
                cmbhasta.Properties.Items.Add(item.HastaAdi+item.HastaSoyadi);
            }
            dttarih.Enabled = false;
            txtrandevusaat.Enabled = false;
            txtdoktor.Enabled = false;
            txtbolum.Enabled = false;
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount < 1)
                return;
            var dt = gridView1.FocusedValue;
            int bul = Convert.ToInt32(dt);
            Base<Randevu> ekle = new Base<Randevu>();
            BaseGetall<vw_esleme> eslemes = new BaseGetall<vw_esleme>();
            var bulus = eslemes.Getall();
            foreach (var item in bulus)
            {
                var yt = item.Id;
                if (yt == bul)
                {
                    
                    dttarih.DateTime = item.Tarih;
                    txtdoktor.Text = item.DoktorAdi;
                    txtbolum.Text = item.Bolum;
                    txtrandevusaat.Text = item.RandevuSaati;
                }

            }

        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            var dt = gridView1.FocusedValue;
            int bul = Convert.ToInt32(dt);
            Randevu rds = new Randevu();
            Eslesme dgs = new Eslesme();
            Base<Randevu> ekle = new Base<Randevu>();
            BaseGetall<vw_esleme> eslemes = new BaseGetall<vw_esleme>();
            var bulus = eslemes.Getall();
            foreach (var item in bulus)
            {
                var yt = item.Id;
                if (yt == bul)
                {
                    rds.Randevutarihi = item.Tarih;
                    dgs.Tarih = item.Tarih;
                 
                }

            }


            BaseGetall<Eslesme> git = new BaseGetall<Eslesme>();
            var rd = git.Getall();
            foreach (var item in rd)
            {
                var gs = item.Id;
                if (bul == gs)
                {
                    rds.DoktorId = item.DoktorId;
                    rds.BolumId = item.BolumId;
                    rds.RandevuSaatId = item.SaatId;
                    dgs.DoktorId = item.DoktorId;
                    dgs.BolumId = item.BolumId;
                    dgs.SaatId = item.SaatId;

                }

            }
            var hastasec = cmbhasta.SelectedItem.ToString();

            BaseGetall<Hasta> hasta = new BaseGetall<Hasta>();
            var hs = hasta.Getall();
            foreach (var item in hs)
            {
                var deger = item.HastaAdi + item.HastaSoyadi;
                if (hastasec == deger)
                {
                    rds.HastaId = item.Id;
                }
            }
            dgs.RandevusuVarmi = true;
            rds.OlusturmaTarihi = DateTime.Now;
            ekle.Insert(rds);
            Base<Eslesme> guncelle = new Base<Eslesme>();
            guncelle.Update(dgs,bul);
            this.Close();

        }
    }
}
