using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Iznajmljivanje
    {
        [DataMember]
        public int IdIznajmljivanja { get; set; }
        [DataMember]
        public string JmbgClana { get; set; }
        [DataMember]
        public int IdKnjige { get; set; }
        [DataMember]
        public DateTime DatumIznajmljivanja { get; set; }
        [DataMember]
        public DateTime DatumVracanja { get; set; }
        [DataMember]
        public bool Vracena { get; set; }

        public Iznajmljivanje()
        {
            IdIznajmljivanja = -1;
            JmbgClana = "-1";
            IdKnjige = -1;
            DatumIznajmljivanja = DateTime.MinValue;
            DatumVracanja = DateTime.MinValue;
            Vracena = false;
        }

        public Iznajmljivanje(int idIznajmljivanja, string jmbgClana, int idKnjige, DateTime datumIznajmljivanja, DateTime datumVracanja, bool vracena)
        {
            IdIznajmljivanja = idIznajmljivanja;
            JmbgClana = jmbgClana;
            IdKnjige = idKnjige;
            DatumIznajmljivanja = datumIznajmljivanja;
            DatumVracanja = datumVracanja;
            Vracena = vracena;
        }
    }
}
