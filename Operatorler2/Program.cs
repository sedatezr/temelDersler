using System.Threading.Channels;

namespace Operatorler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //typeof  verilen değerin türünün type değerini getirir. o tür ile ilgili bütün değerlere ulaşabiliriz.

            int i = 5;

            Console.WriteLine(typeof(int)); // type tipi int 


            //default değişkenlerin varsayılan öz değerlerini getirir

            Console.WriteLine(default(int));
            Console.WriteLine(default(string));


            //is operatörü 

            //object ile boxing yapılmıi değerlerin öz türlerini öğrenmek için kullanılır

            object x = "5";

            if (x is int)
            {
                Console.WriteLine("int değer");
            }
            else if (x is string) {
                Console.WriteLine("bu bir string değer");
            }


            // is not null 
            // bu bir int değel mi ? anlamında kullnılır yapılan işlemin tersi görev yapmaktadır.


            if (x is not int) // bu bir int değer  mi sonuç ? hayır
            {
                Console.WriteLine("int değerss");
            }


            //bir değişkenin null olup olmadığı durumlarda kullanılır. sadece null alabilen türlerlede kullanılabilektedir.

            string ad = null;

            string durum = ad is null ? "evet" : "hayır";
            Console.WriteLine(durum);


            //basit bir kelime kontrolü 

            //string gelenCevap = Console.ReadLine();

            //string gelenCevapKontrol = gelenCevap is null || gelenCevap.Length ==0 ? "gelen cevap Boştur lütfen bir harf veya kelime giriniz" : gelenCevap;

            //Console.WriteLine(gelenCevapKontrol);

             
            int? a = null;

            Console.WriteLine(a is null);
            Console.WriteLine(a is not null);




            //null coalescing operatörü
            //bu operatör sayesinde bir değerin  null olup olmadığı kontrolü yapabilmekteyiz. değer null ise bir atama da yapabilmekteyiz. not atama yapabilmek için her iki değerinde aynı türde olması gerekmektedir.

            string xy = null;
            //gelen değer null ise ahmet değerini ata
            Console.WriteLine(xy ?? "ahmet");



            /// null assigmnent atama operatörü
            /// 

            string xyy = null;
            /// eğer ki gelen değer null ise sen varsayılan değer olaran xyy değişkenine bir değer ata
            Console.WriteLine(xyy ??= "varsayılan değer");
           
        }
    }
}
