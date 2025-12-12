using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PassBox.v2
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void SayfaGetir(UserControl sayfa)
        {
            pnlAnaAlan.Controls.Clear(); // Eskiyi temizle
            sayfa.Dock = DockStyle.Fill; // Yeni sayfayı sığdır
            sayfa.BringToFront();        // Öne getir
            pnlAnaAlan.Controls.Add(sayfa);
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            // Program açılınca otomatik olarak Dashboard gelsin
            btnDashboard.PerformClick();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new UC_Dashboard();
            SayfaGetir(dashboard);
        }

        private void btnSifreler_Click(object sender, EventArgs e)
        {
            UC_Sifrelerim sifreSayfasi = new UC_Sifrelerim();
            SayfaGetir(sifreSayfasi);
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            UC_Kategoriler kategoriSayfasi = new UC_Kategoriler();
            SayfaGetir(kategoriSayfasi);
        }

        private void btnLoglar_Click(object sender, EventArgs e)
        {
            UC_Loglar logSayfasi = new UC_Loglar();
            SayfaGetir(logSayfasi);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            UC_Ayarlar ayarSayfasi = new UC_Ayarlar();
            SayfaGetir(ayarSayfasi);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oturumu kapatıp giriş ekranına dönmek istiyor musun?", "Güvenli Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
