﻿namespace Proje
{
    partial class frm_klasik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_klasik));
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_soru = new System.Windows.Forms.RichTextBox();
            this.txt_dersadi = new DevExpress.XtraEditors.TextEdit();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.LabelControl();
            this.txt_puan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_seviye = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ekle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_dogruyanıt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dersadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl3
            // 
            this.gridControl3.Location = new System.Drawing.Point(1, 2);
            this.gridControl3.MainView = this.gridView1;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(524, 522);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl3;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_dogruyanıt);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_puan);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cmb_seviye);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.btn_guncelle);
            this.groupControl1.Controls.Add(this.btn_sil);
            this.groupControl1.Controls.Add(this.btn_ekle);
            this.groupControl1.Controls.Add(this.txt_soru);
            this.groupControl1.Controls.Add(this.txt_dersadi);
            this.groupControl1.Controls.Add(this.txt_id);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.id);
            this.groupControl1.Location = new System.Drawing.Point(531, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(248, 522);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // txt_soru
            // 
            this.txt_soru.Location = new System.Drawing.Point(74, 72);
            this.txt_soru.Name = "txt_soru";
            this.txt_soru.Size = new System.Drawing.Size(159, 114);
            this.txt_soru.TabIndex = 49;
            this.txt_soru.Text = "";
            // 
            // txt_dersadi
            // 
            this.txt_dersadi.Location = new System.Drawing.Point(120, 45);
            this.txt_dersadi.Name = "txt_dersadi";
            this.txt_dersadi.Size = new System.Drawing.Size(113, 20);
            this.txt_dersadi.TabIndex = 48;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(120, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(113, 20);
            this.txt_id.TabIndex = 47;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 18);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "SORU:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 18);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "DERS ADI:";
            // 
            // id
            // 
            this.id.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.Appearance.Options.UseFont = true;
            this.id.Location = new System.Drawing.Point(8, 21);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(25, 18);
            this.id.TabIndex = 44;
            this.id.Text = "ID:";
            // 
            // txt_puan
            // 
            this.txt_puan.Location = new System.Drawing.Point(146, 362);
            this.txt_puan.Name = "txt_puan";
            this.txt_puan.Properties.Mask.EditMask = "n0";
            this.txt_puan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_puan.Size = new System.Drawing.Size(97, 20);
            this.txt_puan.TabIndex = 59;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 364);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 18);
            this.labelControl5.TabIndex = 58;
            this.labelControl5.Text = "PUAN:";
            // 
            // cmb_seviye
            // 
            this.cmb_seviye.FormattingEnabled = true;
            this.cmb_seviye.Location = new System.Drawing.Point(146, 332);
            this.cmb_seviye.Name = "cmb_seviye";
            this.cmb_seviye.Size = new System.Drawing.Size(97, 21);
            this.cmb_seviye.TabIndex = 57;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(18, 335);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 18);
            this.labelControl4.TabIndex = 56;
            this.labelControl4.Text = "SEVİYE:";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.ImageOptions.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(124, 469);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(119, 37);
            this.btn_guncelle.TabIndex = 55;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.ImageOptions.Image")));
            this.btn_sil.Location = new System.Drawing.Point(124, 430);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(119, 33);
            this.btn_sil.TabIndex = 54;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Appearance.Options.UseFont = true;
            this.btn_ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.ImageOptions.Image")));
            this.btn_ekle.Location = new System.Drawing.Point(124, 389);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(119, 35);
            this.btn_ekle.TabIndex = 53;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(0, 209);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(112, 18);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "DOĞRUYANIT:";
            // 
            // txt_dogruyanıt
            // 
            this.txt_dogruyanıt.Location = new System.Drawing.Point(118, 209);
            this.txt_dogruyanıt.Name = "txt_dogruyanıt";
            this.txt_dogruyanıt.Size = new System.Drawing.Size(115, 106);
            this.txt_dogruyanıt.TabIndex = 61;
            this.txt_dogruyanıt.Text = "";
            // 
            // frm_klasik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 530);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl3);
            this.Name = "frm_klasik";
            this.Text = "Klasik";
            this.Load += new System.EventHandler(this.frm_klasik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dersadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txt_soru;
        private DevExpress.XtraEditors.TextEdit txt_dersadi;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl id;
        private DevExpress.XtraEditors.TextEdit txt_puan;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cmb_seviye;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_ekle;
        private System.Windows.Forms.RichTextBox txt_dogruyanıt;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}