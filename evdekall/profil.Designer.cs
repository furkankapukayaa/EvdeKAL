﻿
namespace evdekall
{
    partial class profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profil));
            this.yas = new System.Windows.Forms.TextBox();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.izinsorgu = new System.Windows.Forms.Button();
            this.hareket = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.kucult = new System.Windows.Forms.PictureBox();
            this.profilfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // yas
            // 
            this.yas.Enabled = false;
            this.yas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.yas.Location = new System.Drawing.Point(124, 307);
            this.yas.Margin = new System.Windows.Forms.Padding(4);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(236, 27);
            this.yas.TabIndex = 21;
            // 
            // adsoyad
            // 
            this.adsoyad.Enabled = false;
            this.adsoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.adsoyad.Location = new System.Drawing.Point(124, 267);
            this.adsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(236, 27);
            this.adsoyad.TabIndex = 20;
            // 
            // izinsorgu
            // 
            this.izinsorgu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izinsorgu.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izinsorgu.Location = new System.Drawing.Point(121, 342);
            this.izinsorgu.Margin = new System.Windows.Forms.Padding(4);
            this.izinsorgu.Name = "izinsorgu";
            this.izinsorgu.Size = new System.Drawing.Size(239, 64);
            this.izinsorgu.TabIndex = 19;
            this.izinsorgu.Text = "Dışarı Çıkabiliyor Muyum ?";
            this.izinsorgu.UseVisualStyleBackColor = true;
            this.izinsorgu.Click += new System.EventHandler(this.izinsorgu_Click);
            // 
            // hareket
            // 
            this.hareket.BackColor = System.Drawing.Color.Red;
            this.hareket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hareket.Location = new System.Drawing.Point(-2, -1);
            this.hareket.Margin = new System.Windows.Forms.Padding(4);
            this.hareket.Name = "hareket";
            this.hareket.Size = new System.Drawing.Size(507, 22);
            this.hareket.TabIndex = 61;
            this.hareket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseDown);
            this.hareket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseMove);
            this.hareket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseUp);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(-2, 480);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(507, 22);
            this.panel.TabIndex = 62;
            // 
            // cikis
            // 
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Image = global::evdekall.Properties.Resources.previous;
            this.cikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cikis.Location = new System.Drawing.Point(458, 27);
            this.cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(30, 33);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cikis.TabIndex = 56;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // kucult
            // 
            this.kucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kucult.Image = global::evdekall.Properties.Resources.minimize;
            this.kucult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kucult.Location = new System.Drawing.Point(422, 27);
            this.kucult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kucult.Name = "kucult";
            this.kucult.Size = new System.Drawing.Size(30, 33);
            this.kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kucult.TabIndex = 55;
            this.kucult.TabStop = false;
            this.kucult.Click += new System.EventHandler(this.kucult_Click);
            // 
            // profilfoto
            // 
            this.profilfoto.Image = global::evdekall.Properties.Resources.profile_user;
            this.profilfoto.Location = new System.Drawing.Point(158, 100);
            this.profilfoto.Margin = new System.Windows.Forms.Padding(4);
            this.profilfoto.Name = "profilfoto";
            this.profilfoto.Size = new System.Drawing.Size(179, 159);
            this.profilfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilfoto.TabIndex = 18;
            this.profilfoto.TabStop = false;
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.hareket);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.kucult);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.izinsorgu);
            this.Controls.Add(this.profilfoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profil";
            this.Load += new System.EventHandler(this.profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.Button izinsorgu;
        private System.Windows.Forms.PictureBox profilfoto;
        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.PictureBox kucult;
        private System.Windows.Forms.Panel hareket;
        private System.Windows.Forms.Panel panel;
    }
}