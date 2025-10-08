namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ///Operatörler matematiksel işlemler veya karşılaştırma operatörleri olarak kullanılmaktadır.
            // + - / * % alma gibi aritmetik operatörler bulunmaktadır.
            // > < => <= == karşılaştırma operatörleri de ise geriye true false değerler döndürür.


            Console.WriteLine(5>4); //true
            Console.WriteLine(5>=4); // true
            Console.WriteLine(5<=4); //false
            Console.WriteLine(5==4); //false



            //Mantıksal operatörler geriye verilen değere göre değerlendirme yaparak boolen snonuç gönderir.

            // && (ve) her iki sonucun da true olmak zorunda 
            // || (veya) her iki sonucunda doğru olmak veya şartlardan herhangi birisinin doğru olması gerekiyor.
            // ^ (ya da) sadece bir şartın doğru olması gerekiyor.

            Console.WriteLine(true && true); // true
            Console.WriteLine(true && false); // false
            Console.WriteLine(false && true); // false

            Console.WriteLine(true || true); // true
            Console.WriteLine(true || false); // true
            Console.WriteLine( false|| false); // false


            Console.WriteLine(true ^ true); // false
            Console.WriteLine(true ^ false); // true
            Console.WriteLine(false ^ false); // false


            //artırma azaltma operatörleri 

            int i = 5;
            int b = i++;

            Console.WriteLine(i);
            Console.WriteLine(b);
      


            int i1 = 5;
            int b1 = ++i1;

            Console.WriteLine(i1);
            Console.WriteLine(b1);



            //üstüne ekleme yığma operatörleri

            // i += 3, i -=3 i *=3, i%=  3
            int x = 5;
            Console.WriteLine(x-3);


        }
    }
}
