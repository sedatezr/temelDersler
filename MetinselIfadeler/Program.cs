namespace MetinselIfadeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("metinsel operatörler");

            string a = "sedat";
            string b = "ahmet";

            Console.WriteLine(a+b); // a değerinin yanına b ekle

            Console.WriteLine(a+= b); // a değerinin üstüne b ekle

            Console.WriteLine(a==b); // a eşit mi? b ye
            Console.WriteLine(a.Length>b.Length); // a karekter sayısına göre büyük mü b den
            Console.WriteLine(a !=b); // a eşit değil mi b ye


            // 
        }
    }
}
