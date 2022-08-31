using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_Pojisteni
{
    internal class Moznosti
    {
        public Databaze databaze { get; private set; }

        // vytvoří novou instanci Moznosti
        public Moznosti()
        {
            databaze = new Databaze();
        }

        public int TelefonniCislo { get; private set; }
        public int Vek { get; private set; }
        public string Prijmeni { get; private set; }
        public string Jmeno { get; private set; }

        /// <summary>
        /// Zeptá se na parametry nového pojištěného
        /// </summary>
        public void PridejZaznam()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            Jmeno = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Zadejte příjmení:");
            Prijmeni = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Zadejte věk:");
            Vek = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Zadejte telefonní číslo:");
            TelefonniCislo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            databaze.PridejZaznam(Jmeno, Prijmeni, Vek, TelefonniCislo);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Pojištěnec byl uložen. Pro zobrazení nabídky stiskněte libovolnou klávesou...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Vyhledá pojištěné podle jména a příjmení 
        /// </summary>
        public void VyhledejZaznamy()
        {
            // Zadání jména uživatelem
            Console.WriteLine("Zadejte jméno pojištěného:");
            Jmeno = Console.ReadLine();
            Console.WriteLine();

            // Zadání příjmení uživatelem
            Console.WriteLine("Zadejte příjmení:");
            Prijmeni = Console.ReadLine();

            // Vyhledání záznamů pojištěných
            List<Pojistenec> pojistenci = databaze.NajdiZaznamy(Jmeno, Prijmeni);
            // Výpis záznamů pojištěných
            if (pojistenci.Count() > 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nalezené záznamy:");
                Console.WriteLine("-----------------");
                Console.WriteLine();
                foreach (Pojistenec pojistenec in pojistenci)
                {
                    Console.WriteLine(pojistenec);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Pro zobrazení nabídky stiskněte libovolnou klávesou...");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                // Nenalezeno
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nebyl nalezen žádný pojištěnec");
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Pro zobrazení nabídky stiskněte libovolnou klávesou...");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
