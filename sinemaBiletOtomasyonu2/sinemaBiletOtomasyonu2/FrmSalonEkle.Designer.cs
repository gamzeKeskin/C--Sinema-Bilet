
namespace sinemaBiletOtomasyonu2
{
    partial class FrmSalonEkle
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
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.lblSalonAd = new System.Windows.Forms.Label();
            this.txtSalonEkle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSalonEkle.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSalonEkle.Image = global::sinemaBiletOtomasyonu2.Properties.Resources.cinema8;
            this.btnSalonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalonEkle.Location = new System.Drawing.Point(64, 60);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(94, 29);
            this.btnSalonEkle.TabIndex = 0;
            this.btnSalonEkle.Text = "Ekle";
            this.btnSalonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSalonAd
            // 
            this.lblSalonAd.AutoSize = true;
            this.lblSalonAd.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblSalonAd.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAd.ForeColor = System.Drawing.Color.Navy;
            this.lblSalonAd.Location = new System.Drawing.Point(9, 29);
            this.lblSalonAd.Name = "lblSalonAd";
            this.lblSalonAd.Size = new System.Drawing.Size(98, 25);
            this.lblSalonAd.TabIndex = 1;
            this.lblSalonAd.Text = "Salon Adı:";
            this.lblSalonAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalonEkle
            // 
            this.txtSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalonEkle.Location = new System.Drawing.Point(113, 25);
            this.txtSalonEkle.Name = "txtSalonEkle";
            this.txtSalonEkle.Size = new System.Drawing.Size(94, 29);
            this.txtSalonEkle.TabIndex = 2;
            this.txtSalonEkle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmSalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sinemaBiletOtomasyonu2.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(208, 101);
            this.Controls.Add(this.txtSalonEkle);
            this.Controls.Add(this.lblSalonAd);
            this.Controls.Add(this.btnSalonEkle);
            this.Name = "FrmSalonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalonEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSalonEkle_FormClosing);
            this.Load += new System.EventHandler(this.FrmSalonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Label lblSalonAd;
        private System.Windows.Forms.TextBox txtSalonEkle;
    }
}