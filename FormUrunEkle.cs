using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün_Kontrol_Sistemi
{
    public partial class FormUrunEkle : Form
    {
        MyConnection mycon = new MyConnection();
        public FormUrunEkle()
        {
            InitializeComponent();
            AnaKategoriGetir();
        }

        private void AnaKategoriGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT KategoriID,KategoriAdi FROM Tbl_Kategori WHERE KategoriDurum=1", mycon.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            cmbbx_Kategori.Text = "Seçiniz...";

            while (dr.Read())
            {
                cmbbx_Kategori.Items.Add(new ComboboxValue(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }

            dr.Close();
        }

        private void AltKategoriGetir()
        {
            ComboboxValue combo = (ComboboxValue)cmbbx_Kategori.SelectedItem;
            cmbbx_AltKategori.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT AltKategoriID,AltKategoriAdi FROM Tbl_AltKategori WHERE AltKategoriDurum=1 AND KategoriID=@ID", mycon.Connection());
            cmd.Parameters.AddWithValue("@ID", combo.Id);
            SqlDataReader dr = cmd.ExecuteReader();
            cmbbx_AltKategori.Text = "Seçiniz...";

            while (dr.Read())
            {
                cmbbx_AltKategori.Items.Add(new ComboboxValue(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }

            dr.Close();
        }

        private void cmbbx_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltKategoriGetir();
        }

        private void UrunEkle()
        {
            ComboboxValue comboMain = (ComboboxValue)cmbbx_Kategori.SelectedItem;
            ComboboxValue comboSub = (ComboboxValue)cmbbx_AltKategori.SelectedItem;

            SqlCommand cmd = new SqlCommand("SP_UrunEkle",mycon.Connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KatID", comboMain.Id);
            cmd.Parameters.AddWithValue("@AltID", comboSub.Id);
            cmd.Parameters.AddWithValue("@UrnKod", txt_UrunKodu.Text.ToString());
            cmd.Parameters.AddWithValue("@UrnNam", txt_UrunAdi.Text.ToString());
            cmd.Parameters.AddWithValue("@UrnFyt", txt_Fiyat.Value);
            cmd.Parameters.AddWithValue("@UrnAck", txt_UrunDetay.Text.ToString());
            cmd.Parameters.AddWithValue("@UrnDrm", chckbx_Aktif.Checked);
            cmd.ExecuteNonQuery();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                UrunEkle();
                MessageBox.Show("Ürün Başarılı Bir Şekilde Eklenmiştir.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Mesajı" + ex.Message.ToString());
            }
            
        }
    }
}
