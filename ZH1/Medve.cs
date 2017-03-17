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
        public int VersenySzam=3;
        public int KorSzamlalo;

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
            Console.WriteLine("TréMedve versenyszáma: {0}, megtett táv: {1}, lépés: {2}", VersenySzam, Tav, Lepesszamlalo);
        }
    }

    public class Medve2 : Kozos
    {        
        public int Lepesszamlalo;
        public int Tav;
        public int VersenySzam=4;
        public int KorSzamlalo;

        public void Lepes()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    KorSzamlalo++;
                    Console.WriteLine("{0}. kör: ", KorSzamlalo);
                    Kilistaz();
                }
                Tav++;
                Lepesszamlalo+=4;                
            }
        }

        public void Kilistaz()
        {
            Console.WriteLine("Barna medve versenyszáma: {0}, megtett táv: {1}, lépés: {2}", VersenySzam, Tav, Lepesszamlalo);
        }
    }
}