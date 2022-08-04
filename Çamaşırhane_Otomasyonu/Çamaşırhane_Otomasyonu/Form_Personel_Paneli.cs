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
    public partial class Form_Personel_Paneli : Form
    {
        public Form_Personel_Paneli()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9HI19T4\MSSQLSERVERRO;Initial Catalog=db_CamasirhaneOtomasyonu;Integrated Security=True");

        int btn_islemi_sayaci = 0;

        private void btn_islemi_Click(object sender, EventArgs e)
        {
            if (btn_islemi_sayaci == 0)
            {
                kirmizi_lamba.Visible = false;
                this.lbl_lamba_bilgisi.Location = new Point(652, 103);
                lbl_lamba_bilgisi.ForeColor = Color.Yellow;
                lbl_lamba_bilgisi.Text = "Yıkama Yapılıyor";
                this.btn_islemi.BackColor = Color.Yellow;
                btn_islemi.Text = "İşlem Sürüyor..";
                timer1.Start();
            }
            else if (btn_islemi_sayaci == 1)
            {
                kirmizi_lamba.Visible = false;
                this.lbl_lamba_bilgisi.Location = new Point(652, 103);
                lbl_lamba_bilgisi.ForeColor = Color.Yellow;
                lbl_lamba_bilgisi.Text = "Kurutma Yapılıyor";
                this.btn_islemi.BackColor = Color.Yellow;
                btn_islemi.Text = "İşlem Sürüyor..";
                timer2.Start();
            }
            else if (btn_islemi_sayaci == 2)
            {
                SqlCommand komut = new SqlCommand("insert into tablo_Is_Kayitlari(is_tarihi,personel,ogrenci) values (@is_tarihi,@personel,@ogrenci)", baglanti);

               
                    baglanti.Open();
                komut.Parameters.AddWithValue("@is_tarihi", txtTarih.Text);
                komut.Parameters.AddWithValue("@personel", txtIslemciPersonel.Text);
                komut.Parameters.AddWithValue("@ogrenci", txtOgrenciYurtNo.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                this.Close();
               

                btn_islemi_sayaci = 0;
            }
            else
            {
                btn_islemi_sayaci = 0; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            btn_islemi_sayaci = btn_islemi_sayaci + 1;
            btn_islemi.Text = "Kurutmayı Başlat";
            btn_islemi.BackColor = Color.Aqua;
            this.lbl_lamba_bilgisi.Location = new Point(643, 103);
            lbl_lamba_bilgisi.Text = "Kurutma Bekleniyor";
            MessageBox.Show("YIKAMA İŞLEMİ TAMAMLANDI, LÜTFEN KURUTMA İŞLEMİNİ BAŞLATINIZ!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            btn_islemi_sayaci = btn_islemi_sayaci + 1;
            sari_lamba.Visible = false;
            btn_islemi.Text = "İşlemi Tamamla";
            btn_islemi.BackColor = Color.Green;
            btn_islemi.ForeColor = Color.White;
            this.lbl_lamba_bilgisi.Location = new Point(643, 103);
            lbl_lamba_bilgisi.ForeColor = Color.LightGreen;
            lbl_lamba_bilgisi.Text = "İşlemi Tamamlayınız";
            MessageBox.Show("YIKAMA VE KURUTMA İŞLEMLERİ BAŞARIYLA TAMAMLANDİ KAYITLARA EKLEMEK İÇİN 'İŞLEMİ TAMAMLA'YI TIKLATINIZ");

           
        }
    }
}
