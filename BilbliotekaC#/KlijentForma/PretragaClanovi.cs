using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentForma
{
    public partial class PretragaClanovi : Form
    {
        public List<Clan> ListaClanova { get; set; }

        public PretragaClanovi()
        {
            InitializeComponent();

            ListaClanova = new List<Clan>();
        }

        private void btnPretragaPoJmbgu_Click(object sender, EventArgs e)
        {
            string text = tbPretraga.Text;

            ListaClanova = Konekcija.Proxy.SviClanovi($"where jmbg_clana = '{text}'");

            if(ListaClanova.Count == 0)
            {
                MessageBox.Show("NEMA REZULTATA PRETRAGE", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();

        }

        private void btnPretragaPoImenu_Click(object sender, EventArgs e)
        {
            string pretraga = tbPretraga.Text;

            List<Clan> SviClanovi = Konekcija.Proxy.SviClanovi("");

            foreach (Clan c in SviClanovi)
            {
                if (c.Ime.Contains(pretraga))
                    ListaClanova.Add(c);
            }

            if (ListaClanova.Count == 0)
            {
                MessageBox.Show("NEMA REUZLTATA PRETRAGE", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

        }

        private void btnPretragaPoPrezimenu_Click(object sender, EventArgs e)
        {
            string text = tbPretraga.Text;

            List<Clan> sviClanovi = Konekcija.Proxy.SviClanovi("");

            foreach (Clan clan in sviClanovi)
            {
                if (clan.Prezime.Contains(text))
                    ListaClanova.Add(clan);
            }

            if (ListaClanova.Count == 0)
            {
                MessageBox.Show("NEMA REZULTATA PRETRAGE", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();

        }

        private void btnPretragaPoKorisnickomImenu_Click(object sender, EventArgs e)
        {
            string text = tbPretraga.Text;

            List<Clan> sviClanovi = Konekcija.Proxy.SviClanovi("");

            foreach (Clan clan in sviClanovi)
            {
                if (clan.Username.Contains(text))
                    ListaClanova.Add(clan);
            }

            if (ListaClanova.Count == 0)
            {
                MessageBox.Show("NEMA REZULTATA PRETRAGE", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
