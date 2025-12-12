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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void IstatistikleriGetir()
        {
            try
            {
                // 1. Prosedürü Çağır
                SqlCommand komut = new SqlCommand("sp_IstatistikGetir", bgl.Baglanti());
                komut.CommandType = System.Data.CommandType.StoredProcedure;

                // 2. Okumayı Başlat
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {

                    lblToplamSifre.Text = dr[0].ToString();
                    lblToplamKategori.Text = dr[1].ToString();
                    lblToplamLog.Text = dr[2].ToString();
                }

                // Bağlantıyı kapat 
                dr.Close();
                bgl.Baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            IstatistikleriGetir();
        }
        private void lblToplamSifre_Click(object sender, EventArgs e)
        {

        }
    }
}
