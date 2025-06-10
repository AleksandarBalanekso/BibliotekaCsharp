using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    [DataContract]
    public class Clan
    {
        [DataMember]
        public string JmbgClana {  get; set; }
        [DataMember]
        public string Ime { get; set; }
        [DataMember]
        public string Prezime { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public DateTime DatumRodjenja { get; set; }
        [DataMember]
        public bool Aktivan {  get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public bool Priveledge { get; set; }


        public Clan()
        {
            JmbgClana ="-1";
            Ime = "";
            Prezime = "";
            Email = "";
            DatumRodjenja = DateTime.MinValue;
            Aktivan = false;
            Username = "";
            Password = "";
            Priveledge = false;
        }

        public Clan(string jmbgClana, string ime, string prezime, string email, DateTime datumRodjenja, bool aktivan, string username, string password, bool priveledge)
        {
            JmbgClana = jmbgClana;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            DatumRodjenja = datumRodjenja;
            Aktivan = aktivan;
            Username = username; 
            Password = password;
            Priveledge = priveledge;
        }
    }
}
