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
    public partial class RaporEkle : Form
    {
        public RaporEkle()
        {
            InitializeComponent();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            var has = cmbhasta.SelectedItem.ToString();
            Rapor ekle = new Rapor();
            BaseGetall<Hasta> hs = new BaseGetall<Hasta>();
            var dt = hs.Getall();
            foreach (var item in dt)
            {
                var deger = item.HastaAdi + " " + item.HastaSoyadi;
                if (has == deger)
                {
                    ekle.HastaId = item.Id;
                        
                }
            }
            ekle.RaporSuresi = txtsure.Text;
            ekle.VerilmeTarihi = dtis.DateTime;
            ekle.BitisTarihi = dtbitis.DateTime;
            ekle.Baslangıctarihi = dtbaslangic.DateTime;
            ekle.VerilmeNedeni = txtverilme.Text;
            ekle.OlusturmaTarihi = DateTime.Now;
            Base<Rapor> rp = new Base<Rapor>();
            rp.Insert(ekle);
            BaseGetall<vw_Rapor> rs = new BaseGetall<vw_Rapor>();
            gridControl1.DataSource = rs.Getall();

        }

        private void RaporEkle_Load(object sender, EventArgs e)
        {
            BaseGetall<Hasta> hs = new BaseGetall<Hasta>();
            var dt = hs.Getall();
            foreach (var item in dt)
            {
                cmbhasta.Properties.Items.Add(item.HastaAdi +" "+item.HastaSoyadi);
            }
            BaseGetall<vw_Rapor> rp = new BaseGetall<vw_Rapor>();
            gridControl1.DataSource = rp.Getall();
        }

        private void dropDownButton2_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount < 1)
                return;
            var secili = gridView1.FocusedValue;
            int Id = Convert.ToInt32(secili);
            BaseGetall<vw_Rapor> cikti = new BaseGetall<vw_Rapor>();          
            var getir = cikti.GetPrint(Id);
            Dokumant print = new Dokumant();
            print.yazdirSayfa(getir);
            print.ShowDialog();
        }
    }
}
