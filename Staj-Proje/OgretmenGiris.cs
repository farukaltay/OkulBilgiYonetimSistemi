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
    public partial class OgretmenGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Integrated Security=TRUE;Initial Catalog=Proje-Staj");
       
        public OgretmenGiris()
        {
            InitializeComponent();
        }

        private void btnGiris(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Kullaniciadi,Sifre from Ogretmen where Kullaniciadi=@Kullaniciadi and Sifre=@Sifre",baglanti);
            komut.Parameters.AddWithValue("@Kullaniciadi", textBox1.Text);
            komut.Parameters.AddWithValue("@Sifre", textBox2.Text);
            
            
            SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read()) //data reader açıldı ve okuyabiliyor ise
                {
                    MessageBox.Show("Giriş başarılı");
                    this.Hide();
                    Ogretmenİslem ogretmen = new Ogretmenİslem();
                    ogretmen.isim = textBox1.Text.ToString();
                    ogretmen.ShowDialog();
                    this.Show();
                    textBox2.Text = "";
                    textBox1.Text = "";
                              
                }
                else
                {
                    MessageBox.Show("Hatalı giriş");
                    textBox2.Text = "";
                    textBox1.Text = "";

                }
                baglanti.Close();

            }

        private void OgretmenGiris_Load(object sender, EventArgs e)
        {
        
        }
            
        }
    }

