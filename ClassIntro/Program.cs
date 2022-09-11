namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1=new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin DEMİROĞ";
            kurs1.IzlenmeOrani = 80;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Jawa";
            kurs2.Egitmen = "Murat DEMİROĞ";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.Egitmen = "Samet BAYRAM";
            kurs3.IzlenmeOrani = 90;

            //Console.WriteLine(kurs1.kursAdi+" : "+kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+": "+kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}