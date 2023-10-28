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
    public partial class FormLogin : Form
    {
        public bool loginoldumu = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_KullaniciAdi.Text == "ahmetkilicli" && txt_Sifre.Text == "dogukilicli") 
            {
                loginoldumu = true;
                this.Close();
            }
            else
            {
                loginoldumu = false;
                lbl_Dikkat.Text = "Kullanıcı Adı veya Şifre Hatalı";
            }
        }

        private void txt_Sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
