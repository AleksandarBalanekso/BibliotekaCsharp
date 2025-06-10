using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    [DataContract]
    public class Knjiga
    {
        [DataMember]
        public int IdKnjige { get; set; }
        [DataMember]
        public string NazivKnjige { get; set; }
        [DataMember]
        public int KolicinaUBiblioteci { get; set; }
        [DataMember]
        public string JmbgPisca {  get; set; }
        [DataMember]
        public int GodinaIzdavanja { get; set; }

        public Knjiga()
        {
            IdKnjige = -1;
            NazivKnjige = "";
            KolicinaUBiblioteci = 0;
            JmbgPisca = "-1";
            GodinaIzdavanja = 0;
        }

        public Knjiga(int idKnjige, string nazivKnjige, int kolicinaUBiblioteci, string jmbgPisca, int godinaIzdavanja)
        {
            IdKnjige = idKnjige;
            NazivKnjige = nazivKnjige;
            KolicinaUBiblioteci = kolicinaUBiblioteci;
            JmbgPisca = jmbgPisca;
            GodinaIzdavanja = godinaIzdavanja;
        }
    }
}
