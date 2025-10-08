namespace ObjectTur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Object Türü Türlerin Atası");

            //Object referans türlü bir yapıdır. fakat bütün değer türlü değişkenleri de kapsayabilirler.
            //Object türü ile tanımlanan bir değer ram üzerinde boxing(kutulama işlemi görür)
            //bunu kullanabilmemiz ve işlemler etabi tutmamız için ise unboxing yapmamız geriyor yani cast operatörüyle kendi türüne özgü olarak dışarı çıarmamızgerekiyor.


            object sayi1 = 5;
            object sayi2 = 6;

            Console.WriteLine((int)sayi1* (int)sayi2);
            Console.WriteLine(sayi1);
        }
    }
}
