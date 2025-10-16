namespace AkisKontrolMekanizmalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Akış Kontrol Mekanizmalar!");

            //İf yapılanması yazılım alanında bütün karşılaştırmaların yapılabileceği bir akış kontrol yapılanmasıdır. 

            int i = 10;


            if(i == 10)
            {
                Console.WriteLine("merhaba dünya");

            }else if(i >=5 && i<=10)
            {
                Console.WriteLine(" i değer hem 5 ten büyük hem de 10 a eşit veya küçük");
            }





            // ! işaretiyle işlemi tersini alma


            int j = 10;
            string mesaj = "her iki kod bloğu çalışması durumunda da gösterilecek mesajdır";
            if(j != 10)
            {
                Console.WriteLine("eşit değil");
           
            }
            else
            {
                Console.WriteLine("eşit");
              
            }
            Console.WriteLine(mesaj);


            // ehliyet puanı ve yaşı tutuyorsa ehliyet alabilir kodun çıktısını alalım

            int yas = 17, puan = 68;


            if(yas >=18 && puan >= 72)
            {
                Console.WriteLine("ehliyet alabilirsiniz");
            }
            else if(yas >= 18 && puan <= 72)
            {
                Console.WriteLine("yaşınız tutuyor, puanınız yetersiz");
            }else if (yas<=17 && puan >= 72)
            {
                Console.WriteLine("yaşınız tutmuyor, puanınız yetrli");
            }
            else {

                Console.WriteLine("yaşınız ve puanınız yetersiz");
            }




            //klavyeden girilen iki ürünün fiyati girildiğinde toplam fiyat 200 tl fazla ise 2. üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapınız
            //   tutarx(100 - oran) / 100”

            Console.WriteLine("lütfen birinci ürünün fiyatını giriniz");
            int birinciUrun = int.Parse(Console.ReadLine());

            Console.WriteLine("lütfen ikinci ürünün fiyatını giriniz");
            int ikinciUrun = int.Parse(Console.ReadLine());


            int islem = birinciUrun + ikinciUrun;

            if(islem >= 200)
            {
                int indirimOlustur = ikinciUrun * (100 - 25) / 100;
                int dusurulenİndirimTutari = ikinciUrun - indirimOlustur;
                int indirimliTutar = birinciUrun + indirimOlustur;

                Console.WriteLine($"ürününüzün toplam maliyeti {islem} toplam tutarınız 200 tl'nin üstünde olduğu için ikinci üründe %25 ndirim kazandınız indirim tutarı {dusurulenİndirimTutari} toplam ödemeniz gereken tutar ise {indirimliTutar} ");

            }
            else
            {
                Console.WriteLine($"ödemeniz gereken tutar {islem}");
            }


            // belirlenen kullanıcı adı ve şifre doğru girildiğinde giriş başarılı yanlış girildiğinde yanlış desin.

            // İF BLOĞUYLA YAPILIŞI
            int sifre = 123;
            string kadi = "sedat";
            if(sifre == 123 && kadi == "sedat")
            {
                Console.WriteLine("giriş başarılı");
            }

            // TERNARY OPERATÖRÜ İLE YAPILIŞI
            string Sorgu = sifre == 123 && kadi == "sedat" ? "doğru" : "yanlış";


            // SWİTCH CASE İLE YAPILIŞI 

            switch (kadi)
            {
                case "sedat" when sifre == 123:
                    Console.WriteLine("kadi şifre doğru");
                    break;

                default: Console.WriteLine("ss"); break;
            }












                //switch yapılanması sadece eşitlik durumlarında kullanılabilmektedir. yani a b ye eşit midir ? veya gelen değer istenilen değere eşit midir? durumlarında kullanılabilinmektedir. buna ek olarak when şartı ile de gelişmiş switch yapılanması kullanabilmeteyiz. bu durum da da ek olarak bir şart daha ekleyerek kod iskeletemizi geliştirebilmekteyiz.

                string adi = "sedat";

            switch (adi)
            {
                case "sedat":
                    Console.WriteLine("adı sedat");
                    break;

                case "ahmet":
                    Console.WriteLine("adı mehmet");
                    break;

                case "mehmet":
                    break;

            }


            //Console.WriteLine("Lütfen bir seçim yapınız 1,2,3,4");
            int gelenSoru = int.Parse(Console.ReadLine());
          /*  int sifre = 1234;*/ // when şartını sağlamak için kullandık

            switch (gelenSoru) {

                case 1 when (sifre == 123): // when ile daha gelişmiş yapı kullanabilmekteyiz 
                    Console.WriteLine("portakal");
                    break;

                case 2:
                    Console.WriteLine("mandalina");
                    break;

                case 3:
                    Console.WriteLine("muz");
                    break;

                default: Console.WriteLine("meyve bulunamadı");break;
            }


            //int girilenSayi = 5;

            //string ternary = girilenSayi > 0 ? "Sayı pozitif" : (girilenSayi < 0 ? "sayı negatif" : "tanımsız sayı");





            //switch case goto komutu eşitlik durumundan ziyade mantıksal işlem yapamadığımızdan dolayı goto manevrası kullanarak birden fazla aynı cevaba eşit olan değerde bir tek kod bloğunu kullanabilmekteyiz.

            string havaDurumu = "Geneşli";
            switch(havaDurumu)
            {
                case "Bulutlu":
                    Console.WriteLine("sıkı giyin");
                    break;
                case "Güneşli":
                    Console.WriteLine("Rahat gezebilirsin");
                    break;
                case "Yağmurlu":
                    Console.WriteLine("yanına şemsiye al");
                    break;
                case "sağınak":
                    goto case "Yağmurlu";
            }
           
        }
    }
}
