using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SimpleTcp;
using System.Net;
using System.IO;

namespace socket
{
    public partial class Alici : Form
    {
        public Alici()
        {
            InitializeComponent();
        }
        sha_odev.EncryptionDecryption encryptionDecryption = new sha_odev.EncryptionDecryption();
        SimpleTcpClient client;
        string siferliBinaryDeger, mesaj;
        int say;
        private void Alici_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            client = new(tb_server.Text);
            client.Events.Connected += Events_Connected ;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
            client.Connect();
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e) // serverdan veri alır
        {
            //serverdan her mesaj için iki veri geliyor birinci sifrelenmiş veya şifrelenmemiş cevap ikincisi mesajın binery hali çünkü mesajın binary hali ile şifreler çözülüyor.
            say += 1;
            if (say % 2 != 0)
            {
                tb_info.Text += $"Server :{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            }
            else
            {
                string gelenmesaj = $"{Encoding.UTF8.GetString(e.Data)}";
                string[] words = gelenmesaj.Split(' ');
                    if (words.Length > 1)
                    {
                        lb_dosya.Text = words[0];
                    }
                    else
                    {
                        mesaj = $"{Encoding.UTF8.GetString(e.Data)}";
                    }
            }
        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e) // serverla bağlıntı bittiğinde
        {
            tb_info.Text += $"Server disconnected.{Environment.NewLine}";
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e) // serverla bağlıntı kurulduğunda
        {
            tb_info.Text += $"Server connected.{Environment.NewLine}";
        } 

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(tb_mesaj.Text) || lb_dosya.Text != " ")
                {
                    siferliBinaryDeger = encryptionDecryption.metin(tb_mesaj.Text);
                    string sifreliDeger;
                    if (cb_spn.Checked)
                    {
                        sifreliDeger = encryptionDecryption.BinaryToString(siferliBinaryDeger);
                    }
                    else
                    {
                        sifreliDeger = tb_mesaj.Text;
                    }
                    if (lb_dosya.Text != " ")
                    {
                        client.Send(lb_dosya.Text + " dosya"); // dosya servera gönderiliyor
                        tb_info.Text += $"Server: {lb_dosya.Text}{Environment.NewLine}";
                        lb_dosya.Text = "";
                    }
                    if (!string.IsNullOrEmpty(tb_mesaj.Text))
                    {
                        client.Send(sifreliDeger + " " + siferliBinaryDeger); // mesaj servera gönderiliyor
                        tb_info.Text += $"Client: {sifreliDeger}{Environment.NewLine}";
                        tb_mesaj.Text = string.Empty;
                        lb_sha.Text = "";
                        lb_sha.Text += "SHA-256 : ";
                        lb_spn.Text = "";
                        lb_spn.Text += "SPN-16 : ";
                        cb_sha.Checked = false;
                        cb_spn.Checked = false;
                    }
                }
            }
        }

        private void btn_coz_Click(object sender, EventArgs e)
        {
            /* Şifrenin çözülmesini sağlayan butonun içeriği Şifre çözerken şifrelenmiş metnin binary değerini kullanıyoruz.*/
            string cozulenDeger = encryptionDecryption.BinaryToString(encryptionDecryption.metinCoz(mesaj));
            lb_yazicoz.Text = cozulenDeger;
        }

        private void cb_sha_CheckedChanged(object sender, EventArgs e)//sha256 şifreleme işlemlerinin başlatıldığı kısım
        {
            if (cb_sha.Checked == true)
            {
                string sifreliDeger, sifrelenecekDeger = tb_mesaj.Text;
                sifreliDeger = encryptionDecryption.SHA_256_Encrypting(sifrelenecekDeger);
                lb_sha.Text += sifreliDeger;
            }
            else
            {
                lb_sha.Text = "";
                lb_sha.Text += "SHA-256 : ";
            }
        }

        private void btn_yukle_Click(object sender, EventArgs e) //dosyayı projenin file dosyasına yükleme 
        {
            openFileDialog1.Filter = "Text files (*.txt;*.data)|*.txt;*.data|Image Files(*.GIF)|*.GIF";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileInfo info = new FileInfo(openFileDialog1.FileName);
                string[] dosya = (openFileDialog1.FileName).Split('\\');
                string dosya_ad = dosya[dosya.Length - 1];
                string[] yol = (Application.StartupPath).Split('\\');
                string yol_dosya = yol[0] + "\\" + yol[1] + "\\" + yol[2] + "\\" + yol[3] + "\\" + yol[4] + "\\" + yol[5] + "\\File\\" + dosya_ad;
                System.IO.File.Copy(openFileDialog1.FileName, yol_dosya);
                lb_dosya.Text = dosya_ad;
            }
        }

        private void btn_indir_Click(object sender, EventArgs e) //dosyayı projenin file dosyasından indirme
        {
            WebClient myWebClient = new WebClient();
            string[] yol = (Application.StartupPath).Split('\\');
            string yol_dosya = yol[0] + "\\" + yol[1] + "\\" + yol[2] + "\\" + yol[3] + "\\" + yol[4] + "\\" + yol[5] + "\\File\\" + lb_dosya.Text;
            string indir = yol[0] + "\\" + yol[1] + "\\" + yol[2] + "\\Downloads\\" + lb_dosya.Text; 
            myWebClient.DownloadFile(yol_dosya, indir);
        }  

        private void cb_spn_CheckedChanged(object sender, EventArgs e)//spn256 şifreleme işlemlerinin başlatıldığı kısım
        {
            if ((tb_mesaj.Text.Length % 2) != 0)// 2 karakter ilerleneceğinden karakter uzunluğu kontrolü
            {
                MessageBox.Show("Lütfen yazınızın sonuna 1 adet boşluk ekleyin !!");
            }
            else
            {
                if (cb_spn.Checked == true)
                {
                    siferliBinaryDeger = encryptionDecryption.metin(tb_mesaj.Text);
                    string siferliDeger = encryptionDecryption.BinaryToString(siferliBinaryDeger);                  
                    lb_spn.Text += siferliDeger;
                }
                else
                {
                    lb_spn.Text = "";
                    lb_spn.Text += "SPN-16 : ";
                }
            }
        }
    }
}
