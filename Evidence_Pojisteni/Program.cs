using System;

namespace Evidence_Pojisteni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instance databáze
            Databaze databaze = new Databaze();

            // instance Metod databáze
            Moznosti moznosti = new Moznosti();
            char volba = '0';
            // hlavní cyklus
            while (volba != '4')
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Evidence pojištěných");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine();
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                Console.WriteLine();
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        moznosti.PridejZaznam();
                        break;
                    case '2':
                        //     databaze.Vypis(); 
                        moznosti.databaze.Vypis();
                        break;
                    case '3':
                        moznosti.VyhledejZaznamy();
                        break;
                    case '4':
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Libovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        Console.WriteLine();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

