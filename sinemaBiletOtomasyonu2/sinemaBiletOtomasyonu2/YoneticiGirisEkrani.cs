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
    public partial class YoneticiGirisEkrani : Form
    {
        public YoneticiGirisEkrani()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" 
            + Application.StartupPath + "\\sinemaBiletDataBase.accdb ");
        private void YoneticiGirisEkrani_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FrmSalonEkle salonEkle = new FrmSalonEkle();
            salonEkle.Show();
            this.Hide();

        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            
            FrmFilmEkle filmEkle = new FrmFilmEkle();
            filmEkle.Show();
            this.Hide();

        }



        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            
            FrmSeansEkle seansEkle = new FrmSeansEkle();
            seansEkle.Show();
            this.Hide();

        }
        private void satisListele()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From SatisBilgileri";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Satisid"].ToString();
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["SalonAd"].ToString());
                ekle.SubItems.Add(oku["FilmAd"].ToString());
                ekle.SubItems.Add(oku["FilmTarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                ekle.SubItems.Add(oku["AlindigiTarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void btn_satis_Click(object sender, EventArgs e)
        {
            satisListele();
        }

        private void YoneticiGirisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisEkrani giris = new GirisEkrani();
            giris.Show();
            this.Hide();
        }
    }
}
