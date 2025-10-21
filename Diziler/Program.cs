namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler, Arrayler!");
            //Tek bir değişken altında birden fazla değer toplamamıza olanak sağlayan yapılar dizilerdir.(veri kümeleri)
            //diziler birden fazla yapıyı tek bir yapıda tutamazlar. sadece kendi türlerene ait yapıları barındarabilmektedirler.
            //Referans türlü yapılardır. özlerinde bir sınıf class yapılardır. 
            //diziler temel programlama da yer alan koleksiyonların temelini oluştururlar.
            //Dizilere sonradan eklenme yapılmamaktadır.
            //önceden belirlenen yapılar üzerinde ilerleme yapmak zorundayız


            int[] sayilar = { 1, 2, 3, 4, 5, 8, 9, 7 };

            Console.WriteLine(sayilar[2]);


            string[] isimler = { "sedat", "şehriban", "ece" };
            Console.WriteLine(isimler[2]);

        }
    }
}
