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
    public partial class FrmSalonEkle : Form
    {
        public FrmSalonEkle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+ "\\sinemaBiletDataBase.accdb ");
        private void FrmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            YoneticiGirisEkrani giris = new YoneticiGirisEkrani();
            giris.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Insert into SalonBilgileri (SalonAd) values ('" + txtSalonEkle.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Salon Eklendi", "Ekle");
                baglanti.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
                baglanti.Close();
            }
          
        }
        private void FrmSalonEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
