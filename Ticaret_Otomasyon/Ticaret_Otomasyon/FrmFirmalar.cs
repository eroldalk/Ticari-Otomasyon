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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        void firmalistesi()
        {  
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHİR From TBL_IL", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        } 
        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
         {
             cmbilce.Items.Clear();
             SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCE where Sehir=@IL", bgl.baglanti());
             komut.Parameters.AddWithValue("@IL", Cmbil.SelectedIndex + 1);
             SqlDataReader dr = komut.ExecuteReader();
             while (dr.Read())
             {
                cmbilce.Items.Add(dr[0]);
             }
             bgl.baglanti().Close();

         }

        void Temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsektor.Text = "";
            txtgorev.Text = "";
            txtyetkili.Text = "";
            MskTC.Text = "";
            Msktel1.Text = "";
            Msktel2.Text = "";
            Msktel3.Text = "";
            Mskfax.Text = "";
            txtmail.Text = "";
            Cmbil.Text = "";
            cmbilce.Text = "";
            txtvergid.Text = "";
            Rchadres.Text = "";
            txtkod1.Text = "";
            txtkod2.Text = "";
            txtkod3.Text = "";
            //txtad.Focus();

        }

        void carikodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                rchkod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmalistesi();

            sehirlistesi();

            Temizle();

            carikodaciklamalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtgorev.Text = dr["YETKİLİSTATU"].ToString();
                txtyetkili.Text = dr["YETKİLİADSOYAD"].ToString();
                MskTC.Text = dr["YETKİLİTC"].ToString();
                txtsektor.Text = dr["SEKTOR"].ToString();
                Msktel1.Text = dr["TELEFON1"].ToString();
                Msktel2.Text = dr["TELEFON2"].ToString();
                Msktel3.Text = dr["TELEFON3"].ToString();
                txtmail.Text = dr["MAİL"].ToString();
                Mskfax.Text = dr["FAX"].ToString();
                Cmbil.Text = dr["İL"].ToString();
                cmbilce.Text = dr["İLCE"].ToString();
                txtvergid.Text = dr["VERGİDAİRE"].ToString();
                Rchadres.Text = dr["ADRES"].ToString();
                txtkod1.Text = dr["OZELKOD1"].ToString();
                txtkod2.Text = dr["OZELKOD2"].ToString();
                txtkod3.Text = dr["OZELKOD3"].ToString();
            }
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR(AD,YETKİLİSTATU,YETKİLİADSOYAD,YETKİLİTC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAİL,FAX,İL,İLCE,VERGİDAİRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtgorev.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtsektor.Text);
            komut.Parameters.AddWithValue("@p6", Msktel1.Text);
            komut.Parameters.AddWithValue("@p7", Msktel2.Text);
            komut.Parameters.AddWithValue("@p8", Msktel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmail.Text);
            komut.Parameters.AddWithValue("@p10", Mskfax.Text);
            komut.Parameters.AddWithValue("@p11", Cmbil.Text);
            komut.Parameters.AddWithValue("@p12", cmbilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergid.Text);
            komut.Parameters.AddWithValue("@p14", Rchadres.Text);
            komut.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut.Parameters.AddWithValue("@p17", txtkod3.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
            Temizle();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult delete = new DialogResult();
            delete = MessageBox.Show("Firma Kaydınız Sileceksiniz. Emin Misiniz?", "Firma Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_FIRMALAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Firma Kaydı Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firmalistesi();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FIRMALAR set AD=@p1 ,YETKİLİSTATU=@p2 ,YETKİLİADSOYAD=@p3 ,YETKİLİTC=@p4 ,SEKTOR=@p5 ,TELEFON1=@p6 ,TELEFON2=@p7 ,TELEFON3=@p8,MAİL=@p9 ,FAX=@p10,İL=@p11 ,İLCE=@p12 ,VERGİDAİRE=@p13 ,ADRES=@p14 ,OZELKOD1=@p15 ,OZELKOD2=@p16 ,OZELKOD3=@p17 where ID=@p18", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtgorev.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtsektor.Text);
            komut.Parameters.AddWithValue("@p6", Msktel1.Text);
            komut.Parameters.AddWithValue("@p7", Msktel2.Text);
            komut.Parameters.AddWithValue("@p8", Msktel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmail.Text);
            komut.Parameters.AddWithValue("@p10", Mskfax.Text);
            komut.Parameters.AddWithValue("@p11", Cmbil.Text);
            komut.Parameters.AddWithValue("@p12", cmbilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergid.Text);
            komut.Parameters.AddWithValue("@p14", Rchadres.Text);
            komut.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut.Parameters.AddWithValue("@p17", txtkod3.Text);
            komut.Parameters.AddWithValue("@p18", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firmalistesi();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
