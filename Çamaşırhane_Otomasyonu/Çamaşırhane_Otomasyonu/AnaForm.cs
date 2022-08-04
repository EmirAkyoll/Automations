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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            kirmizi_carpi.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            kirmizi_carpi.Visible = false;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_Idareci_Paneli form_Idareci_Paneli = new Form_Idareci_Paneli();
            form_Idareci_Paneli.Visible = true;
        }
        private void lbl_idareci_giris_Click(object sender, EventArgs e)
        {
            Form_Idareci_Paneli form_Idareci_Paneli = new Form_Idareci_Paneli();
            form_Idareci_Paneli.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form_Personel_Paneli form_Persnonel_Paneli = new Form_Personel_Paneli();
            form_Persnonel_Paneli.Visible = true;
        }
        private void lbl_personel_giris_Click(object sender, EventArgs e)
        {
            Form_Personel_Paneli form_Persnonel_Paneli = new Form_Personel_Paneli();
            form_Persnonel_Paneli.Visible = true;
        }
    }
}
