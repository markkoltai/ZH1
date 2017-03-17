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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Lepesszamlalo.ToString());
        }
    }

    public class Medve2 : Kozos
    {        
        public int Lepesszamlalo;

        public void Lepes()
        {
            for (int i = 0; i < 100; i++)
            {
                Lepesszamlalo++;                
            }
        }

        public void Kilistaz()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Lepesszamlalo.ToString());
        }
    }
}