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
    public partial class Yoneticiİslem : Form
    {
        public string isim;
        SqlConnection baglanti = new SqlConnection("Data Source=.;Integrated Security=TRUE;Initial Catalog=Proje-Staj");

        public Yoneticiİslem()
        {
            InitializeComponent();

        }

        private void Yoneticiİslem_Load(object sender, EventArgs e)
        {
            this.ogretmenTableAdapter.Fill(this._Proje_StajDataSet1.Ogretmen);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Ogretmen  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "Ogretmen");
            dataGridView1.DataSource = ds.Tables["Ogretmen"];
            
            SqlDataAdapter da3 = new SqlDataAdapter("select * from Sinavlar  ", baglanti);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3, "Sinavlar");
            dataGridView3.DataSource = ds3.Tables["Sinavlar"];

            SqlDataAdapter da2 = new SqlDataAdapter("Select İsim from Yonetici where Kullaniciadi='" + isim + "'", baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "Yonetici");
            dataGridView2.DataSource = ds2.Tables["Yonetici"];
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            label2.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
            baglanti.Close();
         
            
        }

        private void btnOgretmenEkle(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Select Kullaniciadi from Ogretmen where Kullaniciadi=@Kullaniciadi", baglanti);
                komut2.Parameters.AddWithValue("@Kullaniciadi", textBox2.Text);
               
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    MessageBox.Show("Böyle bir kullanıcı adı ile öğretmen bulunmaktadır!");
                    baglanti.Close();
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox1.Text = "";        
                }
                else
                {
                    dr2.Close();
                    SqlCommand komut = new SqlCommand("insert into Ogretmen(İsim,Kullaniciadi,Sifre) values(@İsim,@Kullaniciadi,@Sifre)", baglanti);
                    komut.Parameters.AddWithValue("@İsim", textBox1.Text);
                    komut.Parameters.AddWithValue("@Kullaniciadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@Sifre", textBox3.Text);
                    
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Öğretmen Eklemeniz başarı ile gerçekleşmiştir.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = ""; 


                }
                SqlDataAdapter da = new SqlDataAdapter("select * from Ogretmen  ",baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Ogretmen");
                dataGridView1.DataSource = ds.Tables["Ogretmen"];
                baglanti.Close();
            }
            else
                MessageBox.Show("Tüm alanları doldurunuz");
        }

        private void btnOgretmenSil(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Ogretmen where Kullaniciadi=@Kullaniciadi",baglanti);
            komut.Parameters.AddWithValue("@Kullaniciadi", dataGridView1.CurrentRow.Cells[1].Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Seçilen veri silindi.");

            SqlDataAdapter da = new SqlDataAdapter("select * from Ogretmen  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "Ogretmen");
            dataGridView1.DataSource = ds.Tables["Ogretmen"];
            baglanti.Close();
                         
        }

        private void btnOgrenciEkle(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty)
            {
                baglanti.Open();
                SqlCommand komut22 = new SqlCommand("Select TcKimlik,Okulno from Sinavlar where TcKimlik=@TcKimlik or Okulno=@Okulno", baglanti);
                komut22.Parameters.AddWithValue("@TcKimlik", textBox6.Text);
                komut22.Parameters.AddWithValue("@Okulno", textBox4.Text);

                SqlDataReader dr22 = komut22.ExecuteReader();
                if (dr22.Read())
                {   
                    MessageBox.Show("Böyle bir Tc Kimlik No ile Veya Okul No ile Kayıtlı Öğrenci bulunmaktadır!");
                    baglanti.Close();
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
                else
                {
                    dr22.Close();
                    SqlCommand komut = new SqlCommand("insert into Sinavlar(TcKimlik,Ogrenci,Okulno) values(@TcKimlik,@Ogrenci,@Okulno)", baglanti);
                    komut.Parameters.AddWithValue("@TcKimlik", textBox6.Text);
                    komut.Parameters.AddWithValue("@Ogrenci", textBox5.Text);
                    komut.Parameters.AddWithValue("@Okulno", textBox4.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Öğrenci Eklemeniz Başarı İle Gerçekleşmiştir.");
                    textBox6.Text = "";
                    textBox5.Text = "";
                    textBox4.Text = "";


                }
                SqlDataAdapter da = new SqlDataAdapter("select * from Sinavlar  ", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Sinavlar");
                dataGridView3.DataSource = ds.Tables["Sinavlar"];
                baglanti.Close();
            }
            else
                MessageBox.Show("Tüm alanları doldurunuz");
        }

        private void btnOgrenciSil(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut23 = new SqlCommand("delete from Sinavlar where TcKimlik=@TcKimlik", baglanti);
            komut23.Parameters.AddWithValue("@TcKimlik", dataGridView3.CurrentRow.Cells[0].Value);
            komut23.ExecuteNonQuery();
            MessageBox.Show("Seçilen veri silindi.");

            SqlDataAdapter da = new SqlDataAdapter("select * from Sinavlar  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sinavlar");
            dataGridView3.DataSource = ds.Tables["Sinavlar"];
            baglanti.Close();
        }
    }
}
