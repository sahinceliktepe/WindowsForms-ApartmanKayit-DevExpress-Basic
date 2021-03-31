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
    public partial class FrmResim : Form
    {
        public FrmResim()
        {
            InitializeComponent();
        }

        private void FrmResim_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
