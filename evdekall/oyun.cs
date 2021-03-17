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
    public partial class oyun : Form
    {
        public oyun()
        {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            yenimenu yenimenu = new yenimenu();
            yenimenu.Show();
            this.Close();
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int mov, movX, movY;

        private void hareket_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void beniyakala_Click(object sender, EventArgs e)
        {
            butonuyakala butonuyakala = new butonuyakala();
            butonuyakala.Show();
            this.Close();
        }

        private void hareket_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void hareket_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
