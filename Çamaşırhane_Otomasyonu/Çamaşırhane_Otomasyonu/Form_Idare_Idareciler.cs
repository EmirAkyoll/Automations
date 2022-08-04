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
    public partial class Form_Idare_Idareciler : Form
    {
        public Form_Idare_Idareciler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9HI19T4\MSSQLSERVERRO;Initial Catalog=db_CamasirhaneOtomasyonu;Integrated Security=True");

        private void Form_Idare_Idareciler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_Idareciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewIdari.DataSource = dt;

            baglanti.Close();

            timerIdari.Start();
        }

        private void timerIdari_Tick(object sender, EventArgs e)
        {
            txtIdariAd.Text = "";
            txtIdariSoyad.Text = "";
            txtIdariKullaniciAdi.Text = "";
            txtIdariSifre.Text = "";

            timerIdari.Stop();
        }

        private void datagridviewIdari_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblIdariID.Text = datagridviewIdari.CurrentRow.Cells[0].Value.ToString();
            txtIdariAd.Text = datagridviewIdari.CurrentRow.Cells[1].Value.ToString();
            txtIdariSoyad.Text = datagridviewIdari.CurrentRow.Cells[2].Value.ToString();
            txtIdariKullaniciAdi.Text = datagridviewIdari.CurrentRow.Cells[3].Value.ToString();
            txtIdariSifre.Text = datagridviewIdari.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnIdariGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tablo_Idareciler set idareci_AD=@idareci_AD, idareci_SOYAD=@idareci_SOYAD, idareci_KullaniciAdi=@idareci_KullaniciAdi, idareci_Sifre=@idareci_Sifre where idareci_ID=@idareci_ID", baglanti);

            komut.Parameters.AddWithValue("@idareci_ID", Convert.ToInt32(lblIdariID.Text));
            komut.Parameters.AddWithValue("@idareci_AD", txtIdariAd.Text);
            komut.Parameters.AddWithValue("@idareci_SOYAD", txtIdariSoyad.Text);
            komut.Parameters.AddWithValue("@idareci_KullaniciAdi", txtIdariKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@idareci_Sifre", txtIdariSifre.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            Listele();

            MessageBox.Show("Güncelleme İşlemi Tamamlandı!");
        }

        private void btnIdariSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tablo_Idareciler where idareci_ID=@idareci_ID", baglanti);

            komut.Parameters.AddWithValue("@idareci_ID", Convert.ToInt32(lblIdariID.Text));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            Listele();

            MessageBox.Show("Silme İşlemi Tamamlandı!");

            txtIdariAd.Text = "";
            txtIdariSoyad.Text = "";
            txtIdariKullaniciAdi.Text = "";
            txtIdariSifre.Text = "";
        }

        void Listele()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_Idareciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewIdari.DataSource = dt;

            baglanti.Close();
        }

        private void btnIdariEkle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tablo_Idareciler(idareci_AD,idareci_SOYAD,idareci_KullaniciAdi,idareci_Sifre) values (@idareci_AD, @idareci_SOYAD, @idareci_KullaniciAdi, @idareci_Sifre)", baglanti);

            baglanti.Open();

            komut.Parameters.AddWithValue("@idareci_AD", txtIdariAd.Text);
            komut.Parameters.AddWithValue("@idareci_SOYAD", txtIdariSoyad.Text);
            komut.Parameters.AddWithValue("@idareci_KullaniciAdi", txtIdariKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@idareci_Sifre", txtIdariSifre.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            txtIdariAd.Text = "";
            txtIdariSoyad.Text = "";
            txtIdariKullaniciAdi.Text = "";
            txtIdariSifre.Text = "";

            Listele();

            MessageBox.Show("Yeni İdari Personel Eklendi!");
        }
    }
}