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
using System.Globalization;

namespace sinemaBiletOtomasyonu2
{
    public partial class FrmSeansEkle : Form
    {
        public FrmSeansEkle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" 
            + Application.StartupPath + "\\sinemaBiletDataBase.accdb ");


        private void filmveSalonGoster(ComboBox combo, string sorgu, string sorgu2)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read() == true)
            {
                combo.Items.Add(oku[sorgu2].ToString());
            }
            baglanti.Close();
        }
      
        private void FrmSeansEkle_Load(object sender, EventArgs e)
        {
            filmveSalonGoster(cmb_filmAd, "select * from FilmBilgileri", "FilmAd");
            filmveSalonGoster(cmb_salonad, "select * from SalonBilgileri", "SalonAd");

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void dtp_tarih_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in grpBox_seans.Controls)
            {
                item3.Enabled = true;
            }
            DateTime bugun = DateTime.Today; ;
            DateTime yeni = dtp_tarih.Value.Date; ;
            if (yeni > bugun)
            {
                tarihKarsilastir();
            }
            else if (yeni < bugun)
            {
                MessageBox.Show("Geçersiz Tarih", "Uyarı");
            }
        }
        private void tarihKarsilastir()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from SeansBilgileri where SalonAdi='" 
                + cmb_salonad.Text + "'and Tarih='" + dtp_tarih.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read() == true)
            {
                foreach (Control item2 in grpBox_seans.Controls)
                {
                    if (oku["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglanti.Close();
        }

        private void cmb_salonad_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cmb_filmAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string seans = "";

        private void seansEklendiyse()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
            else if (radioButton13.Checked == true) seans = radioButton13.Text;
            else if (radioButton14.Checked == true) seans = radioButton14.Text;
            else if (radioButton15.Checked == true) seans = radioButton15.Text;
        }

     

        private void btn_seansEkle_Click(object sender, EventArgs e)
        {
            seansEklendiyse();
           if(seans != "")
            {
                try
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("Insert into SeansBilgileri " +
                        "(FilmAd,SalonAdi, Tarih, Seans,Fiyat) values ('" +cmb_filmAd.Text +"','"
                        +cmb_salonad.Text +"','" + dtp_tarih.Text +"','"+seans+"','"+cmbFiyat.Text+"')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Seans Eklendi", "Ekle");
                    baglanti.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    baglanti.Close();
                }
            }
           else if(seans == "")
            {
                MessageBox.Show("Seans Seçiniz", "Uyarı");
            }
            cmb_filmAd.Text = "";
            cmb_salonad.Text = "";
            dtp_tarih.Text = DateTime.Now.ToShortDateString();
           // listView1.Clear();
        }

        private void seansListele()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From SeansBilgileri";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Seansid"].ToString();
                ekle.SubItems.Add(oku["FilmAd"].ToString());
                ekle.SubItems.Add(oku["SalonAdi"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Seans"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btn_seansList_Click(object sender, EventArgs e)
        {
            seansListele();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmSeansEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            YoneticiGirisEkrani giris = new YoneticiGirisEkrani();
            giris.Show();
        }
    }
}
