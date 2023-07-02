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
    public partial class HastaSec : Form
    {
        public HastaSec()
        {
            InitializeComponent();
        }

        private void HastaSec_Load(object sender, EventArgs e)
        {
            BaseGetall<Hasta> goster = new BaseGetall<Hasta>();
            gridControl1.DataSource = goster.Getall();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount < 1)
                return;
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                var ıd = gridView1.FocusedValue;
                var gonder = Convert.ToInt32(ıd);
                RandevuEkle randevu = new RandevuEkle(gonder);
                randevu.ShowDialog();
               
                this.Close();
            }
        }
    }
}
