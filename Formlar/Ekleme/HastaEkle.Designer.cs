namespace Klinik
{
    partial class HastaEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaEkle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txthastaadi = new DevExpress.XtraEditors.TextEdit();
            this.txtsoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txttelefon = new DevExpress.XtraEditors.TextEdit();
            this.dtdogum = new DevExpress.XtraEditors.DateEdit();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txthastaadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdogum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdogum.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(122, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hasta Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(122, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Hasta Soyadı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(122, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Hasta Telefonu";
            // 
            // labelControl6
            // 
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl6.Location = new System.Drawing.Point(122, 204);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 16);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Doğum Tarihi";
            // 
            // txthastaadi
            // 
            this.txthastaadi.Location = new System.Drawing.Point(235, 62);
            this.txthastaadi.Name = "txthastaadi";
            this.txthastaadi.Size = new System.Drawing.Size(177, 22);
            this.txthastaadi.TabIndex = 4;
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.Location = new System.Drawing.Point(235, 110);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(177, 22);
            this.txtsoyadi.TabIndex = 5;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(235, 147);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(177, 22);
            this.txttelefon.TabIndex = 6;
            // 
            // dtdogum
            // 
            this.dtdogum.EditValue = null;
            this.dtdogum.Location = new System.Drawing.Point(235, 198);
            this.dtdogum.Name = "dtdogum";
            this.dtdogum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtdogum.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtdogum.Properties.DisplayFormat.FormatString = "";
            this.dtdogum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtdogum.Properties.EditFormat.FormatString = "";
            this.dtdogum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtdogum.Properties.MaskSettings.Set("mask", "");
            this.dtdogum.Size = new System.Drawing.Size(177, 22);
            this.dtdogum.TabIndex = 7;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.dropDownButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButton1.ImageOptions.Image")));
            this.dropDownButton1.Location = new System.Drawing.Point(133, 253);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.dropDownButton1.Size = new System.Drawing.Size(289, 73);
            this.dropDownButton1.TabIndex = 8;
            this.dropDownButton1.Text = "Kaydet";
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dropDownButton1);
            this.groupControl1.Controls.Add(this.dtdogum);
            this.groupControl1.Controls.Add(this.txttelefon);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtsoyadi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txthastaadi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(532, 331);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Hasta Kayıt";
            // 
            // HastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 353);
            this.Controls.Add(this.groupControl1);
            this.Name = "HastaEkle";
            this.Text = "HastaEkle";
            ((System.ComponentModel.ISupportInitialize)(this.txthastaadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdogum.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdogum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txthastaadi;
        private DevExpress.XtraEditors.TextEdit txtsoyadi;
        private DevExpress.XtraEditors.TextEdit txttelefon;
        private DevExpress.XtraEditors.DateEdit dtdogum;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}