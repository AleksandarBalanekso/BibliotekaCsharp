using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentForma
{
    public partial class DodajKnjigu : Form
    {
        public Knjiga KnjigaZaIzmenu { get; set; }

        private bool izmenjivanje { get; set; }
        public DodajKnjigu()
        {
            InitializeComponent();
            this.Text = "Izmeni Knjigu";

            List<Pisac> pisci = Konekcija.Proxy.SviPisci("");

            cbAutor.DataSource = pisci;
            cbAutor.ValueMember = "JmbgPisca";

            cbAutor.Format += new ListControlConvertEventHandler(cbAutor_Format);
            cbAutor.SelectedIndex = 0;

            List<int> Godine = new List<int>();

            for(int i = 2024; i >= 0; i--)
            {
                Godine.Add(i);
            }

            cbGodinaIzdavanja.DataSource = Godine;
            cbGodinaIzdavanja.SelectedIndex = 0;

            izmenjivanje = false;
        }

        public DodajKnjigu(Knjiga knjiga)
        {
            InitializeComponent();
            btnDodajKnjgu.Text = "IZMENI KNJIGU";

            KnjigaZaIzmenu = knjiga;

            List<Pisac> pisci = Konekcija.Proxy.SviPisci("");

            cbAutor.DataSource = pisci;
            cbAutor.ValueMember = "JmbgPisca";

            cbAutor.Format += new ListControlConvertEventHandler(cbAutor_Format);
            cbAutor.SelectedValue = KnjigaZaIzmenu.JmbgPisca;

            List<int> Godine = new List<int>();

            for (int i = 2024; i >= 0; i--)
            {
                Godine.Add(i);
            }

            cbGodinaIzdavanja.DataSource = Godine;
            cbGodinaIzdavanja.SelectedIndex = 0;

            tbNaziv.Text = KnjigaZaIzmenu.NazivKnjige;
            tbKolicinaUBiblioteci.Text = KnjigaZaIzmenu.KolicinaUBiblioteci.ToString();

            izmenjivanje = true;
        }

        private void cbAutor_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Pisac pisac)
            {
                e.Value = $"{pisac.Ime} {pisac.Prezime}";
            }
        }
    

        private void btnDodajKnjgu_Click(object sender, EventArgs e)
        {
            bool validNumFormat = true;

            foreach (char c in tbKolicinaUBiblioteci.Text)
            {
                if(!Char.IsDigit(c))
                    validNumFormat = false;
            }

            if (tbNaziv.Text == "")
            {
                MessageBox.Show("NISTE UNELI IME", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbKolicinaUBiblioteci.Text == "")
            {
                MessageBox.Show("NISTE UNELI KOLICINU U BIBLIOTECI", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!validNumFormat)
            {
                MessageBox.Show("KOLICINA U BIBLIOTECI MORA BITI BROJ!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (!izmenjivanje)
                {
                    int id = -1;
                    List<int> ids = new List<int>();
                    List<Knjiga> sveKnjige = Konekcija.Proxy.SveKnjige("");

                    foreach (Knjiga k in sveKnjige)
                    {
                        ids.Add(k.IdKnjige);
                    }

                    for (int i = 0; i < sveKnjige.Count() + 1; i++)
                    {
                        if (!ids.Contains(i) && id == -1)
                        {
                            id = i;
                        }
                    }

                    Knjiga novaKnjiga = new Knjiga(id, tbNaziv.Text, int.Parse(tbKolicinaUBiblioteci.Text),
                        cbAutor.SelectedValue.ToString(), int.Parse(cbGodinaIzdavanja.SelectedValue.ToString()));

                    Konekcija.Proxy.DodajKnjigu(novaKnjiga);

                    MessageBox.Show("USEPESNO DODATA NOVA KNJIGA", "USPEH", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    KnjigaZaIzmenu.NazivKnjige = tbNaziv.Text;
                    KnjigaZaIzmenu.KolicinaUBiblioteci = int.Parse(tbKolicinaUBiblioteci.Text);
                    KnjigaZaIzmenu.GodinaIzdavanja = int.Parse(cbGodinaIzdavanja.SelectedValue.ToString());
                    KnjigaZaIzmenu.JmbgPisca = cbAutor.SelectedValue.ToString();

                    Konekcija.Proxy.IzmeniKnjigu(KnjigaZaIzmenu);

                    MessageBox.Show("USPESNO IZMENJENA KNJIGA", "USPEH", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
