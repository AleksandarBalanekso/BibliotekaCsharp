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
    public partial class MainPageAdmin : Form
    {

        public Clan AktivanClan {  get; set; } 
        public MainPageAdmin()
        {
            InitializeComponent();
        }

        public MainPageAdmin(Clan aktivanClan)
        {

            InitializeComponent();

            AktivanClan = aktivanClan;
            lblDobrodosli.Text = string.Format("Dobrodosli {0} {1}!", AktivanClan.Ime, AktivanClan.Prezime);

            dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
            dgwPisci.DataSource = Konekcija.Proxy.SviPisci("");
            dgwIznajmljivanja.DataSource = Konekcija.Proxy.SvaIznajmljivanja("where vracena = 0");
            dgwClanovi.DataSource = Konekcija.Proxy.SviClanovi("");
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            LandingPage lp = new LandingPage();

            lp.Show();
            this.Hide();
        }

        private void btnPocetnaStrana_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnSveKnjige_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
            dgwPisci.DataSource = Konekcija.Proxy.SviPisci("");
            dgwIznajmljivanja.DataSource = Konekcija.Proxy.SvaIznajmljivanja("where vracena = 0");
            dgwClanovi.DataSource = Konekcija.Proxy.SviClanovi("");
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            DodajKnjigu dk = new DodajKnjigu();

            dk.ShowDialog();

            dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
        }

        private void MainPageAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnIzmeniKnjigu_Click(object sender, EventArgs e)
        {
            DataGridViewRow red = dgwKnjige.SelectedRows[0];
            Knjiga k = red.DataBoundItem as Knjiga;

            if (k != null)
            {
                DodajKnjigu dk = new DodajKnjigu(k);

                dk.ShowDialog();

                dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
                dk.Close();
            }
            else
            {
                MessageBox.Show("NEMA KNJIGA U SISTEMU!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnDodajKnjgu_Click(object sender, EventArgs e)
        {
            DataGridViewRow red = dgwKnjige.SelectedRows[0];
            Knjiga k = red.DataBoundItem as Knjiga;

            DialogResult rezultat = MessageBox.Show("Da li ste sigurni da zelite da obriste ovu knjigu?" +
                "Brisanje ove knjige ce obrisati sva iznajmljivanja ove knjige!", "Upozorenje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(rezultat == DialogResult.Yes)
            {
                ObrisiKnjigu(k);

                MessageBox.Show("USPESNO STE OBRISALI KNIGU", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
            }

        }

        private void ObrisiKnjigu(Knjiga k)
        {
            List<Iznajmljivanje> listaIznajmljivanja = Konekcija.Proxy.SvaIznajmljivanja($"where id_knjige = {k.IdKnjige};");

            foreach(Iznajmljivanje i in listaIznajmljivanja)
            {
                Konekcija.Proxy.ObrisiIznajmljivanje(i.IdIznajmljivanja);
            }

            Konekcija.Proxy.ObrisiKnjigu(k.IdKnjige);
        }

        // Zbog nekog razloga ovo jede govna
        private void btnKnjigePretraga_Click(object sender, EventArgs e)
        {
            KnjigePretraga kp = new KnjigePretraga();

            kp.ShowDialog();

            if (kp.IsAccessible)
            {
                if (kp.povratnaLista.Count == 0)
                {
                    dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
                }
                else
                {
                    dgwKnjige.DataSource = kp.povratnaLista;
                }
            }
            else
            {
                dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
            }

            kp.Close();
        }

        private void btnPocetnaStranica_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnObrisiPisca_Click(object sender, EventArgs e)
        {
            DataGridViewRow red = dgwPisci.SelectedRows[0];
            Pisac p = red.DataBoundItem as Pisac;

            if (p != null)
            {
                DialogResult rezultat = MessageBox.Show("Da li ste sigurni da zelite da obriste ovog pisca?" +
               "Brisanje ovog pisca ce obrisati i sva njegova dela!", "Upozorenje",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rezultat == DialogResult.Yes)
                {
                    ObrisiPisca(p);

                    MessageBox.Show("USPESNO STE OBRISALI PISCA", "USPEH", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgwPisci.DataSource = Konekcija.Proxy.SviPisci("");
                }
            }
            else
            {
                MessageBox.Show("NEMA PISACA U SISTEMU!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObrisiPisca(Pisac p)
        {
            List<Knjiga> listaKnjiga = Konekcija.Proxy.SveKnjige($"where jmbg_pisca = '{p.JmbgPisca}';");

            foreach(Knjiga k in listaKnjiga)
            {
                ObrisiKnjigu(k);
            }

            Konekcija.Proxy.ObrisiPisca(p.JmbgPisca);
        }

        private void btnIzmeniPisca_Click(object sender, EventArgs e)
        {
            DataGridViewRow red = dgwPisci.SelectedRows[0];
            Pisac p = red.DataBoundItem as Pisac;

            if(p != null)
            {
                DodajPisca dp = new DodajPisca(p);

                dp.ShowDialog();
                
                dgwPisci.DataSource = Konekcija.Proxy.SviPisci("");
            }
            else
            {
                MessageBox.Show("NEMA PISACA U SISTEMU!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnDodajPisca_Click(object sender, EventArgs e)
        {
            DodajPisca dp = new DodajPisca();

            dp.ShowDialog();

            dgwPisci.DataSource = Konekcija.Proxy.SviPisci("");
        }

        private void btnSviPisci_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnPretragaPisci_Click(object sender, EventArgs e)
        {
            PisciPretraga pp = new PisciPretraga();

            pp.ShowDialog();

            if (pp.Pisci.Count > 0)
            {
                dgwPisci.DataSource = pp.Pisci;
            }

            pp.Close();
        }

        private void btnOIznajmljivanju_Click(object sender, EventArgs e)
        {
            DataGridViewRow red = dgwIznajmljivanja.SelectedRows[0];
            Iznajmljivanje i = red.DataBoundItem as Iznajmljivanje;

            OIznajmljivanju oioioi = new OIznajmljivanju(i, true);

            oioioi.ShowDialog();
        }

        private void btnSvaIznajmljivanja_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btnPocetnaStranaIznajmljivanja_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnPretragaIznajmljivanja_Click(object sender, EventArgs e)
        {
            IznajmljivanjaPretraga izp = new IznajmljivanjaPretraga(AktivanClan);

            izp.ShowDialog();

            if (izp.ListaIznajmljivanja.Count > 0)
            {
                dgwIznajmljivanja.DataSource = izp.ListaIznajmljivanja;
            }

            izp.Close();
        }

        private void BtnISvaIznajmljivanja_Click(object sender, EventArgs e)
        {
            dgwIznajmljivanja.DataSource = Konekcija.Proxy.SvaIznajmljivanja("");
        }

        private void btnAktivnaIznajmljivanja_Click(object sender, EventArgs e)
        {
            dgwIznajmljivanja.DataSource = Konekcija.Proxy.SvaIznajmljivanja("where vracena = 0");
        }

        private void btnOClanu_Click(object sender, EventArgs e)
        {
            DataGridViewRow red = dgwClanovi.SelectedRows[0];
            Clan clan = red.DataBoundItem as Clan;

            using (OClanu oc = new OClanu(clan))
            {
                oc.ShowDialog();

                if (oc.SvaIznajmljivanja != null && oc.SvaIznajmljivanja.Count > 0)
                {
                    this.tabControl1.SelectedIndex = 3;
                    this.dgwIznajmljivanja.DataSource = oc.SvaIznajmljivanja;
                }
            }
        }

        private void btnSviClanovi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void btnMojProfil_Click(object sender, EventArgs e)
        {
            SignUpPage sup = new SignUpPage(AktivanClan);

            sup.ShowDialog();
        }

        private void btnPocetnaStranaClanovi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnPretragaClanovi_Click(object sender, EventArgs e)
        {
            using (PretragaClanovi pc = new PretragaClanovi())
            {
                pc.ShowDialog();

                if (pc.ListaClanova.Count > 0)
                {
                    dgwClanovi.DataSource = pc.ListaClanova;
                }
            }
        }

        private void btnOAutoru_Click(object sender, EventArgs e)
        {
            OAuotru oa = new OAuotru();

            oa.ShowDialog();
        }
    }
}

