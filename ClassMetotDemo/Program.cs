namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mehmet BAYRAM";
            musteri1.Maas = 7500;
            musteri1.Meslek = "Polis";
            musteri1.Sehir = "Konya";

            Musteri musteri2=new Musteri();
            musteri2.Adi = "Erol Efe";
            musteri2.Maas = 7600;
            musteri2.Meslek = "Yazılımcı";
            musteri2.Sehir = "Ankara";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Emirhan";
            musteri3.Maas = 8600;
            musteri3.Meslek = "Sigortacı";
            musteri3.Sehir = "Eskişehir";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

        }
    }
}