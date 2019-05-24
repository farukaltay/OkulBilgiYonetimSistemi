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
    public partial class OgrenciGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Integrated Security=TRUE;Initial Catalog=Proje-Staj");
        public string tck;
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void btnGiris(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TcKimlik,Okulno from Sinavlar where TcKimlik=@TcKimlik and Okulno=@Okulno",baglanti);
            komut.Parameters.AddWithValue("@TcKimlik", textBox1.Text);
            komut.Parameters.AddWithValue("@Okulno", textBox2.Text);
            tck = textBox1.Text;
            
            SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read()) //data reader açıldı ve okuyabiliyor ise
                {
                    MessageBox.Show("Giriş başarılı");
                    this.Hide();
                    Ogrenciİslem ogrIslem = new Ogrenciİslem();
                    ogrIslem.tckn = textBox1.Text.ToString();
                    ogrIslem.ShowDialog();
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

        private void ogrenci_Load(object sender, EventArgs e)
        {

        }
        }
    }

