using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg
{

    public class Nepritel : Postava
    {
        public Nepritel(string jmeno, int zdravi, int utok, int mana, int hbitost, int krit) : base(jmeno, zdravi, utok, mana, hbitost, krit) { }
    }
    class Drak : Nepritel
    {
        static Random rnd = new Random();
        public Drak() : base("Drak", rnd.Next(50, 151), rnd.Next(5, 21), 0, 20, 10) { }
    }
    class Godzilla : Nepritel
    {
        static Random rnd = new Random();
        public Godzilla() : base("Godzilla", rnd.Next(40, 131), rnd.Next(8, 26), 0, 15, 5) { }
    }
    class Skvor : Nepritel
    {
        static Random rnd = new Random();
        public Skvor() : base("Skvor", rnd.Next(30, 81), rnd.Next(12, 29), 0, 25, 20) { }
    }
    class Beranek : Nepritel
    {
        static Random rnd = new Random();
        public Beranek() : base("Beranek", rnd.Next(30, 81), rnd.Next(12, 29), 0, 25, 20) { }
    }
}