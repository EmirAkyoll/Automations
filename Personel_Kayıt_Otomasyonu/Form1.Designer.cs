
namespace Personel_Kayıt_Otomasyonu
{
    partial class frmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.listViewListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnİstatistikveGrafik = new System.Windows.Forms.Button();
            this.grpİşlemler = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblTCKno = new System.Windows.Forms.Label();
            this.lblDoğumYeri = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.grpBilgiler = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.seçenekBekar = new System.Windows.Forms.RadioButton();
            this.seçenekEvli = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seçenekKadın = new System.Windows.Forms.RadioButton();
            this.seçenekErkek = new System.Windows.Forms.RadioButton();
            this.cmbxMeslek = new System.Windows.Forms.ComboBox();
            this.maskedMaaş = new System.Windows.Forms.MaskedTextBox();
            this.cmbxDoğumYeri = new System.Windows.Forms.ComboBox();
            this.maskedYaş = new System.Windows.Forms.MaskedTextBox();
            this.lblMaaş = new System.Windows.Forms.Label();
            this.diğerİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grpİşlemler.SuspendLayout();
            this.grpBilgiler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewListe
            // 
            this.listViewListe.BackColor = System.Drawing.Color.Gainsboro;
            this.listViewListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewListe.FullRowSelect = true;
            this.listViewListe.GridLines = true;
            this.listViewListe.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewListe.HideSelection = false;
            this.listViewListe.Location = new System.Drawing.Point(2, 424);
            this.listViewListe.Name = "listViewListe";
            this.listViewListe.Size = new System.Drawing.Size(961, 176);
            this.listViewListe.TabIndex = 15;
            this.listViewListe.UseCompatibleStateImageBehavior = false;
            this.listViewListe.View = System.Windows.Forms.View.Details;
            this.listViewListe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewListe_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personel ID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Personel AD";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Personel SOYAD";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yaş";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doğum Yeri";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Evli/Bekar";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Meslek";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Maaş";
            this.columnHeader9.Width = 135;
            // 
            // btnListele
            // 
            this.btnListele.ForeColor = System.Drawing.Color.Black;
            this.btnListele.Location = new System.Drawing.Point(6, 34);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(134, 35);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Yenile";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(6, 74);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(134, 35);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(6, 115);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 35);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(6, 156);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(134, 35);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGüncelle.Location = new System.Drawing.Point(6, 197);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(134, 39);
            this.btnGüncelle.TabIndex = 13;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnİstatistikveGrafik
            // 
            this.btnİstatistikveGrafik.ForeColor = System.Drawing.Color.Black;
            this.btnİstatistikveGrafik.Location = new System.Drawing.Point(6, 242);
            this.btnİstatistikveGrafik.Name = "btnİstatistikveGrafik";
            this.btnİstatistikveGrafik.Size = new System.Drawing.Size(134, 65);
            this.btnİstatistikveGrafik.TabIndex = 14;
            this.btnİstatistikveGrafik.Text = "İstatistik ve Grafikler";
            this.btnİstatistikveGrafik.UseVisualStyleBackColor = true;
            this.btnİstatistikveGrafik.Click += new System.EventHandler(this.btnİstatistikveGrafik_Click);
            // 
            // grpİşlemler
            // 
            this.grpİşlemler.BackColor = System.Drawing.Color.Transparent;
            this.grpİşlemler.Controls.Add(this.btnListele);
            this.grpİşlemler.Controls.Add(this.btnİstatistikveGrafik);
            this.grpİşlemler.Controls.Add(this.btnKaydet);
            this.grpİşlemler.Controls.Add(this.btnGüncelle);
            this.grpİşlemler.Controls.Add(this.btnSil);
            this.grpİşlemler.Controls.Add(this.btnTemizle);
            this.grpİşlemler.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpİşlemler.ForeColor = System.Drawing.Color.White;
            this.grpİşlemler.Location = new System.Drawing.Point(774, 63);
            this.grpİşlemler.Name = "grpİşlemler";
            this.grpİşlemler.Size = new System.Drawing.Size(146, 321);
            this.grpİşlemler.TabIndex = 2;
            this.grpİşlemler.TabStop = false;
            this.grpİşlemler.Text = "İşlemler";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(95, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 20);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID:";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.BackColor = System.Drawing.Color.Transparent;
            this.lblAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAD.ForeColor = System.Drawing.Color.White;
            this.lblAD.Location = new System.Drawing.Point(89, 80);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(36, 20);
            this.lblAD.TabIndex = 9;
            this.lblAD.Text = "AD:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.ForeColor = System.Drawing.Color.White;
            this.lblSoyad.Location = new System.Drawing.Point(55, 116);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(70, 20);
            this.lblSoyad.TabIndex = 10;
            this.lblSoyad.Text = "SOYAD:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.White;
            this.lblCinsiyet.Location = new System.Drawing.Point(13, 6);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(87, 20);
            this.lblCinsiyet.TabIndex = 3;
            this.lblCinsiyet.Text = "CİNSİYET:";
            // 
            // lblTCKno
            // 
            this.lblTCKno.AutoSize = true;
            this.lblTCKno.BackColor = System.Drawing.Color.Transparent;
            this.lblTCKno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCKno.ForeColor = System.Drawing.Color.White;
            this.lblTCKno.Location = new System.Drawing.Point(79, 188);
            this.lblTCKno.Name = "lblTCKno";
            this.lblTCKno.Size = new System.Drawing.Size(46, 20);
            this.lblTCKno.TabIndex = 12;
            this.lblTCKno.Text = "YAŞ:";
            // 
            // lblDoğumYeri
            // 
            this.lblDoğumYeri.AutoSize = true;
            this.lblDoğumYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblDoğumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoğumYeri.ForeColor = System.Drawing.Color.White;
            this.lblDoğumYeri.Location = new System.Drawing.Point(7, 224);
            this.lblDoğumYeri.Name = "lblDoğumYeri";
            this.lblDoğumYeri.Size = new System.Drawing.Size(118, 20);
            this.lblDoğumYeri.TabIndex = 13;
            this.lblDoğumYeri.Text = "DOĞUM YERİ:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.BackColor = System.Drawing.Color.Transparent;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.ForeColor = System.Drawing.Color.White;
            this.lblDurum.Location = new System.Drawing.Point(24, 8);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(74, 20);
            this.lblDurum.TabIndex = 14;
            this.lblDurum.Text = "DURUM:";
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.BackColor = System.Drawing.Color.Transparent;
            this.lblMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeslek.ForeColor = System.Drawing.Color.White;
            this.lblMeslek.Location = new System.Drawing.Point(47, 296);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(78, 20);
            this.lblMeslek.TabIndex = 15;
            this.lblMeslek.Text = "MESLEK:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(131, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(144, 31);
            this.txtID.TabIndex = 0;
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(131, 73);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(145, 31);
            this.txtAD.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(131, 109);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(144, 31);
            this.txtSoyad.TabIndex = 2;
            // 
            // grpBilgiler
            // 
            this.grpBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.grpBilgiler.Controls.Add(this.groupBox2);
            this.grpBilgiler.Controls.Add(this.groupBox1);
            this.grpBilgiler.Controls.Add(this.cmbxMeslek);
            this.grpBilgiler.Controls.Add(this.maskedMaaş);
            this.grpBilgiler.Controls.Add(this.cmbxDoğumYeri);
            this.grpBilgiler.Controls.Add(this.maskedYaş);
            this.grpBilgiler.Controls.Add(this.lblMaaş);
            this.grpBilgiler.Controls.Add(this.lblID);
            this.grpBilgiler.Controls.Add(this.lblAD);
            this.grpBilgiler.Controls.Add(this.lblSoyad);
            this.grpBilgiler.Controls.Add(this.lblTCKno);
            this.grpBilgiler.Controls.Add(this.txtSoyad);
            this.grpBilgiler.Controls.Add(this.lblDoğumYeri);
            this.grpBilgiler.Controls.Add(this.txtAD);
            this.grpBilgiler.Controls.Add(this.txtID);
            this.grpBilgiler.Controls.Add(this.lblMeslek);
            this.grpBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBilgiler.ForeColor = System.Drawing.Color.Snow;
            this.grpBilgiler.Location = new System.Drawing.Point(45, 39);
            this.grpBilgiler.Name = "grpBilgiler";
            this.grpBilgiler.Size = new System.Drawing.Size(292, 370);
            this.grpBilgiler.TabIndex = 1;
            this.grpBilgiler.TabStop = false;
            this.grpBilgiler.Text = "Personel Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblDurum);
            this.groupBox2.Controls.Add(this.seçenekBekar);
            this.groupBox2.Controls.Add(this.seçenekEvli);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 35);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // seçenekBekar
            // 
            this.seçenekBekar.AutoSize = true;
            this.seçenekBekar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seçenekBekar.Location = new System.Drawing.Point(180, 9);
            this.seçenekBekar.Name = "seçenekBekar";
            this.seçenekBekar.Size = new System.Drawing.Size(62, 20);
            this.seçenekBekar.TabIndex = 1;
            this.seçenekBekar.TabStop = true;
            this.seçenekBekar.Text = "Bekar";
            this.seçenekBekar.UseVisualStyleBackColor = true;
            // 
            // seçenekEvli
            // 
            this.seçenekEvli.AutoSize = true;
            this.seçenekEvli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seçenekEvli.Location = new System.Drawing.Point(113, 8);
            this.seçenekEvli.Name = "seçenekEvli";
            this.seçenekEvli.Size = new System.Drawing.Size(48, 20);
            this.seçenekEvli.TabIndex = 0;
            this.seçenekEvli.TabStop = true;
            this.seçenekEvli.Text = "Evli";
            this.seçenekEvli.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.seçenekKadın);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.seçenekErkek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 35);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // seçenekKadın
            // 
            this.seçenekKadın.AutoSize = true;
            this.seçenekKadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seçenekKadın.Location = new System.Drawing.Point(180, 6);
            this.seçenekKadın.Name = "seçenekKadın";
            this.seçenekKadın.Size = new System.Drawing.Size(60, 20);
            this.seçenekKadın.TabIndex = 1;
            this.seçenekKadın.TabStop = true;
            this.seçenekKadın.Text = "Kadın";
            this.seçenekKadın.UseVisualStyleBackColor = true;
            // 
            // seçenekErkek
            // 
            this.seçenekErkek.AutoSize = true;
            this.seçenekErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seçenekErkek.Location = new System.Drawing.Point(113, 6);
            this.seçenekErkek.Name = "seçenekErkek";
            this.seçenekErkek.Size = new System.Drawing.Size(61, 20);
            this.seçenekErkek.TabIndex = 0;
            this.seçenekErkek.TabStop = true;
            this.seçenekErkek.Text = "Erkek";
            this.seçenekErkek.UseVisualStyleBackColor = true;
            // 
            // cmbxMeslek
            // 
            this.cmbxMeslek.FormattingEnabled = true;
            this.cmbxMeslek.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Mühendis",
            "Usta Başı",
            "Tekniker",
            "Teknisyen",
            "Stajyer"});
            this.cmbxMeslek.Location = new System.Drawing.Point(131, 289);
            this.cmbxMeslek.Name = "cmbxMeslek";
            this.cmbxMeslek.Size = new System.Drawing.Size(144, 33);
            this.cmbxMeslek.TabIndex = 7;
            // 
            // maskedMaaş
            // 
            this.maskedMaaş.Location = new System.Drawing.Point(131, 326);
            this.maskedMaaş.Mask = "0000";
            this.maskedMaaş.Name = "maskedMaaş";
            this.maskedMaaş.Size = new System.Drawing.Size(145, 31);
            this.maskedMaaş.TabIndex = 8;
            this.maskedMaaş.ValidatingType = typeof(int);
            // 
            // cmbxDoğumYeri
            // 
            this.cmbxDoğumYeri.FormattingEnabled = true;
            this.cmbxDoğumYeri.Location = new System.Drawing.Point(131, 217);
            this.cmbxDoğumYeri.Name = "cmbxDoğumYeri";
            this.cmbxDoğumYeri.Size = new System.Drawing.Size(145, 33);
            this.cmbxDoğumYeri.TabIndex = 5;
            // 
            // maskedYaş
            // 
            this.maskedYaş.Location = new System.Drawing.Point(131, 181);
            this.maskedYaş.Mask = "00";
            this.maskedYaş.Name = "maskedYaş";
            this.maskedYaş.Size = new System.Drawing.Size(144, 31);
            this.maskedYaş.TabIndex = 4;
            this.maskedYaş.ValidatingType = typeof(int);
            // 
            // lblMaaş
            // 
            this.lblMaaş.AutoSize = true;
            this.lblMaaş.BackColor = System.Drawing.Color.Transparent;
            this.lblMaaş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaaş.ForeColor = System.Drawing.Color.White;
            this.lblMaaş.Location = new System.Drawing.Point(66, 333);
            this.lblMaaş.Name = "lblMaaş";
            this.lblMaaş.Size = new System.Drawing.Size(59, 20);
            this.lblMaaş.TabIndex = 24;
            this.lblMaaş.Text = "MAAŞ:";
            // 
            // diğerİşlemlerToolStripMenuItem
            // 
            this.diğerİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.diğerİşlemlerToolStripMenuItem.Name = "diğerİşlemlerToolStripMenuItem";
            this.diğerİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.diğerİşlemlerToolStripMenuItem.Text = "Diğer İşlemler";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click_1);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diğerİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(965, 602);
            this.Controls.Add(this.grpBilgiler);
            this.Controls.Add(this.grpİşlemler);
            this.Controls.Add(this.listViewListe);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnaForm";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            this.grpİşlemler.ResumeLayout(false);
            this.grpBilgiler.ResumeLayout(false);
            this.grpBilgiler.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnİstatistikveGrafik;
        private System.Windows.Forms.GroupBox grpİşlemler;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblTCKno;
        private System.Windows.Forms.Label lblDoğumYeri;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.GroupBox grpBilgiler;
        private System.Windows.Forms.Label lblMaaş;
        private System.Windows.Forms.RadioButton seçenekErkek;
        private System.Windows.Forms.RadioButton seçenekKadın;
        private System.Windows.Forms.MaskedTextBox maskedYaş;
        private System.Windows.Forms.MaskedTextBox maskedMaaş;
        private System.Windows.Forms.ComboBox cmbxMeslek;
        private System.Windows.Forms.ComboBox cmbxDoğumYeri;
        private System.Windows.Forms.ToolStripMenuItem diğerİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtAD;
        public System.Windows.Forms.ListView listViewListe;
        public System.Windows.Forms.RadioButton seçenekBekar;
        public System.Windows.Forms.RadioButton seçenekEvli;
    }
}

