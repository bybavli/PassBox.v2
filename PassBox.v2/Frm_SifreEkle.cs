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
    public partial class Frm_SifreEkle : Form
    {
        public Frm_SifreEkle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        // Kategorileri Getirme
        private void KategorileriGetir()
        {
            SqlCommand komut = new SqlCommand("sp_KategorileriGetir", bgl.Baglanti());
            komut.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // ComboBox Ayarları
            cmbKategori.DisplayMember = "KategoriAdi"; // Gözüken
            cmbKategori.ValueMember = "KategoriID";    // Arkadaki ID
            cmbKategori.DataSource = dt;
        }

        private void Frm_SifreEkle_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        //Kaydetme İşlemi
        private void btnKaydet_Click(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (txtPlatform.Text == "" || txtSifre.Text == "")
                {
                    MessageBox.Show("Lütfen en azından Platform ve Şifre girin.");
                    return;
                }

                SqlCommand komut = new SqlCommand("sp_SifreEkle", bgl.Baglanti());
                komut.CommandType = CommandType.StoredProcedure;

                // Verileri gönderiyoruz
                komut.Parameters.AddWithValue("@KategoriID", Convert.ToInt32(cmbKategori.SelectedValue));
                komut.Parameters.AddWithValue("@PlatformAdi", txtPlatform.Text);
                komut.Parameters.AddWithValue("@KullaniciAdi", txtKullanici.Text);
                komut.Parameters.AddWithValue("@Eposta", txtEposta.Text);
                // Şifreyi önce AES ile karıştırıyoruz, sonra SQL'e atıyoruz.
                string guvenliSifre = Sifreleme.Sifrele(txtSifre.Text);
                komut.Parameters.AddWithValue("@SifreliVeri", guvenliSifre);
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();

                // Log Tutma
                SqlCommand log = new SqlCommand("sp_LogEkle", bgl.Baglanti());
                log.CommandType = CommandType.StoredProcedure;
                log.Parameters.AddWithValue("@IslemTuru", "Yeni Şifre");
                log.Parameters.AddWithValue("@Aciklama", txtPlatform.Text + " şifresi eklendi.");
                log.ExecuteNonQuery();
                bgl.Baglanti().Close();

                MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Formu kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            string harfler = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string sayilar = "0123456789";
            string semboller = "!@#$%^&*-_=+?";

            string tumKarakterler = harfler + sayilar + semboller;

            // 2. Rastgele Seçici
            Random rastgele = new Random();
            string yeniSifre = "";

            // 3. 12 Haneli Şifre Oluştur
            for (int i = 0; i < 12; i++)
            {
                int index = rastgele.Next(0, tumKarakterler.Length);
                yeniSifre += tumKarakterler[index];
            }

            txtSifre.Text = yeniSifre;
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            // Oluşturulan şifreyi panoya kopyala(boş değilse)
            if (!string.IsNullOrEmpty(txtSifre.Text))
            {
                Clipboard.SetText(txtSifre.Text);
                MessageBox.Show("Şifre panoya kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

