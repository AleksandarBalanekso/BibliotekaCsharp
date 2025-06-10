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
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Leave(object sender, EventArgs e)
        {

        }

        private void LogInPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Clan ActiveClan = LogIn(tbUsername.Text, tbPassword.Text, Konekcija.Proxy);

            if (ActiveClan.JmbgClana == "-1")
            { 
               MessageBox.Show("POGRESNO KORISNICKO IME ILI LOZINKA", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Kad se uradi main paige ovo ce pozivati to
            //treba proveriti jel admin ili user
            //Treba skontati kako da prosledim aktivnog usera u mainPaige

            else
            {
               /* MessageBox.Show("USPESNO STE SE ULOGVALI!", "USPEH", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LandingPage lp = new LandingPage();

                lp.Show();
                this.Hide(); */

                if (!ActiveClan.Priveledge)
                {
                    MainPageUser mpu = new MainPageUser(ActiveClan);

                    mpu.Show();
                    this.Hide();
                }
                else
                {
                    MainPageAdmin mpa = new MainPageAdmin(ActiveClan);

                    mpa.Show();
                    this.Hide();
                }
            }

        }

        public Clan LogIn(string username, string password, IBiblioteka proxy)
        {
            string SelectUslovUsername = string.Format("where username = '{0}' and password = '{1}'", username, password);
            string SelectUslovEmail = string.Format("where email = '{0}' and password = '{1}'", username, password);

            List<Clan> clanoviUsername = proxy.SviClanovi(SelectUslovUsername);
            List<Clan> clanoviEmail = proxy.SviClanovi(SelectUslovEmail);

            if (clanoviUsername.Count > 0)
                return clanoviUsername[0];

            if (clanoviEmail.Count > 0)
                return clanoviEmail[0];

            return new Clan();
        }
        private void LogInPage_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LandingPage lp = new LandingPage();

            lp.Show();
            this.Hide();
        }
    }
}
