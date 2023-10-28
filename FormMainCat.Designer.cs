
namespace Ürün_Kontrol_Sistemi
{
    partial class FormMainCat
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
            this.grpbx_KategoriEkle = new System.Windows.Forms.GroupBox();
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_KategoriAdi = new System.Windows.Forms.TextBox();
            this.lbl_KategoriAdi = new System.Windows.Forms.Label();
            this.grpbx_KategoriListele = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbx_KategoriEkle.SuspendLayout();
            this.grpbx_KategoriListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbx_KategoriEkle
            // 
            this.grpbx_KategoriEkle.Controls.Add(this.lbl_Durum);
            this.grpbx_KategoriEkle.Controls.Add(this.btn_Ekle);
            this.grpbx_KategoriEkle.Controls.Add(this.txt_KategoriAdi);
            this.grpbx_KategoriEkle.Controls.Add(this.lbl_KategoriAdi);
            this.grpbx_KategoriEkle.Location = new System.Drawing.Point(13, 13);
            this.grpbx_KategoriEkle.Name = "grpbx_KategoriEkle";
            this.grpbx_KategoriEkle.Size = new System.Drawing.Size(757, 125);
            this.grpbx_KategoriEkle.TabIndex = 0;
            this.grpbx_KategoriEkle.TabStop = false;
            this.grpbx_KategoriEkle.Text = "Kategori Ekle";
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.ForeColor = System.Drawing.Color.Red;
            this.lbl_Durum.Location = new System.Drawing.Point(61, 83);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(57, 20);
            this.lbl_Durum.TabIndex = 3;
            this.lbl_Durum.Text = "Durum:";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(410, 39);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(94, 29);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_KategoriAdi
            // 
            this.txt_KategoriAdi.Location = new System.Drawing.Point(163, 40);
            this.txt_KategoriAdi.Name = "txt_KategoriAdi";
            this.txt_KategoriAdi.Size = new System.Drawing.Size(200, 27);
            this.txt_KategoriAdi.TabIndex = 1;
            // 
            // lbl_KategoriAdi
            // 
            this.lbl_KategoriAdi.AutoSize = true;
            this.lbl_KategoriAdi.Location = new System.Drawing.Point(61, 43);
            this.lbl_KategoriAdi.Name = "lbl_KategoriAdi";
            this.lbl_KategoriAdi.Size = new System.Drawing.Size(96, 20);
            this.lbl_KategoriAdi.TabIndex = 0;
            this.lbl_KategoriAdi.Text = "Kategori Adı:";
            // 
            // grpbx_KategoriListele
            // 
            this.grpbx_KategoriListele.Controls.Add(this.dataGridView1);
            this.grpbx_KategoriListele.Location = new System.Drawing.Point(13, 145);
            this.grpbx_KategoriListele.Name = "grpbx_KategoriListele";
            this.grpbx_KategoriListele.Size = new System.Drawing.Size(757, 246);
            this.grpbx_KategoriListele.TabIndex = 1;
            this.grpbx_KategoriListele.TabStop = false;
            this.grpbx_KategoriListele.Text = "Kategori Listele,Güncelle ve Sil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(744, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormMainCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.grpbx_KategoriListele);
            this.Controls.Add(this.grpbx_KategoriEkle);
            this.Name = "FormMainCat";
            this.Text = "Ana Kategori İşlemleri";
            this.grpbx_KategoriEkle.ResumeLayout(false);
            this.grpbx_KategoriEkle.PerformLayout();
            this.grpbx_KategoriListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_KategoriEkle;
        private System.Windows.Forms.Label lbl_Durum;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_KategoriAdi;
        private System.Windows.Forms.Label lbl_KategoriAdi;
        private System.Windows.Forms.GroupBox grpbx_KategoriListele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}