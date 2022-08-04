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

namespace Çamaşırhane_Otomasyonu
{
    public partial class Form_Idare_Ogrenciler : Form
    {
        public Form_Idare_Ogrenciler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9HI19T4\MSSQLSERVERRO;Initial Catalog=db_CamasirhaneOtomasyonu;Integrated Security=True");

        private void Form_Idare_Ogrenciler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnOgrenciEkle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tablo_Ogrenciler(ogrenci_AD, ogrenci_SOYAD, ogrenci_NO) values (@ogrenci_AD, @ogrenci_SOYAD, @ogrenci_NO)", baglanti);

            baglanti.Open();

            komut.Parameters.AddWithValue("@ogrenci_AD", txtOgrenciAd.Text);
            komut.Parameters.AddWithValue("@ogrenci_SOYAD", txtOgrenciSoyad.Text);
            komut.Parameters.AddWithValue("@ogrenci_NO", txtOgrenciNo.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            txtOgrenciAd.Text = "";
            txtOgrenciSoyad.Text = "";
            txtOgrenciNo.Text = "";

            Listele();

        }

        void Listele()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_Ogrenciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewOgrenci.DataSource = dt;

            baglanti.Close();
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tablo_Ogrenciler set ogrenci_AD=@ogrenci_AD, ogrenci_SOYAD=@ogrenci_SOYAD, ogrenci_NO=@ogrenci_NO where ogrenci_ID=@ogrenci_ID", baglanti);

            komut.Parameters.AddWithValue("@ogrenci_ID", Convert.ToInt32(lblOgrenciID.Text));
            komut.Parameters.AddWithValue("@ogrenci_AD", txtOgrenciAd.Text);
            komut.Parameters.AddWithValue("@ogrenci_SOYAD", txtOgrenciSoyad.Text);
            komut.Parameters.AddWithValue("@ogrenci_NO", txtOgrenciNo.Text);
          
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            Listele();

            MessageBox.Show("Güncelleme İşlemi Tamamlandı!");
        }

        private void datagridviewOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblOgrenciID.Text = datagridviewOgrenci.CurrentRow.Cells[0].Value.ToString();
            txtOgrenciAd.Text = datagridviewOgrenci.CurrentRow.Cells[1].Value.ToString();
            txtOgrenciSoyad.Text = datagridviewOgrenci.CurrentRow.Cells[2].Value.ToString();
            txtOgrenciNo.Text = datagridviewOgrenci.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tablo_Ogrenciler where ogrenci_ID=@ogrenci_ID", baglanti);

            komut.Parameters.AddWithValue("@ogrenci_ID", Convert.ToInt32(lblOgrenciID.Text));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            Listele();

            MessageBox.Show("Silme İşlemi Tamamlandı!");
        }
    }
}
