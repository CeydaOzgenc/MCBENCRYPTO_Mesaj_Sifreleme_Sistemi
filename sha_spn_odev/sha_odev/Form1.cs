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

namespace sha_odev
{
    public partial class Gonderici : Form
    {
        public Gonderici()
        {
            InitializeComponent();
        }
        EncryptionDecryption encryptionDecryption = new EncryptionDecryption();
        SimpleTcpServer server;
        string siferliBinaryDeger,mesaj;
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //sha256 şifreleme işlemlerinin başlatıldığı kısım
        {
            
            if (checkBox1.Checked == true)
            {
                string sifreliDeger,sifrelenecekDeger = tb_mesaj.Text;
                sifreliDeger = encryptionDecryption.SHA_256_Encrypting(sifrelenecekDeger);
                label1.Text += sifreliDeger;
            }
            else
            {
                label1.Text = "";
                label1.Text += "SHA-256 : ";
            }
        }     
        private void checkBox2_CheckedChanged(object sender, EventArgs e) //spn16 şifreleme işlemlerinin başlatıldığı kısım
        {
            if((tb_mesaj.Text.Length%2) != 0)// 2 karakter ilerleneceğinden karakter uzunluğu kontrolü
            {
                MessageBox.Show("Lütfen yazınızın sonuna 1 adet boşluk ekleyin !!");
            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    siferliBinaryDeger = encryptionDecryption.metin(tb_mesaj.Text);
                    string siferliDeger = encryptionDecryption.BinaryToString(siferliBinaryDeger);
                    label2.Text += siferliDeger;
                }
                else
                {
                    label2.Text = "";
                    label2.Text += "SPN-16 : ";
                }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)// spn16 şifre çözme işlemlerinin başlatıldığı kısım.
        {
            string cozulenDeger = encryptionDecryption.BinaryToString(encryptionDecryption.metinCoz(siferliBinaryDeger));
        }

        private void Gonderici_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            server = new SimpleTcpServer(tb_server.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
            server.Start();
        }
        private void Events_DataReceived(object sender, DataReceivedEventArgs e) // clientten veri alır
        {
            string gelenmesaj = $"{Encoding.UTF8.GetString(e.Data)}";
            string[] words = gelenmesaj.Split(' ');
            //clienten alınan veri ikiye bölünür çünkü ilki yazılır ikincisi ise değişkene alınarak onn üzerinde işlemler yapılır
            tb_info.Text += $"{e.IpPort}:{words[0]}{Environment.NewLine}";
            if (words[1].ToString() == "dosya")
            {
                lb_dosya.Text = words[0].ToString();
            }
            else
            {
                mesaj = words[1].ToString();
            }
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)// client ile bağlıntı bittiğinde
        {
            tb_info.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
            lb_kullanici.Items.Remove(e.IpPort);
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)// client ile bağlıntı kurulduğunda
        {
            tb_info.Text += $"{e.IpPort} connected.{Environment.NewLine}";
            lb_kullanici.Items.Add(e.IpPort);
        }

        private void btn_coz_Click(object sender, EventArgs e)
        {
            /* Şifrenin çözülmesini sağlayan butonun içeriği Şifre çözerken şifrelenmiş metnin binary değerini kullanıyoruz.*/
            string cozulenDeger = encryptionDecryption.BinaryToString(encryptionDecryption.metinCoz(mesaj));
            lb_yazicoz.Text = cozulenDeger;
        }

        private void btn_yukle_Click(object sender, EventArgs e)//dosyayı projenin file dosyasına yükleme
        {
            openFileDialog1.Filter = "Text files (*.txt;*.data)|*.txt;*.data|Image Files(*.GIF)|*.GIF";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                string[] dosya = (openFileDialog1.FileName).Split('\\');
                string dosya_ad = dosya[dosya.Length - 1];
                string [] yol = (Application.StartupPath).Split('\\');
                string yol_dosya = yol[0] + "\\" + yol[1] + "\\" + yol[2]  + "\\" + yol[3] + "\\" + yol[4] + "\\" + yol[5] + "\\File\\"+ dosya_ad;
                System.IO.File.Copy(openFileDialog1.FileName, yol_dosya);
                lb_dosya.Text =dosya_ad;
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

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            if (server.IsListening) {
                if ((!string.IsNullOrEmpty(tb_mesaj.Text) || lb_dosya.Text!=" ")&& lb_kullanici.SelectedItem!=null)
                {
                    siferliBinaryDeger = encryptionDecryption.metin(tb_mesaj.Text);
                    string siferliDeger;
                    if (checkBox2.Checked) { 
                        siferliDeger = encryptionDecryption.BinaryToString(siferliBinaryDeger);
                    }
                    else
                    {
                        siferliDeger = tb_mesaj.Text;
                    }
                    if(lb_dosya.Text != " ") {
                        server.Send(lb_kullanici.SelectedItem.ToString(), lb_dosya.Text); // dosya ismi cliente gönderiliyor
                        tb_info.Text += $"Server: {lb_dosya.Text}{Environment.NewLine}";
                        server.Send(lb_kullanici.SelectedItem.ToString(), lb_dosya.Text + " dosya"); // dosya olduğu gönderiliyor
                        lb_dosya.Text = "";
                    }
                    if (!string.IsNullOrEmpty(tb_mesaj.Text)) {
                        server.Send(lb_kullanici.SelectedItem.ToString(), siferliDeger); // mesaj cliente gönderiliyor
                        server.Send(lb_kullanici.SelectedItem.ToString(), siferliBinaryDeger); // mesajın binary hali cliente gönderiliyor
                        tb_info.Text += $"Server: {siferliDeger}{Environment.NewLine}";
                        tb_mesaj.Text = string.Empty;
                        label1.Text = "";
                        label1.Text += "SHA-256 : ";
                        label2.Text = "";
                        label2.Text += "SPN-16 : ";
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                    }
                }
            }
        }
    }
}
