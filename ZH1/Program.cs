using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hovirag hv = new Hovirag();
            Szocske szcs = new Szocske();
            Csiga cs = new Csiga();
            Nyul ny = new Nyul();
            Medve tre = new Medve();
            Medve2 barna = new Medve2();
            Bolha b = new Bolha();
            Roka r = new Roka();

            hv.Lepes();
            hv.Kilistaz();

            szcs.Lepes();
            szcs.Kilistaz();

            cs.Lepes();
            cs.Kilistaz();

            ny.Lepes();
            ny.Kilistaz();

            tre.Lepes();
            tre.Kilistaz();

            barna.Lepes();
            barna.Kilistaz();

            b.Lepes();
            b.Kilistaz();

            r.Lepes();
            r.Kilistaz();

            Console.ReadLine();


        }
    }
}
