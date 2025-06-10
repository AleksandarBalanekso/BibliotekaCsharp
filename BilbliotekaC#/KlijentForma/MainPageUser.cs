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
using System.Windows.Forms.VisualStyles;

namespace KlijentForma
{
    public partial class MainPageUser : Form
    {
        public Clan AktivanClan {  get; set; }

        public MainPageUser()
        {
            InitializeComponent();
        }

        public MainPageUser(Clan aktivanClan)
        {
            InitializeComponent();

            AktivanClan = aktivanClan;

            lblDobrodosli.Text = string.Format("Dobrodosli {0} {1}!",
                AktivanClan.Ime, AktivanClan.Prezime);

            dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
            dgwPisci.DataSource = Konekcija.Proxy.SviPisci("");

            string iznajmljivajnaComm = string.Format("where " +
                "jmbg_clana = '{0}' and vracena = 0;", AktivanClan.JmbgClana);

            dgwIznajmljivanja.DataSource = Konekcija.Proxy.SvaIznajmljivanja(iznajmljivajnaComm);
        }

        private void MainPaigeUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKnjige_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void dgwKnjige_Click(object sender, EventArgs e)
        {
           
        }

        private void dgwKnjige_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnOKnjizi_Click(object sender, EventArgs e)
        {
            DataGridViewRow selektovanRed = dgwKnjige.SelectedRows[0];
            Knjiga k = selektovanRed.DataBoundItem as Knjiga;

            OKnjizi o = new OKnjizi(k, AktivanClan);

            o.ShowDialog();
            dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
        }

        private void btnPocetnaStrana_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            KnjigePretraga kp = new KnjigePretraga();

            kp.ShowDialog();

            if(kp.IsAccessible)
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

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            LandingPage lp = new LandingPage();

            lp.Show();
            this.Hide();
        }

        private void btnPocetnaStranaPisci_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnOPiscu_Click(object sender, EventArgs e)
        {

            DataGridViewRow selektovanRed = dgwPisci.SelectedRows[0];
            Pisac pisac = selektovanRed.DataBoundItem as Pisac;

            OPiscu op = new OPiscu(pisac);

            op.ShowDialog();

            if(op.IsAccessible && op.SveKnjige.Count > 0)
            {
                tabControl1.SelectedIndex = 1;
                dgwKnjige.DataSource = op.SveKnjige;
            }

            op.Close();
        }

        private void btnPisci_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwKnjige.DataSource = Konekcija.Proxy.SveKnjige("");
            dgwPisci.DataSource = Konekcija.Proxy.SviPisci("");

            string iznajmljivajnaComm = string.Format("where " +
                "jmbg_clana = '{0}' and vracena = 0;", AktivanClan.JmbgClana);

            dgwIznajmljivanja.DataSource = Konekcija.Proxy.SvaIznajmljivanja(iznajmljivajnaComm);
        }

        private void btnPretragaPisci_Click(object sender, EventArgs e)
        {
            PisciPretraga pp = new PisciPretraga();

            pp.ShowDialog();

            if(pp.Pisci.Count > 0)
            {
                dgwPisci.DataSource = pp.Pisci;
            }

            pp.Close();
        }

        private void btnMojaIznajmljivajna_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPocetnaStranaIznajmljivanja_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnAktivnaIznajmljivanja_Click(object sender, EventArgs e)
        {
            string iznajmljivajnaComm = string.Format("where " +
               "jmbg_clana = '{0}' and vracena = 0;", AktivanClan.JmbgClana);

            dgwIznajmljivanja.DataSource = Konekcija.Proxy.SvaIznajmljivanja(iznajmljivajnaComm);
        }

        private void btnSvaIznajmljivanja_Click(object sender, EventArgs e)
        {
            string iznajmljivajnaComm = string.Format("where " +
               "jmbg_clana = '{0}';", AktivanClan.JmbgClana);

            dgwIznajmljivanja.DataSource = Konekcija.Proxy.SvaIznajmljivanja(iznajmljivajnaComm);
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

        private void btnOIznajmljivanju_Click(object sender, EventArgs e)
        {
            DataGridViewRow selektovanRed = dgwIznajmljivanja.SelectedRows[0];
            Iznajmljivanje iznajmljivanje = selektovanRed.DataBoundItem as Iznajmljivanje;

            OIznajmljivanju oi = new OIznajmljivanju(iznajmljivanje);

            oi.ShowDialog();

            oi.Close();

            dgwIznajmljivanja.DataSource = Konekcija.Proxy.SvaIznajmljivanja(string.Format("where vracena = 0 " +
                "and jmbg_clana = '{0}';", AktivanClan.JmbgClana));
        }

        private void btnMojProfil_Click(object sender, EventArgs e)
        {
            SignUpPage sup = new SignUpPage(AktivanClan);

            sup.ShowDialog();

            lblDobrodosli.Text = string.Format("Dobrodosli {0} {1}!", AktivanClan.Ime, AktivanClan.Prezime);
        }

        private void btnOAutoru_Click(object sender, EventArgs e)
        {
            OAuotru oa = new OAuotru();

            oa.ShowDialog();
        }
    }
}
