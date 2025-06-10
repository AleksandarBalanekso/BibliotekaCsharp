using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IBiblioteka
    {
        // KNJIGA

        [OperationContract]
        bool DodajKnjigu(Knjiga k);
        [OperationContract]
        bool ObrisiKnjigu(int IdKnjige);
        [OperationContract]
        bool IzmeniKnjigu(Knjiga k);
        [OperationContract]
        List<Knjiga> SveKnjige(string uslov);

        //PISAC

        [OperationContract]
        bool DodajPisca(Pisac p);
        [OperationContract]
        bool ObrisiPisca(string IdPisca);
        [OperationContract]
        bool IzmeniPisca(Pisac p);
        [OperationContract]
        List<Pisac> SviPisci(string uslov);

        //CLAN

        [OperationContract]
        bool DodajClana(Clan c);
        [OperationContract]
        bool ObrisiClana(int IdClana);
        [OperationContract]
        bool IzmeniClana(Clan c);
        [OperationContract]
        List<Clan> SviClanovi(string uslov);

        [OperationContract]
        bool DodajIznajmljivanje(Iznajmljivanje i);
        [OperationContract]
        bool ObrisiIznajmljivanje(int idIznajmljivanja);
        [OperationContract]
        bool IzmeniIznajmljivanje(Iznajmljivanje i);
        [OperationContract]
        List<Iznajmljivanje> SvaIznajmljivanja(string uslov);

    }
}
