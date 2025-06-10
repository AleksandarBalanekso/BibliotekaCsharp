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
    public partial class OIznajmljivanju : Form
    {
        Iznajmljivanje AktivnoIznajmljivanje { get; set; }

        public bool ViewOnly { get; set; }
        public OIznajmljivanju()
        {
            InitializeComponent();
        }

        public OIznajmljivanju(Iznajmljivanje iznajmljivanje)
        {
            InitializeComponent();

            AktivnoIznajmljivanje = iznajmljivanje;

            tbIdIznajmljivanja.Text = AktivnoIznajmljivanje.IdIznajmljivanja.ToString();
            Knjiga k = Konekcija.Proxy.SveKnjige(string.Format("where id_knjige = {0}", AktivnoIznajmljivanje.IdKnjige))[0];

            tbNazivKnjige.Text = k.NazivKnjige;

            Clan c = Konekcija.Proxy.SviClanovi(string.Format("where jmbg_clana = '{0}'", AktivnoIznajmljivanje.JmbgClana))[0];
            tbKorisnickoIme.Text = c.Username;

            tbDatumIznajmljivanja.Text = AktivnoIznajmljivanje.DatumIznajmljivanja.ToString();
            tbDatumVracanja.Text = AktivnoIznajmljivanje.DatumVracanja.ToString();

            if (AktivnoIznajmljivanje.Vracena)
                cbVracena.Checked = true;
            else
                cbVracena.Checked = false;

            ViewOnly = false;

        }
        public OIznajmljivanju(Iznajmljivanje iznajmljivanje, bool viewOnly)
        {
            InitializeComponent();

            AktivnoIznajmljivanje = iznajmljivanje;

            tbIdIznajmljivanja.Text = AktivnoIznajmljivanje.IdIznajmljivanja.ToString();
            Knjiga k = Konekcija.Proxy.SveKnjige(string.Format("where id_knjige = {0}", AktivnoIznajmljivanje.IdKnjige))[0];

            tbNazivKnjige.Text = k.NazivKnjige;

            Clan c = Konekcija.Proxy.SviClanovi(string.Format("where jmbg_clana = '{0}'", AktivnoIznajmljivanje.JmbgClana))[0];
            tbKorisnickoIme.Text = c.Username;

            tbDatumIznajmljivanja.Text = AktivnoIznajmljivanje.DatumIznajmljivanja.ToString();
            tbDatumVracanja.Text = AktivnoIznajmljivanje.DatumVracanja.ToString();

            if (AktivnoIznajmljivanje.Vracena)
                cbVracena.Checked = true;
            else
                cbVracena.Checked = false;

            ViewOnly = viewOnly;

            if(ViewOnly)
            {
                btnVratiOvo.Enabled = false;
                btnVratiOvo.Visible = false;
            }

        }

        private void btnVratiOvo_Click(object sender, EventArgs e)
        {
            if(!AktivnoIznajmljivanje.Vracena && !ViewOnly)
            {
                AktivnoIznajmljivanje.Vracena = true;
                AktivnoIznajmljivanje.DatumVracanja = DateTime.Now;

                //nije testirano, ali valjda radi
                Knjiga k = Konekcija.Proxy.SveKnjige(
                    string.Format("where id_knjige = {0};", AktivnoIznajmljivanje.IdKnjige))[0];

                k.KolicinaUBiblioteci++;

                //ovo jeste
                Konekcija.Proxy.IzmeniIznajmljivanje(AktivnoIznajmljivanje);

                MessageBox.Show("USPESNO VRACENA KNJIGA", "INFORMACIJA", MessageBoxButtons.OK,
                    MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show("KNJIGA JE VEC VRACENA", "INFORMACIJA", MessageBoxButtons.OK,
                    MessageBoxIcon.Information );
            }

            this.Close();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
