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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER", bgl.baglanti());
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
            txtsoyad.Text = "";
            mtbtel1.Text = "";
            MtbTC.Text = "";
            txtmail.Text = "";
            Cmbil.Text = "";
            cmbilce.Text = "";
            richadres.Text = "";
            txtgorev.Text = "";

        }



        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listele();

            sehirlistesi();

            Temizle();

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsoyad.Text = dr["SOYAD"].ToString();
                mtbtel1.Text = dr["TELEFON"].ToString();
                MtbTC.Text = dr["TC"].ToString();
                txtmail.Text = dr["MAİL"].ToString();
                Cmbil.Text = dr["İL"].ToString();
                cmbilce.Text = dr["İLCE"].ToString();
                richadres.Text = dr["ADRES"].ToString();
                txtgorev.Text = dr["GOREV"].ToString();
            }
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER(AD,SOYAD,TELEFON,TC,MAİL,İL,İLCE,ADRES,GOREV) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbtel1.Text);
            komut.Parameters.AddWithValue("@p4", MtbTC.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", richadres.Text);
            komut.Parameters.AddWithValue("@p9", txtgorev.Text);
           

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {

            DialogResult delete = new DialogResult();
            delete = MessageBox.Show("Personel Kaydınız Sileceksiniz. Emin Misiniz?", "Müşteri Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_PERSONELLER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Kaydı Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_PERSONELLER set AD=@p1 ,SOYAD=@p2 ,TELEFON=@p3 ,TC=@p4 ,MAİL=@p5 ,İL=@p6 ,İLCE=@p7,ADRES=@p8 ,GOREV=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbtel1.Text);
            komut.Parameters.AddWithValue("@p4", MtbTC.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", richadres.Text);
            komut.Parameters.AddWithValue("@p9", txtgorev.Text);
            komut.Parameters.AddWithValue("@p10", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
