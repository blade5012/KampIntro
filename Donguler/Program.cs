namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım geliştirici kursu", "Programlamaya başlangıç için temel kurs", "Java","Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}