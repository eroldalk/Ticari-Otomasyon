using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticaret_Otomasyon
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();

        }
        
        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            //Verileri Kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER(URUNAD,MARKA,MODEL,YIL,ADET,ALISFİYAT,SATISFİYAT,DETAY) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)" , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", msktxtyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nmcadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatis.Text));
            komut.Parameters.AddWithValue("@p8", richtxtdetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();


        }
    }
}
