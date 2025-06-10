using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaServer
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class BibliotekaServer : IBiblioteka
    {
        //KNJIGA
        public bool DodajKnjigu(Knjiga k)
        {
            string comm = "insert into knjiga values ('" + k.NazivKnjige + "', " + k.KolicinaUBiblioteci +
                ", " + k.JmbgPisca + ", " + k.GodinaIzdavanja + ");";

            if (Baza.CommandExecuteNumQuery(comm))
            {
                return true;
            }

            return false;

        }
        public bool IzmeniKnjigu(Knjiga k)
        {
            string comm = string.Format("update knjiga set naziv_knjige = '{0}', kolicina_u_biblioteci = {1}, jmbg_pisca = {2}, "
             + "godina_izdavanja = {3} where id_knjige = {4};", k.NazivKnjige, k.KolicinaUBiblioteci, k.JmbgPisca
             , k.GodinaIzdavanja, k.IdKnjige);

            if (Baza.CommandExecuteNumQuery(comm))
            {
                return true;
            }

            return false;
        }
        public bool ObrisiKnjigu(int IdKnjige)
        {
            string comm = string.Format("delete from knjiga where id_knjige = {0};", IdKnjige);

            if (Baza.CommandExecuteNumQuery(comm))
            {
                return true;
            }

            return false;
        }
        public List<Knjiga> SveKnjige(string uslov)
        {
            string comm = "select * from knjiga " + uslov;
            SqlCommand readerCommand = Baza.GetSqlCommand(comm);
            List<Knjiga> l = new List<Knjiga>();

            using (readerCommand)
            {
                using (SqlDataReader reader = readerCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Knjiga k = new Knjiga();

                        k.IdKnjige = reader.GetInt32(0);
                        k.NazivKnjige = reader.GetString(1);
                        k.KolicinaUBiblioteci = reader.GetInt32(2);
                        k.JmbgPisca = reader.GetString(3);
                        k.GodinaIzdavanja = reader.GetInt32(4);


                        l.Add(k);
                    }
                }
            }

            return l;
        }


        //PISAC

        //treba uraditi validaciju primarnog kljuca jer nije autofill
        public bool DodajPisca(Pisac p)
        {
            string comm = string.Format("insert into pisac values('{0}', '{1}', '{2}', '{3}-{4}-{5}');",
                p.JmbgPisca, p.Ime, p.Prezime, p.DatumRodjenja.Year, p.DatumRodjenja.Month, p.DatumRodjenja.Day);

            if (Baza.CommandExecuteNumQuery(comm))
            {
                return true;
            }

            return false;
        }

        public bool IzmeniPisca(Pisac p)
        {
            string comm = string.Format("update pisac set ime = '{0}', prezime = '{1}', datum_rodjenja = '{2}-{3}-{4}'" +
"           where jmbg_pisca = '{5}';", p.Ime, p.Prezime, p.DatumRodjenja.Year, p.DatumRodjenja.Month, p.DatumRodjenja.Day,
            p.JmbgPisca);

            if (Baza.CommandExecuteNumQuery(comm))
            {
                return true;
            }

            return false;
        }

        public bool ObrisiPisca(string IdPisca)
        {
            string comm = string.Format("delete from pisac where jmbg_pisca = {0}", IdPisca);

            if (Baza.CommandExecuteNumQuery(comm))
                return true;

            return false;
        }

        public List<Pisac> SviPisci(string uslov)
        {
            string comm = "select * from pisac " + uslov;
            SqlCommand readerCommand = Baza.GetSqlCommand(comm);
            List<Pisac> l = new List<Pisac>();

            using (readerCommand)
            {
                using (SqlDataReader reader = readerCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pisac p = new Pisac();

                        p.JmbgPisca = reader.GetString(0);
                        p.Ime = reader.GetString(1);
                        p.Prezime = reader.GetString(2);

                        if (!reader.IsDBNull(3))
                        {
                            DateTime dateValue = reader.GetDateTime(3);
                            p.DatumRodjenja = dateValue;
                        }
                        else
                        {
                            p.DatumRodjenja = DateTime.MinValue;
                        }


                        l.Add(p);
                    }
                }
            }

            return l;
        }

        //CLAN

        //jmbg promenjen sa inta na string zbog tipa u bazi, ako ima greska ovo je moguc razlog
        public bool DodajClana(Clan c)
        {
            int aktivan = 0;

            if (c.Aktivan)
                aktivan = 1;

            int priveledge = 0;

            if (c.Priveledge)
                priveledge = 1;

            string comm = string.Format("insert into clan values ({0}, '{1}', '{2}', " +
                "'{3}', '{4}', {5}, '{6}', '{7}', {8});",
                c.JmbgClana, c.Ime, c.Prezime, c.Email, c.DatumRodjenja, aktivan, c.Username, c.Password, priveledge);

            if (Baza.CommandExecuteNumQuery(comm))
                return true;

            return false;
        }
        public bool IzmeniClana(Clan c)
        {
            int aktivan = 0;

            if (c.Aktivan)
                aktivan = 1;

            int priveledge = 0;

            if (c.Priveledge)
                priveledge = 1;

            string comm = string.Format("update clan set ime = '{0}', prezime = '{1}', " +
                "email = '{2}', datum_rodjenja = '{3}'," +
                "\r\naktivan = {4}, username = '{5}', password = '{6}', " +
                "priviledge = {7} where jmbg_clana = {8};", c.Ime, c.Prezime, c.Email, c.DatumRodjenja,
                aktivan, c.Username, c.Password, priveledge, c.JmbgClana);

            if (Baza.CommandExecuteNumQuery(comm))
                return true;

            return false;
        }
        public bool ObrisiClana(int IdClana)
        {
            string comm = string.Format("delete from clan where jmbg_clana = {0}", IdClana);

            if (Baza.CommandExecuteNumQuery(comm))
                return true;
            return false;
        }
        public List<Clan> SviClanovi(string uslov)
        {
            string comm = "select * from clan " + uslov;
            SqlCommand readerCommand = Baza.GetSqlCommand(comm);
            List<Clan> l = new List<Clan>();

            using (readerCommand)
            {
                using (SqlDataReader reader = readerCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Clan c = new Clan();

                        c.JmbgClana = reader.GetString(0);
                        c.Ime = reader.GetString(1);
                        c.Prezime = reader.GetString(2);
                        c.Email = reader.GetString(3);

                        if (!reader.IsDBNull(4))
                            c.DatumRodjenja = reader.GetDateTime(4);
                        else
                            c.DatumRodjenja = DateTime.MinValue;

                        c.Aktivan = reader.GetBoolean(5);
                        c.Username = reader.GetString(6);

                        //hashovati potenicalno
                        c.Password = reader.GetString(7);
                        c.Priveledge = reader.GetBoolean(8);

                        l.Add(c);
                    }
                }
            }

            return l;
        }

        public bool DodajIznajmljivanje(Iznajmljivanje i)
        {
            int vracena = 0;

            if (i.Vracena)
                vracena = 1;

            string comm = string.Format("insert into iznajmio values({0}, {1}, '{2}', '{3}', {4})",
                i.JmbgClana, i.IdKnjige, i.DatumIznajmljivanja, i.DatumVracanja, vracena);

            if (Baza.CommandExecuteNumQuery(comm))
                return true;

            return false;
        }

        public bool ObrisiIznajmljivanje(int idIznajmljivanja)
        {
            string comm = string.Format("delete from iznajmio where id_iznajmljivanja = {0};", idIznajmljivanja);

            if (Baza.CommandExecuteNumQuery(comm))
                return true;

            return false;
        }   

        public bool IzmeniIznajmljivanje(Iznajmljivanje i)
        {
            int vracena = 0;

            if (i.Vracena)
                vracena = 1;

            string comm = string.Format("update iznajmio set jmbg_clana = '{0}', id_knjige = {1}," +
                " datum_izdavanja = '{2}',\r\ndatum_vracanja = '{3}', " +
                "vracena = {4} where id_iznajmljivanja = {5};", i.JmbgClana, i.IdKnjige, i.DatumIznajmljivanja,
                i.DatumVracanja, vracena, i.IdIznajmljivanja);

            if(Baza.CommandExecuteNumQuery(comm))
                return true;

            return false;
        }

        public List<Iznajmljivanje> SvaIznajmljivanja(string uslov)
        {
            string comm = "select * from iznajmio " + uslov;
            SqlCommand readerCommand = Baza.GetSqlCommand(comm);
            List<Iznajmljivanje> l = new List<Iznajmljivanje>();

            using (readerCommand)
            {
                using (SqlDataReader reader = readerCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Iznajmljivanje i = new Iznajmljivanje();

                        i.IdIznajmljivanja = reader.GetInt32(0);
                        i.JmbgClana = reader.GetString(1);
                        i.IdKnjige = reader.GetInt32(2);
                        if (reader.IsDBNull(3))
                            i.DatumIznajmljivanja = DateTime.MinValue;
                        else
                            i.DatumIznajmljivanja = reader.GetDateTime(3);

                        if (reader.IsDBNull(4))
                            i.DatumVracanja = DateTime.MinValue;
                        else
                            i.DatumVracanja = reader.GetDateTime(4);
                        i.Vracena = reader.GetBoolean(5);


                        l.Add(i);
                    }
                }
            }

            return l;
        }


    }
}
