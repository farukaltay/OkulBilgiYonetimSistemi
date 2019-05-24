using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 *** Faruk_Altay 07.07.2017
 */

namespace OkulBilgiYonetimSistemi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnOgretmenGiris(object sender, EventArgs e)
        {
            this.Hide();
            OgretmenGiris ogretmen = new OgretmenGiris();
            ogretmen.ShowDialog();
            this.Show();
           
        }

        private void btnOgrenciGiris(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciGiris ogr = new OgrenciGiris();
            ogr.ShowDialog();
            this.Show();
            
        }

        private void btnYoneticiGiris(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiGiris ynt = new YoneticiGiris();
            ynt.ShowDialog();
            this.Show();
            
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
