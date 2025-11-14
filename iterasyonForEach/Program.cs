using System.Collections;

namespace iterasyonForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iterasyon, ForEach Nedir?!");
            //Foreach bir iterasyondur programlama dilinde kendinden sonra gelen değeri itere ederek çalışma mantığına sahiptir. genellikle listeleme işlemlerinde ve array koleksiyonlarla birlikte kullanılır.

            ArrayList Yonetici = new ArrayList() { "ahmet","mehmet", "sedat", "kemal","ali"};
            string kadi = "sedat";

            foreach (var item in Yonetici) {

                if (item == kadi)
                {
                    Console.WriteLine("bulundu");
                   
                }

            }
        }
    }
}
