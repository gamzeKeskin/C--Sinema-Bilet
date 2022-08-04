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
    public partial class UyeGirisEkrani : Form
    {
        public UyeGirisEkrani()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" 
            + Application.StartupPath + "\\sinemaBiletDataBase.accdb ");
        
        
        int sayac=0;
        private void bosKoltuk()
        {
            sayac = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Button buton = new Button();
                    buton.Size = new Size(30, 30);
                    buton.BackColor = Color.Tan;
                    buton.Location = new Point(j * 30 + 20, i * 30 + 30);
                    buton.Name = sayac.ToString();
                    buton.Text = sayac.ToString();
                    buton.Image = ((System.Drawing.Image)(Properties.Resources.armchair));
                    buton.ForeColor = Color.White;
                    
                    if (j == 5)
                    {
                        continue;
                    }
                    sayac++;
                    this.pnlKoltukDuzen.Controls.Add(buton);
                    buton.Click += Buton_Click;
                }

            }
        }

        private void koltuk_iptal()
        {
            cmbKoltukiptal.Items.Clear();
            cmbKoltukiptal.Text = "";
            foreach (Control item in pnlKoltukDuzen.Controls)
            {
                if (item is Button)
                {
                    if(item.BackColor == Color.DarkRed)
                    {
                        cmbKoltukiptal.Items.Add(item.Text);
                    }
                }
            }
        }

        private void koltukRenginiYenile()
        {
            foreach (Control item in pnlKoltukDuzen.Controls)
            {
                item.BackColor = Color.Tan;
            }
        }

        private void dolu_koltuklariBoya()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From SatisBilgileri where FilmAd='" 
                + cmbFilmAd.SelectedItem + "' and SalonAd='"+cmbSalonAd.SelectedItem+"' and FilmTarih='"
                +cmbFilmTarih.SelectedItem+"' and Saat='"+cmbFilmSeans.SelectedItem+"' ", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                foreach (Control item in pnlKoltukDuzen.Controls)
                {
                    if(item is Button)
                    {
                        if (oku["koltukNo"].ToString() == item.Text)
                        {
                            item.BackColor = Color.DarkRed;
                        }
                        
                    }
                }
            }
            baglanti.Close();
        }

        private void filmveSalonGoster(ComboBox combo, string sorgu, string sorgu2)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                combo.Items.Add(oku[sorgu2].ToString());
            }
            baglanti.Close();
        }
        private void UyeGirisEkranics_Load(object sender, EventArgs e)
        {
            bosKoltuk();
            filmveSalonGoster(cmbFilmAd, "Select * From FilmBilgileri", "FilmAd");
            filmveSalonGoster(cmbSalonAd, "Select * From SalonBilgileri", "SalonAd");

        }
        private void resimGoster()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From FilmBilgileri where FilmAd='"
                +cmbFilmAd.SelectedItem+"' ",baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                pcFilmAfis.ImageLocation = oku["Resim"].ToString();
            }
            baglanti.Close();
        
    }




        private void Buton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.BackColor == Color.Tan)
            {
                txt_koltukNo.Text = b.Text;
            }
        }

        private void lblBilgi_Click(object sender, EventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSoyad_Click(object sender, EventArgs e)
        {

        }

        private void txt_soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_telNo_Click(object sender, EventArgs e)
        {

        }

        private void txt_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        OleDbCommand komut = new OleDbCommand();

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            if(cmbKoltukiptal.Text != "")
            {
                try
                {

                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "Delete from SatisBilgileri where KoltukNo='" + cmbKoltukiptal.Text + "'";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    koltukRenginiYenile();
                    dolu_koltuklariBoya();
                    koltuk_iptal();
                    
                }
                catch (Exception hata)
                {
                    MessageBox.Show("HATA"+hata.Message+ "Uyarı");
                    baglanti.Close();

                }

            }
            else
            {
                MessageBox.Show("Koltuk Seçiniz", "Uyarı");
                baglanti.Close();
            }
        }

        private void cmbFilmAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilmSeans.Items.Clear();
            cmbFilmTarih.Items.Clear();
            cmbFilmTarih.Text = "";
            cmbFilmSeans.Text = "";
            cmbSalonAd.Text = "";
            foreach (Control item in pnlKoltukDuzen.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
            resimGoster();
            koltukRenginiYenile();
            dolu_koltuklariBoya();
        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            if(txt_koltukNo.Text != "")
            {
                try
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("Insert into SatisBilgileri " +
                        "(KoltukNo,SalonAd,FilmAd, FilmTarih, Saat,Ad,Soyad,Fiyat,AlindigiTarih) " +
                        "values ('" + txt_koltukNo.Text + "','" + cmbSalonAd.Text + "','" 
                        + cmbFilmAd.Text + "','" +cmbFilmTarih.Text+ "','"+ cmbFilmSeans.Text+"','"
                        +txt_ad.Text+"','"+txt_soyad.Text+"','"+cmbUcret.Text+"','"+DateTime.Now.ToString()+"')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Bilet Alımı Başarılı", "Mesaj");
                    foreach (Control item in pnlKoltukDuzen.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                    baglanti.Close();
                    koltukRenginiYenile();
                    dolu_koltuklariBoya();
                    koltuk_iptal();
                    
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    baglanti.Close();
                }
            }
        }
        private void filmTarihiGetir()
        {
            cmbFilmTarih.Text = "";
            cmbFilmSeans.Text = "";
            cmbFilmSeans.Items.Clear();
            cmbFilmTarih.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From SeansBilgileri where FilmAd='" 
                + cmbFilmAd.SelectedItem + "'and SalonAdi='" + cmbSalonAd.SelectedItem + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            DateTime bugun = DateTime.Today; ;
            while (oku.Read())
            {
                if (DateTime.Parse(oku["tarih"].ToString()) >= bugun)
                {
                    if (!cmbFilmTarih.Items.Contains(oku["tarih"].ToString()))
                    {
                        cmbFilmTarih.Items.Add(oku["Tarih"].ToString());
                    }
                }
            
            }
            baglanti.Close();
        }

        private void cmbSalonAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmTarihiGetir();
        }

        private void filmSeansiGoster()
        {
            cmbFilmSeans.Text = "";
            cmbFilmSeans.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From SeansBilgileri where FilmAd='"
                + cmbFilmAd.SelectedItem + "'and SalonAdi='" + cmbSalonAd.SelectedItem + "'and tarih='"
                +cmbFilmTarih.SelectedItem+"'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            DateTime bugun = DateTime.Today;
            
            while (oku.Read())
            {
                if (DateTime.Parse(oku["tarih"].ToString()) == bugun)
                {
                    if (DateTime.Parse(oku["seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        cmbFilmSeans.Items.Add(oku["seans"].ToString());
                    }
                }

                else if (DateTime.Parse(oku["tarih"].ToString()) > bugun)
                {
                    
                        cmbFilmSeans.Items.Add(oku["seans"].ToString());
                    
                }

            }
            baglanti.Close();
        }
        private void ucretGoster()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From SeansBilgileri where FilmAd='" 
                + cmbFilmAd.SelectedItem + "'and SalonAdi='" + cmbSalonAd.SelectedItem + "'and tarih='" 
                + cmbFilmTarih.SelectedItem + "'and seans='"+cmbFilmSeans.SelectedItem+"'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            DateTime bugun = DateTime.Today;

            while (oku.Read())
            {
                if (DateTime.Parse(oku["tarih"].ToString()) == bugun)
                {
                    if (DateTime.Parse(oku["seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        cmbUcret.Items.Add(oku["fiyat"].ToString());
                    }
                }

                else if (DateTime.Parse(oku["tarih"].ToString()) > bugun)
                {

                    cmbUcret.Items.Add(oku["fiyat"].ToString());

                }

            }
            baglanti.Close();
        }
        private void cmbFilmTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmSeansiGoster();
        }

        private void cmbFilmSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucretGoster();
            koltukRenginiYenile();
            dolu_koltuklariBoya();
            koltuk_iptal();
        }

        private void pnlKoltukDuzen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UyeGirisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            GirisEkrani giris = new GirisEkrani();
            giris.Show();
            this.Hide();
        }
    }
}
