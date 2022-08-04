
namespace Çamaşırhane_Otomasyonu
{
    partial class Form_Idare_Kayitlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Idare_Kayitlar));
            this.datagridviewKayitlar = new System.Windows.Forms.DataGridView();
            this.is_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewKayitlar
            // 
            this.datagridviewKayitlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewKayitlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.is_ID,
            this.is_tarihi,
            this.personel,
            this.ogrenci});
            this.datagridviewKayitlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewKayitlar.Location = new System.Drawing.Point(0, 0);
            this.datagridviewKayitlar.Name = "datagridviewKayitlar";
            this.datagridviewKayitlar.Size = new System.Drawing.Size(800, 450);
            this.datagridviewKayitlar.TabIndex = 0;
            // 
            // is_ID
            // 
            this.is_ID.DataPropertyName = "is_ID";
            this.is_ID.HeaderText = "İş Kayıt ID";
            this.is_ID.Name = "is_ID";
            // 
            // is_tarihi
            // 
            this.is_tarihi.DataPropertyName = "is_tarihi";
            this.is_tarihi.HeaderText = "İş Kayıt Tarihi";
            this.is_tarihi.Name = "is_tarihi";
            // 
            // personel
            // 
            this.personel.DataPropertyName = "personel";
            this.personel.HeaderText = "Görevli Personel";
            this.personel.Name = "personel";
            // 
            // ogrenci
            // 
            this.ogrenci.DataPropertyName = "ogrenci";
            this.ogrenci.HeaderText = "Oda NO";
            this.ogrenci.Name = "ogrenci";
            // 
            // Form_Idare_Kayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagridviewKayitlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Idare_Kayitlar";
            this.Text = "KAYITLAR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Idare_Kayitlar_FormClosed);
            this.Load += new System.EventHandler(this.Form_Idare_Kayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewKayitlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewKayitlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenci;
    }
}