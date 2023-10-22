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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }


        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                mtbtarih.Text = dr["TARİH"].ToString();
                mtbsaat.Text = dr["SAAT"].ToString();
                txtbaslik.Text = dr["BASLIK"].ToString();
                richdetay.Text = dr["DETAY"].ToString();
                txtolusturan.Text = dr["OLUSTURAN"].ToString();
                txthitap.Text = dr["HİTAP"].ToString();
                
            }
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR(TARİH,SAAT,BASLIK,DETAY,OLUSTURAN,HİTAP) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mtbtarih.Text);
            komut.Parameters.AddWithValue("@p2", mtbsaat.Text);
            komut.Parameters.AddWithValue("@p3", txtbaslik.Text);
            komut.Parameters.AddWithValue("@p4", richdetay.Text);
            komut.Parameters.AddWithValue("@p5", txtolusturan.Text);
            komut.Parameters.AddWithValue("@p6", txthitap.Text);
          
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Bilgileri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set TARİH=@p1 ,SAAT=@p2 ,BASLIK=@p3 ,DETAY=@p4 ,OLUSTURAN=@p5 ,HİTAP=@p6  where ID=@p7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mtbtarih.Text);
            komut.Parameters.AddWithValue("@p2", mtbsaat.Text);
            komut.Parameters.AddWithValue("@p3", txtbaslik.Text);
            komut.Parameters.AddWithValue("@p4", richdetay.Text);
            komut.Parameters.AddWithValue("@p5", txtolusturan.Text);
            komut.Parameters.AddWithValue("@p6", txthitap.Text);
            komut.Parameters.AddWithValue("@p7", txtid.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult delete = new DialogResult();
            delete = MessageBox.Show("Not Kaydınızı Sileceksiniz. Emin Misiniz?", "Not Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_NOTLAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not Kaydı Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            mtbtarih.Text = "";
            mtbsaat.Text = "";
            txtbaslik.Text = "";
            richdetay.Text = "";
            txtolusturan.Text = "";
            txthitap.Text = "";
            txtid.Text = "";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.metin = dr["Detay"].ToString();
            }
            fr.Show();
        }
    }
}
