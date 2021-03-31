using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders67_ApartmanKayitDevExpress
{
    public partial class FrmDaireler : Form
    {
        public FrmDaireler()
        {
            InitializeComponent();
        }
        private void Renkler()
        {
            btnDaire1.Appearance.BackColor = Color.Gray;
            btnDaire2.Appearance.BackColor = Color.Gray;
            btnDaire3.Appearance.BackColor = Color.Gray;
            btnDaire4.Appearance.BackColor = Color.Gray;
            btnDaire5.Appearance.BackColor = Color.Gray;
            btnDaire6.Appearance.BackColor = Color.Gray;
            btnDaire7.Appearance.BackColor = Color.Gray;
            btnDaire8.Appearance.BackColor = Color.Gray;
        }
        private void btnDaire1_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire1.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Ali Veli";
        }

        private void FrmDaireler_Load(object sender, EventArgs e)
        {
            Renkler();
        }

        private void btnDaire2_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire2.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Şahin Çeliktepe";
        }

        private void btnDaire3_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire3.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Kemal Bulut";
        }

        private void btnDaire4_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire4.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Ayşe Efe";
        }

        private void btnDaire5_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire5.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Meltem Güner";
        }

        private void btnDaire6_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire6.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Suat Usta";
        }

        private void btnDaire7_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire7.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Şeyma Çeliktepe";
        }

        private void btnDaire8_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire8.Appearance.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Deniz Görgün";
        }

        private void FrmDaireler_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
