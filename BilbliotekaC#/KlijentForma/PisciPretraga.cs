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
    public partial class PisciPretraga : Form
    {
        public List<Pisac> Pisci { get; set; }

        public PisciPretraga()
        {
            InitializeComponent();

            Pisci = new List<Pisac>();
        }

        private void btnPretragaPoJmbgu_Click(object sender, EventArgs e)
        {
            string pretraga = tbPretraga.Text;

            string comm = string.Format("where jmbg_pisca = '{0}';", pretraga);

            Pisci = Konekcija.Proxy.SviPisci(comm);

            if(Pisci.Count == 0)
            {
                MessageBox.Show("NEMA REUZLTATA PRETRAGE", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnPretragaPoImenu_Click(object sender, EventArgs e)
        {
            string pretraga = tbPretraga.Text;

            List<Pisac> SviPisci = Konekcija.Proxy.SviPisci("");

            foreach(Pisac p in SviPisci)
            {
                if (p.Ime.Contains(pretraga))
                    Pisci.Add(p);
            }

            if (Pisci.Count == 0)
            {
                MessageBox.Show("NEMA REUZLTATA PRETRAGE", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnPretragaPoPrezimenu_Click(object sender, EventArgs e)
        {
            string pretraga = tbPretraga.Text;

            List<Pisac> SviPisci = Konekcija.Proxy.SviPisci("");

            foreach (Pisac p in SviPisci)
            {
                if (p.Prezime.Contains(pretraga))
                    Pisci.Add(p);
            }

            if (Pisci.Count == 0)
            {
                MessageBox.Show("NEMA REUZLTATA PRETRAGE", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
