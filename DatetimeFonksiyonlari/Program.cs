using System.Runtime.Intrinsics.Arm;

namespace DatetimeFonksiyonlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Tarih ve zaman fonksiyonları string fonksiyonundan sonra en çok kullanılan yapılardır.

            #region Now propu bugünün tarihini verir anlık olarak değeri ayıt eder
            Console.WriteLine(DateTime.Now);
            #endregion

            #region Today günlük  tarih bilgisini verir
            Console.WriteLine(DateTime.Today);
            #endregion


            #region Compare iki tarih arasonda kıyaslama yapar ve geriye int olarak -1 0 1 değerlerini döndürür
            DateTime tarih1 = new DateTime(2025, 11, 14);
            DateTime tarih2 = new DateTime(2024, 11, 14);

            int result = DateTime.Compare(tarih1, tarih2);

            if (result == 0) {

                Console.WriteLine("tarihler eşittir");
            }else if (result < 0)
            {
                Console.WriteLine("tarih 1 tarih 2 den küçüktür");
            }
            else
            {
                Console.WriteLine("tarih2 tarih 1 den küçüktür ");
            }
            #endregion



            #region ornek
          
            DateTime SimdikiZaman = DateTime.Now;
            DateTime LisansBitisTarihi =SimdikiZaman.AddDays(14);

            if (SimdikiZaman >= LisansBitisTarihi)
            {
                Console.WriteLine("lisans süreniz doldu");
            }
            else
            {
                TimeSpan kalanSure = LisansBitisTarihi - SimdikiZaman;

                Console.WriteLine($"kalan gün  {kalanSure.Days}");
            }
            #endregion
        }
    }
}
