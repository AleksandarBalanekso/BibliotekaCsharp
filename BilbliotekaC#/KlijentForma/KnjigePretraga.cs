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
    public partial class KnjigePretraga : Form
    {
        public List<Knjiga> povratnaLista { get; set; }
        
        public KnjigePretraga()
        {
            InitializeComponent();
        }

        private void btnPretragaId_Click(object sender, EventArgs e)
        {
            int id;

            if (tbPretraga.Text != "")
                id = int.Parse(tbPretraga.Text);
            else
                id = -1;

            List<Knjiga> knjige = Konekcija.Proxy.SveKnjige(string.Format("where id_knjige = {0};", id));

            if (knjige.Count == 0)
            {
                MessageBox.Show("NEMA REZULTATA PRETRAGE", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            povratnaLista = knjige;

            this.Close();
        }

        private void btnPretragaNaziv_Click(object sender, EventArgs e)
        {

            List<Knjiga> knjige = new List<Knjiga>();
            string naziv = tbPretraga.Text;

            foreach(Knjiga k in Konekcija.Proxy.SveKnjige(""))
            {
                if(k.NazivKnjige.Contains(naziv))
                    knjige.Add(k);
            }

            if (knjige.Count == 0)
            {
                MessageBox.Show("NEMA REZULTATA PRETRAGE", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            povratnaLista = knjige;

            this.Close();
        }

        private void btnPretragaPisac_Click(object sender, EventArgs e)
        {
            string jmbg = tbPretraga.Text;

            string comm = string.Format(", pisac where knjiga.jmbg_pisca = pisac.jmbg_pisca " +
            "and pisac.jmbg_pisca = '{0}';", jmbg);

            List<Knjiga> knjige = Konekcija.Proxy.SveKnjige(comm);

            if (knjige.Count == 0)
            {  
                MessageBox.Show("NEMA REZULTATA PRETRAGE", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            povratnaLista = knjige;

            this.Close();
        }
    }
}
