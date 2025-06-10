using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    [DataContract]
    public class Pisac
    {
        [DataMember]
        public string JmbgPisca {  get; set; }
        [DataMember]
        public string Ime { get; set; }
        [DataMember]
        public string Prezime { get; set; }
        [DataMember]
        public DateTime DatumRodjenja { get; set; }

        public Pisac() 
        {
            JmbgPisca = "-1";
            Ime = "";
            Prezime = "";
            DatumRodjenja = DateTime.MinValue;
        }

        public Pisac(string jmbgPisca, string ime, string prezime, DateTime datumRodjenja)
        {
            JmbgPisca = jmbgPisca;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
