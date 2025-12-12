using Windows.Security.Credentials.UI; // Windows Hello Kütüphanesi
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PassBox.v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Butona basınca buton pasif olsun ki üst üste basamasınlar
                btnGiris.Enabled = false;
                btnGiris.Text = "Doğrulanıyor...";

                // --- WINDOWS HELLO ÇAĞRISI ---
                var sonuc = await UserConsentVerifier.RequestVerificationAsync("Kasa Erişimi İçin Lütfen Doğrulayın");

                switch (sonuc)
                {
                    case UserConsentVerificationResult.Verified:
                        MessageBox.Show("Kimlik Doğrulandı! Hoşgeldiniz.", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AnaSayfa ana = new AnaSayfa();
                        ana.Show();
                        this.Hide(); // Giriş ekranını gizle
                        break;
                        

                    case UserConsentVerificationResult.DeviceNotPresent:
                        MessageBox.Show("Bu cihazda Windows Hello (Kamera/Parmak izi) bulunamadı.\nLütfen Windows ayarlarından PIN ayarlayın.", "Donanım Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case UserConsentVerificationResult.Canceled:
                        // İptal ettiyse bir şey yapma
                        break;

                    case UserConsentVerificationResult.DisabledByPolicy:
                        MessageBox.Show("Windows Hello bu bilgisayarda devre dışı bırakılmış.", "Hata");
                        break;

                    default:
                        MessageBox.Show("Doğrulama yapılamadı.", "Hata");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // İşlem bitince butonu eski haline getir
                btnGiris.Enabled = true;
                btnGiris.Text = "GÜVENLİ GİRİŞ (YÜZ/PARMAK)";
            }
        }
    }
}
