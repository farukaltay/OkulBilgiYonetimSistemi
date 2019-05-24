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
    public partial class Ogretmenİslem : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Integrated Security=TRUE;Initial Catalog=Proje-Staj");
        DataTable dt;
        public string tckn;
        public string tc;
        public string isim;
        public Ogretmenİslem()
        {
            InitializeComponent();
        }

        private void ogretmen_Load(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Sinavlar", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sinavlar");
            dataGridView1.DataSource = ds.Tables["Sinavlar"];
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            SqlDataAdapter da2 = new SqlDataAdapter("Select İsim from Ogretmen where Kullaniciadi='" + isim + "'", baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "Ogretmen");
            dataGridView2.DataSource = ds2.Tables["Ogretmen"];
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            label15.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            tb31.Clear();
            tb32.Clear();
            tb33.Clear();
            tb34.Clear();
            tb35.Clear();
            tb36.Clear();

            label13.Text = "NULL"; label13.ForeColor = System.Drawing.Color.Gray;
            label14.Text = "NULL"; label14.ForeColor = System.Drawing.Color.Gray;
            label16.Text = "NULL"; label16.ForeColor = System.Drawing.Color.Gray;
            label17.Text = "NULL"; label17.ForeColor = System.Drawing.Color.Gray;
            label18.Text = "NULL"; label18.ForeColor = System.Drawing.Color.Gray;
            label19.Text = "NULL"; label19.ForeColor = System.Drawing.Color.Gray;

            if (dataGridView1.SelectedRows.Count != 0)
            {
                tc = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                tb1. Text = dataGridView1.SelectedRows[0].Cells[2]. Value.ToString();
                tb2. Text = dataGridView1.SelectedRows[0].Cells[3]. Value.ToString();
                tb3. Text = dataGridView1.SelectedRows[0].Cells[4]. Value.ToString();
                tb4. Text = dataGridView1.SelectedRows[0].Cells[5]. Value.ToString();
                tb6. Text = dataGridView1.SelectedRows[0].Cells[6]. Value.ToString();
                tb7. Text = dataGridView1.SelectedRows[0].Cells[7]. Value.ToString();
                tb8. Text = dataGridView1.SelectedRows[0].Cells[8]. Value.ToString();
                tb9. Text = dataGridView1.SelectedRows[0].Cells[9]. Value.ToString();
                tb11.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                tb12.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                tb13.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                tb14.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                tb16.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                tb17.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                tb18.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
                tb19.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
                tb21.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
                tb22.Text = dataGridView1.SelectedRows[0].Cells[19].Value.ToString();
                tb23.Text = dataGridView1.SelectedRows[0].Cells[20].Value.ToString();
                tb24.Text = dataGridView1.SelectedRows[0].Cells[21].Value.ToString();
                tb26.Text = dataGridView1.SelectedRows[0].Cells[22].Value.ToString();
                tb27.Text = dataGridView1.SelectedRows[0].Cells[23].Value.ToString();
                tb28.Text = dataGridView1.SelectedRows[0].Cells[24].Value.ToString();
                tb29.Text = dataGridView1.SelectedRows[0].Cells[25].Value.ToString();
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

                if (tb1.Text != string.Empty && tb2.Text != string.Empty && tb3.Text != string.Empty && tb4.Text != string.Empty && tb6.Text != string.Empty && tb7.Text != string.Empty && tb8.Text != string.Empty && tb9.Text != string.Empty && tb11.Text != string.Empty && tb12.Text != string.Empty && tb13.Text != string.Empty && tb14.Text != string.Empty && tb16.Text != string.Empty && tb17.Text != string.Empty && tb18.Text != string.Empty && tb19.Text != string.Empty && tb21.Text != string.Empty && tb22.Text != string.Empty && tb23.Text != string.Empty && tb24.Text != string.Empty && tb26.Text != string.Empty && tb27.Text != string.Empty && tb28.Text != string.Empty && tb29.Text != string.Empty)
                {
                    double sayi = (Convert.ToDouble(tb1.Text)   + Convert.ToDouble(tb2.Text)  + Convert.ToDouble(tb3.Text)  + Convert.ToDouble(tb4.Text)) / (4);
                    double sayi2 = (Convert.ToDouble(tb6.Text)  + Convert.ToDouble(tb7.Text)  + Convert.ToDouble(tb8.Text)  + Convert.ToDouble(tb9.Text)) / (4);
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
                label8.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                label11.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); 
           
            }
            else { MessageBox.Show("Lütfen Satır Seçiniz."); }
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tc != null)
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Sinavlar SET Matematik1=@Matematik1,Matematik2=@Matematik2,Matematik3=@Matematik3,Matematik4=@Matematik4,Turkce1=@Turkce1,Turkce2=@Turkce2,Turkce3=@Turkce3,Turkce4=@Turkce4,Fenbilimleri1=@Fenbilimleri1,Fenbilimleri2=@Fenbilimleri2,Fenbilimleri3=@Fenbilimleri3,Fenbilimleri4=@Fenbilimleri4,Tarih1=@Tarih1,Tarih2=@Tarih2,Tarih3=@Tarih3,Tarih4=@Tarih4,Beden1=@Beden1,Beden2=@Beden2,Beden3=@Beden3,Beden4=@Beden4,Muzik1=@Muzik1,Muzik2=@Muzik2,Muzik3=@Muzik3,Muzik4=@Muzik4 WHERE TcKimlik=@TcKimlik ", baglanti);
                cmd.Parameters.AddWithValue("@TcKimlik", tc);

                cmd.Parameters.AddWithValue("@Matematik1", tb1.Text);
                cmd.Parameters.AddWithValue("@Matematik2", tb2.Text);
                cmd.Parameters.AddWithValue("@Matematik3", tb3.Text);
                cmd.Parameters.AddWithValue("@Matematik4", tb4.Text);
                cmd.Parameters.AddWithValue("@Turkce1", tb6.Text);
                cmd.Parameters.AddWithValue("@Turkce2", tb7.Text);
                cmd.Parameters.AddWithValue("@Turkce3", tb8.Text);
                cmd.Parameters.AddWithValue("@Turkce4", tb9.Text);
                cmd.Parameters.AddWithValue("@Fenbilimleri1", tb11.Text);
                cmd.Parameters.AddWithValue("@Fenbilimleri2", tb12.Text);
                cmd.Parameters.AddWithValue("@Fenbilimleri3", tb13.Text);
                cmd.Parameters.AddWithValue("@Fenbilimleri4", tb14.Text);
                cmd.Parameters.AddWithValue("@Tarih1", tb16.Text);
                cmd.Parameters.AddWithValue("@Tarih2", tb17.Text);
                cmd.Parameters.AddWithValue("@Tarih3", tb18.Text);
                cmd.Parameters.AddWithValue("@Tarih4", tb19.Text);
                cmd.Parameters.AddWithValue("@Beden1", tb21.Text);
                cmd.Parameters.AddWithValue("@Beden2", tb22.Text);
                cmd.Parameters.AddWithValue("@Beden3", tb23.Text);
                cmd.Parameters.AddWithValue("@Beden4", tb24.Text);
                cmd.Parameters.AddWithValue("@Muzik1", tb26.Text);
                cmd.Parameters.AddWithValue("@Muzik2", tb27.Text);
                cmd.Parameters.AddWithValue("@Muzik3", tb28.Text);
                cmd.Parameters.AddWithValue("@Muzik4", tb29.Text);
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

                if (tb1.Text != string.Empty && tb2.Text != string.Empty && tb3.Text != string.Empty && tb4.Text != string.Empty && tb6.Text != string.Empty && tb7.Text != string.Empty && tb8.Text != string.Empty && tb9.Text != string.Empty && tb11.Text != string.Empty && tb12.Text != string.Empty && tb13.Text != string.Empty && tb14.Text != string.Empty && tb16.Text != string.Empty && tb17.Text != string.Empty && tb18.Text != string.Empty && tb19.Text != string.Empty && tb21.Text != string.Empty && tb22.Text != string.Empty && tb23.Text != string.Empty && tb24.Text != string.Empty && tb26.Text != string.Empty && tb27.Text != string.Empty && tb28.Text != string.Empty && tb29.Text != string.Empty)
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

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from Sinavlar", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Sinavlar");
                dataGridView1.DataSource = ds.Tables["Sinavlar"];
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if(checkBox1.Checked==true)
                {
                    SqlCommand komut2 = new SqlCommand("Select * from Devamsizlik where Devamsizlik=@Devamsizlik",baglanti);
                    komut2.Parameters.AddWithValue("@Devamsizlik", tc + "-" + dateTimePicker1.Text.ToString());
                    SqlDataReader dr3 = komut2.ExecuteReader();
                    if (dr3.Read())
                    {
                        MessageBox.Show("Aynı Gün Ve Aynı Öğrenci İçin Devamsızlık 1 den Fazla Girilemez");

                    }
                        
                    else
                    {
                        dr3.Close();
                        SqlDataReader dr2 = komut2.ExecuteReader();
                        SqlCommand komut = new SqlCommand("insert into Devamsizlik(Devamsizlik) values(@Devamsizlik)", baglanti);
                        komut.Parameters.AddWithValue("@Devamsizlik", tc + "-" + dateTimePicker1.Text.ToString());
                        dr2.Close();
                        komut.ExecuteNonQuery();
                        
                    }              
                }
                else { }
            }
            else { }
            
                baglanti.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
      
    }
}
