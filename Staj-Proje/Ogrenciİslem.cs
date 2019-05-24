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

/**
 *** Faruk_Altay 07.07.2017
 */

namespace OkulBilgiYonetimSistemi
{
    public partial class Ogrenciİslem : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Integrated Security=TRUE;Initial Catalog=Proje-Staj");
        public string tckn;
        OgrenciGiris ogr = new OgrenciGiris();
        DataTable dt;
     
        public Ogrenciİslem()
        {
            InitializeComponent();
            

        }

        private void ogrencinot_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            
            SqlDataAdapter da = new SqlDataAdapter("select * from Sinavlar where TcKimlik='" +tckn+ "'", baglanti);          
            DataSet ds = new DataSet();
            da.Fill(ds, "Sinavlar");
            dataGridView1.DataSource = ds.Tables["Sinavlar"];
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            label20.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            label21.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            tb1.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            tb2.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            tb3.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            tb4.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            tb6.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            tb7.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            tb8.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
            tb9.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
            tb11.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
            tb12.Text = dataGridView1.Rows[0].Cells[11].Value.ToString();
            tb13.Text = dataGridView1.Rows[0].Cells[12].Value.ToString();
            tb14.Text = dataGridView1.Rows[0].Cells[13].Value.ToString();
            tb16.Text = dataGridView1.Rows[0].Cells[14].Value.ToString();
            tb17.Text = dataGridView1.Rows[0].Cells[15].Value.ToString();
            tb18.Text = dataGridView1.Rows[0].Cells[16].Value.ToString();
            tb19.Text = dataGridView1.Rows[0].Cells[17].Value.ToString();
            tb21.Text = dataGridView1.Rows[0].Cells[18].Value.ToString();
            tb22.Text = dataGridView1.Rows[0].Cells[19].Value.ToString();
            tb23.Text = dataGridView1.Rows[0].Cells[20].Value.ToString();
            tb24.Text = dataGridView1.Rows[0].Cells[21].Value.ToString();
            tb26.Text = dataGridView1.Rows[0].Cells[22].Value.ToString();
            tb27.Text = dataGridView1.Rows[0].Cells[23].Value.ToString();
            tb28.Text = dataGridView1.Rows[0].Cells[24].Value.ToString();
            tb29.Text = dataGridView1.Rows[0].Cells[25].Value.ToString();     
            baglanti.Close();
            if (tb1.Text != string.Empty && tb2.Text != string.Empty && tb3.Text != string.Empty && tb4.Text != string.Empty && tb6.Text != string.Empty && tb7.Text != string.Empty && tb8.Text != string.Empty && tb9.Text != string.Empty && tb11.Text != string.Empty && tb12.Text != string.Empty && tb13.Text != string.Empty && tb14.Text != string.Empty && tb16.Text != string.Empty && tb17.Text != string.Empty && tb18.Text != string.Empty && tb19.Text != string.Empty && tb21.Text != string.Empty && tb22.Text != string.Empty && tb23.Text != string.Empty && tb24.Text != string.Empty && tb26.Text != string.Empty && tb27.Text != string.Empty && tb28.Text != string.Empty && tb29.Text != string.Empty)
            {
                double sayi = (Convert.ToDouble(tb1.Text) + Convert.ToDouble(tb2.Text) + Convert.ToDouble(tb3.Text) + Convert.ToDouble(tb4.Text)) / (4);
                tb31.Text = sayi.ToString();
                double sayi2 = (Convert.ToDouble(tb6.Text) + Convert.ToDouble(tb7.Text) + Convert.ToDouble(tb8.Text) + Convert.ToDouble(tb9.Text)) / (4);
                tb32.Text = sayi2.ToString();
                double sayi3 = (Convert.ToDouble(tb11.Text) + Convert.ToDouble(tb12.Text) + Convert.ToDouble(tb13.Text) + Convert.ToDouble(tb14.Text)) / (4);
                tb33.Text = sayi3.ToString();
                double sayi4 = (Convert.ToDouble(tb16.Text) + Convert.ToDouble(tb17.Text) + Convert.ToDouble(tb18.Text) + Convert.ToDouble(tb19.Text)) / (4);
                tb34.Text = sayi4.ToString();
                double sayi5 = (Convert.ToDouble(tb21.Text) + Convert.ToDouble(tb22.Text) + Convert.ToDouble(tb23.Text) + Convert.ToDouble(tb24.Text)) / (4);
                tb35.Text = sayi5.ToString();
                double sayi6 = (Convert.ToDouble(tb26.Text) + Convert.ToDouble(tb27.Text) + Convert.ToDouble(tb28.Text) + Convert.ToDouble(tb29.Text)) / (4);
                tb36.Text = sayi6.ToString();
            }
            else { }

            if (tb31.Text != string.Empty && tb32.Text != string.Empty && tb33.Text != string.Empty && tb34.Text != string.Empty && tb35.Text != string.Empty && tb36.Text != string.Empty)
            {
                double sayi = (Convert.ToDouble(tb1.Text) + Convert.ToDouble(tb2.Text) + Convert.ToDouble(tb3.Text) + Convert.ToDouble(tb4.Text)) / (4);
                double sayi2 = (Convert.ToDouble(tb6.Text) + Convert.ToDouble(tb7.Text) + Convert.ToDouble(tb8.Text) + Convert.ToDouble(tb9.Text)) / (4);
                double sayi3 = (Convert.ToDouble(tb11.Text) + Convert.ToDouble(tb12.Text) + Convert.ToDouble(tb13.Text) + Convert.ToDouble(tb14.Text)) / (4);
                double sayi4 = (Convert.ToDouble(tb16.Text) + Convert.ToDouble(tb17.Text) + Convert.ToDouble(tb18.Text) + Convert.ToDouble(tb19.Text)) / (4);
                double sayi5 = (Convert.ToDouble(tb21.Text) + Convert.ToDouble(tb22.Text) + Convert.ToDouble(tb23.Text) + Convert.ToDouble(tb24.Text)) / (4);
                double sayi6 = (Convert.ToDouble(tb26.Text) + Convert.ToDouble(tb27.Text) + Convert.ToDouble(tb28.Text) + Convert.ToDouble(tb29.Text)) / (4);

                if (sayi > 49.5)
                {
                    label13.Text = "GEÇTİ";
                    label13.ForeColor = System.Drawing.Color.Green;
                }
                else { label13.Text = "KALDI"; label13.ForeColor = System.Drawing.Color.Red; }
                if (sayi2 > 49.5)
                {
                    label14.Text = "GEÇTİ";
                    label14.ForeColor = System.Drawing.Color.Green;
                }
                else { label14.Text = "KALDI"; label14.ForeColor = System.Drawing.Color.Red; }
                if (sayi3 > 49.5)
                {
                    label16.Text = "GEÇTİ";
                    label16.ForeColor = System.Drawing.Color.Green;
                }
                else { label16.Text = "KALDI"; label16.ForeColor = System.Drawing.Color.Red; }
                if (sayi4 > 49.5)
                {
                    label17.Text = "GEÇTİ";
                    label17.ForeColor = System.Drawing.Color.Green;
                }
                else { label17.Text = "KALDI"; label17.ForeColor = System.Drawing.Color.Red; }
                if (sayi5 > 49.5)
                {
                    label18.Text = "GEÇTİ";
                    label18.ForeColor = System.Drawing.Color.Green;
                }
                else { label18.Text = "KALDI"; label18.ForeColor = System.Drawing.Color.Red; }
                if (sayi6 > 49.5)
                {
                    label19.Text = "GEÇTİ";
                    label19.ForeColor = System.Drawing.Color.Green;
                }
                else { label19.Text = "KALDI"; label19.ForeColor = System.Drawing.Color.Red; }
            }
            else { }

            baglanti.Open();

            
            string sorgu = "Select * from Devamsizlik where Devamsizlik Like '" + dataGridView1.Rows[0].Cells[0].Value.ToString() + "%'";

            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);

            DataSet ds3 = new DataSet();

            adap.Fill(ds3);
            
            listBox1.DataSource = ds3.Tables[0];
            listBox1.DisplayMember = "Devamsizlik"; 
            label24.Text = listBox1.Items.Count.ToString();
            
            if (Convert.ToInt32(label24.Text) > 20)
            {
                label25.Text = "KALDI";
                label25.ForeColor = Color.Red;
            }
            else { label25.Text = "GEÇER"; label25.ForeColor = Color.Green; }

            baglanti.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
    }
}
