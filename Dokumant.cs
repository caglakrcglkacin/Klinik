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
    public partial class Dokumant : Form
    {
        public Dokumant()
        {
            InitializeComponent();
        }
        public void yazdirSayfa(List<vw_Rapor> Data)
        {
            XtraReport1 report = new XtraReport1();
            report.yazdir(Data,DateTime.Now);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
