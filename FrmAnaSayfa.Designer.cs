
namespace Ders67_ApartmanKayitDevExpress
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.btnDaireler = new DevExpress.XtraEditors.SimpleButton();
            this.btnVeriler = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayitEkleGuncelleSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnFotograflar = new DevExpress.XtraEditors.SimpleButton();
            this.btnHakkimizda = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnDaireler
            // 
            this.btnDaireler.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDaireler.Appearance.Options.UseFont = true;
            this.btnDaireler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaireler.ImageOptions.Image")));
            this.btnDaireler.Location = new System.Drawing.Point(60, 82);
            this.btnDaireler.Name = "btnDaireler";
            this.btnDaireler.Size = new System.Drawing.Size(240, 48);
            this.btnDaireler.TabIndex = 0;
            this.btnDaireler.Text = "Daireler";
            this.btnDaireler.Click += new System.EventHandler(this.btnDaireler_Click);
            // 
            // btnVeriler
            // 
            this.btnVeriler.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnVeriler.Appearance.Options.UseFont = true;
            this.btnVeriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVeriler.ImageOptions.Image")));
            this.btnVeriler.Location = new System.Drawing.Point(377, 82);
            this.btnVeriler.Name = "btnVeriler";
            this.btnVeriler.Size = new System.Drawing.Size(240, 48);
            this.btnVeriler.TabIndex = 0;
            this.btnVeriler.Text = "Veriler";
            this.btnVeriler.Click += new System.EventHandler(this.btnVeriler_Click);
            // 
            // btnKayitEkleGuncelleSil
            // 
            this.btnKayitEkleGuncelleSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnKayitEkleGuncelleSil.Appearance.Options.UseFont = true;
            this.btnKayitEkleGuncelleSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitEkleGuncelleSil.ImageOptions.Image")));
            this.btnKayitEkleGuncelleSil.Location = new System.Drawing.Point(60, 187);
            this.btnKayitEkleGuncelleSil.Name = "btnKayitEkleGuncelleSil";
            this.btnKayitEkleGuncelleSil.Size = new System.Drawing.Size(240, 48);
            this.btnKayitEkleGuncelleSil.TabIndex = 0;
            this.btnKayitEkleGuncelleSil.Text = "Kayıt Ekle Güncelle Sil";
            this.btnKayitEkleGuncelleSil.Click += new System.EventHandler(this.btnKayitEkleGuncelleSil_Click);
            // 
            // btnFotograflar
            // 
            this.btnFotograflar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnFotograflar.Appearance.Options.UseFont = true;
            this.btnFotograflar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFotograflar.ImageOptions.Image")));
            this.btnFotograflar.Location = new System.Drawing.Point(377, 187);
            this.btnFotograflar.Name = "btnFotograflar";
            this.btnFotograflar.Size = new System.Drawing.Size(240, 48);
            this.btnFotograflar.TabIndex = 0;
            this.btnFotograflar.Text = "Fotoğraflar";
            this.btnFotograflar.Click += new System.EventHandler(this.btnFotograflar_Click);
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnHakkimizda.Appearance.Options.UseFont = true;
            this.btnHakkimizda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHakkimizda.ImageOptions.Image")));
            this.btnHakkimizda.Location = new System.Drawing.Point(60, 285);
            this.btnHakkimizda.Name = "btnHakkimizda";
            this.btnHakkimizda.Size = new System.Drawing.Size(240, 48);
            this.btnHakkimizda.TabIndex = 0;
            this.btnHakkimizda.Text = "Hakkımızda";
            this.btnHakkimizda.Click += new System.EventHandler(this.btnHakkimizda_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(377, 285);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(240, 48);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(692, 410);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnHakkimizda);
            this.Controls.Add(this.btnFotograflar);
            this.Controls.Add(this.btnKayitEkleGuncelleSil);
            this.Controls.Add(this.btnVeriler);
            this.Controls.Add(this.btnDaireler);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAnaSayfa_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDaireler;
        private DevExpress.XtraEditors.SimpleButton btnVeriler;
        private DevExpress.XtraEditors.SimpleButton btnKayitEkleGuncelleSil;
        private DevExpress.XtraEditors.SimpleButton btnFotograflar;
        private DevExpress.XtraEditors.SimpleButton btnHakkimizda;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}