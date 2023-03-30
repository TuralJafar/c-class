namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.KapiSayi = 4;
            araba1.Arabarengi = "qirmizi";
            araba1.ArabaModeli = "bmw";


            araba1.KapilariKilitle();
            araba1.MotorCalistir();

            Console.WriteLine("araban kapi sayi=" + araba1.KapiSayi);
            Console.WriteLine("araba rengi=" + araba1.Arabarengi);
            Console.WriteLine("araba modeli=" + araba1.ArabaModeli);
        }
    }
}