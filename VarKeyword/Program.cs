namespace VarKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var Keywordü");

            //var keywordü verilen değere otomatik olarak bürünerek kendi türüne uygun değerlerde kullanılabilmektedir.
            //tanımlandığı anda kendi türüne uygun olarak compailer seviyesinde işlem görür. 
            //genellikle anonim olarak gelen type'larda kullanılır. fakat gönümüzde değişken türleri belirtilmeden direk var keywordüne başvurulmaktadır.
            //herhangi bir cast işlemine gerek yoktur. stack üzerinde direk değişken türüne uygun olarak tutulmaktadır.


            var adi = "sedat";
            var yasi = 27;
            var durum = true;
            var pi = 3.14f;




            //Dynamic keywordü türü bilmediğimiz gelen dataların kontrolünü yapmak için kullanılmaktadır. yani dışarıdan gelen türü bilmediğimizden doalyı herhangi bir işlem yapamıyoruz. fakat dynamic keywordü sayesinde bunu runtime yani çalışma esnasında kontrolünü sağlayarak istemiş olduğumuz alanda kullanabilmeteyiz. var keywürdü ile arasında ki farkı sadece runtime esnasında türünü belirlemesidir.


            dynamic yas = 27;

            if(yas is int)
            {
                Console.WriteLine("bu bir int");
            }else if (yas is string)
            {
                Console.WriteLine("bu bir string değer");
            }

            if(yas.GetType() == typeof(int))
            {
                Console.WriteLine("bu bir int");
            }
        }
    }
}
