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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        //Veri tabanı dosya yolu ve provider nesnesinin belirlenmesi
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" 
            + Application.StartupPath + "\\sinemaBiletDataBase.accdb");

        //Yerel formda kullanılacak değişkenlerin tanımlanması
        bool durum = false;
        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            this.Text = "Kullanıcı Girişi";
            this.AcceptButton = btn_kullaniciGiris;
            this.CancelButton = btnCikis;
            radioButton1.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
        private void btn_kullaniciGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From kullanici ", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (radioButton1.Checked == true)
                {
                    if (oku["Kullaniciadi"].ToString() == txt_kullaniciAd.Text &&
                        oku["Sifre"].ToString() == txt_kullaniciSifre.Text && oku["yetki"].ToString() == "Yönetici")
                    {
                        durum = true;
                        this.Hide();
                        YoneticiGirisEkrani yoneticiGiris = new YoneticiGirisEkrani();
                        yoneticiGiris.Show();
                        break;
                    }

                }
                if (radioButton2.Checked == true)
                {
                    if (oku["Kullaniciadi"].ToString() == txt_kullaniciAd.Text && 
                        oku["Sifre"].ToString() == txt_kullaniciSifre.Text &&
                        oku["yetki"].ToString() == "Kullanıcı")
                    {
                        durum = true;
                        this.Hide();
                        UyeGirisEkrani uye = new UyeGirisEkrani();
                        uye.ShowDialog();
                        break;
                    }

                }
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKayit kayit = new FrmKayit();
            kayit.ShowDialog();
        }
    }
}
