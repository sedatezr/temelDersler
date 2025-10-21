namespace DizilerArraySinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Sınıfı, !");

            //dizi olarak tanımlanan değişkenler array sınıfından türetilmiştir.
            //dizileri haliyle array sınıfı ile karşılayabilmekteyiz.

            // dizi array olarak kullanılıyorsa indexer kullanılmaz
            Array sayi = new int[3];
            

            //array üzerinden diziye değer atama
            Array dizi = new int[] { 1,2,2};

            //bu format genellikle algoritmalarda kullanılır.
            //dizi kentdi türünde tutuluyorsa indexer kullanılır.
            int[] sayi2 = new int[3];
        }
    }
}
