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
    public partial class FormMainCat : Form
    {
        MyConnection mycon = new MyConnection();
        public FormMainCat()
        {
            InitializeComponent();
            DataGetir();
            DataButonEkle();
        }
        
        private void DataGetir()          //DataGridWiev'e data getirdik
        {
            SqlCommand cmd = new SqlCommand("SELECT KategoriID,KategoriAdi,KategoriDurum,KategoriTarih FROM Tbl_Kategori",
                mycon.Connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = false;  //Index numarasını alması için bu kodu yazmalıyız.
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
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            AnaKategoriEkle();
        }

        private void AnaKategoriEkle()
        {
            if (txt_KategoriAdi.Text.ToString() != "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Kategori(KategoriAdi) VALUES('"+txt_KategoriAdi.Text.ToString()+"')",mycon.Connection());
                cmd.ExecuteNonQuery();
                lbl_Durum.Text = "Durum:" + txt_KategoriAdi.Text.ToString() + " adlı kategori başarılı bir şekilde eklendi.";

                DataGetir(); //datamızı eklendikten sonra yeniler
            }
            else
            {
                lbl_Durum.Text = "Durum:Geçerli bir değer giriniz.";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)  
        {
            if (e.ColumnIndex==4)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["KategoriID"].Value.ToString();
                string ad = dataGridView1.Rows[e.RowIndex].Cells["KategoriAdi"].Value.ToString();
                byte durum = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells["KategoriDurum"].Value);
                KategoriGuncelle(id, ad, durum);
            }
            else if (e.ColumnIndex==5)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["KategoriID"].Value.ToString();
                KategoriSil(id);
            }
        }

        private void KategoriGuncelle(string _id,string _ad,byte _durum)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Kategori SET KategoriAdi='"+_ad+"',KategoriDurum="+_durum+" WHERE KategoriID="+_id+"",mycon.Connection());
            cmd.ExecuteNonQuery();

            DataGetir();

            MessageBox.Show(_id +" Numaralı Kategori Güncelleme İşlemi Başarılı");
        }

        private void KategoriSil(string _id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Kategori WHERE KategoriID = " + _id, mycon.Connection());
            cmd.ExecuteNonQuery();

            DataGetir();

            MessageBox.Show(_id + " Numaralı Kategori Silme İşlemi Başarılı");
        }
    }
}
