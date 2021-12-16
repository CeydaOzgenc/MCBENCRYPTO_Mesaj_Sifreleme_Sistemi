
namespace socket
{
    partial class Alici
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.tb_mesaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.lb_yazi = new System.Windows.Forms.Label();
            this.btn_coz = new System.Windows.Forms.Button();
            this.lb_sifreyaz = new System.Windows.Forms.Label();
            this.lb_yazicoz = new System.Windows.Forms.Label();
            this.cb_sha = new System.Windows.Forms.CheckBox();
            this.cb_spn = new System.Windows.Forms.CheckBox();
            this.lb_spn = new System.Windows.Forms.Label();
            this.lb_sha = new System.Windows.Forms.Label();
            this.btn_indir = new System.Windows.Forms.Button();
            this.btn_yukle = new System.Windows.Forms.Button();
            this.lb_dosya = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server :";
            // 
            // tb_server
            // 
            this.tb_server.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_server.Location = new System.Drawing.Point(119, 31);
            this.tb_server.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(400, 30);
            this.tb_server.TabIndex = 10;
            this.tb_server.Text = "127.0.0.1:9000";
            // 
            // tb_mesaj
            // 
            this.tb_mesaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mesaj.Location = new System.Drawing.Point(119, 500);
            this.tb_mesaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_mesaj.Name = "tb_mesaj";
            this.tb_mesaj.Size = new System.Drawing.Size(400, 30);
            this.tb_mesaj.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mesaj :";
            // 
            // tb_info
            // 
            this.tb_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_info.Location = new System.Drawing.Point(30, 100);
            this.tb_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_info.Multiline = true;
            this.tb_info.Name = "tb_info";
            this.tb_info.ReadOnly = true;
            this.tb_info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_info.Size = new System.Drawing.Size(489, 270);
            this.tb_info.TabIndex = 11;
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(424, 666);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(95, 30);
            this.btn_gonder.TabIndex = 14;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // lb_yazi
            // 
            this.lb_yazi.AutoSize = true;
            this.lb_yazi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_yazi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_yazi.Location = new System.Drawing.Point(30, 400);
            this.lb_yazi.Name = "lb_yazi";
            this.lb_yazi.Size = new System.Drawing.Size(126, 22);
            this.lb_yazi.TabIndex = 15;
            this.lb_yazi.Text = "Şifreli Mesaj :";
            // 
            // btn_coz
            // 
            this.btn_coz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_coz.Location = new System.Drawing.Point(399, 400);
            this.btn_coz.Name = "btn_coz";
            this.btn_coz.Size = new System.Drawing.Size(120, 29);
            this.btn_coz.TabIndex = 16;
            this.btn_coz.Text = "Mesajı Çöz";
            this.btn_coz.UseVisualStyleBackColor = true;
            this.btn_coz.Click += new System.EventHandler(this.btn_coz_Click);
            // 
            // lb_sifreyaz
            // 
            this.lb_sifreyaz.AutoSize = true;
            this.lb_sifreyaz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sifreyaz.Location = new System.Drawing.Point(162, 450);
            this.lb_sifreyaz.Name = "lb_sifreyaz";
            this.lb_sifreyaz.Size = new System.Drawing.Size(0, 22);
            this.lb_sifreyaz.TabIndex = 18;
            // 
            // lb_yazicoz
            // 
            this.lb_yazicoz.AutoSize = true;
            this.lb_yazicoz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_yazicoz.Location = new System.Drawing.Point(162, 400);
            this.lb_yazicoz.Name = "lb_yazicoz";
            this.lb_yazicoz.Size = new System.Drawing.Size(15, 22);
            this.lb_yazicoz.TabIndex = 19;
            this.lb_yazicoz.Text = " ";
            // 
            // cb_sha
            // 
            this.cb_sha.AutoSize = true;
            this.cb_sha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_sha.Location = new System.Drawing.Point(25, 558);
            this.cb_sha.Name = "cb_sha";
            this.cb_sha.Size = new System.Drawing.Size(108, 26);
            this.cb_sha.TabIndex = 20;
            this.cb_sha.Text = "SHA-256";
            this.cb_sha.UseVisualStyleBackColor = true;
            this.cb_sha.CheckedChanged += new System.EventHandler(this.cb_sha_CheckedChanged);
            // 
            // cb_spn
            // 
            this.cb_spn.AutoSize = true;
            this.cb_spn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_spn.Location = new System.Drawing.Point(162, 558);
            this.cb_spn.Name = "cb_spn";
            this.cb_spn.Size = new System.Drawing.Size(95, 26);
            this.cb_spn.TabIndex = 21;
            this.cb_spn.Text = "SPN-16";
            this.cb_spn.UseVisualStyleBackColor = true;
            this.cb_spn.CheckedChanged += new System.EventHandler(this.cb_spn_CheckedChanged);
            // 
            // lb_spn
            // 
            this.lb_spn.AutoSize = true;
            this.lb_spn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_spn.Location = new System.Drawing.Point(25, 628);
            this.lb_spn.Name = "lb_spn";
            this.lb_spn.Size = new System.Drawing.Size(84, 22);
            this.lb_spn.TabIndex = 22;
            this.lb_spn.Text = "SPN-16 :";
            // 
            // lb_sha
            // 
            this.lb_sha.AutoSize = true;
            this.lb_sha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sha.Location = new System.Drawing.Point(25, 597);
            this.lb_sha.Name = "lb_sha";
            this.lb_sha.Size = new System.Drawing.Size(97, 22);
            this.lb_sha.TabIndex = 23;
            this.lb_sha.Text = "SHA-256 :";
            // 
            // btn_indir
            // 
            this.btn_indir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_indir.Location = new System.Drawing.Point(399, 450);
            this.btn_indir.Name = "btn_indir";
            this.btn_indir.Size = new System.Drawing.Size(120, 29);
            this.btn_indir.TabIndex = 24;
            this.btn_indir.Text = "Dosya İndir";
            this.btn_indir.UseVisualStyleBackColor = true;
            this.btn_indir.Click += new System.EventHandler(this.btn_indir_Click);
            // 
            // btn_yukle
            // 
            this.btn_yukle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_yukle.Location = new System.Drawing.Point(256, 450);
            this.btn_yukle.Name = "btn_yukle";
            this.btn_yukle.Size = new System.Drawing.Size(137, 29);
            this.btn_yukle.TabIndex = 25;
            this.btn_yukle.Text = "Dosya Yükle";
            this.btn_yukle.UseVisualStyleBackColor = true;
            this.btn_yukle.Click += new System.EventHandler(this.btn_yukle_Click);
            // 
            // lb_dosya
            // 
            this.lb_dosya.AutoSize = true;
            this.lb_dosya.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_dosya.Location = new System.Drawing.Point(25, 454);
            this.lb_dosya.Name = "lb_dosya";
            this.lb_dosya.Size = new System.Drawing.Size(15, 22);
            this.lb_dosya.TabIndex = 26;
            this.lb_dosya.Text = " ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Alici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 741);
            this.Controls.Add(this.lb_dosya);
            this.Controls.Add(this.btn_yukle);
            this.Controls.Add(this.btn_indir);
            this.Controls.Add(this.lb_sha);
            this.Controls.Add(this.lb_spn);
            this.Controls.Add(this.cb_spn);
            this.Controls.Add(this.cb_sha);
            this.Controls.Add(this.lb_yazicoz);
            this.Controls.Add(this.lb_sifreyaz);
            this.Controls.Add(this.btn_coz);
            this.Controls.Add(this.lb_yazi);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.tb_mesaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_info);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Alici";
            this.Text = "Alıcı";
            this.Load += new System.EventHandler(this.Alici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.TextBox tb_mesaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label lb_yazi;
        private System.Windows.Forms.Button btn_coz;
        private System.Windows.Forms.Label lb_sifreyaz;
        private System.Windows.Forms.Label lb_yazicoz;
        private System.Windows.Forms.CheckBox cb_sha;
        private System.Windows.Forms.CheckBox cb_spn;
        private System.Windows.Forms.Label lb_spn;
        private System.Windows.Forms.Label lb_sha;
        private System.Windows.Forms.Button btn_indir;
        private System.Windows.Forms.Button btn_yukle;
        private System.Windows.Forms.Label lb_dosya;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

