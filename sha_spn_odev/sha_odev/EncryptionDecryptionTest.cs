using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sha_odev
{
    [TestFixture] // bu ifade bize bu sınıfın bir test sınıfı olduğunu ifade etmektedir
    class EncryptionDecryptionTest
    {
        EncryptionDecryption eD = new EncryptionDecryption(); // burada EncryptionDecryption sınıfımızdan bir nesne oluşturduk

        [Test] //bu ifade bize bu metodun test metodu olduğunu ifade etmektedir
        public void StringToBinary() //StringToBinary test metodumuz
        {
            string sonuc = eD.StringToBinary("na"); //StringToBinary methoduna değerimizi parametre olarak geçirdik, ve EncryptionDecryption sınıfının metodunu çağırdık
            Assert.AreEqual("0110111001100001", sonuc); //ilk parametre 2. parametre ile aynı ise methodumuz doğru çalışıyordur ve test başarılıdır
        }

        [Test] //bu ifade bize bu metodun test metodu olduğunu ifade etmektedir
        //
        public void BinaryToString() //BinaryToString test metodumuz
        {
            string sonuc = eD.BinaryToString("0110111001100001"); //BinaryToString methoduna değerimizi parametre olarak geçirdik, ve EncryptionDecryption sınıfının metodunu çağırdık
            Assert.AreEqual("na", sonuc); //ilk parametre 2. parametre ile aynı ise methodumuz doğru çalışıyordur ve test başarılıdır
        }
        [Test] //bu ifade bize bu metodun test metodu olduğunu ifade etmektedir
        public void metin() //metin test metodumuz
        {
            string sonuc = eD.metin("mutluyum"); //metin methoduna değerimizi parametre olarak geçirdik, ve EncryptionDecryption sınıfının metodunu çağırdık
            Assert.AreEqual("1110111001101101000011000110101101001110010011110000111001101111", sonuc); //ilk parametre(mutluyum kelimesinin spn16 ile şifrelenmiş binary değeri) 2. parametre ile aynı ise şifreleme methodumuz doğru çalışıyordur ve test başarılıdır
        }
        [Test] //bu ifade bize bu metodun test metodu olduğunu ifade etmektedir
        public void metinCoz() //metinCoz test metodumuz
        {
            string sonuc = eD.metinCoz("1110111001101101000011000110101101001110010011110000111001101111"); //metinCoz methoduna değerimizi(mutluyum kelimesinin spn16 ile şifrelenmiş binary değeri) parametre olarak geçirdik, ve EncryptionDecryption sınıfının metodunu çağırdık
            Assert.AreEqual("0110110101110101011101000110110001110101011110010111010101101101", sonuc); //ilk parametre(mutluyum kelimesinin binary değeri) 2. parametre ile aynı ise şifreleme methodumuz doğru çalışıyordur ve test başarılıdır
        }
        [Test] //bu ifade bize bu metodun test metodu olduğunu ifade etmektedir
        public void SHA_256_Encrypting() //SHA_256_Encrypting test metodumuz
        {
            string sonuc = eD.SHA_256_Encrypting("mutluyum"); //SHA_256_Encrypting methoduna değerimizi parametre olarak geçirdik, ve EncryptionDecryption sınıfının metodunu çağırdık
            Assert.AreEqual("18d3fd6cb97d6027656f341fbc12fc33e65fe9d0ba14025c474e9e46b8017fbf", sonuc); //ilk parametre(mutluyum kelimesinin sha256 ile şifrelenmiş hali) 2. parametre ile aynı ise şifreleme methodumuz doğru çalışıyordur ve test başarılıdır
        }
    }
}
