﻿using System;
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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
            {
                InitializeComponent();
            }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        void listele()
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
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



        private void FrmMusteriler_Load(object sender, EventArgs e)
            {
                listele();

                sehirlistesi();

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
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER(AD,SOYAD,TELEFON,TELEFON2,TC,MAİL,İL,İLCE,ADRES,VERGİDAİRE) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbtel1.Text);
            komut.Parameters.AddWithValue("@p4", mtbtel2.Text);
            komut.Parameters.AddWithValue("@p5", MtbTC.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.Parameters.AddWithValue("@p7", Cmbil.Text);
            komut.Parameters.AddWithValue("@p8", cmbilce.Text);
            komut.Parameters.AddWithValue("@p9", richadres.Text);
            komut.Parameters.AddWithValue("@p10", txtvergid.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
           /* SqlCommand komutsil = new SqlCommand("Delete From TBL_MUSTERILER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Sistemeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
           */
           

            DialogResult delete = new DialogResult();
            delete = MessageBox.Show("Müşteri Kaydınız Sileceksiniz. Emin Misiniz?", "Müşteri Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_MUSTERILER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Kaydı Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }

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
                mtbtel2.Text = dr["TELEFON2"].ToString();
                MtbTC.Text = dr["TC"].ToString();
                txtmail.Text = dr["MAİL"].ToString();
                Cmbil.Text = dr["İL"].ToString();
                cmbilce.Text = dr["İLCE"].ToString();
                richadres.Text = dr["ADRES"].ToString();
                txtvergid.Text = dr["VERGİDAİRE"].ToString();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set AD=@p1 ,SOYAD=@p2 ,TELEFON=@p3 ,TELEFON2=@p4 ,TC=@p5 ,MAİL=@p6 ,İL=@p7 ,İLCE=@p8,ADRES=@p9 ,VERGİDAİRE=@p10 where ID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbtel1.Text);
            komut.Parameters.AddWithValue("@p4", mtbtel2.Text);
            komut.Parameters.AddWithValue("@p5", MtbTC.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.Parameters.AddWithValue("@p7", Cmbil.Text);
            komut.Parameters.AddWithValue("@p8", cmbilce.Text);
            komut.Parameters.AddWithValue("@p9", richadres.Text);
            komut.Parameters.AddWithValue("@p10", txtvergid.Text);
            komut.Parameters.AddWithValue("@p11", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
  

  
}
