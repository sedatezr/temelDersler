namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Değişkenler");
            // Değişkenler ram üzerinde tutulabilen farklı türlerde değerler alablen yapılardır.
            //Bir değişken ram üzerinde alan tahsis ettiğinde bunlara değer türlü değişkenler diyoruz.
            //Not sayısal değerlerde varsayılan olarak int olarak değerler algılanır.
            //örnek



            int yas = 27;
            string ad = "sedat";
            char Bolum = 'a';
            bool LoginStatus = false;
            float ondalikli = 3.14f;

            //Tuple veri türleri örneği

            (int yas, int boy, string ad) kisi = (27, 179, "sedat");

            Console.WriteLine(kisi.ad + kisi.yas+ kisi.boy);

            Console.WriteLine($"ad {ad} yaş {yas} ");

            Console.WriteLine(default(bool));



            int a = 5;
            int b = 10;
            int c = b; //10
            int d = a; //5
            b = a; //5
            c = b; //10

            #region Elektrik kwh hesaplama

            //float MeskenAktifEnerji = 1.49f;
            //float kWh = 2.59f;
            //float kwhOn = 3.92f;

            //Console.WriteLine("lütfen kullanmış olduğunuz elektrik kwh belirtiniz ");
            //float gelenkWh = int.Parse(Console.ReadLine());

            //if (gelenkWh <= 0)
            //{

            //    Console.WriteLine("elektrik kullanımı oldmadğı için herhangi bir ödeme yapam zorunluluğunuz yok");

            //}else if(gelenkWh == 10)
            //{
            //  float Degisiklik =  gelenkWh * kwhOn;
            //    Console.WriteLine($"Ödemeniz gereken ücret {Degisiklik}");
            //}
            //else
            //{
            //    float islemYap = gelenkWh * kWh;
            //    Console.WriteLine($"Ödemeniz gereken ücret {islemYap}");
            //}

            #endregion 



            //SABİTLER
            // belirlenen değişkenin başına const yazıldığında değiştirlemez veya başka bir scope alanında buna tekrardan yeni bir değer atanamaz.
            //genellikle sabit değerlerin olduğu alanlarda kullanılmaktadır. örnek pi sayısi


            const double pi = 3.14f;

            //Global değişkenler
            // bir değişken tanımlanırken class içerisine tanımlanırsa bunlar global değişken denilir. var olan sınıf içerisinde istenildiği yerden erişim alabilmektedir. 

            //iç içe oluşturulan scopların en başına yazılan deişken de alt gruba yazıldığında global değişken olaran nitelendirilebilir.

            //ÖRNEK 

            //int f = 5;
            //{
            //    {
            //        {
            //            Console.WriteLine(f);
            //        }
            //    }
            //}

             


            //DEĞİŞKENLER ARASI DEĞER ATAMA DURUMLARI
            // DEĞİŞKENLER BİRBİRİNE ATANIRKEN DEEP COPY VEYA SHALLOW COPY OLARAK İKİ FARKLI TÜRDE KOPYALAMA İŞLEMİ YAPMAKTADIR.
            
            //DEEP COPY VAR OLAN DEĞERİN AYNISINI KLONLAMAK ANLAMINA GELİR. YANİ A DEĞŞKENİNE ATANAN 5 DEĞERİNİ AYNISINI B DEĞİŞKENİNE TANIMLAMAK.
            //DEĞER TÜRLÜ DEĞİŞKENLER BİRBİRİNE ATANIRKEN DEFAULT OLARAK DEEP COPY GEÇERLİDİR. YANİ VERİ OTOMATİK OLARAK ÜRETİLİR
        }
    }
}
