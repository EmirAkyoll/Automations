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
    public partial class frmAnaForm : Form
    {
        int id = 0;
        public frmAnaForm()
        {
            InitializeComponent();
        }
       
        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            txtID.Text = id.ToString();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result =  MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?","Çıkış Yap?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void hakkımızdaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmHakkımızda frm2 = new frmHakkımızda();
            frm2.Show();
        }

        ArrayList dogum_yeri_verisi = new ArrayList();

        string cinsiyet = "", medeni_durum = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string id = txtID.Text,
                   ad = txtAD.Text,
                   soyad = txtSoyad.Text,
                   yas = maskedYaş.Text,
                   dogum_yeri = cmbxDoğumYeri.Text,
                   meslek = cmbxMeslek.Text,
                   maas = maskedMaaş.Text;


               cmbxDoğumYeri.Items.Add(dogum_yeri);
               cmbxDoğumYeri.Sorted = true;



            if (seçenekErkek.Checked == true)
            {
                cinsiyet = seçenekErkek.Text;
            }
             
            else if (seçenekKadın.Checked == true) 
            {
                cinsiyet = seçenekKadın.Text;
            }
              
             

            if (seçenekEvli.Checked == true)
            {
                medeni_durum = seçenekEvli.Text;
            }

            else if (seçenekBekar.Checked == true)
            {
                medeni_durum = seçenekBekar.Text;
            }
            

            string[] bilgiler = {id, ad, soyad, cinsiyet, yas, dogum_yeri, medeni_durum, meslek, maas};
            bool kayit_mevcutmu = false;

            for (int i = 0; i < listViewListe.Items.Count; i++)
            {
                if (listViewListe.Items[i].SubItems[0].Text == txtID.Text)
                {
                    kayit_mevcutmu = true;
                    MessageBox.Show("-" + txtID.Text + "- id numaralı personel zaten kayıtlı.","Kayıtlı Eleman", MessageBoxButtons.OK , MessageBoxIcon.Warning);  
                } 
            }


            if (kayit_mevcutmu == false)
            {
                ListViewItem liste = new ListViewItem(bilgiler);

                if (id != "" || ad != "" || soyad != "" || cinsiyet != "" || yas != "" || dogum_yeri != "" || medeni_durum != "" || meslek != "" || maas != "")
                {
                    listViewListe.Items.Add(liste);
                    MessageBox.Show("Yeni personel eklendi.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt bilgilerinde eksiklik bırakmayınız!","Bazı Veriler Eksik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (txtAD.Text != "" || maskedYaş.Text != "" || cmbxMeslek.Text != "")
                    btnTemizle.Enabled = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilen_sayisi = listViewListe.SelectedItems.Count;

            foreach (ListViewItem secilen_kaydin_verileri in listViewListe.SelectedItems)
            {
                secilen_kaydin_verileri.Remove();
            }

            MessageBox.Show(secilen_sayisi.ToString() + " adet kayıt silindi.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            int id_no = Convert.ToInt32(txtID.Text);

            if (txtAD.Text == "" || maskedYaş.Text == "" || cmbxMeslek.Text == "")
            {
                btnTemizle.Enabled = false;
                MessageBox.Show("Hedef alan zaten boş.","",MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }

            txtAD.Text = "";
            txtSoyad.Text = "";
            seçenekErkek.Checked = false;
            seçenekKadın.Checked = false;
            maskedYaş.Text = "";
            cmbxDoğumYeri.Text = "";
            seçenekEvli.Checked = false;
            seçenekBekar.Checked = false;
            cmbxMeslek.Text = "";
            maskedMaaş.Text = "";

            if ((id_no + 1)  == listViewListe.Items.Count)
            {
                id++;
            }

            txtID.Text = id.ToString();
            txtAD.Focus();
       
        }
       

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
              if (txtAD.Text != "" && txtSoyad.Text != "" && maskedYaş.Text != "" && cmbxDoğumYeri.Text != "" && cmbxMeslek.Text != "" && maskedMaaş.Text != "")
                 {

                  int sira_no = Convert.ToInt32(listViewListe.SelectedItems[0].SubItems[0].Text);

                        listViewListe.SelectedItems[0].SubItems[0].Text = txtID.Text;
                        listViewListe.SelectedItems[0].SubItems[1].Text = txtAD.Text;
                        listViewListe.SelectedItems[0].SubItems[2].Text = txtSoyad.Text;
                        if (seçenekErkek.Checked == true)
                        {
                            listViewListe.Items[sira_no].SubItems[3].Text = "Erkek";
                        }
                        if (seçenekKadın.Checked == true)
                        {
                            listViewListe.Items[sira_no].SubItems[3].Text = "Kadın";
                        }
                        listViewListe.SelectedItems[0].SubItems[4].Text = maskedYaş.Text;
                        listViewListe.SelectedItems[0].SubItems[5].Text = cmbxDoğumYeri.Text;
                        if (seçenekEvli.Checked == true)
                        {
                            listViewListe.Items[sira_no].SubItems[6].Text = "Evli";
                        }
                        if (seçenekBekar.Checked == true)
                        {
                            listViewListe.Items[sira_no].SubItems[6].Text = "Bekar";
                        }
                        listViewListe.SelectedItems[0].SubItems[7].Text = cmbxMeslek.Text;
                        listViewListe.SelectedItems[0].SubItems[8].Text = maskedMaaş.Text;
                    }
                    else
                    {
                        MessageBox.Show("Güncellemek istediğiniz personel datasını seçiniz!", "Seçilmemiş Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

            
        }
       
        private void listViewListe_MouseClick(object sender, MouseEventArgs e)
        {
            int sira_no = Convert.ToInt32(listViewListe.SelectedItems[0].SubItems[0].Text);


            txtID.Text = listViewListe.SelectedItems[0].SubItems[0].Text;
            txtAD.Text = listViewListe.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listViewListe.SelectedItems[0].SubItems[2].Text;

            if (listViewListe.Items[sira_no].SubItems[3].Text == "Erkek")
            {
                seçenekErkek.Checked = true;
            }
            else if (listViewListe.Items[sira_no].SubItems[3].Text == "Kadın")
            {
                seçenekKadın.Checked = true;
            }

            maskedYaş.Text = listViewListe.SelectedItems[0].SubItems[4].Text;
            cmbxDoğumYeri.Text = listViewListe.SelectedItems[0].SubItems[5].Text;

            if (listViewListe.Items[sira_no].SubItems[6].Text == "Evli")
            {
                seçenekEvli.Checked = true;
            }
            else if (listViewListe.Items[0].SubItems[6].Text == "Bekar")
            {
                seçenekBekar.Checked = true;
            }

            cmbxMeslek.Text = listViewListe.SelectedItems[0].SubItems[7].Text;
            maskedMaaş.Text = listViewListe.SelectedItems[0].SubItems[8].Text;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewListe.Items.Count; i++)
            {
                listViewListe.Items[i].SubItems[0].Text = i.ToString();  
            }

            btnTemizle.Enabled = true;
        }

        
       
   
        private void btnİstatistikveGrafik_Click(object sender, EventArgs e)
        {
            frmGrafikler frmGra = new frmGrafikler();

         
            for (int i = 0; i < listViewListe.Items.Count; i++)
            {

                if (listViewListe.Items[i].SubItems[3].Text == "Erkek")                  
                    frmGra.erkek_sayisi++;
                
                if (listViewListe.Items[i].SubItems[3].Text == "Kadın")                  
                    frmGra.kadin_sayisi++;
                



                if (Convert.ToInt32(listViewListe.Items[i].SubItems[4].Text) > 0 && (Convert.ToInt32(listViewListe.Items[i].SubItems[4].Text)) <= 20)
                    frmGra.yas_20alti++;
                
                if (Convert.ToInt32(listViewListe.Items[i].SubItems[4].Text) > 20 && (Convert.ToInt32(listViewListe.Items[i].SubItems[4].Text)) <= 40)
                    frmGra.yas_21_40++;
                
                if (Convert.ToInt32(listViewListe.Items[i].SubItems[4].Text) > 40 && (Convert.ToInt32(listViewListe.Items[i].SubItems[4].Text)) <= 64)
                    frmGra.yas_41_64++;
                
                if (Convert.ToInt32(listViewListe.Items[i].SubItems[4].Text) > 64 && (Convert.ToInt32(listViewListe.Items[i].SubItems[4].Text)) <= 999)
                    frmGra.yas_65ustu++;
                

                              


                if (listViewListe.Items[i].SubItems[6].Text == "Evli")
                    frmGra.evli_sayisi++;
                
                if (listViewListe.Items[i].SubItems[6].Text == "Bekar")
                    frmGra.bekar_sayisi++;
                


                if ((listViewListe.Items[i].SubItems[7].Text) == "İnsan Kaynakları")
                    frmGra.ik_sayisi++;
                
                if (listViewListe.Items[i].SubItems[7].Text == "Mühendis")
                    frmGra.muhendis_sayisi++;
                
                if (listViewListe.Items[i].SubItems[7].Text == "Usta Başı")
                    frmGra.ustabasi_sayisi++;
                
                if (listViewListe.Items[i].SubItems[7].Text == "Tekniker")
                    frmGra.tekniker_sayisi++;
                
                if (listViewListe.Items[i].SubItems[7].Text == "Teknisyen")
                    frmGra.teknisyen_sayisi++;
                
                if (listViewListe.Items[i].SubItems[7].Text == "Stajyer")
                    frmGra.stajyer_sayisi++;
                


                if (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text) > 0 && (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text)) <= 1000)
                    frmGra.maas_1000alti++;
                
                if (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text) > 1000 && (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text)) <= 3500)
                    frmGra.maas_1000_3500++;
                
                if (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text) > 3500 && (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text)) <= 6000)
                    frmGra.maas_3500_6000++;
                
                if (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text) > 6000 && (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text)) <= 7500)
                    frmGra.maas_6000_7500++;
                
                if (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text) > 7500 && (Convert.ToInt32(listViewListe.Items[i].SubItems[8].Text)) <= 99999)
                    frmGra.maas_7500ustu++;
                

            }

            frmGra.labeltoplam.Text = listViewListe.Items.Count.ToString();
            frmGra.lbltoplam.Text = listViewListe.Items.Count.ToString();
            frmGra.Show();
            frmGra.lblTPLM.Visible = false;
            frmGra.lbltoplam.Visible = false;
            frmGra.labeltoplam.Visible = false;
            frmGra.labelTPLM.Visible = false;
            frmGra.pictureBox2.Visible = true;
        }
    }
}