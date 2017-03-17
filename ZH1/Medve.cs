using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Medve : Kozos
    {
        public bool Ordit = false;
        public int Lepesszamlalo;
        public int Tav;

        public void Lepes()
        {
            for (int i = 0; i < 100; i++)
            {
                Tav++;
                Lepesszamlalo += 4;
                if (i % 5 == 0)
                {
                    Ordit = true;
                }
            }
        }

        public void Kilistaz()
        {
            Console.WriteLine("TréMedve megtett táv, lépés: {0}, {1}", Tav, Lepesszamlalo);
        }
    }

    public class Medve2 : Kozos
    {        
        public int Lepesszamlalo;
        public int Tav;

        public void Lepes()
        {
            for (int i = 0; i < 100; i++)
            {
                Tav++;
                Lepesszamlalo+=4;                
            }
        }

        public void Kilistaz()
        {
            Console.WriteLine("Barna medve megtett táv, lépés: {0}, {1}", Tav, Lepesszamlalo);
        }
    }
}