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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl =new Sqlbaglantisi();


        private void FrmStoklar_Load(object sender, EventArgs e)
        {
         

           


            SqlDataAdapter da = new SqlDataAdapter("Select UrunAd,Sum(adet) As 'Miktar' from TBL_URUNLER group by UrunAd" , bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //charta stok miktarı listeleme

            SqlCommand cmd = new SqlCommand("Select UrunAd,Sum(adet) As 'Miktar' from TBL_URUNLER group by UrunAd", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();

            //iller

            SqlCommand cmd2 = new SqlCommand("Select İL,Count(*) from TBL_FIRMALAR Group by İL", bgl.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 2"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();




        }
    }
}
