using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKlijentKonzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IBiblioteka> ch = new ChannelFactory<IBiblioteka>(new BasicHttpBinding(),
                new EndpointAddress("http://localhost:8000"));
            IBiblioteka proxy = ch.CreateChannel();

            List<Iznajmljivanje> l = proxy.SvaIznajmljivanja("");

            foreach(Iznajmljivanje i in l)
            {
                Console.WriteLine(i.IdIznajmljivanja.ToString());
            }

            Console.ReadKey();
        }
       
        //kad se bude hashovao password  morace se to uzeti u obzir
        public static Clan LogIn(string username, string password, IBiblioteka proxy)
        {
            string SelectUslovUsername = string.Format("where username = '{0}' and password = '{1}'", username, password);
            string SelectUslovEmail = string.Format("where email = '{0}' and password = '{1}'", username, password);

            List<Clan> clanoviUsername = proxy.SviClanovi(SelectUslovUsername);
            List<Clan> clanoviEmail = proxy.SviClanovi(SelectUslovEmail);

            if (clanoviUsername.Count > 0)
                return clanoviUsername[0];

            if (clanoviEmail.Count > 0)
                return clanoviEmail[0];

            //ovo se treba promeniti kada se bude implementiralo u win formu
            Console.WriteLine("POGRESNO KORISNICKO IME ILI LOZINKA");

            return new Clan();
        }
    }
}
