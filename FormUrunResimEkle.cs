using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün_Kontrol_Sistemi
{
    public partial class FormUrunResimEkle : Form
    {
        MyConnection mycon = new MyConnection();
        public FormUrunResimEkle()
        {
            InitializeComponent();
            cmbbx_KategoriSeciniz.Items.AddRange(VeriGetir("SELECT KategoriID,KategoriAdi FROM Tbl_Kategori"));
        }

        private object[] VeriGetir(string komut)
        {
            SqlCommand cmd = new SqlCommand(komut,mycon.Connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            object[] urunveriler = new object[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                urunveriler[i] = new ComboboxValue(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1].ToString());
            }

            return urunveriler;
        }

        private void cmbbx_KategoriSeciniz_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxValue combo = (ComboboxValue)cmbbx_KategoriSeciniz.SelectedItem;

            cmbbx_AltKategoriSeciniz.Items.AddRange(VeriGetir("SELECT AltKategoriID,AltKategoriAdi FROM Tbl_AltKategori WHERE KategoriID="+combo.Id.ToString() + ""));
        }

        private void cmbbx_AltKategoriSeciniz_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxValue combo = (ComboboxValue)cmbbx_AltKategoriSeciniz.SelectedItem;

            cmbbx_UrunSeciniz.Items.AddRange(VeriGetir("SELECT UrunID,UrunAdi FROM Tbl_Urun WHERE AltKategoriID=" + combo.Id.ToString() + ""));
        }

        private OpenFileDialog OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Dosyasını Aç";
            ofd.Filter = "PNG Files(*.png) | *.png | JPG Files(*.jpg) | *.jpg | Tüm dosyalar (*.*) | *.* ";
            ofd.FilterIndex = 3;
            DialogResult dr = ofd.ShowDialog();

            return ofd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = OpenFile().FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = OpenFile().FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = OpenFile().FileName;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != "")
            {
                Guid guid = new Guid();
                string kaynak = pictureBox1.ImageLocation;
                string hedef = @"C:\Users\ahmet\source\repos\Ürün Kontrol Sistemi\Ürün Kontrol Sistemi\Image\" + guid + ".png";

                File.Copy(kaynak, hedef,true);
            }
            else if (pictureBox2.ImageLocation != "")
            {
                Guid guid = new Guid();
                string kaynak = pictureBox2.ImageLocation;
                string hedef = @"C:\Users\ahmet\source\repos\Ürün Kontrol Sistemi\Ürün Kontrol Sistemi\Image\" + guid + ".png";

                File.Copy(kaynak, hedef, true);
            }
            else if(pictureBox3.ImageLocation != "")
            {
                Guid guid = new Guid();
                string kaynak = pictureBox3.ImageLocation;
                string hedef = @"C:\Users\ahmet\source\repos\Ürün Kontrol Sistemi\Ürün Kontrol Sistemi\Image\" + guid + ".png";

                File.Copy(kaynak, hedef, true);
            }
        }
    }
}
