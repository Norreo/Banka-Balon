using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Balon
{
    public class Ucet
    {
            public string CisloUctu { get; set; }
            public string Zustatek { get; set; }
        public Ucet() { }

        public Ucet(string cislo, string zustatek)
        {
            CisloUctu = cislo;
            Zustatek = zustatek;
        }

      

    }
}
