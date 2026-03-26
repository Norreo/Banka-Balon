using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Balon
{
    public class Klient
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string UzivatelskeJmeno { get; set; }
        public string Heslo { get; set; }
        public string Ucet { get; set; }

        public Klient(string jmeno, string prijmeni, string uzivatelskeJmeno, string heslo, string ucet)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            UzivatelskeJmeno = uzivatelskeJmeno;
            Heslo = heslo;
            Ucet = ucet;
        }
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni;
        }



    }
}
