
namespace sinemaBiletOtomasyonu2
{
    partial class FrmFilmEkle
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
            this.txt_filmad = new System.Windows.Forms.TextBox();
            this.txt_sure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_flimTuru = new System.Windows.Forms.ComboBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_filmad
            // 
            this.txt_filmad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_filmad.Location = new System.Drawing.Point(101, 20);
            this.txt_filmad.Name = "txt_filmad";
            this.txt_filmad.Size = new System.Drawing.Size(128, 26);
            this.txt_filmad.TabIndex = 1;
            // 
            // txt_sure
            // 
            this.txt_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sure.Location = new System.Drawing.Point(101, 60);
            this.txt_sure.Name = "txt_sure";
            this.txt_sure.Size = new System.Drawing.Size(128, 26);
            this.txt_sure.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Süre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Film Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Film Tarihi:";
            // 
            // cmb_flimTuru
            // 
            this.cmb_flimTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_flimTuru.FormattingEnabled = true;
            this.cmb_flimTuru.Location = new System.Drawing.Point(101, 149);
            this.cmb_flimTuru.Name = "cmb_flimTuru";
            this.cmb_flimTuru.Size = new System.Drawing.Size(128, 28);
            this.cmb_flimTuru.TabIndex = 9;
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_tarih.Location = new System.Drawing.Point(101, 103);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(128, 26);
            this.dtp_tarih.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.clapperboard1;
            this.btnFilmEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilmEkle.Location = new System.Drawing.Point(140, 192);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(89, 34);
            this.btnFilmEkle.TabIndex = 12;
            this.btnFilmEkle.Text = "Ekle";
            this.btnFilmEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.projector;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(244, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Resim Seç";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 164);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(16, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Çıkış Yap";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(391, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmb_flimTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_filmad);
            this.Controls.Add(this.label1);
            this.Name = "FrmFilmEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Ekle";
            this.Load += new System.EventHandler(this.FrmFilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filmad;
        private System.Windows.Forms.TextBox txt_sure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_flimTuru;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}