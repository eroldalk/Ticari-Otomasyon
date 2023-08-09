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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgileri", bgl.baglanti());
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
         
        void firmalistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD From TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        void temizle()
        {
            
            txtbankaad.Text = "";
            Cmbil.Text = "";
            cmbilce.Text = "";
            txtsube.Text = "";
            mskiban.Text = "";
            mskhesap.Text = "";
            mskyetkili.Text = "";
            msktel.Text = "";
            msktarih.Text = "";
            txttur.Text = "";
            lookUpEdit1.EditValue = "";

        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele();

            sehirlistesi();

            firmalistesi();

            temizle();
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

        private void Btnkaydet_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR(BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKİLİ,TELEFON,TARİH,HESAPTURU,FIRMAID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@P11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbankaad.Text);
            komut.Parameters.AddWithValue("@p2", Cmbil.Text);
            komut.Parameters.AddWithValue("@p3", cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", txtsube.Text);
            komut.Parameters.AddWithValue("@p5", mskiban.Text);
            komut.Parameters.AddWithValue("@p6", mskhesap.Text);
            komut.Parameters.AddWithValue("@p7", mskyetkili.Text);
            komut.Parameters.AddWithValue("@p8", msktel.Text);
            komut.Parameters.AddWithValue("@p9", msktarih.Text);
            komut.Parameters.AddWithValue("@p10", txttur.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgileri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
                SqlCommand komut = new SqlCommand("Delete From TBL_BANKALAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Banka Kaydı Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtbankaad.Text = dr["BANKAADI"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                txtsube.Text = dr["SUBE"].ToString();
                mskiban.Text = dr["IBAN"].ToString();
                mskhesap.Text = dr["HESAPNO"].ToString();
                mskyetkili.Text = dr["YETKİLİ"].ToString();
                msktel.Text = dr["TELEFON"].ToString();
                msktarih.Text = dr["TARİH"].ToString();
                txttur.Text = dr["HESAPTURU"].ToString();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_BANKALAR set BANKAADI=@p1 ,IL=@p2 ,ILCE=@p3 ,SUBE=@p4 ,IBAN=@p5 ,HESAPNO=@p6 ,YETKİLİ=@p7 ,TELEFON=@p8,TARİH=@p9 ,HESAPTURU=@p10 FIRMAID=@p11 where ID=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbankaad.Text);
            komut.Parameters.AddWithValue("@p2", Cmbil.Text);
            komut.Parameters.AddWithValue("@p3", cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", txtsube.Text);
            komut.Parameters.AddWithValue("@p5", mskiban.Text);
            komut.Parameters.AddWithValue("@p6", mskhesap.Text);
            komut.Parameters.AddWithValue("@p7", mskyetkili.Text);
            komut.Parameters.AddWithValue("@p8", msktel.Text);
            komut.Parameters.AddWithValue("@p9", msktarih.Text);
            komut.Parameters.AddWithValue("@p10", txttur.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@p12", txtid.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
