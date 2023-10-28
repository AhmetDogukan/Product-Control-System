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
    public partial class FormUrunListele : Form
    {
        MyConnection mycon = new MyConnection();

        public static DataGridViewRow dataTasi { get; set; }
        public FormUrunListele()
        {
            InitializeComponent();
            try
            {
                AnaKategoriGetir();
                UrunGetir("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.ToString());
            }
            
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
            try
            {
                AltKategoriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.ToString());
                
            }
            
        }

        private void UrunGetir(string where)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SqlCommand cmd = new SqlCommand("SELECT*FROM TBL_Urun " + where, mycon.Connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Kategori ID";
            dt.Columns[2].ColumnName = "Alt Kategori ID";
            dt.Columns[3].ColumnName = "Ürün Kodu";
            dt.Columns[4].ColumnName = "Ürün Adı";
            dt.Columns[5].ColumnName = "Ürün Fiyatı";
            dt.Columns[6].ColumnName = "Ürün Açıklama";
            dt.Columns[7].ColumnName = "Ürün Tarih";
            dt.Columns[8].ColumnName = "Ürün Durum";

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dataGridView1.DataSource = ds.Tables[0];
            

        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            ComboboxValue combo = (ComboboxValue)cmbbx_AltKategori.SelectedItem;
            UrunGetir("WHERE Tbl_AltKategoriID=" + combo.Id);
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (txt_UrunKodu.Text != "" && txt_UrunAdi.Text != "")
            {
                UrunGetir("WHERE UrunKodu LIKE '%" + txt_UrunKodu.Text.ToString() + "%' OR UrunAdi LIKE '%" + txt_UrunAdi.Text.ToString() + "%'");
            }
            else if (txt_UrunKodu.Text==""&& txt_UrunAdi.Text !="")
            {
                UrunGetir("WHERE UrunAdi LIKE '%" + txt_UrunAdi.Text.ToString() + "%'");
            }
            else if (txt_UrunKodu.Text != "" && txt_UrunAdi.Text == "")
            {
                UrunGetir("WHERE UrunKodu LIKE '%" + txt_UrunKodu.Text.ToString() + "%'");
            }
            


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataTasi = dataGridView1.SelectedRows[0];

            FormUrunGuncelle frm = new FormUrunGuncelle();
            frm.ShowDialog();
        }
    }
}
