
namespace Ürün_Kontrol_Sistemi
{
    partial class FormSubCat
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
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_AltKat = new System.Windows.Forms.TextBox();
            this.cmbbx_AnaKat = new System.Windows.Forms.ComboBox();
            this.lbl_AltKategoriİsmi = new System.Windows.Forms.Label();
            this.lbl_AnaKategoriSeçiniz = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Durum);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.txt_AltKat);
            this.groupBox1.Controls.Add(this.cmbbx_AnaKat);
            this.groupBox1.Controls.Add(this.lbl_AltKategoriİsmi);
            this.groupBox1.Controls.Add(this.lbl_AnaKategoriSeçiniz);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alt Kategori Ekle";
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.ForeColor = System.Drawing.Color.Red;
            this.lbl_Durum.Location = new System.Drawing.Point(501, 68);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(57, 20);
            this.lbl_Durum.TabIndex = 5;
            this.lbl_Durum.Text = "Durum:";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(501, 23);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(94, 29);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_AltKat
            // 
            this.txt_AltKat.Location = new System.Drawing.Point(272, 65);
            this.txt_AltKat.Name = "txt_AltKat";
            this.txt_AltKat.Size = new System.Drawing.Size(200, 27);
            this.txt_AltKat.TabIndex = 3;
            // 
            // cmbbx_AnaKat
            // 
            this.cmbbx_AnaKat.FormattingEnabled = true;
            this.cmbbx_AnaKat.Location = new System.Drawing.Point(272, 24);
            this.cmbbx_AnaKat.Name = "cmbbx_AnaKat";
            this.cmbbx_AnaKat.Size = new System.Drawing.Size(200, 28);
            this.cmbbx_AnaKat.TabIndex = 2;
            // 
            // lbl_AltKategoriİsmi
            // 
            this.lbl_AltKategoriİsmi.AutoSize = true;
            this.lbl_AltKategoriİsmi.Location = new System.Drawing.Point(117, 68);
            this.lbl_AltKategoriİsmi.Name = "lbl_AltKategoriİsmi";
            this.lbl_AltKategoriİsmi.Size = new System.Drawing.Size(123, 20);
            this.lbl_AltKategoriİsmi.TabIndex = 1;
            this.lbl_AltKategoriİsmi.Text = "Alt Kategori İsmi:";
            // 
            // lbl_AnaKategoriSeçiniz
            // 
            this.lbl_AnaKategoriSeçiniz.AutoSize = true;
            this.lbl_AnaKategoriSeçiniz.Location = new System.Drawing.Point(117, 27);
            this.lbl_AnaKategoriSeçiniz.Name = "lbl_AnaKategoriSeçiniz";
            this.lbl_AnaKategoriSeçiniz.Size = new System.Drawing.Size(149, 20);
            this.lbl_AnaKategoriSeçiniz.TabIndex = 0;
            this.lbl_AnaKategoriSeçiniz.Text = "Ana Kategori Seçiniz:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alt Kategori Listele,Güncelle ve Sil";
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
            // FormSubCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSubCat";
            this.Text = "Alt Kategori İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Durum;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_AltKat;
        private System.Windows.Forms.ComboBox cmbbx_AnaKat;
        private System.Windows.Forms.Label lbl_AltKategoriİsmi;
        private System.Windows.Forms.Label lbl_AnaKategoriSeçiniz;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}