using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg
{
    public class Hrdina : Postava, IKlonovatelny<Hrdina>
    {
        public Rasa? Rasa { get; private set;}
        public Hrdina(string jmeno, int zdravi, int utok, int mana, int hbitost, int krit, Rasa rasa) : base(jmeno, zdravi, utok, mana, hbitost, krit)
         {
            this.Rasa = rasa;
         }

         public Hrdina VytvorKlon() 
        {
            return new Hrdina(this.Jmeno + "-Kopie", this.Zdravi, this.Utok, this.Mana, this.Krit, this.Hbitost, this.Rasa!);
        }
    }
    class Valecnik : Hrdina
    {
        public Valecnik(Rasa rasa) : base("Valecnik", 100, 10, 50, 33, 10, rasa) { }
    }
    class Carodej : Hrdina
    {

        public Carodej(Rasa rasa) : base("Carodej", 50, 20, 100, 25, 20, rasa) { }
    }
    class Lucistnik : Hrdina
    {
        public Lucistnik(Rasa rasa) : base("Lucistnik", 70, 15, 60, 33, 33, rasa) {
         }
    }
}