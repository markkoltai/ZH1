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

            }

        }

        public void Kilistaz()
        {
            throw new NotImplementedException();
        }
    }
}