using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_Pojisteni
{
    internal class Databaze
    {
        private List<Pojistenec> pojistenci;

        /// <summary>
        /// Vytvoří novou instanci databáze
        /// </summary>
        public Databaze()
        {
            pojistenci = new List<Pojistenec>();
        }

        /// <summary>
        /// Přidá nový záznam pojištěného
        /// </summary>
        /// <param name="Jmeno"></param>
        /// <param name="Prijmeni"></param>
        /// <param name="Vek"></param>
        /// <param name="TelefonniCislo"></param>
        public void PridejZaznam(string Jmeno, string Prijmeni, int Vek, int TelefonniCislo)
        {
            pojistenci.Add(new Pojistenec(Jmeno, Prijmeni, Vek, TelefonniCislo));
        }

        /// <summary>
        /// Najde pojištěného podle jména a příjmení
        /// </summary>
        /// <param name="datum"></param>
        /// <param name="dleCasu"></param>
        /// <returns></returns>
        public List<Pojistenec> NajdiZaznamy(string Jmeno, string Prijmeni)
        {
            List<Pojistenec> nalezene = new List<Pojistenec>();
            foreach (Pojistenec pojistenec in pojistenci)
            {
                if ((pojistenec.Jmeno == Jmeno) && (pojistenec.Prijmeni == Prijmeni))
                    nalezene.Add(pojistenec);
            }
            return nalezene;
        }

        /// <summary>
        /// Vypíše všechny pojištěnce
        /// </summary>
        public void Vypis()
        {
            Console.WriteLine("Všechny pojištěné osoby:");
            Console.WriteLine("------------------------");
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
    }
}
