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
    public partial class OClanu : Form
    {
        public Clan AktivanClan { get; set; }
        public List<Iznajmljivanje> SvaIznajmljivanja { get; set; }

        public OClanu()
        {
            InitializeComponent();
        }
        public OClanu(Clan skibidiToilet)
        {
            InitializeComponent();

            AktivanClan = skibidiToilet;

            tbJmbg.Text = AktivanClan.JmbgClana;
            tbIme.Text = AktivanClan.Ime;
            tbPrezime.Text = AktivanClan.Prezime;
            tbEmail.Text = AktivanClan.Email;
            tbDatumRodjenja.Text = AktivanClan.DatumRodjenja.ToString();
            if(AktivanClan.Aktivan)
            {
                cbAktivan.Checked = true;
            }
            else
            {
                cbAdmin.Checked = false;
            }
            tbKorisnickoIme.Text = AktivanClan.Username;
            if(AktivanClan.Priveledge)
            {
                cbAdmin.Checked = true;
            }
            else
            {
                cbAdmin.Checked = false;
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            SvaIznajmljivanja = new List<Iznajmljivanje>();

            this.Close();
        }

        private void btnSvaIznajmljivanja_Click(object sender, EventArgs e)
        {
            SvaIznajmljivanja = Konekcija.Proxy.SvaIznajmljivanja($"where jmbg_clana = '{AktivanClan.JmbgClana}'");

            if(SvaIznajmljivanja.Count == 0)
            {
                MessageBox.Show("OVAJ CLAN NIJE IMAO NI JEDNO IZNAJMLJIVANJE", "INFORMACIJA", MessageBoxButtons.OK,
                    MessageBoxIcon.Information );
            }

            this.Close();
        }
    }
}
