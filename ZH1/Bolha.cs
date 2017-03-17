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
        public int VersenySzam=8;
        public int KorSzamlalo;

        public void Kilistaz()
        {
            Console.WriteLine("Bolha versenyszáma: {0}, megtett táv: {1}, lépés: {2}", VersenySzam, Tav, Lepesszamlalo);
        }

        public void Lepes()
        {
            for (int i = 0; i < 100; i++)
            {
                Lepesszamlalo = 0;
                Tav = m.Tav;
                if (i % 10 == 0)
                {
                    KorSzamlalo++;
                    Console.WriteLine("{0}. kör: ", KorSzamlalo);
                    Kilistaz();
                }

            }
        }
    }
}