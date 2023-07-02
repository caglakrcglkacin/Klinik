namespace Klinik
{
    partial class Rekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rekle));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtdoktor = new DevExpress.XtraEditors.TextEdit();
            this.txtbolum = new DevExpress.XtraEditors.TextEdit();
            this.txtrandevusaat = new DevExpress.XtraEditors.TextEdit();
            this.cmbhasta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dttarih = new DevExpress.XtraEditors.DateEdit();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdoktor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbolum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrandevusaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbhasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttarih.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Location = new System.Drawing.Point(12, 265);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1076, 589);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 36);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Doktor Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 99);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Bölüm";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 152);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Randevu Tarihi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 202);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Randevu Saati";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(519, 36);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 16);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Hasta Adı";
            // 
            // txtdoktor
            // 
            this.txtdoktor.Location = new System.Drawing.Point(161, 33);
            this.txtdoktor.Margin = new System.Windows.Forms.Padding(6);
            this.txtdoktor.Name = "txtdoktor";
            this.txtdoktor.Size = new System.Drawing.Size(275, 22);
            this.txtdoktor.TabIndex = 6;
            // 
            // txtbolum
            // 
            this.txtbolum.Location = new System.Drawing.Point(161, 96);
            this.txtbolum.Margin = new System.Windows.Forms.Padding(8);
            this.txtbolum.Name = "txtbolum";
            this.txtbolum.Size = new System.Drawing.Size(275, 22);
            this.txtbolum.TabIndex = 7;
            // 
            // txtrandevusaat
            // 
            this.txtrandevusaat.Location = new System.Drawing.Point(161, 199);
            this.txtrandevusaat.Margin = new System.Windows.Forms.Padding(8);
            this.txtrandevusaat.Name = "txtrandevusaat";
            this.txtrandevusaat.Size = new System.Drawing.Size(272, 22);
            this.txtrandevusaat.TabIndex = 9;
            // 
            // cmbhasta
            // 
            this.cmbhasta.Location = new System.Drawing.Point(618, 31);
            this.cmbhasta.Margin = new System.Windows.Forms.Padding(8);
            this.cmbhasta.Name = "cmbhasta";
            this.cmbhasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbhasta.Size = new System.Drawing.Size(344, 22);
            this.cmbhasta.TabIndex = 10;
            // 
            // dttarih
            // 
            this.dttarih.EditValue = null;
            this.dttarih.Location = new System.Drawing.Point(161, 149);
            this.dttarih.Margin = new System.Windows.Forms.Padding(8);
            this.dttarih.Name = "dttarih";
            this.dttarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dttarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dttarih.Properties.DisplayFormat.FormatString = "";
            this.dttarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dttarih.Properties.EditFormat.FormatString = "";
            this.dttarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dttarih.Properties.MaskSettings.Set("mask", "");
            this.dttarih.Size = new System.Drawing.Size(272, 22);
            this.dttarih.TabIndex = 8;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.dropDownButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButton1.ImageOptions.Image")));
            this.dropDownButton1.Location = new System.Drawing.Point(695, 84);
            this.dropDownButton1.Margin = new System.Windows.Forms.Padding(6);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.dropDownButton1.Size = new System.Drawing.Size(240, 45);
            this.dropDownButton1.TabIndex = 11;
            this.dropDownButton1.Text = "Randevu Ver";
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
            // 
            // Rekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 559);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.txtrandevusaat);
            this.Controls.Add(this.txtbolum);
            this.Controls.Add(this.txtdoktor);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmbhasta);
            this.Controls.Add(this.dttarih);
            this.Name = "Rekle";
            this.Text = "Rekle";
            this.Load += new System.EventHandler(this.Rekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdoktor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbolum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrandevusaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbhasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtdoktor;
        private DevExpress.XtraEditors.TextEdit txtbolum;
        private DevExpress.XtraEditors.TextEdit txtrandevusaat;
        private DevExpress.XtraEditors.ComboBoxEdit cmbhasta;
        private DevExpress.XtraEditors.DateEdit dttarih;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}