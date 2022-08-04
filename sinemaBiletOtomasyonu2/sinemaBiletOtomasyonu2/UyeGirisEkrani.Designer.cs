
namespace sinemaBiletOtomasyonu2
{
    partial class UyeGirisEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlKoltukDuzen = new System.Windows.Forms.Panel();
            this.lblFilmAd = new System.Windows.Forms.Label();
            this.cmbFilmAd = new System.Windows.Forms.ComboBox();
            this.cmbSalonAd = new System.Windows.Forms.ComboBox();
            this.lblSalonAd = new System.Windows.Forms.Label();
            this.cmbFilmTarih = new System.Windows.Forms.ComboBox();
            this.lblFilmTarih = new System.Windows.Forms.Label();
            this.cmbFilmSeans = new System.Windows.Forms.ComboBox();
            this.lblFilmSeans = new System.Windows.Forms.Label();
            this.cmbUcret = new System.Windows.Forms.ComboBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblFilmAfis = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKoltukiptal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_koltukNo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.pcFilmAfis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFilmAfis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKoltukDuzen
            // 
            this.pnlKoltukDuzen.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlKoltukDuzen.Location = new System.Drawing.Point(22, 268);
            this.pnlKoltukDuzen.Name = "pnlKoltukDuzen";
            this.pnlKoltukDuzen.Size = new System.Drawing.Size(378, 159);
            this.pnlKoltukDuzen.TabIndex = 0;
            this.pnlKoltukDuzen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKoltukDuzen_Paint);
            // 
            // lblFilmAd
            // 
            this.lblFilmAd.AutoSize = true;
            this.lblFilmAd.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAd.Location = new System.Drawing.Point(36, 42);
            this.lblFilmAd.Name = "lblFilmAd";
            this.lblFilmAd.Size = new System.Drawing.Size(81, 21);
            this.lblFilmAd.TabIndex = 2;
            this.lblFilmAd.Text = "Film Adı:";
            // 
            // cmbFilmAd
            // 
            this.cmbFilmAd.BackColor = System.Drawing.Color.Tan;
            this.cmbFilmAd.DropDownHeight = 135;
            this.cmbFilmAd.DropDownWidth = 135;
            this.cmbFilmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFilmAd.FormattingEnabled = true;
            this.cmbFilmAd.IntegralHeight = false;
            this.cmbFilmAd.Location = new System.Drawing.Point(123, 42);
            this.cmbFilmAd.Name = "cmbFilmAd";
            this.cmbFilmAd.Size = new System.Drawing.Size(135, 24);
            this.cmbFilmAd.Sorted = true;
            this.cmbFilmAd.TabIndex = 3;
            this.cmbFilmAd.SelectedIndexChanged += new System.EventHandler(this.cmbFilmAd_SelectedIndexChanged);
            // 
            // cmbSalonAd
            // 
            this.cmbSalonAd.BackColor = System.Drawing.Color.Tan;
            this.cmbSalonAd.DropDownHeight = 135;
            this.cmbSalonAd.DropDownWidth = 135;
            this.cmbSalonAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSalonAd.FormattingEnabled = true;
            this.cmbSalonAd.IntegralHeight = false;
            this.cmbSalonAd.Location = new System.Drawing.Point(123, 81);
            this.cmbSalonAd.Name = "cmbSalonAd";
            this.cmbSalonAd.Size = new System.Drawing.Size(135, 24);
            this.cmbSalonAd.Sorted = true;
            this.cmbSalonAd.TabIndex = 5;
            this.cmbSalonAd.SelectedIndexChanged += new System.EventHandler(this.cmbSalonAd_SelectedIndexChanged);
            // 
            // lblSalonAd
            // 
            this.lblSalonAd.AutoSize = true;
            this.lblSalonAd.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAd.Location = new System.Drawing.Point(27, 81);
            this.lblSalonAd.Name = "lblSalonAd";
            this.lblSalonAd.Size = new System.Drawing.Size(90, 21);
            this.lblSalonAd.TabIndex = 4;
            this.lblSalonAd.Text = "Salon Adı:";
            // 
            // cmbFilmTarih
            // 
            this.cmbFilmTarih.BackColor = System.Drawing.Color.Tan;
            this.cmbFilmTarih.DropDownHeight = 135;
            this.cmbFilmTarih.DropDownWidth = 135;
            this.cmbFilmTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFilmTarih.FormattingEnabled = true;
            this.cmbFilmTarih.IntegralHeight = false;
            this.cmbFilmTarih.Location = new System.Drawing.Point(123, 124);
            this.cmbFilmTarih.Name = "cmbFilmTarih";
            this.cmbFilmTarih.Size = new System.Drawing.Size(135, 24);
            this.cmbFilmTarih.Sorted = true;
            this.cmbFilmTarih.TabIndex = 7;
            this.cmbFilmTarih.SelectedIndexChanged += new System.EventHandler(this.cmbFilmTarih_SelectedIndexChanged);
            // 
            // lblFilmTarih
            // 
            this.lblFilmTarih.AutoSize = true;
            this.lblFilmTarih.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmTarih.Location = new System.Drawing.Point(18, 124);
            this.lblFilmTarih.Name = "lblFilmTarih";
            this.lblFilmTarih.Size = new System.Drawing.Size(99, 21);
            this.lblFilmTarih.TabIndex = 6;
            this.lblFilmTarih.Text = "Film Tarihi:";
            // 
            // cmbFilmSeans
            // 
            this.cmbFilmSeans.BackColor = System.Drawing.Color.Tan;
            this.cmbFilmSeans.DropDownHeight = 135;
            this.cmbFilmSeans.DropDownWidth = 135;
            this.cmbFilmSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFilmSeans.FormattingEnabled = true;
            this.cmbFilmSeans.IntegralHeight = false;
            this.cmbFilmSeans.Location = new System.Drawing.Point(123, 162);
            this.cmbFilmSeans.Name = "cmbFilmSeans";
            this.cmbFilmSeans.Size = new System.Drawing.Size(135, 24);
            this.cmbFilmSeans.Sorted = true;
            this.cmbFilmSeans.TabIndex = 9;
            this.cmbFilmSeans.SelectedIndexChanged += new System.EventHandler(this.cmbFilmSeans_SelectedIndexChanged);
            // 
            // lblFilmSeans
            // 
            this.lblFilmSeans.AutoSize = true;
            this.lblFilmSeans.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmSeans.Location = new System.Drawing.Point(9, 162);
            this.lblFilmSeans.Name = "lblFilmSeans";
            this.lblFilmSeans.Size = new System.Drawing.Size(108, 21);
            this.lblFilmSeans.TabIndex = 8;
            this.lblFilmSeans.Text = "Film Seansı:";
            // 
            // cmbUcret
            // 
            this.cmbUcret.BackColor = System.Drawing.Color.Tan;
            this.cmbUcret.DropDownHeight = 135;
            this.cmbUcret.DropDownWidth = 135;
            this.cmbUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUcret.FormattingEnabled = true;
            this.cmbUcret.IntegralHeight = false;
            this.cmbUcret.Location = new System.Drawing.Point(123, 200);
            this.cmbUcret.Name = "cmbUcret";
            this.cmbUcret.Size = new System.Drawing.Size(135, 24);
            this.cmbUcret.Sorted = true;
            this.cmbUcret.TabIndex = 11;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.Location = new System.Drawing.Point(60, 200);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(57, 21);
            this.lblUcret.TabIndex = 10;
            this.lblUcret.Text = "Ücret:";
            // 
            // lblFilmAfis
            // 
            this.lblFilmAfis.AutoSize = true;
            this.lblFilmAfis.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmAfis.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAfis.ForeColor = System.Drawing.Color.OldLace;
            this.lblFilmAfis.Location = new System.Drawing.Point(279, 42);
            this.lblFilmAfis.Name = "lblFilmAfis";
            this.lblFilmAfis.Size = new System.Drawing.Size(103, 26);
            this.lblFilmAfis.TabIndex = 12;
            this.lblFilmAfis.Text = "Film Afişi";
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.BackColor = System.Drawing.Color.Transparent;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.OldLace;
            this.lblBilgi.Location = new System.Drawing.Point(406, 83);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(191, 19);
            this.lblBilgi.TabIndex = 13;
            this.lblBilgi.Text = "Bilet Sahibine Ait Bilgiler";
            this.lblBilgi.Click += new System.EventHandler(this.lblBilgi_Click);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(462, 158);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(63, 21);
            this.lblSoyad.TabIndex = 15;
            this.lblSoyad.Text = "Soyadı";
            this.lblSoyad.Click += new System.EventHandler(this.lblSoyad_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(476, 102);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(36, 21);
            this.lblAd.TabIndex = 16;
            this.lblAd.Text = "Adı";
            this.lblAd.Click += new System.EventHandler(this.lblAd_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.Color.Tan;
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(429, 126);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(146, 23);
            this.txt_ad.TabIndex = 17;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.Color.Tan;
            this.txt_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(427, 185);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(146, 23);
            this.txt_soyad.TabIndex = 18;
            this.txt_soyad.TextChanged += new System.EventHandler(this.txt_soyad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(462, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bilet İptal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(462, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Koltuk No:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbKoltukiptal
            // 
            this.cmbKoltukiptal.BackColor = System.Drawing.Color.Tan;
            this.cmbKoltukiptal.DropDownHeight = 135;
            this.cmbKoltukiptal.DropDownWidth = 135;
            this.cmbKoltukiptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKoltukiptal.FormattingEnabled = true;
            this.cmbKoltukiptal.IntegralHeight = false;
            this.cmbKoltukiptal.Location = new System.Drawing.Point(427, 358);
            this.cmbKoltukiptal.Name = "cmbKoltukiptal";
            this.cmbKoltukiptal.Size = new System.Drawing.Size(146, 24);
            this.cmbKoltukiptal.TabIndex = 22;
            this.cmbKoltukiptal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Bilet Anasayfasına Hoşgeldiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Koltuk No:";
            // 
            // txt_koltukNo
            // 
            this.txt_koltukNo.BackColor = System.Drawing.Color.Tan;
            this.txt_koltukNo.Enabled = false;
            this.txt_koltukNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_koltukNo.Location = new System.Drawing.Point(123, 234);
            this.txt_koltukNo.Name = "txt_koltukNo";
            this.txt_koltukNo.Size = new System.Drawing.Size(135, 23);
            this.txt_koltukNo.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.armchair;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(508, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 31;
            this.button2.Text = "DOLU";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.armchair;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(427, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "BOŞ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBiletSat.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiletSat.Image = global::sinemaBiletOtomasyonu2.Properties.Resources._3d_glasses__1_;
            this.btnBiletSat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBiletSat.Location = new System.Drawing.Point(456, 268);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(97, 44);
            this.btnBiletSat.TabIndex = 27;
            this.btnBiletSat.Text = "Bilet Al";
            this.btnBiletSat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBiletSat.UseVisualStyleBackColor = true;
            this.btnBiletSat.Click += new System.EventHandler(this.btnBiletSat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.indir__2_;
            this.pictureBox1.Location = new System.Drawing.Point(423, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_iptal.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iptal.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.cinema;
            this.btn_iptal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_iptal.Location = new System.Drawing.Point(456, 385);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(98, 44);
            this.btn_iptal.TabIndex = 24;
            this.btn_iptal.Text = "  İptal Et";
            this.btn_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // pcFilmAfis
            // 
            this.pcFilmAfis.Location = new System.Drawing.Point(264, 69);
            this.pcFilmAfis.Name = "pcFilmAfis";
            this.pcFilmAfis.Size = new System.Drawing.Size(136, 184);
            this.pcFilmAfis.TabIndex = 1;
            this.pcFilmAfis.TabStop = false;
            // 
            // UyeGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 439);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_koltukNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBiletSat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.cmbKoltukiptal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.lblFilmAfis);
            this.Controls.Add(this.cmbUcret);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.cmbFilmSeans);
            this.Controls.Add(this.lblFilmSeans);
            this.Controls.Add(this.cmbFilmTarih);
            this.Controls.Add(this.lblFilmTarih);
            this.Controls.Add(this.cmbSalonAd);
            this.Controls.Add(this.lblSalonAd);
            this.Controls.Add(this.cmbFilmAd);
            this.Controls.Add(this.lblFilmAd);
            this.Controls.Add(this.pcFilmAfis);
            this.Controls.Add(this.pnlKoltukDuzen);
            this.Name = "UyeGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uye Giris Ekrani";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UyeGirisEkrani_FormClosing);
            this.Load += new System.EventHandler(this.UyeGirisEkranics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFilmAfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlKoltukDuzen;
        private System.Windows.Forms.PictureBox pcFilmAfis;
        private System.Windows.Forms.Label lblFilmAd;
        private System.Windows.Forms.ComboBox cmbFilmAd;
        private System.Windows.Forms.ComboBox cmbSalonAd;
        private System.Windows.Forms.Label lblSalonAd;
        private System.Windows.Forms.ComboBox cmbFilmTarih;
        private System.Windows.Forms.Label lblFilmTarih;
        private System.Windows.Forms.ComboBox cmbFilmSeans;
        private System.Windows.Forms.Label lblFilmSeans;
        private System.Windows.Forms.ComboBox cmbUcret;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblFilmAfis;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKoltukiptal;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBiletSat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_koltukNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}