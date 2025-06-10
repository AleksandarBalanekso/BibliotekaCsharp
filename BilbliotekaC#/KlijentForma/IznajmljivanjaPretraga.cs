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
    public partial class IznajmljivanjaPretraga : Form
    {
        public List<Iznajmljivanje> ListaIznajmljivanja { get; set; }

        public Clan AktivanClan { get; set; }

        public IznajmljivanjaPretraga()
        {
            InitializeComponent();

            ListaIznajmljivanja = new List<Iznajmljivanje>();
            rbAktivnaIznajmljivanja.Checked = true;
        }

        public IznajmljivanjaPretraga(Clan aktivanClan)
        {
            InitializeComponent();

            ListaIznajmljivanja = new List<Iznajmljivanje>();
            AktivanClan = aktivanClan;

            rbAktivnaIznajmljivanja.Checked = true;
        }

        private void lblPretraga_Click(object sender, EventArgs e)
        {

        }

        private void btnPretragaPoIdu_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbPretraga.Text);

            string comm = string.Format("where id_iznajmljivanja = {0} ", id);

            if(rbAktivnaIznajmljivanja.Checked)
            {
                comm += "and vracena = 0;";
            }

            ListaIznajmljivanja = Konekcija.Proxy.SvaIznajmljivanja(comm);

            if (ListaIznajmljivanja.Count == 0)
            {
                MessageBox.Show("NEMA REZULTATA PRETRAGE", "INFOMRACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void btnPretragaPoNazivu_Click(object sender, EventArgs e)
        {
            List<Knjiga> sveKnjige = Konekcija.Proxy.SveKnjige("");

            foreach(Knjiga k in sveKnjige)
            {
                if(k.NazivKnjige.Contains(tbPretraga.Text))
                {
                    string comm = string.Format("where id_knjige = {0} and jmbg_clana = '{1}' ",
                        k.IdKnjige, AktivanClan.JmbgClana);

                    if (rbAktivnaIznajmljivanja.Checked)
                        comm += "and vracena = 0;";

                    List<Iznajmljivanje> pronadjenaIznajmljivanja = Konekcija.Proxy.SvaIznajmljivanja(comm);

                    if(pronadjenaIznajmljivanja.Count > 0)
                    {
                        foreach(Iznajmljivanje i in pronadjenaIznajmljivanja)
                        {
                            ListaIznajmljivanja.Add(i);
                        }
                    }
                }
            }

            if (ListaIznajmljivanja.Count == 0)
            {
                MessageBox.Show("NEMA REZULTATA PRETRAGE", "INFOMRACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
