using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Main2();
        }
        static void again()
        {
            Console.WriteLine("");
            Console.Write("tu en veut encore ? ");
            string rep = Console.ReadLine();
            if (rep == "oui")
            {
                Console.Clear();
                Console.WriteLine("");
                Console.Write("Du coup tu veut combien de phrases ?");
                int nbmP = Change1();
                Console.WriteLine(" ");
                phraseAlea(nbmP);
            }
            
        }
        static void Main2()
        {
            Console.WriteLine("OOOOOH BOIIIIIIIIIIIII");
            Console.WriteLine("j'ai un petit générateur de phrases qui est vachement sympa");
            Console.Write("Du coup tu veut combien de phrases ?");
            int nbmP = Change1();
            Console.WriteLine(" ");
            phraseAlea(nbmP);
        }
        static void phraseAlea(int nbmP)
        {
            var sujets = new string[]
            {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fee",
                "Un magicien",
                "Une tortue",
                "Paul",
                "Zemour",
                "le père noël",
                "le prêtre",
                "Hugo la servante",
                "Mohamed en hélico",
                "Max en live",
                "Le papi de paul"
            };

            var Verbe = new string[]
            {
                "fait",
                "regarde",
                "mange",
                "goume",
                "jette",
                "ferme",
                "nettoie",
                "attrape",
                "s'accroche a",
                "dégage",
                "se bat avec",
                "kidnappe",
                "gobe",
                "détruit",
                "attaque",
                "soulève",
                "lèche"
            };

            var complement = new string[]
            {
                "un gateau",
                "une souris",
                "le soleil",
                "la lune",
                "une piscine",
                "des enfants",
                "un chat",
                "zemour",
                "une grand-mère",
                "Paul",
                "un livre",

            };

            Random Rand = new Random();
            int i = 0;
            while (i != nbmP )
            {
                i = i + 1;
                int Num = Rand.Next(0, sujets.Length);
                Console.Write(sujets[Num] + " ");

                int Num2 = Rand.Next(0, Verbe.Length);
                Console.Write(Verbe[Num2] + " ");

                int Num3 = Rand.Next(0, complement.Length);
                Console.WriteLine(complement[Num3]);
            }
            again();
        }
        static int Change1()
        {
            Console.Write("Du coup tu veut combien de phrases ?");
            try
            {
                int nbmP = int.Parse(Console.ReadLine());
                return (nbmP);
            }
            catch
            {
                Console.WriteLine("Tu ne peut pas mettre de texte ici !!");
                return Change1();
            }
        }
    }
}
