using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KlijentForma
{
    public partial class OKnjizi : Form
    {
        public Knjiga k { get; set; }
        public Clan c {  get; set; }

        public OKnjizi()
        {
            InitializeComponent();
        }

        public OKnjizi(Knjiga knjiga, Clan clan)
        {
            InitializeComponent();

            k = knjiga;
            c = clan;

            tbId.Text = k.IdKnjige.ToString();
            tbNaziv.Text = k.NazivKnjige.ToString();

            string pisacComm = string.Format(", knjiga where knjiga.jmbg_pisca = pisac.jmbg_pisca\r\nand knjiga.id_knjige = {0};",
                k.IdKnjige);
            Pisac p = Konekcija.Proxy.SviPisci(pisacComm)[0];

            string pisacString = p.Ime + " " + p.Prezime;

            tbPisac.Text = pisacString;
            tbGodinaIzdavanja.Text = k.GodinaIzdavanja.ToString();
            tbKolicinaUBiblioteci.Text = k.KolicinaUBiblioteci.ToString();
        }

        private void btnIznajmiOvo_Click(object sender, EventArgs e)
        {

            string checkComm = string.Format("where id_knjige = {0} and jmbg_clana = {1} and vracena = 0;",
                k.IdKnjige, c.JmbgClana);

            if (Konekcija.Proxy.SvaIznajmljivanja(checkComm).Count > 0)
            {
                MessageBox.Show("VEC STE IZNAJMILI OVU KNJIGU", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                k.KolicinaUBiblioteci--;
                Konekcija.Proxy.IzmeniKnjigu(k);

                List<Iznajmljivanje> iznajmljivanja = Konekcija.Proxy.SvaIznajmljivanja("");
                List<int> indeksi = new List<int>();

                foreach (Iznajmljivanje i in iznajmljivanja)
                {
                    indeksi.Add(i.IdIznajmljivanja);
                }

                int id = -1;

                for (int i = 0; i < iznajmljivanja.Count + 1; i++)
                {
                    if (!indeksi.Contains(i) && id == -1)
                        id = i;
                }

                Iznajmljivanje iznajmljivanje = new Iznajmljivanje(id, c.JmbgClana, k.IdKnjige,
                    DateTime.Now, DateTime.MinValue, false);

                Konekcija.Proxy.DodajIznajmljivanje(iznajmljivanje);
            }

            this.Close();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
