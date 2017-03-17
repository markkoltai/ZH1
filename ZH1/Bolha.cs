using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Bolha : Kozos
    {
        Medve m = new Medve();
        public int Tav;
        public int Lepesszamlalo;
        public void Kilistaz()
        {
            Console.WriteLine("Bolha megtett táv, lépés: {0}, {1}", Tav, Lepesszamlalo);
        }

        public void Lepes()
        {
            for (int i = 0; i < 100; i++)
            {
                Lepesszamlalo = 0;
                Tav = m.Tav;
            }
        }
    }
}