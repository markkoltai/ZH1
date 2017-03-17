using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Nyul : Kozos
    {
        Medve m = new Medve();
        public int Lepesszamlalo;
        public int Tav;
        public int VersenySzam = 6;
        public int KorSzamlalo;

        public void Lepes()
        {
            for (int i = 0; i < 100; i++)
            {
                Tav++;
                Lepesszamlalo += 2;
                if (m.Ordit == true)
                {
                    Tav += 4;
                    Lepesszamlalo += 3;
                }
                if (i % 10 == 0)
                {
                    KorSzamlalo++;
                    Console.WriteLine("{0}. kör: ", KorSzamlalo);
                    Kilistaz();
                }

            }

        }

        public void Kilistaz()
        {
            Console.WriteLine("Nyul versenyszáma: {0}, megtett táv: {1}, lépés: {2}", VersenySzam, Tav, Lepesszamlalo);
        }
    }
}