
namespace Ürün_Kontrol_Sistemi
{
    partial class FormLogin
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
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.lbl_Dikkat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(193, 114);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(200, 27);
            this.txt_Sifre.TabIndex = 1;
            this.txt_Sifre.TextChanged += new System.EventHandler(this.txt_Sifre_TextChanged);
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(193, 62);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(200, 27);
            this.txt_KullaniciAdi.TabIndex = 0;
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(92, 62);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(95, 20);
            this.lbl_KullaniciAdi.TabIndex = 2;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(92, 114);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(42, 20);
            this.lbl_Sifre.TabIndex = 3;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(299, 176);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(94, 29);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "GİRİŞ";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // lbl_Dikkat
            // 
            this.lbl_Dikkat.AutoSize = true;
            this.lbl_Dikkat.ForeColor = System.Drawing.Color.Red;
            this.lbl_Dikkat.Location = new System.Drawing.Point(92, 179);
            this.lbl_Dikkat.Name = "lbl_Dikkat";
            this.lbl_Dikkat.Size = new System.Drawing.Size(0, 20);
            this.lbl_Dikkat.TabIndex = 4;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.lbl_Dikkat);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.txt_Sifre);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sisteme Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label lbl_Dikkat;
    }
}