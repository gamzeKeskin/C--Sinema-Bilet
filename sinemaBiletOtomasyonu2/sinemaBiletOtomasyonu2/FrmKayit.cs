using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemaBiletOtomasyonu2
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + Application.StartupPath + "\\sinemaBiletDataBase.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert into kullanici (Ad,Soyad,Sifre,Kullaniciadi)" 
                    + "values ('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtSifre.Text + "','" 
                    + txtKullaniciAd.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Mesaj");
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu " + hata.Message + "Hata");
                baglanti.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisEkrani giris = new GirisEkrani();
            giris.Show();
        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
