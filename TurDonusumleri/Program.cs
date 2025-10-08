namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tür Dönüşümleri!");

            //tür dönşümlerindeki temel amaç var olan değeri kendi türüne uygun şekilde dönüştürmektir. örnek verecek olursak byte ile atanan değeri int değişkenine dönüştürmek. veya string ile atanan 123 deüerini int dönüştürmek yani dönüştürmek istediğimiz değer yeni atanacak türe uygun olması gerekiyor. 123 değerini bool veya char değişkenine dönüştüremeyiz. sadece kendi türlerine uygun olması gerekiyor.

            // int olan bir değeri stringe çevirme

            int yas = 27;
            string donustur = yas.ToString();
            Console.WriteLine(donustur.GetType());


            // string olan bir değeri int çevirme

            string sayi = "27";

            int donstur2 = int.Parse(sayi );


            //bool değişkenini stringe çevirme

            bool deger = true;

            string gelenBool = Convert.ToString(deger);



            //string değerini bool dönüştirme


            string deger1 = "true";

            bool gelenString = Convert.ToBoolean(deger1);


            int yas1 = 0;

            bool inDonustur = Convert.ToBoolean(yas1);

            Console.WriteLine(inDonustur);



            //Tostring metodu var olan herhangi bir değişkenin değerini stringe çervirmek için kullanılır

            int x = 2;
            x.ToString();

            bool x2 = true;
            x2.ToString();

            char x3 = 'A';
            x3.ToString();




            //Sayısal değerlerde tür dönüşümleri
            //sayısa değerlerde tur dönüşümlerinde iki farklı dönüşüm söz konusudur. blinçli ve bilinçsiz tur dönüşümü
            //bilinçli tur dönüşümlerinde var olan bir değişken tipini kendi değerinde kendisinden daha küçük bir değer aralığına dönüştürüldüğünde kullanılmaktadır. buda elde olan verilen kaybolmasını önlemek için yapılmaktadır. int byte çevirme
            //bilinçsiz tur dönüşümü ise kendisinden daha büyük bir değer aralığını alan değere dönütürme işleminde kullanılır örnek short int çevirme 


            //bilinçsiz tur dönüşümü

            int x4 = 5;
            double x_ =   x4;

            //Bilinçli tür dönüşümü
            //Burada cast işlemi söz konusudur.

            int xx1 = 50;
            byte yeniDeger =  (byte)(xx1);



        }
    }
}
