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
    public partial class SignUpPage : Form
    {
        public Clan AktivanClan { get; set; }
        private bool PraviNovogClana { get; set; }

        public SignUpPage()
        {
            InitializeComponent();

            PraviNovogClana = true;
        }

        public SignUpPage(Clan aktivanClan)
        {
            InitializeComponent();

            AktivanClan = aktivanClan;

            tbIme.Text = AktivanClan.Ime;
            tbPrezime.Text = AktivanClan.Prezime;
            tbEmail.Text = AktivanClan.Email;

            if (aktivanClan.Priveledge)
                rbAdmin.Checked = true;
            else
                rbKorisnik.Checked = true;

            tbKorisnickoIme.Text = AktivanClan.Username;
            tbLozinka.Text = AktivanClan.Password;
            tbPotvrdiLozinku.Text = AktivanClan.Password;

            rbAdmin.Enabled = false;
            rbKorisnik.Enabled = false;

            PraviNovogClana = false;

            rbAdmin.Enabled = false;
            rbKorisnik.Enabled = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if(PraviNovogClana)
            {
                LandingPage lp = new LandingPage();

                lp.Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }

        private void SignUpPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(PraviNovogClana)
            {
                Application.Exit();
            }
        }


        /* Za svrhe lakseg pregledanja funkcionalnosti projekta uradjeno je da korisnik moze da bira 
        da li je admin ili user pri kreiranju novog korisnika */
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            List<Clan> Clanovi = Konekcija.Proxy.SviClanovi("");

            bool validEmail = false;
            bool validUsername = true;

            foreach (char c in tbEmail.Text)
            {
                if (c == '@')
                    validEmail = true;
            }

            if(PraviNovogClana)
            {
                foreach (Clan c in Clanovi)
                {
                    if (c.Email == tbEmail.Text)
                        validEmail = false;
                    if (c.Username == tbKorisnickoIme.Text)
                        validUsername = false;
                }
            }

            if (tbKorisnickoIme.Text == "")
                validUsername = false;


            if (tbIme.Text == "")
            {
                MessageBox.Show("NISTE UNELI IME!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPrezime.Text == "")
            {
                MessageBox.Show("NISTE UNELI PREZIME!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbEmail.Text == "")
            {
                MessageBox.Show("NISTE UNELI EMAIL!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!validEmail)
            {
                MessageBox.Show("NIJE VALIDAN EMAIL!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!validUsername)
            {
                MessageBox.Show("NIJE VALIDNO KORSINICKO IME!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbLozinka.Text != tbPotvrdiLozinku.Text || tbLozinka.Text == "")
            {
                MessageBox.Show("LOZINKE SE NE POKLAPAJU", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                List<Clan> SviClanovi = Konekcija.Proxy.SviClanovi("");
                List<int> indeksi = new List<int>();

                foreach(Clan c in  SviClanovi)
                {
                    indeksi.Add(int.Parse(c.JmbgClana));
                }

                string jmbg = "-1";

                for (int i = 0; i < SviClanovi.Count + 1; i++)
                {
                    if(!indeksi.Contains(i) && jmbg == "-1")
                    {
                        jmbg = i.ToString();
                        break;
                    }

                }

                bool priveledge = false;

                if(rbAdmin.Checked)
                {
                    priveledge = true;
                }

                if(PraviNovogClana)
                {
                    Clan clan = new Clan(jmbg, tbIme.Text, tbPrezime.Text, tbEmail.Text, dateTimePicker1.Value,
                   true, tbKorisnickoIme.Text, tbLozinka.Text, priveledge);

                    Konekcija.Proxy.DodajClana(clan);

                    MessageBox.Show("UPSESNO STE NAPRAVILI NOVOG KORISNIKA", "USPEH", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!clan.Priveledge)
                    {
                        MainPageUser mpu = new MainPageUser(clan);

                        mpu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MainPageAdmin mpa = new MainPageAdmin(clan);

                        mpa.Show();
                        this.Hide();
                    }
                }
                else
                {
                    AktivanClan.Ime = tbIme.Text;
                    AktivanClan.Prezime = tbPrezime.Text;
                    AktivanClan.Email = tbEmail.Text;
                    AktivanClan.DatumRodjenja = dateTimePicker1.Value;
                    AktivanClan.Username = tbKorisnickoIme.Text;
                    AktivanClan.Password = tbLozinka.Text;

                   /* if (rbAdmin.Checked)
                        AktivanClan.Priveledge = true;
                    else
                        AktivanClan.Priveledge = false; */

                    Konekcija.Proxy.IzmeniClana(AktivanClan);

                    MessageBox.Show("USPESNO STE IZMENILI PROFIL", "USPEH", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }
        }
    }
}
