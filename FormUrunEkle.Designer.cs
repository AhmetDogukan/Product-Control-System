
namespace Ürün_Kontrol_Sistemi
{
    partial class FormUrunEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbx_AltKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbx_Kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Fiyat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UrunKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_UrunDetay = new System.Windows.Forms.TextBox();
            this.chckbx_Aktif = new System.Windows.Forms.CheckBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fiyat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbx_AltKategori);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbbx_Kategori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori İşlemleri";
            // 
            // cmbbx_AltKategori
            // 
            this.cmbbx_AltKategori.FormattingEnabled = true;
            this.cmbbx_AltKategori.Location = new System.Drawing.Point(546, 27);
            this.cmbbx_AltKategori.Name = "cmbbx_AltKategori";
            this.cmbbx_AltKategori.Size = new System.Drawing.Size(200, 28);
            this.cmbbx_AltKategori.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alt Kategori Seçiniz:";
            // 
            // cmbbx_Kategori
            // 
            this.cmbbx_Kategori.FormattingEnabled = true;
            this.cmbbx_Kategori.Location = new System.Drawing.Point(160, 27);
            this.cmbbx_Kategori.Name = "cmbbx_Kategori";
            this.cmbbx_Kategori.Size = new System.Drawing.Size(200, 28);
            this.cmbbx_Kategori.TabIndex = 1;
            this.cmbbx_Kategori.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Kategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Seçiniz:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Fiyat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_UrunAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_UrunKodu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.DecimalPlaces = 2;
            this.txt_Fiyat.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txt_Fiyat.Location = new System.Drawing.Point(587, 27);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(70, 27);
            this.txt_Fiyat.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Fiyat:";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(285, 27);
            this.txt_UrunAdi.MaxLength = 50;
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(200, 27);
            this.txt_UrunAdi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ürün Adı:";
            // 
            // txt_UrunKodu
            // 
            this.txt_UrunKodu.Location = new System.Drawing.Point(115, 27);
            this.txt_UrunKodu.MaxLength = 5;
            this.txt_UrunKodu.Name = "txt_UrunKodu";
            this.txt_UrunKodu.Size = new System.Drawing.Size(70, 27);
            this.txt_UrunKodu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Kod:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_UrunDetay);
            this.groupBox3.Location = new System.Drawing.Point(13, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Detay";
            // 
            // txt_UrunDetay
            // 
            this.txt_UrunDetay.Location = new System.Drawing.Point(7, 27);
            this.txt_UrunDetay.Multiline = true;
            this.txt_UrunDetay.Name = "txt_UrunDetay";
            this.txt_UrunDetay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_UrunDetay.Size = new System.Drawing.Size(739, 92);
            this.txt_UrunDetay.TabIndex = 0;
            // 
            // chckbx_Aktif
            // 
            this.chckbx_Aktif.AutoSize = true;
            this.chckbx_Aktif.Checked = true;
            this.chckbx_Aktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbx_Aktif.Location = new System.Drawing.Point(473, 355);
            this.chckbx_Aktif.Name = "chckbx_Aktif";
            this.chckbx_Aktif.Size = new System.Drawing.Size(97, 24);
            this.chckbx_Aktif.TabIndex = 3;
            this.chckbx_Aktif.Text = "Aktif Ürün";
            this.chckbx_Aktif.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(622, 352);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(94, 29);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // FormUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.chckbx_Aktif);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUrunEkle";
            this.Text = "Ürün Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fiyat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbbx_AltKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbx_Kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txt_Fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UrunKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_UrunDetay;
        private System.Windows.Forms.CheckBox chckbx_Aktif;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}