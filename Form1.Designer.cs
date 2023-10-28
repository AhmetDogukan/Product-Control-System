
namespace Ürün_Kontrol_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altKategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListeleGüncelleVeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünResimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriİşlemleriToolStripMenuItem,
            this.altKategoriİşlemleriToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            this.kategoriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kategoriİşlemleriToolStripMenuItem_Click);
            // 
            // altKategoriİşlemleriToolStripMenuItem
            // 
            this.altKategoriİşlemleriToolStripMenuItem.Name = "altKategoriİşlemleriToolStripMenuItem";
            this.altKategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.altKategoriİşlemleriToolStripMenuItem.Text = "Alt Kategori İşlemleri";
            this.altKategoriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.altKategoriİşlemleriToolStripMenuItem_Click);
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünToolStripMenuItem,
            this.ürünListeleGüncelleVeSilToolStripMenuItem,
            this.ürünResimEkleToolStripMenuItem});
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            this.ürünİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ürünİşlemleriToolStripMenuItem_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.ürünToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünToolStripMenuItem.Click += new System.EventHandler(this.ürünToolStripMenuItem_Click);
            // 
            // ürünListeleGüncelleVeSilToolStripMenuItem
            // 
            this.ürünListeleGüncelleVeSilToolStripMenuItem.Name = "ürünListeleGüncelleVeSilToolStripMenuItem";
            this.ürünListeleGüncelleVeSilToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.ürünListeleGüncelleVeSilToolStripMenuItem.Text = "Ürün Listele(Güncelle ve Sil)";
            this.ürünListeleGüncelleVeSilToolStripMenuItem.Click += new System.EventHandler(this.ürünListeleGüncelleVeSilToolStripMenuItem_Click);
            // 
            // ürünResimEkleToolStripMenuItem
            // 
            this.ürünResimEkleToolStripMenuItem.Name = "ürünResimEkleToolStripMenuItem";
            this.ürünResimEkleToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.ürünResimEkleToolStripMenuItem.Text = "Ürün Resim Ekle";
            this.ürünResimEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünResimEkleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ürün Kontrol İşlemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altKategoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListeleGüncelleVeSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünResimEkleToolStripMenuItem;
    }
}

