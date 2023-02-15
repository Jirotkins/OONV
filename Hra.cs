using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg
{
    public class Hra
    {
        public static int SpustHru(List<Hrdina> hrdinove, List<Nepritel> prisery)
        {
            Random rnd = new Random();
            int uroven = 1;
            bool klonBool = false;
            int klon = 0;
            System.Console.WriteLine($"\n{uroven}. UROVEN");
            while (hrdinove.Count >= 1)
            {
                if (prisery.Count < 1)
                {
                    uroven++;
                    System.Console.WriteLine($"\n{uroven}. UROVEN");
                    prisery = VytvorPrisery(hrdinove.Count);
                }

                int hrdinaCounter = 0;
                if (klonBool == true)
                {
                    hrdinove.Add(hrdinove[klon].VytvorKlon());
                    klonBool = false;
                }
                System.Console.WriteLine("\nTvoji hrdinove:");
                foreach (Hrdina hrdina in hrdinove)
                {
                    System.Console.WriteLine(hrdina.toString());
                }

                System.Console.WriteLine("\nPrisery:");
                foreach (Postava prisera in prisery)
                {
                    System.Console.WriteLine(prisera.toString());
                }

                foreach (Hrdina hrdina in hrdinove)
                {
                    System.Console.WriteLine($"\nNyni hrajes za: {hrdina.toString()}");
                    bool exit = false;
                    do
                    {
                        System.Console.WriteLine($"1: utok\n2: klon\n3: schopnost\n4: valecny pokrik\n5: vynechat kolo");
                        int ukon = Convert.ToInt32(Console.ReadLine());
                        switch (ukon)
                        {
                            case 1:
                                int pocet = 0;
                                foreach (Nepritel prisera in prisery)
                                {
                                    System.Console.WriteLine($"{pocet}: {prisera.toString()}");
                                    pocet++;
                                }
                                int cil = Convert.ToInt32(Console.ReadLine());
                                if (cil >= prisery.Count)
                                {
                                    break;
                                }
                                if (prisery[cil].BranSe(hrdina.Utok) == true)
                                {
                                    System.Console.WriteLine($"{prisery[cil].Jmeno} zemrel");
                                    prisery.RemoveAt(cil);
                                }
                                exit = true;
                                break;
                            case 2:
                                if (!hrdina.Jmeno!.Contains("Kopie")) 
                                {
                                    klon = hrdinaCounter;
                                    klonBool = true;
                                    exit = true;
                                    break;
                                }
                                exit = true;
                                break;
                            case 3:
                                hrdina.Vitalita += hrdina.Rasa.schopnost().Item1;
                                hrdina.Zdravi += hrdina.Rasa.schopnost().Item1;
                                hrdina.Utok += hrdina.Rasa.schopnost().Item2;
                                exit = true;
                                break;
                            case 4:
                                hrdina.Rasa.valecnyPokrik();
                                exit = true;
                                break;
                            case 5:
                                exit = true;
                                break;
                            default:
                                break;
                        }
                    } while (!exit);
                    if (prisery.Count < 1)
                    {
                        break;
                    }
                    hrdinaCounter += 1;
                }

                foreach (Nepritel prisera in prisery)
                {
                    int random = rnd.Next(0, hrdinove.Count);
                    if (hrdinove[random].BranSe(prisera.Utok) == true)
                    {
                        System.Console.WriteLine($"{hrdinove[random].Jmeno} zemrel");
                        hrdinove.RemoveAt(random);
                    }
                }

            }
            return uroven;
        }


        public static List<Nepritel> VytvorPrisery(int pocetHrdinu)
            {
                Random rnd = new Random();
                int pocetPriser = 0;
                var seznamPriser = new List<Nepritel>();

                if (pocetHrdinu <= 2)
                {
                    pocetPriser = 1;
                }
                else if (pocetHrdinu == 3)
                {
                    pocetPriser = rnd.Next(1, 3);
                }
                else if (pocetHrdinu == 4)
                {
                    pocetPriser = rnd.Next(2, 4);
                }
                else
                {
                    pocetPriser = rnd.Next(3, 5);
                }

                for (int i = 0; i < pocetPriser; i++)
                {
                    int random = rnd.Next(4);
                    switch (random)
                    {
                        case 1:
                            seznamPriser.Add(new Drak());
                            break;
                        case 2:
                            seznamPriser.Add(new Beranek());
                            break;
                        case 3:
                            seznamPriser.Add(new Skvor());
                            break;
                        default:
                            seznamPriser.Add(new Godzilla());
                            break;
                    }
                }
                return seznamPriser;
            }
    }
}