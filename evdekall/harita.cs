﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evdekall
{
    public partial class harita : Form
    {
        public harita()
        {
            InitializeComponent();
        }

        private void harita_Load(object sender, EventArgs e)
        {

        }

        public void Donustur()
        {
            txtİLCE.Text = txtİLCE.Text.Replace("ı", "i");
            txtİLCE.Text = txtİLCE.Text.Replace("ü", "u");
            txtİLCE.Text = txtİLCE.Text.Replace("ğ", "g");
            txtİLCE.Text = txtİLCE.Text.Replace("İ", "I");
            txtİLCE.Text = txtİLCE.Text.Replace("Ğ", "G");
            txtİLCE.Text = txtİLCE.Text.Replace("Ü", "U");
            txtİLCE.Text = txtİLCE.Text.Replace("Ç", "C");
            txtİLCE.Text = txtİLCE.Text.Replace("ç", "c");
            txtİLCE.Text = txtİLCE.Text.Replace("ö", "o");
            txtİLCE.Text = txtİLCE.Text.Replace("Ö", "O");
            txtİLCE.Text = txtİLCE.Text.Replace("Ş", "S");
            txtİLCE.Text = txtİLCE.Text.Replace("ş", "s");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Donustur();
            string ulke = ulkeler.SelectedItem.ToString();
            string il = iller.SelectedItem.ToString();
            string ilce = txtİLCE.Text;
            string mekan = this.mekan.SelectedItem.ToString();

            try
            {
                StringBuilder adres = new StringBuilder();
                adres.Append("https://www.google.com/maps/search/");
                
                if (ulke != String.Empty)
                {
                    adres.Append(ulke + " " + "+");
                }
                if (il != String.Empty)
                {
                    adres.Append(il + " " + "+");
                }
                if (ilce != String.Empty)
                {
                    adres.Append(ilce + " " + "+");
                }
                if (mekan != String.Empty)
                {
                    adres.Append(mekan);
                }
                webBrowser1.Navigate(adres.ToString());
                pictureBox1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            yenimenu yenimenu = new yenimenu();
            yenimenu.Show();
            this.Close();
        }

        int mov, movX, movY;

        private void hareket_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtİLCE.Clear();
            ulkeler.SelectedIndex = 0;
            iller.SelectedIndex = 0;
            mekan.SelectedIndex = 0;
        }

        private void txtİLCE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void hareket_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void hareket_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
    }
}
