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
    public partial class Form_Idare_Personeller : Form
    {
        public Form_Idare_Personeller()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9HI19T4\MSSQLSERVERRO;Initial Catalog=db_CamasirhaneOtomasyonu;Integrated Security=True");

        private void Form_Idare_Personeller_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_Personeller", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewPersonel.DataSource = dt;

            baglanti.Close();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tablo_Personeller(personel_AD, personel_SOYAD) values (@personel_AD, @personel_SOYAD)", baglanti);

            baglanti.Open();

            komut.Parameters.AddWithValue("@personel_AD", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@personel_SOYAD", txtPersonelSoyad.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";

            Listele();

            MessageBox.Show("Yeni Personel Eklendi!");
        }

        void Listele()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_Personeller", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewPersonel.DataSource = dt;

            baglanti.Close();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tablo_Personeller set personel_AD=@personel_AD, personel_SOYAD=@personel_SOYAD  where personel_ID=@personel_ID", baglanti);

            komut.Parameters.AddWithValue("@personel_ID", Convert.ToInt32(lblPersonelID.Text));
            komut.Parameters.AddWithValue("@personel_AD", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@personel_SOYAD", txtPersonelSoyad.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            Listele();

            MessageBox.Show("Güncelleme İşlemi Tamamlandı!");
        }

        private void datagridviewPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPersonelID.Text = datagridviewPersonel.CurrentRow.Cells[0].Value.ToString();
            txtPersonelAd.Text = datagridviewPersonel.CurrentRow.Cells[1].Value.ToString();
            txtPersonelSoyad.Text = datagridviewPersonel.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tablo_Personeller where personel_ID=@personel_ID", baglanti);

            komut.Parameters.AddWithValue("@personel_ID", Convert.ToInt32(lblPersonelID.Text));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            Listele();

            MessageBox.Show("Silme İşlemi Tamamlandı!");
        }
    }
}
