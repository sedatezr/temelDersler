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
            //dizilerde değer okuması yapılırken var olan değer aralığınını geçmemek gerekiyor. aksi halde program hata verir.



            //dizi tanımlama yöntemleri 1

            // 7 elemanlı bir int dizisi oluşturduk ve buna sonradan iki değer eklemesi yaptık.
            int[] dizi = new int[7];
            dizi[0] = 1;
            dizi[1] = 2;



            string[] personeller = new string[4];

            personeller[0] = "sedat";
            personeller[1] = "ece";
            personeller[2] = "ayşe";
            personeller[3] = "şehriban";


            foreach (string i in personeller) { 
            
                Console.WriteLine(i);
                
            }

            //dizi tanımlama yöntemleri 2

            int[] sayilar = { 1, 2, 3, 4, 5, 8, 9, 7 };

            Console.WriteLine(sayilar[2]);


            string[] isimler = { "sedat", "şehriban", "ece" };
            Console.WriteLine(isimler[2]);

        }
    }
}
