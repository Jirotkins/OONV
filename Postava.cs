using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg
{
    public class Postava
    {
        public string? Jmeno { get; private set; }
        public int Vitalita { get; set; }
        public int Zdravi { get; set; }
        public int Utok { get; set; }
        public int Mana { get; private set; }
        public int Krit { get; private set; }
        public int Hbitost { get; private set; }

        public Postava(string jmeno, int zdravi, int utok, int mana, int krit, int hbitost)
        {
            this.Jmeno = jmeno;
            this.Vitalita = zdravi;
            this.Zdravi = zdravi;
            this.Utok = utok;
            this.Mana = mana;
            this.Krit = krit;
            this.Hbitost = hbitost;
        }

        public bool BranSe(int utok)
        {
            Random rnd = new Random(); //Sance ze se postava vyhne utoku
            if (rnd.Next(0, 101) <= Hbitost)
            {
                System.Console.WriteLine("Vedle!");
                return false;
            }
            this.Zdravi -= utok;
            System.Console.WriteLine($"{this.Jmeno} dostal {utok} poskozeni");
            if (Zdravi > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public String toString()
        {
            return $"{this.Jmeno} ♥[{this.Zdravi}/{this.Vitalita}] [{this.Utok}|{this.Mana}] ";
        }
        
        public static Postava VyberPostavu() 
        {
            System.Console.WriteLine("1: valecnik\n2: lucistnik\n3: carodej");
            int hrdina = Convert.ToInt32(Console.ReadLine());

            switch (hrdina)
            {
                case 1:
                    return new Valecnik(new Ork());
                case 2:
                    return new Lucistnik(new Ork());
                case 3:
                    return new Carodej(new Ork());
                default:
                    return new Valecnik(new Ork());
            }
        }
    }
    public interface IKlonovatelny<T>
    {
        public T VytvorKlon();
    }
}