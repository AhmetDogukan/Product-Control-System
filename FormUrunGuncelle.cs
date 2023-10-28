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
    public partial class FormUrunGuncelle : Form
    {
        public FormUrunGuncelle()
        {
            InitializeComponent();

            txt_UrunKodu.Text = FormUrunListele.dataTasi.Cells["Ürün Kodu"].Value.ToString();
            txt_UrunAdi.Text = FormUrunListele.dataTasi.Cells["Ürün Adı"].Value.ToString();
        }
    }
}
