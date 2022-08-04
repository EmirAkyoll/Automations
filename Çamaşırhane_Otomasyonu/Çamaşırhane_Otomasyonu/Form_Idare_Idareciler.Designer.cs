
namespace Çamaşırhane_Otomasyonu
{
    partial class Form_Idare_Idareciler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Idare_Idareciler));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdariKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtIdariSoyad = new System.Windows.Forms.TextBox();
            this.txtIdariAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.datagridviewIdari = new System.Windows.Forms.DataGridView();
            this.idareci_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idareci_AD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idareci_SOYAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idareci_KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idareci_Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIdariGuncelle = new System.Windows.Forms.Button();
            this.btnIdariSil = new System.Windows.Forms.Button();
            this.btnIdariEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdariSifre = new System.Windows.Forms.TextBox();
            this.lblIdariID = new System.Windows.Forms.Label();
            this.timerIdari = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewIdari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "KULLANICI ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "AD:";
            // 
            // txtIdariKullaniciAdi
            // 
            this.txtIdariKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdariKullaniciAdi.Location = new System.Drawing.Point(321, 189);
            this.txtIdariKullaniciAdi.Name = "txtIdariKullaniciAdi";
            this.txtIdariKullaniciAdi.Size = new System.Drawing.Size(198, 31);
            this.txtIdariKullaniciAdi.TabIndex = 3;
            // 
            // txtIdariSoyad
            // 
            this.txtIdariSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdariSoyad.Location = new System.Drawing.Point(321, 125);
            this.txtIdariSoyad.Name = "txtIdariSoyad";
            this.txtIdariSoyad.Size = new System.Drawing.Size(198, 31);
            this.txtIdariSoyad.TabIndex = 2;
            // 
            // txtIdariAd
            // 
            this.txtIdariAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdariAd.Location = new System.Drawing.Point(321, 68);
            this.txtIdariAd.Name = "txtIdariAd";
            this.txtIdariAd.Size = new System.Drawing.Size(198, 31);
            this.txtIdariAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 33);
            this.label1.TabIndex = 66;
            this.label1.Text = "- İdari Personel İşlemleri -";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // datagridviewIdari
            // 
            this.datagridviewIdari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewIdari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewIdari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idareci_ID,
            this.idareci_AD,
            this.idareci_SOYAD,
            this.idareci_KullaniciAdi,
            this.idareci_Sifre});
            this.datagridviewIdari.Location = new System.Drawing.Point(2, 309);
            this.datagridviewIdari.Name = "datagridviewIdari";
            this.datagridviewIdari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewIdari.Size = new System.Drawing.Size(557, 180);
            this.datagridviewIdari.TabIndex = 59;
            this.datagridviewIdari.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewIdari_CellEnter);
            // 
            // idareci_ID
            // 
            this.idareci_ID.DataPropertyName = "idareci_ID";
            this.idareci_ID.HeaderText = "İdareci ID";
            this.idareci_ID.Name = "idareci_ID";
            // 
            // idareci_AD
            // 
            this.idareci_AD.DataPropertyName = "idareci_AD";
            this.idareci_AD.HeaderText = "İdareci AD";
            this.idareci_AD.Name = "idareci_AD";
            // 
            // idareci_SOYAD
            // 
            this.idareci_SOYAD.DataPropertyName = "idareci_SOYAD";
            this.idareci_SOYAD.HeaderText = "İdareci SOYAD";
            this.idareci_SOYAD.Name = "idareci_SOYAD";
            // 
            // idareci_KullaniciAdi
            // 
            this.idareci_KullaniciAdi.DataPropertyName = "idareci_KullaniciAdi";
            this.idareci_KullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.idareci_KullaniciAdi.Name = "idareci_KullaniciAdi";
            // 
            // idareci_Sifre
            // 
            this.idareci_Sifre.DataPropertyName = "idareci_Sifre";
            this.idareci_Sifre.HeaderText = "Şifre";
            this.idareci_Sifre.Name = "idareci_Sifre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnIdariGuncelle
            // 
            this.btnIdariGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIdariGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdariGuncelle.Location = new System.Drawing.Point(71, 146);
            this.btnIdariGuncelle.Name = "btnIdariGuncelle";
            this.btnIdariGuncelle.Size = new System.Drawing.Size(193, 50);
            this.btnIdariGuncelle.TabIndex = 61;
            this.btnIdariGuncelle.Text = "GÜNCELLE";
            this.btnIdariGuncelle.UseVisualStyleBackColor = false;
            this.btnIdariGuncelle.Click += new System.EventHandler(this.btnIdariGuncelle_Click);
            // 
            // btnIdariSil
            // 
            this.btnIdariSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIdariSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdariSil.Location = new System.Drawing.Point(71, 229);
            this.btnIdariSil.Name = "btnIdariSil";
            this.btnIdariSil.Size = new System.Drawing.Size(193, 48);
            this.btnIdariSil.TabIndex = 62;
            this.btnIdariSil.Text = "SİL";
            this.btnIdariSil.UseVisualStyleBackColor = false;
            this.btnIdariSil.Click += new System.EventHandler(this.btnIdariSil_Click);
            // 
            // btnIdariEkle
            // 
            this.btnIdariEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIdariEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdariEkle.Location = new System.Drawing.Point(71, 56);
            this.btnIdariEkle.Name = "btnIdariEkle";
            this.btnIdariEkle.Size = new System.Drawing.Size(193, 54);
            this.btnIdariEkle.TabIndex = 60;
            this.btnIdariEkle.Text = "EKLE";
            this.btnIdariEkle.UseVisualStyleBackColor = false;
            this.btnIdariEkle.Click += new System.EventHandler(this.btnIdariEkle_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "ŞİFRE:";
            // 
            // txtIdariSifre
            // 
            this.txtIdariSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdariSifre.Location = new System.Drawing.Point(321, 256);
            this.txtIdariSifre.Name = "txtIdariSifre";
            this.txtIdariSifre.Size = new System.Drawing.Size(198, 31);
            this.txtIdariSifre.TabIndex = 4;
            // 
            // lblIdariID
            // 
            this.lblIdariID.AutoSize = true;
            this.lblIdariID.Location = new System.Drawing.Point(28, 18);
            this.lblIdariID.Name = "lblIdariID";
            this.lblIdariID.Size = new System.Drawing.Size(13, 13);
            this.lblIdariID.TabIndex = 75;
            this.lblIdariID.Text = "..";
            this.lblIdariID.Visible = false;
            // 
            // timerIdari
            // 
            this.timerIdari.Interval = 1;
            this.timerIdari.Tick += new System.EventHandler(this.timerIdari_Tick);
            // 
            // Form_Idare_Idareciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 491);
            this.Controls.Add(this.lblIdariID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdariSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdariKullaniciAdi);
            this.Controls.Add(this.txtIdariSoyad);
            this.Controls.Add(this.txtIdariAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.datagridviewIdari);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIdariGuncelle);
            this.Controls.Add(this.btnIdariSil);
            this.Controls.Add(this.btnIdariEkle);
            this.Name = "Form_Idare_Idareciler";
            this.Text = "İDARE / İDARECİLER";
            this.Load += new System.EventHandler(this.Form_Idare_Idareciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewIdari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdariKullaniciAdi;
        private System.Windows.Forms.TextBox txtIdariSoyad;
        private System.Windows.Forms.TextBox txtIdariAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView datagridviewIdari;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIdariGuncelle;
        private System.Windows.Forms.Button btnIdariSil;
        private System.Windows.Forms.Button btnIdariEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdariSifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idareci_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idareci_AD;
        private System.Windows.Forms.DataGridViewTextBoxColumn idareci_SOYAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn idareci_KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idareci_Sifre;
        private System.Windows.Forms.Label lblIdariID;
        private System.Windows.Forms.Timer timerIdari;
    }
}