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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void Temizle()
        {
            txtid.Text = "";
            cmbay.Text = "";
            cmbyil.Text = "";
            txtelektrik.Text = "";
            txtsu.Text = "";
            txtgaz.Text = "";
            txtnet.Text = "";
            txtmaas.Text = "";
            txtekstra.Text = "";
            rchnot.Text = "";

        }


        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            listele();
            Temizle();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER(AY,YIL,ELEKTRİK,SU,DOGALGAZ,İNTERNET,MAASLAR,EKSTRA,NOTLAR) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbay.Text);
            komut.Parameters.AddWithValue("@p2", cmbyil.Text);
            komut.Parameters.AddWithValue("@p3", txtelektrik.Text);
            komut.Parameters.AddWithValue("@p4", txtsu.Text);
            komut.Parameters.AddWithValue("@p5", txtgaz.Text);
            komut.Parameters.AddWithValue("@p6", txtnet.Text);  // p3 den p8 e kadar dersde decimal.parse()içine alınıyor
            komut.Parameters.AddWithValue("@p7", txtmaas.Text);
            komut.Parameters.AddWithValue("@p8", txtekstra.Text);
            komut.Parameters.AddWithValue("@p9", rchnot.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            Temizle();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult delete = new DialogResult();
            delete = MessageBox.Show("Gider Bilgilerinizi Sileceksiniz. Emin Misiniz?", "Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_GIDERLER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Gider Bilgileriniz Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_GIDERLER set AY=@p1 ,YIL=@p2 ,ELEKTRİK=@p3 ,SU=@p4 ,DOGALGAZ=@p5 ,İNTERNET=@p6 ,MAASLAR=@p7,EKSTRA=@p8 ,NOTLAR=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbay.Text);
            komut.Parameters.AddWithValue("@p2", cmbyil.Text);
            komut.Parameters.AddWithValue("@p3", txtelektrik.Text);
            komut.Parameters.AddWithValue("@p4", txtsu.Text);
            komut.Parameters.AddWithValue("@p5", txtgaz.Text);
            komut.Parameters.AddWithValue("@p6", txtnet.Text);
            komut.Parameters.AddWithValue("@p7", txtmaas.Text);
            komut.Parameters.AddWithValue("@p8", txtekstra.Text);
            komut.Parameters.AddWithValue("@p9", rchnot.Text);
            komut.Parameters.AddWithValue("@p10", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                cmbay.Text = dr["AY"].ToString();
                cmbyil.Text = dr["YIL"].ToString();
                txtelektrik.Text = dr["ELEKTRİK"].ToString();
                txtsu.Text = dr["SU"].ToString();
                txtgaz.Text = dr["DOGALGAZ"].ToString();
                txtnet.Text = dr["İNTERNET"].ToString();
                txtmaas.Text = dr["MAASLAR"].ToString();
                txtekstra.Text = dr["EKSTRA"].ToString();
                rchnot.Text = dr["NOTLAR"].ToString();
            }
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
