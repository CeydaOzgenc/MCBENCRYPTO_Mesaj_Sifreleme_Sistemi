using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace sha_odev
{
    public class EncryptionDecryption
    {
        public string StringToBinary(string data)//string veriyi binary veriye çeviriyor
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public string BinaryToString(string data)//binary veriyi string veriye çeviriyor
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public string SHA_256_Encrypting(string deger)//Sha 256 şifreleme kod başlangıcı
        {
            SHA256 sha = SHA256.Create();
            byte[] degerBytes = Encoding.UTF8.GetBytes(deger);
            byte[] shaBytes = sha.ComputeHash(degerBytes);
            return HashToByte(shaBytes);
        }

        public static string HashToByte(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte item in hash)
            {
                result.Append(item.ToString("x2"));

            }

            return result.ToString();
        }//Sha 256 şifreleme kod sonu                       
        public string keys(string metinBinary)//spn16 şifreleme işlemenin yapıldığı fonksiyon
        {
            string key = "security", keyTut, keyBinary, sifreliMetin = "";
            char[] newSifreliMetin = new char[16];
            keyTut = key;
            for (int i = 0; i < 4; i++)//8 karakterli şifre olacağından 4 sefer çalışan for döngüsü
            {
                keyBinary = StringToBinary(keyTut.Substring(0, 2));//şifrenin ilk 2 karakteri alınıyor ve binary haline getiriliyor

                sifreliMetin = "";
                for (int j = 0; j < 16; j++)//binary şeklindeki verilere XOR işlemi uygulanıyor
                {
                    sifreliMetin += keyBinary[j] ^ metinBinary[j];

                }
                /*Karma işlemi sadece 2 sefer uygulandığından algoritmadaki sıralamay * uygun olarak koşul koyuldu. Karma işlemi burada yapılıyor.*/
                if (i == 0 || i == 1)
                {
                    newSifreliMetin[5] = sifreliMetin[0];
                    newSifreliMetin[9] = sifreliMetin[1];
                    newSifreliMetin[0] = sifreliMetin[2];
                    newSifreliMetin[12] = sifreliMetin[3];      
                    newSifreliMetin[7] = sifreliMetin[4];
                    newSifreliMetin[3] = sifreliMetin[5];
                    newSifreliMetin[11] = sifreliMetin[6];
                    newSifreliMetin[14] = sifreliMetin[7];
                    newSifreliMetin[1] = sifreliMetin[8];
                    newSifreliMetin[4] = sifreliMetin[9];
                    newSifreliMetin[13] = sifreliMetin[10];
                    newSifreliMetin[8] = sifreliMetin[11];
                    newSifreliMetin[2] = sifreliMetin[12];
                    newSifreliMetin[15] = sifreliMetin[13];
                    newSifreliMetin[6] = sifreliMetin[14];
                    newSifreliMetin[10] = sifreliMetin[15];
                    string strDonustur = new string(newSifreliMetin);//char dizisi halindeki veri tekrar string hale getiriliyor.
                    metinBinary = strDonustur;
                }
                else
                {
                    metinBinary = sifreliMetin;
                }
                keyTut = keyTut.Substring(2, keyTut.Length - 2);    //keyin ilk 2 hanesi siliniyor
            }
            return sifreliMetin;    //şifrelenen ilk 2 karakter geri gönderiliyor
        }
        public string metin(string textBoxMetin)    //spn sifreleme işlemlerinin başladığı method.
        {
            string metin = textBoxMetin, metinTut, metinBinary, sonMetin = "";
            metinTut = metin;
            for (int i = 0; i < metin.Length / 2; i++)  //2 karakter şeklinde ilerlendiği için metin uzunluğunun yarısı kadar dönüyor
            {
                metinBinary = StringToBinary(metinTut.Substring(0, 2)); //metinin ilk iki karakteri çekilip binary hale getiriliyor

                sonMetin += keys(metinBinary);  //binary hale getirilen 2 karakter keys fonksiyonuna gönderiliyor
                metinTut = metinTut.Substring(2, metinTut.Length - 2);  //burada metnin ilk iki karakteri siliniyor

            }
            return sonMetin;    //metnin şifrelenmiş hali formda gösterilmek üzere geri gönderiliyor.

        }
        public string keysCoz(string metinBinary)//şifre çözme işleminin gerçekleştirildiği fonksiyon
        {
            string key = "security", keyTut, keyBinary, sifreliMetin = "";
            char[] newSifreliMetin = new char[16];
            int k = 6;
            keyTut = key;
            for (int i = 0; i < 4; i++)
            {   
                keyBinary = StringToBinary(keyTut.Substring(k, 2)); //işlem tersine olacağından keyin son 2 karakterinin binary değeri alınıyor.
                sifreliMetin = "";
                for (int j = 0; j < 16; j++) //XOR işlemi burada gerçekleşiyor.
                {
                    sifreliMetin += keyBinary[j] ^ metinBinary[j];

                }
                if (i == 1 || i == 2) //karma işlemi burada gerçekleşiyor işlemler tersine uygulanıyor !!
                {
                    newSifreliMetin[0] = sifreliMetin[5];
                    newSifreliMetin[1] = sifreliMetin[9];
                    newSifreliMetin[2] = sifreliMetin[0];
                    newSifreliMetin[3] = sifreliMetin[12];
                    newSifreliMetin[4] = sifreliMetin[7];
                    newSifreliMetin[5] = sifreliMetin[3];
                    newSifreliMetin[6] = sifreliMetin[11];
                    newSifreliMetin[7] = sifreliMetin[14];
                    newSifreliMetin[8] = sifreliMetin[1];
                    newSifreliMetin[9] = sifreliMetin[4];
                    newSifreliMetin[10] = sifreliMetin[13];
                    newSifreliMetin[11] = sifreliMetin[8];
                    newSifreliMetin[12] = sifreliMetin[2];
                    newSifreliMetin[13] = sifreliMetin[15];
                    newSifreliMetin[14] = sifreliMetin[6];
                    newSifreliMetin[15] = sifreliMetin[10];
                    string strDonustur = new string(newSifreliMetin);
                    metinBinary = strDonustur;
                }
                else
                {
                    metinBinary = sifreliMetin;
                }
                k = k - 2;
            }
            return sifreliMetin;    //şifrelenmiş metnin ilk karakteri çözülü binary olarak geri gönderiliyor.
        }
        public string metinCoz(string textBoxMetin)//sifreli metnin çözlüme işlemlerinin başladığı method
        {
            string metin = textBoxMetin, metinTut, metinBinary, sonMetin = "";
            metinTut = metin;
            for (int i = 0; i < metin.Length / 16; i++)//çözülecek şifreli metni binary olarak aldığımız içi 2 karakter 16 bit olduğundan bu for döngüsü kuruldu
            {
                metinBinary = metinTut.Substring(0, 16);    //elimizde şifreli metnin binary değeri olduğundan 2 karaktere denk gelen ilk 16 bit alınıyor.
                sonMetin += keysCoz(metinBinary);   //şifre çözülmek üzere fonksiyona gönderiliyor
                metinTut = metinTut.Substring(16, metinTut.Length - 16);    //ilk 16bit siliniyor
            }
            return sonMetin;//metnin çözülmüş halinin binary degeri döndürülüyor
        }

    }
}
