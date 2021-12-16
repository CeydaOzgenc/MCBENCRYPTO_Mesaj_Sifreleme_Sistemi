
namespace sha_odev
{
    partial class Gonderici
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.tb_mesaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_kullanici = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.btn_coz = new System.Windows.Forms.Button();
            this.lb_yazi = new System.Windows.Forms.Label();
            this.lb_yazicoz = new System.Windows.Forms.Label();
            this.lb_dosya = new System.Windows.Forms.Label();
            this.btn_yukle = new System.Windows.Forms.Button();
            this.btn_indir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(546, 510);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 26);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "SHA-256";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(680, 510);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 26);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "SPN-16";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "SHA-256 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "SPN-16 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server :";
            // 
            // tb_server
            // 
            this.tb_server.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_server.Location = new System.Drawing.Point(119, 25);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(400, 30);
            this.tb_server.TabIndex = 10;
            this.tb_server.Text = "127.0.0.1:9000";
            // 
            // tb_mesaj
            // 
            this.tb_mesaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_mesaj.Location = new System.Drawing.Point(101, 520);
            this.tb_mesaj.Name = "tb_mesaj";
            this.tb_mesaj.Size = new System.Drawing.Size(418, 30);
            this.tb_mesaj.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mesaj :";
            // 
            // lb_kullanici
            // 
            this.lb_kullanici.FormattingEnabled = true;
            this.lb_kullanici.ItemHeight = 16;
            this.lb_kullanici.Location = new System.Drawing.Point(546, 80);
            this.lb_kullanici.Name = "lb_kullanici";
            this.lb_kullanici.Size = new System.Drawing.Size(229, 292);
            this.lb_kullanici.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(542, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kulanıcı IP :";
            // 
            // tb_info
            // 
            this.tb_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_info.Location = new System.Drawing.Point(30, 80);
            this.tb_info.Multiline = true;
            this.tb_info.Name = "tb_info";
            this.tb_info.ReadOnly = true;
            this.tb_info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_info.Size = new System.Drawing.Size(489, 300);
            this.tb_info.TabIndex = 11;
            // 
            // btn_gonder
            // 
            this.btn_gonder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gonder.Location = new System.Drawing.Point(671, 638);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(95, 30);
            this.btn_gonder.TabIndex = 16;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // btn_coz
            // 
            this.btn_coz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_coz.Location = new System.Drawing.Point(649, 410);
            this.btn_coz.Name = "btn_coz";
            this.btn_coz.Size = new System.Drawing.Size(126, 30);
            this.btn_coz.TabIndex = 17;
            this.btn_coz.Text = "Mesajı Çöz";
            this.btn_coz.UseVisualStyleBackColor = true;
            this.btn_coz.Click += new System.EventHandler(this.btn_coz_Click);
            // 
            // lb_yazi
            // 
            this.lb_yazi.AutoSize = true;
            this.lb_yazi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_yazi.Location = new System.Drawing.Point(25, 410);
            this.lb_yazi.Name = "lb_yazi";
            this.lb_yazi.Size = new System.Drawing.Size(126, 22);
            this.lb_yazi.TabIndex = 18;
            this.lb_yazi.Text = "Şifreli Mesaj :";
            // 
            // lb_yazicoz
            // 
            this.lb_yazicoz.AutoSize = true;
            this.lb_yazicoz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_yazicoz.Location = new System.Drawing.Point(162, 410);
            this.lb_yazicoz.Name = "lb_yazicoz";
            this.lb_yazicoz.Size = new System.Drawing.Size(15, 22);
            this.lb_yazicoz.TabIndex = 19;
            this.lb_yazicoz.Text = " ";
            // 
            // lb_dosya
            // 
            this.lb_dosya.AutoSize = true;
            this.lb_dosya.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_dosya.Location = new System.Drawing.Point(27, 462);
            this.lb_dosya.Name = "lb_dosya";
            this.lb_dosya.Size = new System.Drawing.Size(15, 22);
            this.lb_dosya.TabIndex = 20;
            this.lb_dosya.Text = " ";
            // 
            // btn_yukle
            // 
            this.btn_yukle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yukle.Location = new System.Drawing.Point(506, 462);
            this.btn_yukle.Name = "btn_yukle";
            this.btn_yukle.Size = new System.Drawing.Size(137, 30);
            this.btn_yukle.TabIndex = 21;
            this.btn_yukle.Text = "Dosya Yükle";
            this.btn_yukle.UseVisualStyleBackColor = true;
            this.btn_yukle.Click += new System.EventHandler(this.btn_yukle_Click);
            // 
            // btn_indir
            // 
            this.btn_indir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_indir.Location = new System.Drawing.Point(649, 462);
            this.btn_indir.Name = "btn_indir";
            this.btn_indir.Size = new System.Drawing.Size(125, 30);
            this.btn_indir.TabIndex = 22;
            this.btn_indir.Text = "Dosya İndir";
            this.btn_indir.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Gonderici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 710);
            this.Controls.Add(this.btn_indir);
            this.Controls.Add(this.btn_yukle);
            this.Controls.Add(this.lb_dosya);
            this.Controls.Add(this.lb_yazicoz);
            this.Controls.Add(this.lb_yazi);
            this.Controls.Add(this.btn_coz);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_kullanici);
            this.Controls.Add(this.tb_mesaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_info);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Gonderici";
            this.Text = "Gönderici";
            this.Load += new System.EventHandler(this.Gonderici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.TextBox tb_mesaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_kullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Button btn_coz;
        private System.Windows.Forms.Label lb_yazi;
        private System.Windows.Forms.Label lb_yazicoz;
        private System.Windows.Forms.Label lb_dosya;
        private System.Windows.Forms.Button btn_yukle;
        private System.Windows.Forms.Button btn_indir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

