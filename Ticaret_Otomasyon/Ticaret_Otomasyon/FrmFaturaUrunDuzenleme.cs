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
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        
        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            Txturunid.Text = urunid;


            SqlCommand komut = new SqlCommand("Select * From TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                TxtFiyat.Text= dr[3].ToString();
                Txtmiktar.Text = dr[2].ToString();
                Txttutar.Text = dr[4].ToString();
                Txturunad.Text = dr[1].ToString();

                bgl.baglanti().Close();
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURADETAY set URUNAD=@p1 ,MİKTAR=@p2 ,FİYAT=@p3 ,TUTAR=@p4 where FATURAURUNID=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txturunad.Text);
            komut.Parameters.AddWithValue("@p2", Txtmiktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse( TxtFiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse( Txttutar.Text));
            komut.Parameters.AddWithValue("@p5", Txturunid.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {

            DialogResult delete = new DialogResult();
            delete = MessageBox.Show("Ürün Kaydını Sileceksiniz. Emin Misiniz?", "Ürün Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txturunid.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
