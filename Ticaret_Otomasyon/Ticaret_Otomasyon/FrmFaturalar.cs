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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        void faturalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURABILGI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            txtid.Text = "";
            txtseri.Text = "";
            txtsıra.Text = "";
            mtbsaat.Text = "";
            mtbtarih.Text = "";
            txtalici.Text = "";
            txtvergi.Text = "";
            txtteden.Text = "";
            txtalan.Text = "";

            /*Txturunid.Text = "";
            Txturunad.Text = "";
            Txtmiktar.Text = "";
            TxtFiyat.Text = "";
            Txttutar.Text = "";
            TxtFaturaId.Text = "";*/
          

        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            faturalistesi();
            Temizle();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            if(TxtFaturaId.Text == "")
            {
                SqlCommand komut =new SqlCommand("insert into TBL_FATURABILGI (SERİ ,SIRANO , TARİH ,SAAT , VERGİDAİRE ,ALICI ,TESLİMEDEN ,TESLİMALAN ) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7 ,@P8)", bgl.baglanti());
  
                komut.Parameters.AddWithValue("@p1", txtseri.Text);
                komut.Parameters.AddWithValue("@p2", txtsıra.Text);
                komut.Parameters.AddWithValue("@p3", mtbtarih.Text);
                komut.Parameters.AddWithValue("@p4", mtbsaat.Text);
                komut.Parameters.AddWithValue("@p5", txtvergi.Text);
                komut.Parameters.AddWithValue("@p6", txtalici.Text);
                komut.Parameters.AddWithValue("@p7", txtteden.Text);
                komut.Parameters.AddWithValue("@p8", txtalan.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                faturalistesi();
            }
            if (TxtFaturaId.Text != "")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(Txtmiktar.Text);
                tutar = miktar * fiyat;
                Txttutar.Text = tutar.ToString();


                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD ,MİKTAR , FİYAT ,TUTAR , FATURAID ) VALUES (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());

                komut2.Parameters.AddWithValue("@p1", Txturunad.Text);
                komut2.Parameters.AddWithValue("@p2", Txtmiktar.Text);
                komut2.Parameters.AddWithValue("@p3", TxtFiyat.Text);
                komut2.Parameters.AddWithValue("@p4", Txttutar.Text);
                komut2.Parameters.AddWithValue("@p5", TxtFaturaId.Text);

                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Ürün Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                
                txtid.Text = dr["FATURABİLGİID"].ToString();
                txtseri.Text = dr["SERİ"].ToString();
                txtsıra.Text = dr["SIRANO"].ToString();
                mtbsaat.Text = dr["SAAT"].ToString();
                mtbtarih.Text = dr["TARİH"].ToString();
                txtvergi.Text = dr["VERGİDAİRE"].ToString();
                txtalici.Text = dr["ALICI"].ToString();
                txtteden.Text = dr["TESLİMEDEN"].ToString();
                txtalan.Text = dr["TESLİMALAN"].ToString();

                /*Txturunid.Text = dr["FATURAURUNID"].ToString();
                Txturunad.Text = dr["URUNAD"].ToString();
                Txtmiktar.Text = dr["MİKTAR"].ToString();
                TxtFiyat.Text = dr["FİYAT"].ToString();
                Txttutar.Text = dr["TUTAR"].ToString();
                TxtFaturaId.Text = dr["FATURAID"].ToString();*/
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult delete = new DialogResult();
            delete = MessageBox.Show("Fatura Kaydınızı Sileceksiniz. Emin Misiniz?", "Fatura Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_FATURABILGI where FATURABİLGİID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Kaydı Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                faturalistesi();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI set SERİ=@p1 ,SIRANO=@p2 ,SAAT=@p3 ,TARİH=@p4 ,VERGİDAİRE=@p5 ,ALICI=@p6 ,TESLİMEDEN=@p7 ,TESLİMALAN=@p8 where FATURABİLGİID=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtseri.Text);
            komut.Parameters.AddWithValue("@p2", txtsıra.Text);
            komut.Parameters.AddWithValue("@p3", mtbsaat.Text);
            komut.Parameters.AddWithValue("@p4", mtbtarih.Text);
            komut.Parameters.AddWithValue("@p5", txtvergi.Text);
            komut.Parameters.AddWithValue("@p6", txtalici.Text);
            komut.Parameters.AddWithValue("@p7", txtteden.Text);
            komut.Parameters.AddWithValue("@p8", txtalan.Text);
            komut.Parameters.AddWithValue("@p9", txtid.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            faturalistesi();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunler fr = new FrmFaturaUrunler();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr != null)
            {
                fr.id = dr["FATURABİLGİID"].ToString();
            }
            fr.Show();
        }
    }
}
