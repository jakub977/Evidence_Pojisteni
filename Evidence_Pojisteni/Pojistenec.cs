using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Evidence_Pojisteni
{
    internal class Pojistenec
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public int TelefonniCislo { get; set; }

        public Pojistenec(string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        public override string ToString()
        {
            return Jmeno + "  " + Prijmeni + "  " + Vek + "  " + TelefonniCislo;
        }
    }
}
