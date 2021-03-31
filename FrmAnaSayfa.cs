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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnDaireler_Click(object sender, EventArgs e)
        {
            FrmDaireler frmDaire = new FrmDaireler();
            frmDaire.Show();
            this.Hide();
        }

        private void btnKayitEkleGuncelleSil_Click(object sender, EventArgs e)
        {
            FrmKayitIslemleri frmKayitIslemleri = new FrmKayitIslemleri();
            frmKayitIslemleri.Show();
            this.Hide();
        }

        private void btnFotograflar_Click(object sender, EventArgs e)
        {
            FrmResim frmResim = new FrmResim();
            frmResim.Show();
            this.Hide();
        }

        private void btnVeriler_Click(object sender, EventArgs e)
        {
            FrmBorclar frmBorclar = new FrmBorclar();
            frmBorclar.Show();
            this.Hide();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DevExpress kullanılarak Apartman Kayıt uygulaması gerçekleştirdik");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Hide();
        }

        private void FrmAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
