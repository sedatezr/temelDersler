using System.ComponentModel;

namespace StringDeger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //String bir referans türlü değişkendir. değer türlü değildir. değeri ram üzerinde heap bölgesinde tutar değişken referans kısmı ise stack alanında tutulur. değeri referans ederek işaret ederek heap bölgesinden alır.


            #region Null bir değişken null değer alıyorsa ram üzerinde herhangi bir yer edinmez
            string nullDeger = null; // herhangi bir yer tahsisinde bulunmaz

            string deger1 = null;

            if (deger1 == null) {
                Console.WriteLine("herhagi bir yer tahsisinde bulunmamış");
            }

            #endregion


            #region EMPTY bir değişken empty değer alırsa ram üzerinde yer ta hsisi eder ama değeri yok anlamına gelir.
            //default değerlerin olduğu durumlar empty olarak yer alır.
            string emptyDeger = string.Empty; // yer tahsisinde bulundu ama herhangi bir değer ataması yok.

            string deger = "";
            if(deger == string.Empty)
            {
                Console.WriteLine("boş geldi");
            }
            #endregion

            #region IsnulllorEmpty gelen değerin boş veya null olma durumunu kontrol eder geriye true değer döndürür
            string kontrol = "";

            if (!(string.IsNullOrEmpty(kontrol))) {

                Console.WriteLine("işlem yapılabilir");
            }
            else
            {
                Console.WriteLine("gelen değer boş");
            }
            #endregion



            #region IsnulllorWhiteSpace gelen değerin null,empty veya boş karekter olup olmadığını kontrol eder
            string kontrol1 = "null";

            if (!(string.IsNullOrWhiteSpace(kontrol1)))
            {

                Console.WriteLine("işlem 1 yapılabilir");
            }
            else
            {
                Console.WriteLine("gelen 1 değer boş");
            }
            #endregion

            #region string format önermiyorum string ınterpolation daha mantıklı
            string ad = "sedat";
            string yas = "28";
            string sonuc = string.Format ("ad : {0} yaşı : {1}", ad, yas);
            Console.WriteLine(sonuc);
            #endregion



            #region string ınterpolation
            // en çok tercih edilen yapıdır.
            string adi = "sedat";
            int tc = 5555;

            Console.WriteLine($"adi {adi} tc {tc}");


            #endregion




            ///STRİNG FONKSİYONLARI
            ///

            //Contains
            // string içerisinde arma yapar bir değerin var olup olmadığını kontrol eder var ise geriye bool değer dçndürür
            string mesaj = "sana göre laylaylom hayat";
            bool sonucmesaj = mesaj.Contains("göre");
            Console.WriteLine(sonucmesaj);

            //EQUALS elimizde ki bir değeri ile başka bir string değeri karşılaştırır geriye bool döndürür.
            // karşılaşma eksik olduğu için false döndürür
            bool durum = mesaj.Equals("sana göre laylaylom ");
            Console.WriteLine(durum);


            //split metinsel ifadeyi ayraç olarak kullanır bir string dizisine döndürür.
            //bu örnekte mesaj adlı değişkenin içerisinde var olan değer bir string değer dönüştü ve 3 indexli bir string dizisine dönüştü bizde dizinin 0 indexini alıp ekrana yazdık
            string[] dizi = mesaj.Split(' ');

            Console.WriteLine(dizi[0]);

            //Substring
            //substring ile dizi içerisinde istemiş olduğumuz karekterden  başlayarak bir sonraki karektere kadar alabilmekteyiz.
            string sub = mesaj.Substring(0, 2);
            Console.WriteLine(sub);




            //girilen metnin içerisinde kaç adet "n" karekterinin olduğunu hesaplayalım
            
            string girilenMetin = "merhaba dünya nasılsın";

            int sayac = 0;
            for (int i = 0; i < girilenMetin.Length; i++) {
                if (girilenMetin[i] == 'n')
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac);


            //girilen metnin içerisinde kelime sayısını kaç tane olduğunu hesaplayalım

             
            string girilenMetin1 = "göklerden gelen bir karar vardır";
            string[] donustur = girilenMetin1.Split(" ");

            for (int a = 0; a < donustur.Length; a++) {
                Console.WriteLine(a);
            }



            long TCkimlikNo = 26974587446;

            int birinci = TCkimlikNo.ToString()[0];
            int ucuncu = TCkimlikNo.ToString()[2];
            int besinci = TCkimlikNo.ToString()[4];
            int yedinci = TCkimlikNo.ToString()[6];
            int dokuzuncu = TCkimlikNo.ToString()[8];


            int birinciIslem = birinci + ucuncu + besinci + yedinci + dokuzuncu;

            int carp = birinciIslem * 7;
            //ikinci aşama

            int ikinci = TCkimlikNo.ToString()[1];
            int dortduncu = TCkimlikNo.ToString()[3];
            int altinci = TCkimlikNo.ToString()[5];
            int sekizinci = TCkimlikNo.ToString()[7];

            int ikinciIslem = ikinci + dortduncu + altinci + sekizinci;

            int islemYap = (carp - ikinciIslem) ;
            int bol = islemYap / 10;
            Console.WriteLine(islemYap);

        }
    }
}
