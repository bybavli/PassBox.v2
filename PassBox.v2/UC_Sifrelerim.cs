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
    public partial class UC_Sifrelerim : UserControl
    {
        public UC_Sifrelerim()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        // Listeleme ve Arama Metodu
        private void SifreleriGetir(string aranan = "")
        {
            try
            {
                SqlCommand komut = new SqlCommand("sp_SifreAra", bgl.Baglanti());
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ArananKelime", aranan);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridSifreler.DataSource = dt;


                // 1. ID'yi Gizle 
                if (gridSifreler.Columns["SifreID"] != null)
                    gridSifreler.Columns["SifreID"].Visible = false;

                if (gridSifreler.Columns["KategoriID"] != null)
                    gridSifreler.Columns["KategoriID"].Visible = false;

                // 3. Şifreli Veriyi Gizle 
                if (gridSifreler.Columns["SifreliVeri"] != null)
                    gridSifreler.Columns["SifreliVeri"].Visible = false;

                // 4. Sütun Başlıklarını Düzenle 
                if (gridSifreler.Columns["PlatformAdi"] != null)
                    gridSifreler.Columns["PlatformAdi"].HeaderText = "Platform";

                if (gridSifreler.Columns["KullaniciAdi"] != null)
                    gridSifreler.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";

                bgl.Baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste hatası: " + ex.Message);
            }
        }

        
        private void UC_Sifrelerim_Load(object sender, EventArgs e)
        {
            SifreleriGetir();
        }

       
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            SifreleriGetir(txtArama.Text);
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            // Ekleme formunu aç
            Frm_SifreEkle ekle = new Frm_SifreEkle();
            ekle.ShowDialog(); 

            SifreleriGetir();

        }

        private void şİFREYİKOPYALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridSifreler.SelectedRows.Count > 0)
            {
                try
                {
                    // 1. Şifreli veriyi al
                    string veritabanindakiSifre = gridSifreler.SelectedRows[0].Cells["SifreliVeri"].Value.ToString();

                    string gercekSifre = Sifreleme.Coz(veritabanindakiSifre);

                    // 3. Çözülmüş halini kopyala
                    Clipboard.SetText(gercekSifre);

                    MessageBox.Show("Şifre çözüldü ve kopyalandı! 🔓", "Güvenlik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Şifre çözülemedi! Veri bozuk olabilir.");
                }
            }
        }

        private void kULLANICIADINIKOPYALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridSifreler.SelectedRows.Count > 0)
            {
                string kAdi = gridSifreler.SelectedRows[0].Cells["KullaniciAdi"].Value.ToString();

                Clipboard.SetText(kAdi);
                MessageBox.Show("Kullanıcı adı kopyalandı! 👤");
            }
        }

        private void vERİYİSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridSifreler.SelectedRows.Count > 0)
            {
                // 2. Güvenlik Sorusu 
                DialogResult cevap = MessageBox.Show("Bu kaydı kalıcı olarak silmek istediğine emin misin?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(gridSifreler.SelectedRows[0].Cells["SifreID"].Value);
                        SqlCommand log = new SqlCommand("sp_LogEkle", bgl.Baglanti());
                        log.CommandType = CommandType.StoredProcedure;
                        log.Parameters.AddWithValue("@IslemTuru", "Kayıt Silindi");
                        log.Parameters.AddWithValue("@Aciklama", " şifre kaydı silindi.");
                        log.Parameters.AddWithValue("@SifreID", id);
                        log.ExecuteNonQuery();
                        bgl.Baglanti().Close();

                        SqlCommand komut = new SqlCommand("sp_SifreSil", bgl.Baglanti());
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@SifreID", id);
                        komut.ExecuteNonQuery();
                        bgl.Baglanti().Close();

                        // 6. Listeyi Yenile
                        SifreleriGetir();

                        MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme hatası: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }
    }
}
