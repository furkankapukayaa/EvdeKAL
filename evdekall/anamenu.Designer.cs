﻿
namespace evdekall
{
    partial class anamenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anamenu));
            this.button6 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.mmt = new System.Windows.Forms.Label();
            this.hareket = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.evdekal = new System.Windows.Forms.Label();
            this.baslik = new System.Windows.Forms.Label();
            this.KoronaHaber = new System.Windows.Forms.Button();
            this.baslik2 = new System.Windows.Forms.Label();
            this.AltmisBesUzeri = new System.Windows.Forms.Button();
            this.YirmiBirAltmisDortArasi = new System.Windows.Forms.Button();
            this.YirmiYasAlti = new System.Windows.Forms.Button();
            this.KoronaTablo = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.profil = new System.Windows.Forms.PictureBox();
            this.corona = new System.Windows.Forms.PictureBox();
            this.kucult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(747, 320);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(209, 108);
            this.button6.TabIndex = 55;
            this.button6.Text = "Türkiye Aşı Tablosu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(-3, 480);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1006, 22);
            this.panel.TabIndex = 52;
            // 
            // mmt
            // 
            this.mmt.AutoSize = true;
            this.mmt.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mmt.ForeColor = System.Drawing.Color.Green;
            this.mmt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mmt.Location = new System.Drawing.Point(372, 82);
            this.mmt.Name = "mmt";
            this.mmt.Size = new System.Drawing.Size(232, 26);
            this.mmt.TabIndex = 51;
            this.mmt.Text = "Maske - Mesafe - Temizlik";
            // 
            // hareket
            // 
            this.hareket.BackColor = System.Drawing.Color.Red;
            this.hareket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hareket.Location = new System.Drawing.Point(-3, -1);
            this.hareket.Margin = new System.Windows.Forms.Padding(4);
            this.hareket.Name = "hareket";
            this.hareket.Size = new System.Drawing.Size(1006, 22);
            this.hareket.TabIndex = 50;
            this.hareket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseDown);
            this.hareket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseMove);
            this.hareket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // evdekal
            // 
            this.evdekal.AutoSize = true;
            this.evdekal.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evdekal.ForeColor = System.Drawing.Color.Red;
            this.evdekal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.evdekal.Location = new System.Drawing.Point(439, 59);
            this.evdekal.Name = "evdekal";
            this.evdekal.Size = new System.Drawing.Size(100, 26);
            this.evdekal.TabIndex = 47;
            this.evdekal.Text = "#EVDEKAL";
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.baslik.Location = new System.Drawing.Point(380, 32);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(222, 29);
            this.baslik.TabIndex = 46;
            this.baslik.Text = "Korona Virüs Türkiye";
            // 
            // KoronaHaber
            // 
            this.KoronaHaber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KoronaHaber.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.KoronaHaber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KoronaHaber.Location = new System.Drawing.Point(747, 75);
            this.KoronaHaber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KoronaHaber.Name = "KoronaHaber";
            this.KoronaHaber.Size = new System.Drawing.Size(209, 108);
            this.KoronaHaber.TabIndex = 45;
            this.KoronaHaber.Text = "Korona Virüs Haberleri";
            this.KoronaHaber.UseVisualStyleBackColor = true;
            this.KoronaHaber.Click += new System.EventHandler(this.KoronaHaber_Click);
            // 
            // baslik2
            // 
            this.baslik2.AutoSize = true;
            this.baslik2.Font = new System.Drawing.Font("Chaparral Pro", 24F);
            this.baslik2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.baslik2.Location = new System.Drawing.Point(341, 354);
            this.baslik2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baslik2.Name = "baslik2";
            this.baslik2.Size = new System.Drawing.Size(324, 38);
            this.baslik2.TabIndex = 43;
            this.baslik2.Text = "DIŞARI KİM ÇIKIYOR ?";
            // 
            // AltmisBesUzeri
            // 
            this.AltmisBesUzeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AltmisBesUzeri.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.AltmisBesUzeri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AltmisBesUzeri.Location = new System.Drawing.Point(42, 320);
            this.AltmisBesUzeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AltmisBesUzeri.Name = "AltmisBesUzeri";
            this.AltmisBesUzeri.Size = new System.Drawing.Size(209, 108);
            this.AltmisBesUzeri.TabIndex = 42;
            this.AltmisBesUzeri.Text = "65 Yaş ve Üzeri";
            this.AltmisBesUzeri.UseVisualStyleBackColor = true;
            this.AltmisBesUzeri.Click += new System.EventHandler(this.AltmisBesUzeri_Click);
            // 
            // YirmiBirAltmisDortArasi
            // 
            this.YirmiBirAltmisDortArasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YirmiBirAltmisDortArasi.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.YirmiBirAltmisDortArasi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.YirmiBirAltmisDortArasi.Location = new System.Drawing.Point(42, 196);
            this.YirmiBirAltmisDortArasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YirmiBirAltmisDortArasi.Name = "YirmiBirAltmisDortArasi";
            this.YirmiBirAltmisDortArasi.Size = new System.Drawing.Size(209, 108);
            this.YirmiBirAltmisDortArasi.TabIndex = 41;
            this.YirmiBirAltmisDortArasi.Text = "21 ve 64 Yaş Arası";
            this.YirmiBirAltmisDortArasi.UseVisualStyleBackColor = true;
            this.YirmiBirAltmisDortArasi.Click += new System.EventHandler(this.YirmiBirAltmisDortArasi_Click);
            // 
            // YirmiYasAlti
            // 
            this.YirmiYasAlti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YirmiYasAlti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.YirmiYasAlti.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YirmiYasAlti.ImageKey = "(yok)";
            this.YirmiYasAlti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.YirmiYasAlti.Location = new System.Drawing.Point(42, 75);
            this.YirmiYasAlti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YirmiYasAlti.Name = "YirmiYasAlti";
            this.YirmiYasAlti.Size = new System.Drawing.Size(209, 108);
            this.YirmiYasAlti.TabIndex = 40;
            this.YirmiYasAlti.Text = "20 Yaş Altı";
            this.YirmiYasAlti.UseVisualStyleBackColor = true;
            this.YirmiYasAlti.Click += new System.EventHandler(this.YirmiYasAlti_Click);
            // 
            // KoronaTablo
            // 
            this.KoronaTablo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KoronaTablo.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.KoronaTablo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KoronaTablo.Location = new System.Drawing.Point(747, 199);
            this.KoronaTablo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KoronaTablo.Name = "KoronaTablo";
            this.KoronaTablo.Size = new System.Drawing.Size(209, 108);
            this.KoronaTablo.TabIndex = 44;
            this.KoronaTablo.Text = "Türkiye Korona Virüs Tablosu";
            this.KoronaTablo.UseVisualStyleBackColor = true;
            this.KoronaTablo.Click += new System.EventHandler(this.KoronaTablo_Click);
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tarih.Location = new System.Drawing.Point(380, 158);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(178, 25);
            this.tarih.TabIndex = 39;
            this.tarih.Text = "Güncelleniyor...";
            this.tarih.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cikis
            // 
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Image = global::evdekall.Properties.Resources.newClose;
            this.cikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cikis.Location = new System.Drawing.Point(956, 27);
            this.cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(36, 34);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cikis.TabIndex = 54;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // profil
            // 
            this.profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profil.Image = global::evdekall.Properties.Resources.newProfil;
            this.profil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.profil.Location = new System.Drawing.Point(876, 28);
            this.profil.Margin = new System.Windows.Forms.Padding(4);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(37, 33);
            this.profil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profil.TabIndex = 53;
            this.profil.TabStop = false;
            this.profil.Click += new System.EventHandler(this.profil_Click);
            // 
            // corona
            // 
            this.corona.Image = global::evdekall.Properties.Resources.coronavirus;
            this.corona.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.corona.Location = new System.Drawing.Point(385, 227);
            this.corona.Margin = new System.Windows.Forms.Padding(4);
            this.corona.Name = "corona";
            this.corona.Size = new System.Drawing.Size(207, 101);
            this.corona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.corona.TabIndex = 49;
            this.corona.TabStop = false;
            // 
            // kucult
            // 
            this.kucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kucult.Image = global::evdekall.Properties.Resources.newKucult;
            this.kucult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kucult.Location = new System.Drawing.Point(920, 28);
            this.kucult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kucult.Name = "kucult";
            this.kucult.Size = new System.Drawing.Size(30, 33);
            this.kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kucult.TabIndex = 48;
            this.kucult.TabStop = false;
            this.kucult.Click += new System.EventHandler(this.kucult_Click);
            // 
            // anamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.mmt);
            this.Controls.Add(this.hareket);
            this.Controls.Add(this.corona);
            this.Controls.Add(this.kucult);
            this.Controls.Add(this.evdekal);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.KoronaHaber);
            this.Controls.Add(this.baslik2);
            this.Controls.Add(this.AltmisBesUzeri);
            this.Controls.Add(this.YirmiBirAltmisDortArasi);
            this.Controls.Add(this.YirmiYasAlti);
            this.Controls.Add(this.KoronaTablo);
            this.Controls.Add(this.tarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anamenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvdeKal";
            this.Load += new System.EventHandler(this.anamenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox profil;
        private System.Windows.Forms.Label mmt;
        private System.Windows.Forms.Panel hareket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox corona;
        private System.Windows.Forms.PictureBox kucult;
        private System.Windows.Forms.Label evdekal;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Button KoronaHaber;
        private System.Windows.Forms.Label baslik2;
        private System.Windows.Forms.Button AltmisBesUzeri;
        private System.Windows.Forms.Button YirmiBirAltmisDortArasi;
        private System.Windows.Forms.Button YirmiYasAlti;
        private System.Windows.Forms.Button KoronaTablo;
        private System.Windows.Forms.Label tarih;
    }
}

