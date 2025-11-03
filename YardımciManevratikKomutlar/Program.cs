namespace YardımciManevratikKomutlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manevratik komutlar");
            //kod yazarken belirli durumlarda döngüleri sonlandırmak veya devam edebilmeye ihtiyaç duyabiliyoruz. bu aşamada da manevratik komutlar devreye girmektedir. örneğin return kod bloğunu tamamen sonlandırır. continue devam eder. go to kendinden önceki kod satırına atlar gibi keywordler mevcuttur.


            ///BREAK
            ///break komutu döngü ve switch caselerde kullanılabilen bir manevratik komuttur. bu komut sayesinde var olan döngü sonlanır ve işlem biter. metod içerisinde kullanılması durumunda da metod sonlanır ve çıkış yapılır. yani çıkış yapmak istediğimiz alanlarda kullanabilmekteyiz.
            ///

            //while (true)
            //{



            //    if (DateTime.Now.Second == 10)
            //    {

            //        break;
            //    }
            //    Console.WriteLine("merhaba dünya");


            //}



            //klavyeden t harfi girene kadar girilen bütün sayıları toplayan sonsuz döngüyü yapınız
            //int toplam = 0;
            //while(true)
            //{
            //    Console.WriteLine("lütfen bir sayı giriniz");
            //    string gelenSayi = Console.ReadLine();

            //    if (gelenSayi== "t")
            //    {
            //        Console.WriteLine(toplam);
            //        break;

            //    }
            //    else
            //    {

            //       int sayi = int.Parse(gelenSayi);
            //        toplam += sayi;
            //    }
            //}




            //Klavyeden girilen sayı 37 'nin katı ise program sonlansın. değil ise devam etsin.

            //while (true)
            //{
            //    Console.WriteLine("lütfen bir sayı girinz");
            //    int kullaniciSayi = int.Parse(Console.ReadLine());
            //    if (kullaniciSayi % 37 == 0)
            //    {
            //        Console.WriteLine($"girilen sayı 37'nin katıdır. program sonlanıyor... {kullaniciSayi}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("37 katı değil");
            //    }
            //}



            ///CONTİNUE
            ///continue sadece döngülerde kullanılabilinmektedir. kullanılıan alanlarda burayı es geç veya devam et şeklinde kullanılabilir.
            ///00;

            //örnek sayı 5 ise döngü devam etsin 5 değilse döngü sonlansın 
            //while (true)
            //{
            //    Console.WriteLine("lütfen bir sayı giriniz");
            //    int i = int.Parse(Console.ReadLine());
            //    if(i == 5)
            //{
            //    Console.WriteLine("sayı 5 oldu");
            //    continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayı 5 değil");
            //        break;
            //    }
            // }

            //girilen sayı 5 ten küçükse program devam etsin 5 ten büyükse üstüne ekleyerek devam etsin 
            //int toplam = 0;

            //    while (true) {

            //        Console.WriteLine("lütfen bir sayı giriniz");
            //        int c = int.Parse(Console.ReadLine());

            //    if(c > 5)
            //    {
            //        toplam += c;
            //        Console.WriteLine(toplam);
            //    }
            //    else
            //    {
            //        Console.WriteLine("girdiğiniz sayı 5 'ten küçük olamaz lütfen tekrar deneyiniz");
            //        continue;
            //    }
            //    }


            //girilen değer toplam ise sonucu göster ve sonlandır değilse çarp devam et
            //int carpim = 1;
            //while (true)
            //{
            //    Console.WriteLine("bir sayı giriniz girdiğiniz sayı pozitif ise çarpar 't' bastığında bitirir ve sonucu verir");

            //    string gelendeger = Console.ReadLine();
            //    if( gelendeger == "t")
            //    {
            //        Console.WriteLine(carpim);
            //        return;

            //    }else if (int.Parse(gelendeger) > 0)
            //    {
            //        Console.WriteLine("devam");
            //        carpim *= int.Parse(gelendeger);
            //        continue;
            //    }
            //}


            //Return Keywordü
            // return metod içerisinde kullanılır. kullanıldığı anda metod içerisinde çıkış yaparak uygulamayı sonlandırır.

            while (true) {
                Console.WriteLine("lütfen sonsuz döngüye devam ediniz 'c' basmanız durumunda program sonlanacaktır.....");
                string gelenStringDeger = Console.ReadLine();
                if(gelenStringDeger == "c")
                {
                    Console.WriteLine($"uygulama sona erdi {gelenStringDeger}");
                    return;
                }
            
            }


            }
        }
    }

