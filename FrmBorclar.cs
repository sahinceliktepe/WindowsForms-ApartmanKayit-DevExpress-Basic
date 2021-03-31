using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ders67_ApartmanKayitDevExpress
{
    public partial class FrmBorclar : Form
    {
        public FrmBorclar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DELLG5-5505;Initial Catalog=Apartman;Integrated Security=True");
        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KisiBilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["borclar"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void FrmBorclar_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void FrmBorclar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
