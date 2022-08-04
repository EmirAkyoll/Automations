using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çamaşırhane_Otomasyonu
{
    public partial class Form_Idareci_Paneli : Form
    {
        public Form_Idareci_Paneli()
        {
            InitializeComponent();
        }

        private void btn_idari_MouseHover(object sender, EventArgs e)
        {
            btn_idari.BackColor = Color.DarkBlue;
            btn_idari.ForeColor = Color.White;
        }
        private void btn_idari_MouseLeave(object sender, EventArgs e)
        {
            btn_idari.BackColor = Color.White;
            btn_idari.ForeColor = Color.DarkBlue;
        }

        private void btn_personel_MouseHover(object sender, EventArgs e)
        {
            btn_personel.BackColor = Color.DarkBlue;
            btn_personel.ForeColor = Color.White;
        }
        private void btn_personel_MouseLeave(object sender, EventArgs e)
        {
            btn_personel.BackColor = Color.White;
            btn_personel.ForeColor = Color.DarkBlue;
        }

        private void btn_ogrenci_MouseHover(object sender, EventArgs e)
        {
            btn_ogrenci.BackColor = Color.DarkBlue;
            btn_ogrenci.ForeColor = Color.White;
        }
        private void btn_ogrenci_MouseLeave(object sender, EventArgs e)
        {
            btn_ogrenci.BackColor = Color.White;
            btn_ogrenci.ForeColor = Color.DarkBlue;
        }

        private void btn_kayitlar_MouseHover(object sender, EventArgs e)
        {
            btn_kayitlar.BackColor = Color.DarkBlue;
            btn_kayitlar.ForeColor = Color.White;
        }
        private void btn_kayitlar_MouseLeave(object sender, EventArgs e)
        {
            btn_kayitlar.BackColor = Color.White;
            btn_kayitlar.ForeColor = Color.DarkBlue;
        }

        private void btn_kayitlar_Click(object sender, EventArgs e)
        {
            Form_Idare_Kayitlar form_Idare_Kayitlar = new Form_Idare_Kayitlar();
            form_Idare_Kayitlar.Visible = true;
            this.Hide();
        }

        private void btn_idari_Click(object sender, EventArgs e)
        {
            Form_Idare_Idareciler form_Idare_Idareciler = new Form_Idare_Idareciler();
            form_Idare_Idareciler.Visible = true;
        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            Form_Idare_Personeller form_Idare_Personeller = new Form_Idare_Personeller();
            form_Idare_Personeller.Visible = true;
        }

        private void btn_ogrenci_Click(object sender, EventArgs e)
        {
            Form_Idare_Ogrenciler form_Idare_Ogrenciler = new Form_Idare_Ogrenciler();
            form_Idare_Ogrenciler.Visible = true;
        }
    }
}
