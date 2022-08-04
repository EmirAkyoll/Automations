using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Personel_Kayıt_Otomasyonu
{
    public partial class frmGrafikler : Form
    {
        public frmGrafikler()
        {
            InitializeComponent();
        }
        
        

        int tek_defa = 0;

        private void btnCNSYT_MouseMove(object sender, MouseEventArgs e)
        {
            btnCNSYT.BackColor = Color.LightSteelBlue;
        }
        private void btnCNSYT_MouseLeave(object sender, EventArgs e)
        {
            btnCNSYT.BackColor = Color.Gainsboro;
        }

        private void btnYAŞ_MouseMove(object sender, MouseEventArgs e)
        {
            btnYAŞ.BackColor = Color.LightSteelBlue;
        }
        private void btnYAŞ_MouseLeave(object sender, EventArgs e)
        {
            btnYAŞ.BackColor = Color.Gainsboro;
        }

        private void btnMDNDRM_MouseMove(object sender, MouseEventArgs e)
        {
            btnMDNDRM.BackColor = Color.LightSteelBlue;
        }
        private void btnMDNDRM_MouseLeave(object sender, EventArgs e)
        {
            btnMDNDRM.BackColor = Color.Gainsboro;
        }

        private void btnMSLK_MouseMove(object sender, MouseEventArgs e)
        {
            btnMSLK.BackColor = Color.LightSteelBlue;
        }
        private void btnMSLK_MouseLeave(object sender, EventArgs e)
        {
            btnMSLK.BackColor = Color.Gainsboro;
        }

        private void btnMAAŞ_MouseMove(object sender, MouseEventArgs e)
        {
            btnMAAŞ.BackColor = Color.LightSteelBlue;
        }
        private void btnMAAŞ_MouseLeave(object sender, EventArgs e)
        {
            btnMAAŞ.BackColor = Color.Gainsboro;
        }

        int tek_defa_kontrolu1 = 0,
            tek_defa_kontrolu2 = 0,
            tek_defa_kontrolu4 = 0,
            tek_defa_kontrolu5 = 0,
            tek_defa_kontrolu6 = 0;

        

        public int erkek_sayisi = 0,
                   kadin_sayisi = 0,
                   yas_20alti = 0,
                   yas_21_40 = 0,
                   yas_41_64 = 0,
                   yas_65ustu = 0,
                   evli_sayisi = 0,
                   bekar_sayisi = 0,
                   ik_sayisi = 0,
                   muhendis_sayisi = 0,
                   ustabasi_sayisi = 0,
                   tekniker_sayisi = 0,
                   teknisyen_sayisi = 0,
                   stajyer_sayisi = 0,
                   maas_1000alti = 0,
                   maas_1000_3500 = 0,
                   maas_3500_6000 = 0,
                   maas_6000_7500 = 0,
                   maas_7500ustu = 0;

       

        private void btnCNSYT_Click_1(object sender, EventArgs e)
        {
            lblTPLM.Visible = true;
            lbltoplam.Visible = true;

            tek_defa++;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            chartMaaş.Visible = false;
            chartMeslek.Visible = false;
            charttMedeniDurum.Visible = false;
            chartDoğumYeri.Visible = false;
            chartYAŞ.Visible = false;
            chartCNSYT.Visible = true;

            if (tek_defa == 1 && tek_defa_kontrolu1 < 1)
            {
                chartCNSYT.Series["cinsiyet"].Points.AddXY("Erkek("+erkek_sayisi+")", erkek_sayisi);
                chartCNSYT.Series["cinsiyet"].Points.AddXY("Kadın("+kadin_sayisi+")", kadin_sayisi);
            }

            tek_defa--;
            tek_defa_kontrolu1++;
        }


        private void btnYAŞ_Click_1(object sender, EventArgs e)
        {
            lblTPLM.Visible = true;
            lbltoplam.Visible = true;

            tek_defa++;

            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            chartMaaş.Visible = false;
            chartMeslek.Visible = false;
            charttMedeniDurum.Visible = false;
            chartDoğumYeri.Visible = false; ;
            chartCNSYT.Visible = false;
            chartYAŞ.Visible = true;

            if (tek_defa == 1 && tek_defa_kontrolu2 < 1)
            {
                if (yas_20alti > 0)
                    chartYAŞ.Series["yaş"].Points.AddXY("20- (" + yas_20alti + ")", yas_20alti);
                
                if (yas_21_40 > 0)
                    chartYAŞ.Series["yaş"].Points.AddXY("21-40 (" + yas_21_40 + ")", yas_21_40);
                
                if (yas_41_64 > 0)
                    chartYAŞ.Series["yaş"].Points.AddXY("41-64 (" + yas_41_64 + ")", yas_41_64);

                if (yas_65ustu > 0)
                    chartYAŞ.Series["yaş"].Points.AddXY("65+ (" + yas_65ustu + ")", yas_65ustu);
                
            }

            tek_defa--;
            tek_defa_kontrolu2++;
        }

        


        private void btnMDNDRM_Click(object sender, EventArgs e)
        {
            lblTPLM.Visible = false;
            lbltoplam.Visible = false;
            labeltoplam.Visible = true;
            labelTPLM.Visible = true;

            tek_defa++;

            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            chartMaaş.Visible = false;
            chartMeslek.Visible = false;
            chartCNSYT.Visible = false;
            chartYAŞ.Visible = false;
            chartDoğumYeri.Visible = false;
            charttMedeniDurum.Visible = true;

            if (tek_defa == 1 && tek_defa_kontrolu4 < 1)
            {
                charttMedeniDurum.Series["medenidurum"].Points.AddXY("Evli ("+evli_sayisi+")", evli_sayisi);
                charttMedeniDurum.Series["medenidurum"].Points.AddXY("Bekar ("+bekar_sayisi+")", bekar_sayisi);
            }

            tek_defa--;
            tek_defa_kontrolu4++;
        }

        private void btnMSLK_Click(object sender, EventArgs e)
        {
            lblTPLM.Visible = true;
            lbltoplam.Visible = true;

            tek_defa++;

            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            chartMaaş.Visible = false;
            chartCNSYT.Visible = false;
            chartYAŞ.Visible = false;
            chartDoğumYeri.Visible = false;
            charttMedeniDurum.Visible = false;
            chartMeslek.Visible = true;

            if (tek_defa == 1 && tek_defa_kontrolu5 < 1)
            {
                if (ik_sayisi > 0)
                    chartMeslek.Series["meslek"].Points.AddXY("İnsan Kaynakları("+ik_sayisi+")", ik_sayisi);
                
                if (muhendis_sayisi > 0)
                    chartMeslek.Series["meslek"].Points.AddXY("Mühendis("+muhendis_sayisi+")", muhendis_sayisi);
                
                if (ustabasi_sayisi > 0)
                    chartMeslek.Series["meslek"].Points.AddXY("Usta Başı("+ustabasi_sayisi+")", ustabasi_sayisi);
                
                if (tekniker_sayisi > 0)
                    chartMeslek.Series["meslek"].Points.AddXY("Tekniker("+tekniker_sayisi+")", tekniker_sayisi);
                
                if (teknisyen_sayisi > 0)
                    chartMeslek.Series["meslek"].Points.AddXY("Teknisyen("+teknisyen_sayisi+")", teknisyen_sayisi);
                
                if (stajyer_sayisi > 0)
                    chartMeslek.Series["meslek"].Points.AddXY("Stajyer("+stajyer_sayisi+")", stajyer_sayisi);
                
                
            }

            tek_defa--;
            tek_defa_kontrolu5++;
        }

        private void btnMAAŞ_Click(object sender, EventArgs e)
        {
            lblTPLM.Visible = true;
            lbltoplam.Visible = true;

            tek_defa++;

            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            chartCNSYT.Visible = false;
            chartYAŞ.Visible = false;
            chartDoğumYeri.Visible = false;
            charttMedeniDurum.Visible = false;
            chartMeslek.Visible = false;
            chartMaaş.Visible = true;

            if (tek_defa == 1 && tek_defa_kontrolu6 < 1)
            {
                if (maas_1000alti > 0)
                  chartMaaş.Series["maaş"].Points.AddXY("1000- (" + maas_1000alti + ")", maas_1000alti);
                
                if (maas_1000_3500 > 0)
                    chartMaaş.Series["maaş"].Points.AddXY("1000-3500 (" + maas_1000_3500 + ")", maas_1000_3500);
                
                if (maas_3500_6000 > 0)
                    chartMaaş.Series["maaş"].Points.AddXY("3500-6000 (" + maas_3500_6000 + ")", maas_3500_6000);
                
                if (maas_6000_7500 > 0)
                    chartMaaş.Series["maaş"].Points.AddXY("6000-7500 (" + maas_6000_7500 + ")", maas_6000_7500);
                
                if (maas_7500ustu > 0)
                    chartMaaş.Series["maaş"].Points.AddXY("7500+ (" + maas_7500ustu + ")", maas_7500ustu);
                
            }

            tek_defa--;
            tek_defa_kontrolu6++;
        }
    }
}
