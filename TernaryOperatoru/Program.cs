namespace TernaryOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ternary Operatörü");

            //ternary operatörü if else gibi akış kontrol mekanizmaları olarak pratik bir şekilde kullanılabilmektedir. fonksiyonel ve büyük işlemler gerektirmeyen durumlarda kullanılabilir.
            // Kullanımı (değişken türü) şart ? true:false

            string medeniHal = "evli";


            string durum = medeniHal == "evli" ? "evlilere kampanya" : "bekarlara kampanya";
            Console.WriteLine(durum);




            //var sayi3 = "5";


            //if (sayi3.GetType() == typeof(int))
            //{
            //    Console.WriteLine("evet bu bir int sayıdır");
            //}
            //else if (sayi3.GetType() == typeof(string))
            //{
            //    Console.WriteLine("string değer algılandı");
            //}



            int yas = 24;

            char durum2 = yas < 25 ? 'a' : (yas == 25 ? 'b' : 'c');

            Console.WriteLine(durum2);



            int sayi = 5;

            int durum3 = sayi < 3 ? sayi * 5 : sayi > 3 ? sayi * 3 : sayi >= 9 && sayi % 2 == 0 ? sayi * 10 : sayi % 2 == 1 ? sayi : 0;



            //hava yağmurlu ise şemsiye almaslısın
            //hava güneşli ise bol bol d vitamini alman dileğiyle
            // hava kapalı => yağmur yağabilir


            string mesaj = "kapalı";

            string durum4 = mesaj == "yağmurlu" ? "şemsiye almalısın yanına" : (mesaj == "güneşli" ? "bol bol d vitamini al" : "yağmur yağabilir");

            Console.WriteLine(durum4);


            //Console.WriteLine("! eşit değil mi Operatörü");

            //int i = 3;
            //int i2 = 5;

            //Console.WriteLine(!(i == i2)); //işlemin tersini alır ! operatörü




        }
    }
}
