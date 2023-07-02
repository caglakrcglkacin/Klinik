using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Klinik
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        public void yazdir(List<vw_Rapor> liste,DateTime Tarih)
        {
            OlusturmaTarihi.Value = Tarih;
            objectDataSource1.DataSource = liste;

        }
    }
}
