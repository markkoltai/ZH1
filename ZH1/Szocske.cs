﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Szocske : Kozos
    {
        public int Lepesszamlalo;
        public int Tav;
        public int VersenySzam=1;
        public int KorSzamlalo;

        public void Kilistaz()
        {
            Console.WriteLine("Szocske versenyszáma: {0}, megtett táv: {1}, lépés: {2}", VersenySzam, Tav, Lepesszamlalo);
        }

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
                Lepesszamlalo += 2;
            }
        }
    }
}