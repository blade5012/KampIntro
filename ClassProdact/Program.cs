namespace ClassProdact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.marka = "Mercedes";
            araba1.renk = "Sarı";
            araba1.fiyat = 150000;
            araba1.model = 2006;

            Araba araba2 = new Araba();
            araba2.marka = "BNW";
            araba2.renk = "Mavi";
            araba2.fiyat = 240000;
            araba2.model = 2010;

            Araba araba3 = new Araba();
            araba3.marka = "Audi";
            araba3.renk = "Beyaz";
            araba3.fiyat = 170000;
            araba3.model = 2008;

            Araba[] arabalar = new Araba[] { araba1, araba2, araba3 };
            foreach (var a in arabalar)
            {
                Console.WriteLine(a.marka + ": " + a.fiyat);
            }
        }
    }
    class Araba
    {
        public string marka { get; set; }
        public string renk { get; set; }
        public int fiyat { get; set; }
        public int model { get; set; }
    }
}