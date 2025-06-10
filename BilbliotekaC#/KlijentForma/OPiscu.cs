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
    public partial class OPiscu : Form
    {
        public Pisac Pisac { get; set; }
        public List<Knjiga> SveKnjige { get; set;}

        public OPiscu()
        {
            InitializeComponent();
        }

        public OPiscu(Pisac p)
        {
            InitializeComponent();

            Pisac = p;

            tbJmbg.Text = p.JmbgPisca;
            tbIme.Text = p.Ime;
            tbPrezime.Text = p.Prezime;
            tbDatumRodjenja.Text = p.DatumRodjenja.ToString();
        }

        private void btnSvaDela_Click(object sender, EventArgs e)
        {

            SveKnjige = Konekcija.Proxy.SveKnjige(string.Format("where jmbg_pisca = '{0}';", Pisac.JmbgPisca));

            if (SveKnjige.Count == 0)
            {
                MessageBox.Show("OVAJ PISAC NIJE NAPISAO NI JEDNO DELO", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            SveKnjige = new List<Knjiga>();

            this.Close();
        }
    }
}
