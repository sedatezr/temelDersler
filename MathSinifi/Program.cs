namespace MathSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematiksel işlemlerim yapıldığı sınıftır!");


            //Math sınıfı Mutlak değer sonucu verir
            int i = Math.Abs(5); //geriye int değer döndürür

            //ceiling ondalıklı sayılarda tam sayı kullanmak için kullanılır. aşağı veya yukarı döndürür // YUKARI
            Math.Ceiling(5.14);
            //floor ondalıklı sayılarda tam sayı kullanmak için kullanılır. aşağı veya yukarı döndürür // AŞAĞI
            Math.Floor(5.14);
            //round küsürata en yakın değer eyuvarlama yapar
            Math.Round(5.5);


            //pow sayıların üstünü almak için kullanılır
            Math.Pow(7, 9); // 7 nin 9 kuvveti nedir?

            //sqrt karekök değerini alır
            Math.Sqrt(6);

            //Truncate ondalıklı sayının tam sayısını almak
            Math.Truncate(3.14);




        }
    }
}
