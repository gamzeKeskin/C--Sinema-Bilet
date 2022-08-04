
namespace sinemaBiletOtomasyonu2
{
    partial class FrmSeansEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_salonad = new System.Windows.Forms.ComboBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_filmAd = new System.Windows.Forms.ComboBox();
            this.grpBox_seans = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbFiyat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_seansList = new System.Windows.Forms.Button();
            this.btn_seansEkle = new System.Windows.Forms.Button();
            this.grpBox_seans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarih";
            // 
            // cmb_salonad
            // 
            this.cmb_salonad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_salonad.FormattingEnabled = true;
            this.cmb_salonad.Location = new System.Drawing.Point(90, 54);
            this.cmb_salonad.Name = "cmb_salonad";
            this.cmb_salonad.Size = new System.Drawing.Size(153, 28);
            this.cmb_salonad.TabIndex = 5;
            this.cmb_salonad.SelectedIndexChanged += new System.EventHandler(this.cmb_salonad_SelectedIndexChanged);
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_tarih.Location = new System.Drawing.Point(90, 93);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(153, 27);
            this.dtp_tarih.TabIndex = 6;
            this.dtp_tarih.ValueChanged += new System.EventHandler(this.dtp_tarih_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seans";
            // 
            // cmb_filmAd
            // 
            this.cmb_filmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_filmAd.FormattingEnabled = true;
            this.cmb_filmAd.Location = new System.Drawing.Point(90, 12);
            this.cmb_filmAd.Name = "cmb_filmAd";
            this.cmb_filmAd.Size = new System.Drawing.Size(153, 28);
            this.cmb_filmAd.TabIndex = 10;
            this.cmb_filmAd.SelectedIndexChanged += new System.EventHandler(this.cmb_filmAd_SelectedIndexChanged);
            // 
            // grpBox_seans
            // 
            this.grpBox_seans.Controls.Add(this.radioButton11);
            this.grpBox_seans.Controls.Add(this.radioButton12);
            this.grpBox_seans.Controls.Add(this.radioButton13);
            this.grpBox_seans.Controls.Add(this.radioButton14);
            this.grpBox_seans.Controls.Add(this.radioButton15);
            this.grpBox_seans.Controls.Add(this.radioButton10);
            this.grpBox_seans.Controls.Add(this.radioButton7);
            this.grpBox_seans.Controls.Add(this.radioButton9);
            this.grpBox_seans.Controls.Add(this.radioButton8);
            this.grpBox_seans.Controls.Add(this.radioButton2);
            this.grpBox_seans.Controls.Add(this.radioButton3);
            this.grpBox_seans.Controls.Add(this.radioButton4);
            this.grpBox_seans.Controls.Add(this.radioButton5);
            this.grpBox_seans.Controls.Add(this.radioButton6);
            this.grpBox_seans.Controls.Add(this.radioButton1);
            this.grpBox_seans.Location = new System.Drawing.Point(272, 46);
            this.grpBox_seans.Name = "grpBox_seans";
            this.grpBox_seans.Size = new System.Drawing.Size(200, 152);
            this.grpBox_seans.TabIndex = 11;
            this.grpBox_seans.TabStop = false;
            this.grpBox_seans.Text = "Seans Saatleri";
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton11.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton11.Location = new System.Drawing.Point(74, 93);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(55, 21);
            this.radioButton11.TabIndex = 29;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "18.00";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton12.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton12.Location = new System.Drawing.Point(137, 93);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(55, 21);
            this.radioButton12.TabIndex = 28;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "19.00";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton13.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton13.Location = new System.Drawing.Point(6, 120);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(57, 21);
            this.radioButton13.TabIndex = 27;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "20.00";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton14.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton14.Location = new System.Drawing.Point(74, 120);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(55, 21);
            this.radioButton14.TabIndex = 26;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "21.00";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton15.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton15.Location = new System.Drawing.Point(137, 120);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(57, 21);
            this.radioButton15.TabIndex = 25;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "22.00";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton10.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton10.Location = new System.Drawing.Point(6, 93);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(55, 21);
            this.radioButton10.TabIndex = 24;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "17.00";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton7.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton7.Location = new System.Drawing.Point(6, 66);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(55, 21);
            this.radioButton7.TabIndex = 23;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "14.00";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton9.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton9.Location = new System.Drawing.Point(137, 66);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(55, 21);
            this.radioButton9.TabIndex = 22;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "16.00";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton8.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton8.Location = new System.Drawing.Point(74, 68);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(55, 21);
            this.radioButton8.TabIndex = 21;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "15.00";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton2.Location = new System.Drawing.Point(74, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 21);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "09.00";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton3.Location = new System.Drawing.Point(137, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 21);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "10.00";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton4.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton4.Location = new System.Drawing.Point(6, 39);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 21);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "11.00";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton5.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton5.Location = new System.Drawing.Point(74, 41);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(55, 21);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "12.00";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton6.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton6.Location = new System.Drawing.Point(137, 41);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 21);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "13.00";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.Color.Lavender;
            this.radioButton1.Location = new System.Drawing.Point(6, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 21);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "08.00";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 214);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(338, 181);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Salon Id";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Adı";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salon Adı";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarih";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Saat";
            // 
            // cmbFiyat
            // 
            this.cmbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFiyat.FormattingEnabled = true;
            this.cmbFiyat.Location = new System.Drawing.Point(90, 132);
            this.cmbFiyat.Name = "cmbFiyat";
            this.cmbFiyat.Size = new System.Drawing.Size(153, 28);
            this.cmbFiyat.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fiyat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.clockk;
            this.pictureBox1.Location = new System.Drawing.Point(385, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_seansList
            // 
            this.btn_seansList.BackColor = System.Drawing.Color.Maroon;
            this.btn_seansList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_seansList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_seansList.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.clipboardlist;
            this.btn_seansList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seansList.Location = new System.Drawing.Point(366, 245);
            this.btn_seansList.Name = "btn_seansList";
            this.btn_seansList.Size = new System.Drawing.Size(100, 50);
            this.btn_seansList.TabIndex = 13;
            this.btn_seansList.Text = "Seans \r\nListele";
            this.btn_seansList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_seansList.UseVisualStyleBackColor = false;
            this.btn_seansList.Click += new System.EventHandler(this.btn_seansList_Click);
            // 
            // btn_seansEkle
            // 
            this.btn_seansEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_seansEkle.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.add;
            this.btn_seansEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seansEkle.Location = new System.Drawing.Point(139, 166);
            this.btn_seansEkle.Name = "btn_seansEkle";
            this.btn_seansEkle.Size = new System.Drawing.Size(104, 32);
            this.btn_seansEkle.TabIndex = 9;
            this.btn_seansEkle.Text = "Ekle";
            this.btn_seansEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_seansEkle.UseVisualStyleBackColor = true;
            this.btn_seansEkle.Click += new System.EventHandler(this.btn_seansEkle_Click);
            // 
            // FrmSeansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(484, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_seansList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grpBox_seans);
            this.Controls.Add(this.cmb_filmAd);
            this.Controls.Add(this.btn_seansEkle);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.cmb_salonad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmSeansEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeansEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeansEkle_FormClosing);
            this.Load += new System.EventHandler(this.FrmSeansEkle_Load);
            this.grpBox_seans.ResumeLayout(false);
            this.grpBox_seans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_salonad;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_seansEkle;
        private System.Windows.Forms.ComboBox cmb_filmAd;
        private System.Windows.Forms.GroupBox grpBox_seans;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_seansList;
        private System.Windows.Forms.ComboBox cmbFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}