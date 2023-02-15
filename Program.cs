using System;
using System.Collections.Generic;

namespace rpg
{
    class Program
    {

        static void Main(string[] args)
        {
            var Hrdinove = new List<Hrdina>();
            //System.Console.WriteLine("Vyber si 2 hrdiny do zacatku!\n");
            //Hrdinove.Add(Postava.vyberPostavu());
            //Hrdinove.Add(Postava.vyberPostavu());
            Hrdina Karel = new Lucistnik(new Ork());
            Hrdinove.Add(Karel);
            // Postava KarelKopie = Karel.VytvorKlon();
            // Hrdinove.Add(KarelKopie);
            var Prisery = new List<Nepritel>(Hra.VytvorPrisery(Hrdinove.Count));
            int uroven = Hra.SpustHru(Hrdinove, Prisery);
            System.Console.WriteLine($"Umrel si, dostal ses do {uroven}. urovne.");
        }
    }
}