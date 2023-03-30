using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Araba
    {
        public int KapiSayi;
        public string ArabaModeli;
        public string Arabarengi;

        public Araba()
        {
            
            Console.WriteLine("araba yapici methodu calisti");
        }
        public void MotorCalistir()
        {
            Console.WriteLine("motor calisiyor");
        }
        public void KapilariKilitle()
        {
            Console.WriteLine("kapilar kilitlendi");
        }
    }
}
