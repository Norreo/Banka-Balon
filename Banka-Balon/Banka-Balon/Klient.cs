using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Banka_Balon
{
    public class Klient
    {

        public List<Ucet> SeznamUctu { get; set; } = new List<Ucet>();

        public static List<Klient> Ucty = new List<Klient>();

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string UzivatelskeJmeno { get; set; }
        public string Heslo { get; set; }


        public static List<Klient> Ucty = new List<Klient>();

        public Klient() { }

        public Klient(string jmeno, string prijmeni, string uzivatelskejmeno, string heslo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            UzivatelskeJmeno = uzivatelskejmeno;
            Heslo = heslo;
        }

        public static void PridejKlienta(Klient klient)
        {
            Ucty.Add(klient);
        }

        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} ({UzivatelskeJmeno})";
        }

        public static void SerializujDoXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Klient>));
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, Ucty);
            }
        }

        public static void DeserializujZXml(string filePath)
        {
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Klient>));
                using (StreamReader sr = new StreamReader(filePath))
                {
                    Ucty = (List<Klient>)serializer.Deserialize(sr);
                }
            }
        }
    }
}
