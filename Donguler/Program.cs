using System.Security.Cryptography;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Döngüsü");
            //Prosedurel programlamada döngü yapılardan bir tanesi de for döngüsüdür.
            //genellikle aritmetik veya ardışık sayıların kullanım durumlarında tercih edilir.
            //for döngüsü başlangıç şart ve artış olarak 3 farkı konfigürasyondan geçmektedir. başlangıçtan başlayarak şart sağlanana kadar artırılma ve ya istenilen durum devam etmektedir. taki koşul sağlanana kadar. koşul sağlandıktan sonra program kendini sonlandırarak sonuş verir.

            #region for döngüsü örneği
            //int sayi = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    sayi++;
            //    Console.WriteLine($"{sayi} Merhaba Dünya");
            //}
            #endregion


            #region for döngüsüyle birden 10' kadar olan sayılardan 2 ' ile bölünebilen çift sayıları ekrana yazdırma
            //for(int i = 0; i<=10; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region for döngüsüyle 10 dan başlayıp 0' kadar eksilterek git
            //for(int k =10; k>0; k--)
            //{
            //    Console.WriteLine(k);
            //}
            #endregion

            #region 1 ile 40 arasında olan sayıların toplayarak sonuca yazdırmak

            #endregion
            //int toplam = 0;
            //for (int j = 1; j<=40; j ++)
            //{
            //    if (j % 2 == 0)
            //    {
            //        toplam += j;
            //    }
            //}
            //Console.WriteLine(toplam);



            #region klavyeden girilen sayıların n faktöriyel verme

            //Console.WriteLine("lütfen bir sayı giriniz");
            //int gelenSayi = int.Parse(Console.ReadLine());


            //int islem = 1;
            //for (int i = gelenSayi; i > 0; i--) {

            //    islem *= i;

            //}
            //Console.WriteLine(islem);

            #endregion


            /// WHİLE DÖNGÜSÜ ///
            /// WHİLE DÖNGÜSÜ SONSUZ DÖNGÜLERDE KULLANILIR. BİR ŞART VERİLİR VE ŞART SAĞLANANA KADAR SONSUZ BİR DÖNGÜ İLE ÇALIŞMA YAPAR.
            /// 


            #region while döngüsü ile 1 den 10 kadar olan sayıları yazdırma
            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine("merhaba while");
            //    i++;
            //}
            #endregion

            #region while döngüsü ile klavyeden girilen sayıyı geriye doğru 0 kadar sayan bir sayaç hazırlayalım
            //int i = 5;

            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            #endregion


            #region while döngüsü ile 0 ile 100 arasınd"a olan tek sayıların toplamını ekrana yazdırma
            //int i = 1;
            //int toplam = 0;

            //while (i<=100)
            //{
            //    toplam += i;
            //    i+=2;
            //}
            //Console.WriteLine(toplam);
            #endregion

            #region while döngüsü ile tarih saniye aralığını alarak her 5 in kaı olduğu sürece ekrana yazdırsın

            while (true)
            {
                if(DateTime.Now.Second % 5 == 0)
                {
                    Console.WriteLine(DateTime.Now);
                }
            }
            #endregion
        }
    }
} 

