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
        public void Kilistaz()
        {
            throw new NotImplementedException();
        }

        public void Lepes()
        {
            for (int i = 0; i < 100; i++)
            {
                Tav = m.Tav;
            }
        }
    }
}