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
    public partial class UC_Kategoriler : UserControl
    {
        public UC_Kategoriler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void KategorileriListele()
        {
            try
            {
                SqlCommand komut = new SqlCommand("sp_KategorileriGetir", bgl.Baglanti());
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridKategoriler.DataSource = dt;


                // ID'yi Gizle
                if (gridKategoriler.Columns["KategoriID"] != null)
                    gridKategoriler.Columns["KategoriID"].Visible = false;

                // Başlıkları Türkçeleştir
                if (gridKategoriler.Columns["KategoriAdi"] != null)
                    gridKategoriler.Columns["KategoriAdi"].HeaderText = "Kategori Adı";

                if (gridKategoriler.Columns["RenkKodu"] != null)
                    gridKategoriler.Columns["RenkKodu"].HeaderText = "Renk Kodu";

                bgl.Baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste hatası: " + ex.Message);
            }
        }

        private void UC_Kategoriler_Load(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        //Ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("sp_KategoriEkle", bgl.Baglanti());
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KategoriAdi", txtAd.Text);
                komut.Parameters.AddWithValue("@RenkKodu", txtRenk.Text);
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();

                MessageBox.Show("Kategori eklendi!");
                KategorileriListele();
                txtAd.Clear(); txtRenk.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAd.Tag != null)
            {
                if (MessageBox.Show("Silmek istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("sp_KategoriSil", bgl.Baglanti());
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@KategoriID", int.Parse(txtAd.Tag.ToString()));
                        // Silme işleminden hemen sonra:
                        SqlCommand log = new SqlCommand("sp_LogEkle", bgl.Baglanti());
                        log.CommandType = CommandType.StoredProcedure;
                        log.Parameters.AddWithValue("@IslemTuru", "Kategori Silindi");
                        log.Parameters.AddWithValue("@Aciklama", txtAd.Text + " kategorisi silindi.");

                        log.Parameters.AddWithValue("@KategoriID", int.Parse(txtAd.Tag.ToString()));
                        log.ExecuteNonQuery();
                        komut.ExecuteNonQuery();
                        bgl.Baglanti().Close();

                        KategorileriListele();
                        txtAd.Tag = null; // Hafızayı temizle
                        txtAd.Clear(); txtRenk.Clear();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547) // İlişki hatası
                            MessageBox.Show("Bu kategoriyi silemezsin, içinde şifreler var!");
                        else
                            MessageBox.Show("SQL Hatası: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden silinecek kategoriyi seçin.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Tag != null)
            {
                SqlCommand komut = new SqlCommand("sp_KategoriGuncelle", bgl.Baglanti());
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KategoriID", int.Parse(txtAd.Tag.ToString()));
                komut.Parameters.AddWithValue("@KategoriAdi", txtAd.Text);
                komut.Parameters.AddWithValue("@RenkKodu", txtRenk.Text);
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();

                MessageBox.Show("Güncellendi!");
                KategorileriListele();
            }
        }

        private void gridKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = gridKategoriler.Rows[e.RowIndex];

                txtAd.Text = satir.Cells["KategoriAdi"].Value.ToString();
                txtRenk.Text = satir.Cells["RenkKodu"].Value.ToString();

                txtAd.Tag = satir.Cells["KategoriID"].Value.ToString();
            }
        }

        private void txtRenk_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridKategoriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridKategoriler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridKategoriler.Columns[e.ColumnIndex].Name == "RenkKodu")
            {
                if (e.Value != null)
                {
                    try
                    {
                        string hex = e.Value.ToString();

                        // Renge çevir
                        System.Drawing.Color renk = System.Drawing.ColorTranslator.FromHtml(hex);

                        gridKategoriler.Rows[e.RowIndex].DefaultCellStyle.BackColor = renk;

                        gridKategoriler.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}
