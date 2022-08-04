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
    public partial class Form_Idare_Kayitlar : Form
    {
        public Form_Idare_Kayitlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9HI19T4\MSSQLSERVERRO;Initial Catalog=db_CamasirhaneOtomasyonu;Integrated Security=True");

        private void Form_Idare_Kayitlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Idare_Kayitlar form_Idare_Kayitlar = new Form_Idare_Kayitlar();
            form_Idare_Kayitlar.Visible = false;
            Form_Idareci_Paneli form_Idareci_Paneli = new Form_Idareci_Paneli();
            form_Idareci_Paneli.Visible = true;
        }

        private void Form_Idare_Kayitlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_Is_Kayitlari", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewKayitlar.DataSource = dt;

            baglanti.Close();
        }
    }
}