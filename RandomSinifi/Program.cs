namespace RandomSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Sınıfı");
            ///Random sınıflarda rastgele sayılar üretmemize olanak sağlamaktadır.
            ///


            Random rnd = new Random();
            int degisken =  rnd.Next(0,900000);
            Console.WriteLine(degisken);

            string kadi = "sedat";
            int sifre = 123;

            bool durum = true;
            int sayac = 0;
            while (durum)
            {
                Console.WriteLine("lütfen kadi giriniz");
                string kadi1 = Console.ReadLine();
                Console.WriteLine("lütfen sifre giriniz");
                int sifre1 = int.Parse(Console.ReadLine());
                Console.WriteLine("lütfen doğrulama kodu giriniz");
                int dk = int.Parse(Console.ReadLine());

                if (kadi == kadi1 && sifre == sifre1 && dk == degisken) {

                    Console.WriteLine("giriş başarılı");
                    durum = false;
                
                }else if(dk != degisken)
                {
                    Console.WriteLine("doğrulama kodu hatalı girdiniz");
                    sayac++;
                }
                else
                {
                    sayac++;
                }

                if(sayac >= 3)
                {
                    Console.WriteLine("giriş hakkınız doldu");
                    break;
                }
            }
           
        }
    }
}
