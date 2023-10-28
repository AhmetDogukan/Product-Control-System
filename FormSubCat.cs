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
    public partial class FormSubCat : Form
    {
        MyConnection mycon = new MyConnection();
        public FormSubCat()
        {
            InitializeComponent();
            AnaKategoriGetir();
            DataGetir();
            DataButonEkle();
        }

        private void AnaKategoriGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT KategoriID,KategoriAdi FROM Tbl_Kategori WHERE KategoriDurum=1",mycon.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            cmbbx_AnaKat.Text = "Seçiniz...";

            while (dr.Read())
            {
                cmbbx_AnaKat.Items.Add(new ComboboxValue(Convert.ToInt32(dr[0]) , dr[1].ToString()));
            }

            dr.Close();
        }

        private void DataGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT AltKategoriID,KategoriID,AltKategoriAdi,AltKategoriDurum,AltKategoriTarih FROM Tbl_AltKategori",mycon.Connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = false;

        }

        private void DataButonEkle()
        {
            DataGridViewLinkColumn EditLink = new DataGridViewLinkColumn();
            EditLink.UseColumnTextForLinkValue = true;
            EditLink.HeaderText = "Güncelle";                       //Başlık
            EditLink.DataPropertyName = "LnkColumn";                //Properties namae gibi
            EditLink.LinkBehavior = LinkBehavior.SystemDefault;     //Görünüm
            EditLink.Text = "Güncelle";
            dataGridView1.Columns.Add(EditLink);

            DataGridViewLinkColumn DeleteLink = new DataGridViewLinkColumn();
            DeleteLink.UseColumnTextForLinkValue = true;
            DeleteLink.HeaderText = "Sil";                       //Başlık
            DeleteLink.DataPropertyName = "LnkColumn";                //Properties namae gibi
            DeleteLink.LinkBehavior = LinkBehavior.SystemDefault;     //Görünüm
            DeleteLink.Text = "Sil";
            dataGridView1.Columns.Add(DeleteLink);

        }

        private void AltKategoriEkle()
        {
            ComboboxValue combo=(ComboboxValue)cmbbx_AnaKat.SelectedItem;

            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_AltKategori(KategoriID,AltKategoriAdi) VALUES(@ID, @AD)", mycon.Connection());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", combo.Id);
            cmd.Parameters.AddWithValue("@AD", txt_AltKat.Text);
            cmd.ExecuteNonQuery();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (cmbbx_AnaKat.SelectedItem !=null)
            {
                if (txt_AltKat.Text.ToString() != "")
                {
                    AltKategoriEkle();
                    DataGetir();
                    lbl_Durum.Text = "Durum: Alt Kategori başarılı bir şekilde eklendi...";
                }
                else
                {
                    lbl_Durum.Text = "Durum: Lütfen geçerli bir isim giriniz...";
                }
            }
            else
            {
                lbl_Durum.Text = "Durum: Lütfen ana kategori seçiniz...";
            }
        }

        private void KategoriSil(string _id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_AltKategori WHERE AltKategoriID=" + _id, mycon.Connection());
            cmd.ExecuteNonQuery();
            DataGetir();
            MessageBox.Show(_id + "numaralı kategori başarılı bir şekilde silinmiştir.");

        }

        private void KategoriGuncelle(string _id ,string _ad,int _durum)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_AltKategori SET AltKategoriAdi='" + _ad + "', AltKategoriDurum = " +
                 _durum + " WHERE  AltKategoriID=" + _id, mycon.Connection());
            cmd.ExecuteNonQuery();
            DataGetir();
            MessageBox.Show(_id + "numaralı kategori başarılı bir şekilde güncellenmiştir.");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["AltKategoriID"].Value.ToString();
                string ad= dataGridView1.Rows[e.RowIndex].Cells["AltKategoriAdi"].Value.ToString();
                byte durum=Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells["AltKategoriDurum"].Value.ToString());
                KategoriGuncelle(id, ad, durum);
            }
            else if(e.ColumnIndex==6)
            {
                DialogResult secim = new DialogResult();
                secim = MessageBox.Show("Emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(secim==DialogResult.Yes)
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["AltKategoriID"].Value.ToString();
                    KategoriSil(id);
                }
            }
        }
    }
}
