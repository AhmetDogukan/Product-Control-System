using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün_Kontrol_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormLogin formLogin = new FormLogin();
            if (formLogin.loginoldumu==false)
            {
                formLogin.ShowDialog();     //Bu diyalog penceresi kapanmadan diğer sistem çalışmıyor.
                Environment.Exit(0);
            }
            
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunEkle formUrunEkle = new FormUrunEkle();
            formUrunEkle.ShowDialog();
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMainCat formMainCat = new FormMainCat();
            formMainCat.ShowDialog();
        }

        private void altKategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubCat formSubCat = new FormSubCat();
            formSubCat.ShowDialog();
        }

        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünListeleGüncelleVeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunListele formUrunListele = new FormUrunListele();
            formUrunListele.ShowDialog();
        }

        private void ürünResimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunResimEkle formUrunResimEkle = new FormUrunResimEkle();
            formUrunResimEkle.ShowDialog();
        }
    }
}
