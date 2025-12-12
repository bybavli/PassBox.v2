using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Security.Credentials.UI; // Windows Hello
using Microsoft.Data.SqlClient; // SQL

namespace PassBox.v2
{
    public partial class UC_Ayarlar : UserControl
    {
        public UC_Ayarlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        // ASYNC yapmayı unutma
        private async void btnSifirla_Click(object sender, EventArgs e)
        {
            // 1. Önce kullanıcıyı uyar
            if (MessageBox.Show("DİKKAT! Bu işlem kayıtlı TÜM ŞİFRELERİ, kategorileri ve logları geri getirilemez şekilde silecektir.\n\nDevam etmek istiyor musun?", "Kritik Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                try
                {
                    // 2. Windows Hello ile Son Kontrol (Yüzünü okut!)
                    var sonuc = await UserConsentVerifier.RequestVerificationAsync("Sıfırlama İşlemi İçin Onay Verin");

                    if (sonuc == UserConsentVerificationResult.Verified)
                    {
                        // --- 3. TEMİZLİK BAŞLASIN ---

                        // Önce şifreleri sil (Çünkü kategorilere bağlı)
                        SqlCommand komut1 = new SqlCommand("DELETE FROM Sifreler", bgl.Baglanti());
                        komut1.ExecuteNonQuery();
                        bgl.Baglanti().Close();

                        // Sonra logları sil
                        SqlCommand komut2 = new SqlCommand("TRUNCATE TABLE GuvenlikLoglari", bgl.Baglanti());
                        komut2.ExecuteNonQuery();
                        bgl.Baglanti().Close();

                        // En son kategorileri sil
                        SqlCommand komut3 = new SqlCommand("DELETE FROM Kategoriler", bgl.Baglanti());
                        komut3.ExecuteNonQuery();
                        bgl.Baglanti().Close();

                        MessageBox.Show("Sistem başarıyla sıfırlandı. Uygulama kapatılıyor.", "Temizlendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Doğrulama yapılamadı, işlem iptal edildi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
