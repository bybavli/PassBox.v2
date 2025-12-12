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
    public partial class UC_Loglar : UserControl
    {
        public UC_Loglar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        // 1. LOGLARI GETİRME METODU
        private void LoglariGetir()
        {
            try
            {
                SqlCommand komut = new SqlCommand("sp_LoglariGetir", bgl.Baglanti());
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridLoglar.DataSource = dt;


                // ID'yi Gizle
                if (gridLoglar.Columns["LogID"] != null)
                    gridLoglar.Columns["LogID"].Visible = false;

                // Sütun Genişlik Ayarı 
                if (gridLoglar.Columns["IslemTarihi"] != null)
                {
                    gridLoglar.Columns["IslemTarihi"].Width = 140;
                    gridLoglar.Columns["IslemTarihi"].HeaderText = "Tarih & Saat";
                }

                if (gridLoglar.Columns["IslemTuru"] != null)
                    gridLoglar.Columns["IslemTuru"].HeaderText = "İşlem Türü";

                if (gridLoglar.Columns["Aciklama"] != null)
                    gridLoglar.Columns["Aciklama"].HeaderText = "Açıklama";

                bgl.Baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Log hatası: " + ex.Message);
            }
        }

        private void UC_Loglar_Load(object sender, EventArgs e)
        {
            LoglariGetir();
        }
        //Eski logları temizleme
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eski güvenlik kayıtlarını temizlemek istiyor musun?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand komut = new SqlCommand("sp_LoglariTemizle", bgl.Baglanti());
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.ExecuteNonQuery();
                    bgl.Baglanti().Close();

                    MessageBox.Show("Eski kayıtlar silindi.");
                    LoglariGetir(); // Yenile
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
