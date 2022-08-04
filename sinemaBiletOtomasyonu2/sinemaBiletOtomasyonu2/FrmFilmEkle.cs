using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sinemaBiletOtomasyonu2
{
    public partial class FrmFilmEkle : Form
    {
        public FrmFilmEkle()
        {
            InitializeComponent();
        }

        private void FrmFilmEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            YoneticiGirisEkrani giris2 = new YoneticiGirisEkrani();
            giris2.ShowDialog();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" 
            + Application.StartupPath + "\\sinemaBiletDataBase.accdb");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert into FilmBilgileri (FilmAd,FilmSure,FilmEklenmeTarih,Resim,FilmTuru) " +
                    "values ('" + txt_filmad.Text + "','"+txt_sure.Text + "','"+dtp_tarih.Text + "','"
                    +pictureBox1.ImageLocation+"','"+cmb_flimTuru.Text+"')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Film Eklendi", "Ekle");
                baglanti.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                baglanti.Close();
            }
        }

        private void FrmFilmEkle_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

       

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiGirisEkrani giris2 = new YoneticiGirisEkrani();
            giris2.ShowDialog();
            
        }
    }
}
