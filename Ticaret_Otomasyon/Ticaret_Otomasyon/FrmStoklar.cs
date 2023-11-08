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
         

            chartControl2.Series["Series 2"].Points.AddPoint("istanbul", 16);
            chartControl2.Series["Series 2"].Points.AddPoint("İzmir", 6);
            chartControl2.Series["Series 2"].Points.AddPoint("Ankara", 6);
            chartControl2.Series["Series 2"].Points.AddPoint("Adana", 5);


            SqlDataAdapter da = new SqlDataAdapter("Select UrunAd");
          
        }
    }
}
