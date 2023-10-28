
namespace Ürün_Kontrol_Sistemi
{
    partial class FormUrunListele
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
            this.btn_Getir = new System.Windows.Forms.Button();
            this.cmbbx_AltKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbx_Kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.txt_UrunKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Getir);
            this.groupBox1.Controls.Add(this.cmbbx_AltKategori);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbbx_Kategori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Listele";
            // 
            // btn_Getir
            // 
            this.btn_Getir.Location = new System.Drawing.Point(636, 24);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(94, 29);
            this.btn_Getir.TabIndex = 2;
            this.btn_Getir.Text = "GETİR";
            this.btn_Getir.UseVisualStyleBackColor = true;
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // cmbbx_AltKategori
            // 
            this.cmbbx_AltKategori.FormattingEnabled = true;
            this.cmbbx_AltKategori.Location = new System.Drawing.Point(403, 26);
            this.cmbbx_AltKategori.Name = "cmbbx_AltKategori";
            this.cmbbx_AltKategori.Size = new System.Drawing.Size(200, 28);
            this.cmbbx_AltKategori.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alt Kategori:";
            // 
            // cmbbx_Kategori
            // 
            this.cmbbx_Kategori.FormattingEnabled = true;
            this.cmbbx_Kategori.Location = new System.Drawing.Point(83, 26);
            this.cmbbx_Kategori.Name = "cmbbx_Kategori";
            this.cmbbx_Kategori.Size = new System.Drawing.Size(200, 28);
            this.cmbbx_Kategori.TabIndex = 1;
            this.cmbbx_Kategori.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Kategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Ara);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_UrunAdi);
            this.groupBox2.Controls.Add(this.txt_UrunKodu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Ara";
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(636, 33);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(94, 29);
            this.btn_Ara.TabIndex = 2;
            this.btn_Ara.Text = "ARA";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "veya";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(392, 37);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(200, 27);
            this.txt_UrunAdi.TabIndex = 1;
            // 
            // txt_UrunKodu
            // 
            this.txt_UrunKodu.Location = new System.Drawing.Point(97, 37);
            this.txt_UrunKodu.Name = "txt_UrunKodu";
            this.txt_UrunKodu.Size = new System.Drawing.Size(125, 27);
            this.txt_UrunKodu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Kodu:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(757, 216);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FormUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUrunListele";
            this.Text = "Ürün Listele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Getir;
        private System.Windows.Forms.ComboBox cmbbx_AltKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbx_Kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.TextBox txt_UrunKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}