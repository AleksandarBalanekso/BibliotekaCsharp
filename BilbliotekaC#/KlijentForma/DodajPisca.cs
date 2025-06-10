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
    public partial class DodajPisca : Form
    {
        public Pisac PisacZaIzmenu { get; set; }    

        private bool DodajaPisca { get; set; }

        public DodajPisca()
        {
            InitializeComponent();

            DodajaPisca = true;
        }

        public DodajPisca(Pisac p)
        {
            InitializeComponent();

            PisacZaIzmenu = p;

            tbIme.Text = p.Ime;
            tbPrezime.Text = p.Prezime;
            dtpDatumRodjenja.Value = p.DatumRodjenja;

            DodajaPisca = false;

            this.Text = "Izmena pisca";
            btnDodajPisca.Text = "IZMENI PISCA";
        }

        private void btnDodajPisca_Click(object sender, EventArgs e)
        {
            if(tbIme.Text == "")
            {
                MessageBox.Show("NISTE UNELI IME!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else if (tbPrezime.Text == "")
            {
                MessageBox.Show("NISTE UNELI IME!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(DodajaPisca)
                {

                    List<Pisac> SviPisci = Konekcija.Proxy.SviPisci("");

                    List<string> jmbgovi = new List<string>();

                    foreach (Pisac pisac in SviPisci)
                    {
                        jmbgovi.Add(pisac.JmbgPisca);
                    }

                    string jmbg = "-1";

                    /* for (int i = 0; i < SviPisci.Count + 1; i++)
                     {
                         if (!jmbgovi.Contains(i.ToString()) && jmbg == "-1")
                         {
                             jmbg = i.ToString();
                         }
                     } */

                    int a = SviPisci.Count + 1;
                    jmbg = a.ToString();

                    Konekcija.Proxy.DodajPisca(new Pisac(jmbg, tbIme.Text, tbPrezime.Text,
                        dtpDatumRodjenja.Value));

                    MessageBox.Show("USPESNO STE DODALI PISCA!", "USPEH", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    PisacZaIzmenu.Ime = tbIme.Text;
                    PisacZaIzmenu.Prezime = tbPrezime.Text;
                    PisacZaIzmenu.DatumRodjenja = dtpDatumRodjenja.Value;

                    Konekcija.Proxy.IzmeniPisca(PisacZaIzmenu);

                    MessageBox.Show("USPESNO STE IZMENILI PISCA!", "USPEH", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                this.Close();
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
