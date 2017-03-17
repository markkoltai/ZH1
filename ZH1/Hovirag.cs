using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Hovirag : Kozos
    {
        public int Lepesszamlalo;
        public int Tav;

        public void Kilistaz()
        {
            Console.WriteLine("Hóvirág megtett táv, lépés: {0}, {1}", Tav, Lepesszamlalo);
        }

        public void Lepes()
        {
            for (int i = 0; i < 100; i++)
            {
                Tav = 0;
                Lepesszamlalo = 0;
            }
        }
    }
}