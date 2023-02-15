using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg
{
    public abstract class Rasa{
        public abstract (int, int) schopnost();
        public abstract void valecnyPokrik();
    }

    public class Ork: Rasa
    {
        public override void valecnyPokrik() 
        {
            System.Console.WriteLine("The Time of the Orc Has Come");
        }

        public override (int, int) schopnost() 
        { 
            return (5, 2);
        }
    }

    public class Elf: Rasa
    {
        public override void valecnyPokrik() 
        {
            System.Console.WriteLine("Gurth goth (rim) Tel'Quessir");
        }

        public override (int, int) schopnost() 
        {
            return (2, 4);
        }
    }

    public class Trpaslik: Rasa
    {
        public override  void valecnyPokrik() 
        {
            System.Console.WriteLine("Baruk Khazâd!");
        }

        public override (int, int) schopnost() 
        {
            return (8, 1);
        }
    }
}