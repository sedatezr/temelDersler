using System.Collections;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koleksiyon Nedir?!");
            //ArrayList koleksiyonlar dizilerde var olan sınırlılıkları ortadan kaldırarak avantajlar sağlıyor.
            //dizilerde başlangıçta belirtmemiz gereken değer sayısı gibi durumları ortadan kaldırarak profesyonel bir yaklaşım  sergilemektedir.
            //system.collection sınıfından türemektedir. bir sınıf edasıyla yaklaşım yapmak gerekiyor.
            //COunt ile eleman sayısı dönüyoruz.
            //ArrayList ile oluşturulan veriler object olarak depolanır bundan dolayı da boxing ve unboxing değerlere tabi tutmamız gerekiiyor.
            ArrayList yaslar = new ArrayList();
            yaslar.Add(28);
            yaslar.Add(29);
            yaslar.Add(27);





            ArrayList Yonetici = new ArrayList() {"sedat","mehmet","ali"};
            ArrayList Ogretmen = new ArrayList() {"ece","şehriban","ayşe"};
            ArrayList Ogrenciler = new ArrayList() { "merve", "handan", "melek", "nuri", "şuayip" };


            bool kural = true;
            int sayac = 0;
            while(kural) { 
            Console.WriteLine("lütfen kullanıcı adınızı giriniz");
            string kadi = Console.ReadLine();
            Console.WriteLine("lütfen şifrenizi giriniz");
            string sifre = Console.ReadLine();
               
                bool bulunduMu = false;
               

                    if(Yonetici.Contains(kadi) && sifre == "1")
                    {
                    Console.WriteLine("Hoşgeldin Yönetici");

                        bulunduMu = true;
                        kural = false;
                    }
                   
                    if(Ogretmen.Contains(kadi) && sifre == "1")
                    {
                    Console.WriteLine("Hoşgeldin Öğretmen");
                    bulunduMu = true;
                        kural = false;
                    }
                   
                    if(Ogrenciler.Contains(kadi) && sifre == "1")
                    {
                    Console.WriteLine("Hoşgeldin Öğrenci");
                        bulunduMu = true;
                        kural = false;
                    }
                     
                if (!bulunduMu)
                {
                    Console.WriteLine("kadi veya şifre yanlış");
                    sayac++;
                    if(sayac == 3)
                    {
                        Console.WriteLine("3 hatalı denemeden sonra bloke edildiniz");
                        kural = false;
                    }
                }
             

               

            }


        }
    }
}
