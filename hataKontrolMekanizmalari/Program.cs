namespace hataKontrolMekanizmalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Akış Kontrol Mekanizması!");
            //Runtime çalışma zamanı hataları
            //program çalışırken istenmeyen bir veri işlendiğinde program kaldırmadığında vermiş olduğu hatalardır. bunların önüne geçmek için try cath bloğu kullanmamız gerekiyor.
            bool durumKontrol = true;

            while (durumKontrol)
            {
                try
                {


                    Console.WriteLine("lütfen bir sayı giriniz");
                    int sayi = int.Parse(Console.ReadLine());
                    Console.WriteLine("lütfen ikinci sayı giriniz");
                    int sayi2 = int.Parse(Console.ReadLine());
                    durumKontrol = false;

                }
                catch (FormatException ex )
                {

                    Console.WriteLine("mesaj: " + ex.Message);


                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("mesaj: " + ex.Message);
                }
            }
            //derleme esnasında alınan hatalar
            //kod yazarken genellikle sytnax kod hataları derleme esnasında görülebilen hatalar olarak geçmektedir. bunlar kolaylıkla çözülebilmektedir.




        }
    }
}
