using System.Linq.Expressions;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi=false;
            double dolarDun = 4.45;
            double dolarBugun = 4.55;
            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("yukarı ok");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("asagı ok");
            }
            else
            {
                Console.WriteLine("degismedi");
            }

            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
        }
    }
}