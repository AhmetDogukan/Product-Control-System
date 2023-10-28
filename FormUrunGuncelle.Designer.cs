
namespace Ürün_Kontrol_Sistemi
{
    partial class FormUrunGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UrunKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu:";
            // 
            // txt_UrunKodu
            // 
            this.txt_UrunKodu.Location = new System.Drawing.Point(129, 64);
            this.txt_UrunKodu.Name = "txt_UrunKodu";
            this.txt_UrunKodu.Size = new System.Drawing.Size(125, 27);
            this.txt_UrunKodu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı:";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(389, 64);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(125, 27);
            this.txt_UrunAdi.TabIndex = 1;
            // 
            // FormUrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UrunKodu);
            this.Controls.Add(this.label1);
            this.Name = "FormUrunGuncelle";
            this.Text = "Ürün Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UrunKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UrunAdi;
    }
}