namespace Klinik
{
    partial class Doktor_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor_Ekle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.dtdogum = new DevExpress.XtraEditors.DateEdit();
            this.txttelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoyadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbbolum = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdogum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdogum.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbolum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dropDownButton1);
            this.groupControl1.Controls.Add(this.dtdogum);
            this.groupControl1.Controls.Add(this.txttelefon);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtsoyadi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtadi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.cmbbolum);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(532, 331);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Doktor Kayıt";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 235);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Bölüm";
            // 
            // labelControl1
            // 
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(19, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Doktor Adı";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.dropDownButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButton1.ImageOptions.Image")));
            this.dropDownButton1.Location = new System.Drawing.Point(47, 274);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.dropDownButton1.Size = new System.Drawing.Size(252, 43);
            this.dropDownButton1.TabIndex = 8;
            this.dropDownButton1.Text = "Kaydet";
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
            // 
            // dtdogum
            // 
            this.dtdogum.EditValue = null;
            this.dtdogum.Location = new System.Drawing.Point(122, 180);
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
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(122, 142);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(177, 22);
            this.txttelefon.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Doktor Soyadı";
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.Location = new System.Drawing.Point(122, 100);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(177, 22);
            this.txtsoyadi.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Doktor Telefonu";
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(122, 52);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(177, 22);
            this.txtadi.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl6.Location = new System.Drawing.Point(19, 183);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 16);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Doğum Tarihi";
            // 
            // cmbbolum
            // 
            this.cmbbolum.Location = new System.Drawing.Point(122, 232);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbolum.Size = new System.Drawing.Size(177, 22);
            this.cmbbolum.TabIndex = 10;
            // 
            // Doktor_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 362);
            this.Controls.Add(this.groupControl1);
            this.Name = "Doktor_Ekle";
            this.Text = "Doktor_Ekle";
            this.Load += new System.EventHandler(this.Doktor_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdogum.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdogum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbolum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.DateEdit dtdogum;
        private DevExpress.XtraEditors.TextEdit txttelefon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtsoyadi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtadi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbolum;
    }
}