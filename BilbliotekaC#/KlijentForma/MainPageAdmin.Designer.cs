namespace KlijentForma
{
    partial class MainPageAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDobrodosli = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAdmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPocetna = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSveKnjige = new System.Windows.Forms.Button();
            this.btnSviPisci = new System.Windows.Forms.Button();
            this.btnSvaIznajmljivanja = new System.Windows.Forms.Button();
            this.btnSviClanovi = new System.Windows.Forms.Button();
            this.btnOAutoru = new System.Windows.Forms.Button();
            this.btnMojProfil = new System.Windows.Forms.Button();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.tabKnjige = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.btnIzmeniKnjigu = new System.Windows.Forms.Button();
            this.btnDodajKnjgu = new System.Windows.Forms.Button();
            this.btnPocetnaStrana = new System.Windows.Forms.Button();
            this.btnKnjigePretraga = new System.Windows.Forms.Button();
            this.dgwKnjige = new System.Windows.Forms.DataGridView();
            this.tabPisci = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDodajPisca = new System.Windows.Forms.Button();
            this.btnIzmeniPisca = new System.Windows.Forms.Button();
            this.btnObrisiPisca = new System.Windows.Forms.Button();
            this.btnPretragaPisci = new System.Windows.Forms.Button();
            this.btnPocetnaStranica = new System.Windows.Forms.Button();
            this.dgwPisci = new System.Windows.Forms.DataGridView();
            this.tabIznajmljivanja = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOIznajmljivanju = new System.Windows.Forms.Button();
            this.btnPretragaIznajmljivanja = new System.Windows.Forms.Button();
            this.btnPocetnaStranaIznajmljivanja = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnISvaIznajmljivanja = new System.Windows.Forms.Button();
            this.btnAktivnaIznajmljivanja = new System.Windows.Forms.Button();
            this.dgwIznajmljivanja = new System.Windows.Forms.DataGridView();
            this.tabClanovi = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOClanu = new System.Windows.Forms.Button();
            this.btnPretragaClanovi = new System.Windows.Forms.Button();
            this.btnPocetnaStranaClanovi = new System.Windows.Forms.Button();
            this.dgwClanovi = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPocetna.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabKnjige.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKnjige)).BeginInit();
            this.tabPisci.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPisci)).BeginInit();
            this.tabIznajmljivanja.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIznajmljivanja)).BeginInit();
            this.tabClanovi.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDobrodosli,
            this.lblAdmin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1204, 35);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(116, 28);
            this.lblDobrodosli.Text = "Dobrodosli";
            // 
            // lblAdmin
            // 
            this.lblAdmin.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(69, 28);
            this.lblAdmin.Text = "ADMIN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPocetna);
            this.tabControl1.Controls.Add(this.tabKnjige);
            this.tabControl1.Controls.Add(this.tabPisci);
            this.tabControl1.Controls.Add(this.tabIznajmljivanja);
            this.tabControl1.Controls.Add(this.tabClanovi);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1204, 584);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPocetna
            // 
            this.tabPocetna.Controls.Add(this.tableLayoutPanel1);
            this.tabPocetna.Location = new System.Drawing.Point(4, 29);
            this.tabPocetna.Name = "tabPocetna";
            this.tabPocetna.Padding = new System.Windows.Forms.Padding(3);
            this.tabPocetna.Size = new System.Drawing.Size(1196, 551);
            this.tabPocetna.TabIndex = 0;
            this.tabPocetna.Text = "Pocetna";
            this.tabPocetna.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSveKnjige, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSviPisci, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSvaIznajmljivanja, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSviClanovi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOAutoru, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMojProfil, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOdjaviSe, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1190, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSveKnjige
            // 
            this.btnSveKnjige.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSveKnjige.BackColor = System.Drawing.Color.DarkGray;
            this.btnSveKnjige.Location = new System.Drawing.Point(147, 3);
            this.btnSveKnjige.Name = "btnSveKnjige";
            this.btnSveKnjige.Size = new System.Drawing.Size(300, 80);
            this.btnSveKnjige.TabIndex = 0;
            this.btnSveKnjige.Text = "SVE KNJIGE";
            this.btnSveKnjige.UseVisualStyleBackColor = false;
            this.btnSveKnjige.Click += new System.EventHandler(this.btnSveKnjige_Click);
            // 
            // btnSviPisci
            // 
            this.btnSviPisci.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSviPisci.BackColor = System.Drawing.Color.DarkGray;
            this.btnSviPisci.Location = new System.Drawing.Point(742, 3);
            this.btnSviPisci.Name = "btnSviPisci";
            this.btnSviPisci.Size = new System.Drawing.Size(300, 80);
            this.btnSviPisci.TabIndex = 1;
            this.btnSviPisci.Text = "SVI PISCI";
            this.btnSviPisci.UseVisualStyleBackColor = false;
            this.btnSviPisci.Click += new System.EventHandler(this.btnSviPisci_Click);
            // 
            // btnSvaIznajmljivanja
            // 
            this.btnSvaIznajmljivanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSvaIznajmljivanja.BackColor = System.Drawing.Color.DarkGray;
            this.btnSvaIznajmljivanja.Location = new System.Drawing.Point(147, 139);
            this.btnSvaIznajmljivanja.Name = "btnSvaIznajmljivanja";
            this.btnSvaIznajmljivanja.Size = new System.Drawing.Size(300, 80);
            this.btnSvaIznajmljivanja.TabIndex = 2;
            this.btnSvaIznajmljivanja.Text = "SVA IZNAJMLJIVANJA";
            this.btnSvaIznajmljivanja.UseVisualStyleBackColor = false;
            this.btnSvaIznajmljivanja.Click += new System.EventHandler(this.btnSvaIznajmljivanja_Click);
            // 
            // btnSviClanovi
            // 
            this.btnSviClanovi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSviClanovi.BackColor = System.Drawing.Color.DarkGray;
            this.btnSviClanovi.Location = new System.Drawing.Point(742, 139);
            this.btnSviClanovi.Name = "btnSviClanovi";
            this.btnSviClanovi.Size = new System.Drawing.Size(300, 80);
            this.btnSviClanovi.TabIndex = 3;
            this.btnSviClanovi.Text = "SVI CLANOVI";
            this.btnSviClanovi.UseVisualStyleBackColor = false;
            this.btnSviClanovi.Click += new System.EventHandler(this.btnSviClanovi_Click);
            // 
            // btnOAutoru
            // 
            this.btnOAutoru.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOAutoru.BackColor = System.Drawing.Color.DarkGray;
            this.btnOAutoru.Location = new System.Drawing.Point(147, 275);
            this.btnOAutoru.Name = "btnOAutoru";
            this.btnOAutoru.Size = new System.Drawing.Size(300, 80);
            this.btnOAutoru.TabIndex = 4;
            this.btnOAutoru.Text = "O AUTORU";
            this.btnOAutoru.UseVisualStyleBackColor = false;
            this.btnOAutoru.Click += new System.EventHandler(this.btnOAutoru_Click);
            // 
            // btnMojProfil
            // 
            this.btnMojProfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMojProfil.BackColor = System.Drawing.Color.DarkGray;
            this.btnMojProfil.Location = new System.Drawing.Point(742, 275);
            this.btnMojProfil.Name = "btnMojProfil";
            this.btnMojProfil.Size = new System.Drawing.Size(300, 80);
            this.btnMojProfil.TabIndex = 5;
            this.btnMojProfil.Text = "MOJ PROFIL";
            this.btnMojProfil.UseVisualStyleBackColor = false;
            this.btnMojProfil.Click += new System.EventHandler(this.btnMojProfil_Click);
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdjaviSe.BackColor = System.Drawing.Color.DarkGray;
            this.btnOdjaviSe.Location = new System.Drawing.Point(147, 411);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(300, 80);
            this.btnOdjaviSe.TabIndex = 6;
            this.btnOdjaviSe.Text = "ODJAVI SE";
            this.btnOdjaviSe.UseVisualStyleBackColor = false;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // tabKnjige
            // 
            this.tabKnjige.Controls.Add(this.tableLayoutPanel2);
            this.tabKnjige.Controls.Add(this.dgwKnjige);
            this.tabKnjige.Location = new System.Drawing.Point(4, 29);
            this.tabKnjige.Name = "tabKnjige";
            this.tabKnjige.Padding = new System.Windows.Forms.Padding(3);
            this.tabKnjige.Size = new System.Drawing.Size(1196, 551);
            this.tabKnjige.TabIndex = 1;
            this.tabKnjige.Text = "Knjige";
            this.tabKnjige.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnDodajKnjigu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIzmeniKnjigu, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDodajKnjgu, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnPocetnaStrana, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnKnjigePretraga, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 545);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.BackColor = System.Drawing.Color.DarkGray;
            this.btnDodajKnjigu.Location = new System.Drawing.Point(3, 3);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(300, 80);
            this.btnDodajKnjigu.TabIndex = 0;
            this.btnDodajKnjigu.Text = "DODAJ KNJIGU";
            this.btnDodajKnjigu.UseVisualStyleBackColor = false;
            this.btnDodajKnjigu.Click += new System.EventHandler(this.btnDodajKnjigu_Click);
            // 
            // btnIzmeniKnjigu
            // 
            this.btnIzmeniKnjigu.BackColor = System.Drawing.Color.DarkGray;
            this.btnIzmeniKnjigu.Location = new System.Drawing.Point(3, 112);
            this.btnIzmeniKnjigu.Name = "btnIzmeniKnjigu";
            this.btnIzmeniKnjigu.Size = new System.Drawing.Size(300, 80);
            this.btnIzmeniKnjigu.TabIndex = 1;
            this.btnIzmeniKnjigu.Text = "IZMENI KNJIGU";
            this.btnIzmeniKnjigu.UseVisualStyleBackColor = false;
            this.btnIzmeniKnjigu.Click += new System.EventHandler(this.btnIzmeniKnjigu_Click);
            // 
            // btnDodajKnjgu
            // 
            this.btnDodajKnjgu.BackColor = System.Drawing.Color.DarkGray;
            this.btnDodajKnjgu.Location = new System.Drawing.Point(3, 221);
            this.btnDodajKnjgu.Name = "btnDodajKnjgu";
            this.btnDodajKnjgu.Size = new System.Drawing.Size(300, 80);
            this.btnDodajKnjgu.TabIndex = 4;
            this.btnDodajKnjgu.Text = "OBRISI KNJIGU";
            this.btnDodajKnjgu.UseVisualStyleBackColor = false;
            this.btnDodajKnjgu.Click += new System.EventHandler(this.btnDodajKnjgu_Click);
            // 
            // btnPocetnaStrana
            // 
            this.btnPocetnaStrana.BackColor = System.Drawing.Color.DarkGray;
            this.btnPocetnaStrana.Location = new System.Drawing.Point(3, 439);
            this.btnPocetnaStrana.Name = "btnPocetnaStrana";
            this.btnPocetnaStrana.Size = new System.Drawing.Size(300, 80);
            this.btnPocetnaStrana.TabIndex = 3;
            this.btnPocetnaStrana.Text = "POCETNA STRANA";
            this.btnPocetnaStrana.UseVisualStyleBackColor = false;
            this.btnPocetnaStrana.Click += new System.EventHandler(this.btnPocetnaStrana_Click);
            // 
            // btnKnjigePretraga
            // 
            this.btnKnjigePretraga.BackColor = System.Drawing.Color.DarkGray;
            this.btnKnjigePretraga.Location = new System.Drawing.Point(3, 330);
            this.btnKnjigePretraga.Name = "btnKnjigePretraga";
            this.btnKnjigePretraga.Size = new System.Drawing.Size(300, 80);
            this.btnKnjigePretraga.TabIndex = 5;
            this.btnKnjigePretraga.Text = "PRETRAGA";
            this.btnKnjigePretraga.UseVisualStyleBackColor = false;
            this.btnKnjigePretraga.Click += new System.EventHandler(this.btnKnjigePretraga_Click);
            // 
            // dgwKnjige
            // 
            this.dgwKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKnjige.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwKnjige.Location = new System.Drawing.Point(394, 3);
            this.dgwKnjige.MultiSelect = false;
            this.dgwKnjige.Name = "dgwKnjige";
            this.dgwKnjige.RowHeadersWidth = 62;
            this.dgwKnjige.RowTemplate.Height = 28;
            this.dgwKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKnjige.Size = new System.Drawing.Size(799, 545);
            this.dgwKnjige.TabIndex = 0;
            // 
            // tabPisci
            // 
            this.tabPisci.Controls.Add(this.tableLayoutPanel3);
            this.tabPisci.Controls.Add(this.dgwPisci);
            this.tabPisci.Location = new System.Drawing.Point(4, 29);
            this.tabPisci.Name = "tabPisci";
            this.tabPisci.Size = new System.Drawing.Size(1196, 551);
            this.tabPisci.TabIndex = 2;
            this.tabPisci.Text = "Pisci";
            this.tabPisci.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnDodajPisca, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnIzmeniPisca, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnObrisiPisca, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnPretragaPisci, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnPocetnaStranica, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(371, 551);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnDodajPisca
            // 
            this.btnDodajPisca.BackColor = System.Drawing.Color.DarkGray;
            this.btnDodajPisca.Location = new System.Drawing.Point(3, 3);
            this.btnDodajPisca.Name = "btnDodajPisca";
            this.btnDodajPisca.Size = new System.Drawing.Size(300, 80);
            this.btnDodajPisca.TabIndex = 0;
            this.btnDodajPisca.Text = "DODAJ PISCA";
            this.btnDodajPisca.UseVisualStyleBackColor = false;
            this.btnDodajPisca.Click += new System.EventHandler(this.btnDodajPisca_Click);
            // 
            // btnIzmeniPisca
            // 
            this.btnIzmeniPisca.BackColor = System.Drawing.Color.DarkGray;
            this.btnIzmeniPisca.Location = new System.Drawing.Point(3, 113);
            this.btnIzmeniPisca.Name = "btnIzmeniPisca";
            this.btnIzmeniPisca.Size = new System.Drawing.Size(300, 80);
            this.btnIzmeniPisca.TabIndex = 1;
            this.btnIzmeniPisca.Text = "IZMENI PISCA";
            this.btnIzmeniPisca.UseVisualStyleBackColor = false;
            this.btnIzmeniPisca.Click += new System.EventHandler(this.btnIzmeniPisca_Click);
            // 
            // btnObrisiPisca
            // 
            this.btnObrisiPisca.BackColor = System.Drawing.Color.DarkGray;
            this.btnObrisiPisca.Location = new System.Drawing.Point(3, 223);
            this.btnObrisiPisca.Name = "btnObrisiPisca";
            this.btnObrisiPisca.Size = new System.Drawing.Size(300, 80);
            this.btnObrisiPisca.TabIndex = 2;
            this.btnObrisiPisca.Text = "OBRISI PISCA";
            this.btnObrisiPisca.UseVisualStyleBackColor = false;
            this.btnObrisiPisca.Click += new System.EventHandler(this.btnObrisiPisca_Click);
            // 
            // btnPretragaPisci
            // 
            this.btnPretragaPisci.BackColor = System.Drawing.Color.DarkGray;
            this.btnPretragaPisci.Location = new System.Drawing.Point(3, 333);
            this.btnPretragaPisci.Name = "btnPretragaPisci";
            this.btnPretragaPisci.Size = new System.Drawing.Size(300, 80);
            this.btnPretragaPisci.TabIndex = 3;
            this.btnPretragaPisci.Text = "PRETRAGA";
            this.btnPretragaPisci.UseVisualStyleBackColor = false;
            this.btnPretragaPisci.Click += new System.EventHandler(this.btnPretragaPisci_Click);
            // 
            // btnPocetnaStranica
            // 
            this.btnPocetnaStranica.BackColor = System.Drawing.Color.DarkGray;
            this.btnPocetnaStranica.Location = new System.Drawing.Point(3, 443);
            this.btnPocetnaStranica.Name = "btnPocetnaStranica";
            this.btnPocetnaStranica.Size = new System.Drawing.Size(300, 80);
            this.btnPocetnaStranica.TabIndex = 4;
            this.btnPocetnaStranica.Text = "POCETNA STRANA";
            this.btnPocetnaStranica.UseVisualStyleBackColor = false;
            this.btnPocetnaStranica.Click += new System.EventHandler(this.btnPocetnaStranica_Click);
            // 
            // dgwPisci
            // 
            this.dgwPisci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPisci.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwPisci.Location = new System.Drawing.Point(371, 0);
            this.dgwPisci.MultiSelect = false;
            this.dgwPisci.Name = "dgwPisci";
            this.dgwPisci.RowHeadersWidth = 62;
            this.dgwPisci.RowTemplate.Height = 28;
            this.dgwPisci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPisci.Size = new System.Drawing.Size(825, 551);
            this.dgwPisci.TabIndex = 0;
            // 
            // tabIznajmljivanja
            // 
            this.tabIznajmljivanja.Controls.Add(this.tableLayoutPanel4);
            this.tabIznajmljivanja.Controls.Add(this.dgwIznajmljivanja);
            this.tabIznajmljivanja.Location = new System.Drawing.Point(4, 29);
            this.tabIznajmljivanja.Name = "tabIznajmljivanja";
            this.tabIznajmljivanja.Size = new System.Drawing.Size(1196, 551);
            this.tabIznajmljivanja.TabIndex = 3;
            this.tabIznajmljivanja.Text = "Iznajmljivanja";
            this.tabIznajmljivanja.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnOIznajmljivanju, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPretragaIznajmljivanja, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnPocetnaStranaIznajmljivanja, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(382, 551);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnOIznajmljivanju
            // 
            this.btnOIznajmljivanju.BackColor = System.Drawing.Color.DarkGray;
            this.btnOIznajmljivanju.Location = new System.Drawing.Point(3, 3);
            this.btnOIznajmljivanju.Name = "btnOIznajmljivanju";
            this.btnOIznajmljivanju.Size = new System.Drawing.Size(300, 80);
            this.btnOIznajmljivanju.TabIndex = 0;
            this.btnOIznajmljivanju.Text = "O IZNAJMLJIVAJU";
            this.btnOIznajmljivanju.UseVisualStyleBackColor = false;
            this.btnOIznajmljivanju.Click += new System.EventHandler(this.btnOIznajmljivanju_Click);
            // 
            // btnPretragaIznajmljivanja
            // 
            this.btnPretragaIznajmljivanja.BackColor = System.Drawing.Color.DarkGray;
            this.btnPretragaIznajmljivanja.Location = new System.Drawing.Point(3, 140);
            this.btnPretragaIznajmljivanja.Name = "btnPretragaIznajmljivanja";
            this.btnPretragaIznajmljivanja.Size = new System.Drawing.Size(300, 80);
            this.btnPretragaIznajmljivanja.TabIndex = 1;
            this.btnPretragaIznajmljivanja.Text = "PRETRAGA";
            this.btnPretragaIznajmljivanja.UseVisualStyleBackColor = false;
            this.btnPretragaIznajmljivanja.Click += new System.EventHandler(this.btnPretragaIznajmljivanja_Click);
            // 
            // btnPocetnaStranaIznajmljivanja
            // 
            this.btnPocetnaStranaIznajmljivanja.BackColor = System.Drawing.Color.DarkGray;
            this.btnPocetnaStranaIznajmljivanja.Location = new System.Drawing.Point(3, 277);
            this.btnPocetnaStranaIznajmljivanja.Name = "btnPocetnaStranaIznajmljivanja";
            this.btnPocetnaStranaIznajmljivanja.Size = new System.Drawing.Size(300, 80);
            this.btnPocetnaStranaIznajmljivanja.TabIndex = 2;
            this.btnPocetnaStranaIznajmljivanja.Text = "POCETNA STRANA";
            this.btnPocetnaStranaIznajmljivanja.UseVisualStyleBackColor = false;
            this.btnPocetnaStranaIznajmljivanja.Click += new System.EventHandler(this.btnPocetnaStranaIznajmljivanja_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.BtnISvaIznajmljivanja, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAktivnaIznajmljivanja, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 414);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(376, 134);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // BtnISvaIznajmljivanja
            // 
            this.BtnISvaIznajmljivanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnISvaIznajmljivanja.BackColor = System.Drawing.Color.DarkGray;
            this.BtnISvaIznajmljivanja.Location = new System.Drawing.Point(4, 3);
            this.BtnISvaIznajmljivanja.Name = "BtnISvaIznajmljivanja";
            this.BtnISvaIznajmljivanja.Size = new System.Drawing.Size(180, 70);
            this.BtnISvaIznajmljivanja.TabIndex = 0;
            this.BtnISvaIznajmljivanja.Text = "SVA IZNAJMLJIVANJA";
            this.BtnISvaIznajmljivanja.UseVisualStyleBackColor = false;
            this.BtnISvaIznajmljivanja.Click += new System.EventHandler(this.BtnISvaIznajmljivanja_Click);
            // 
            // btnAktivnaIznajmljivanja
            // 
            this.btnAktivnaIznajmljivanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAktivnaIznajmljivanja.BackColor = System.Drawing.Color.DarkGray;
            this.btnAktivnaIznajmljivanja.Location = new System.Drawing.Point(192, 3);
            this.btnAktivnaIznajmljivanja.Name = "btnAktivnaIznajmljivanja";
            this.btnAktivnaIznajmljivanja.Size = new System.Drawing.Size(180, 70);
            this.btnAktivnaIznajmljivanja.TabIndex = 1;
            this.btnAktivnaIznajmljivanja.Text = "AKTIVNJA IZNAJMLJIVANJA";
            this.btnAktivnaIznajmljivanja.UseVisualStyleBackColor = false;
            this.btnAktivnaIznajmljivanja.Click += new System.EventHandler(this.btnAktivnaIznajmljivanja_Click);
            // 
            // dgwIznajmljivanja
            // 
            this.dgwIznajmljivanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIznajmljivanja.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwIznajmljivanja.Location = new System.Drawing.Point(382, 0);
            this.dgwIznajmljivanja.MultiSelect = false;
            this.dgwIznajmljivanja.Name = "dgwIznajmljivanja";
            this.dgwIznajmljivanja.RowHeadersWidth = 62;
            this.dgwIznajmljivanja.RowTemplate.Height = 28;
            this.dgwIznajmljivanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwIznajmljivanja.Size = new System.Drawing.Size(814, 551);
            this.dgwIznajmljivanja.TabIndex = 0;
            // 
            // tabClanovi
            // 
            this.tabClanovi.Controls.Add(this.tableLayoutPanel6);
            this.tabClanovi.Controls.Add(this.dgwClanovi);
            this.tabClanovi.Location = new System.Drawing.Point(4, 29);
            this.tabClanovi.Name = "tabClanovi";
            this.tabClanovi.Size = new System.Drawing.Size(1196, 551);
            this.tabClanovi.TabIndex = 4;
            this.tabClanovi.Text = "Clanovi";
            this.tabClanovi.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.btnOClanu, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnPretragaClanovi, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnPocetnaStranaClanovi, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(408, 551);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // btnOClanu
            // 
            this.btnOClanu.BackColor = System.Drawing.Color.DarkGray;
            this.btnOClanu.Location = new System.Drawing.Point(3, 3);
            this.btnOClanu.Name = "btnOClanu";
            this.btnOClanu.Size = new System.Drawing.Size(300, 80);
            this.btnOClanu.TabIndex = 0;
            this.btnOClanu.Text = "O CLANU";
            this.btnOClanu.UseVisualStyleBackColor = false;
            this.btnOClanu.Click += new System.EventHandler(this.btnOClanu_Click);
            // 
            // btnPretragaClanovi
            // 
            this.btnPretragaClanovi.BackColor = System.Drawing.Color.DarkGray;
            this.btnPretragaClanovi.Location = new System.Drawing.Point(3, 186);
            this.btnPretragaClanovi.Name = "btnPretragaClanovi";
            this.btnPretragaClanovi.Size = new System.Drawing.Size(300, 80);
            this.btnPretragaClanovi.TabIndex = 1;
            this.btnPretragaClanovi.Text = "PRETRAGA";
            this.btnPretragaClanovi.UseVisualStyleBackColor = false;
            this.btnPretragaClanovi.Click += new System.EventHandler(this.btnPretragaClanovi_Click);
            // 
            // btnPocetnaStranaClanovi
            // 
            this.btnPocetnaStranaClanovi.BackColor = System.Drawing.Color.DarkGray;
            this.btnPocetnaStranaClanovi.Location = new System.Drawing.Point(3, 369);
            this.btnPocetnaStranaClanovi.Name = "btnPocetnaStranaClanovi";
            this.btnPocetnaStranaClanovi.Size = new System.Drawing.Size(300, 80);
            this.btnPocetnaStranaClanovi.TabIndex = 2;
            this.btnPocetnaStranaClanovi.Text = "POCETNA STRANA";
            this.btnPocetnaStranaClanovi.UseVisualStyleBackColor = false;
            this.btnPocetnaStranaClanovi.Click += new System.EventHandler(this.btnPocetnaStranaClanovi_Click);
            // 
            // dgwClanovi
            // 
            this.dgwClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClanovi.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwClanovi.Location = new System.Drawing.Point(408, 0);
            this.dgwClanovi.MultiSelect = false;
            this.dgwClanovi.Name = "dgwClanovi";
            this.dgwClanovi.RowHeadersWidth = 62;
            this.dgwClanovi.RowTemplate.Height = 28;
            this.dgwClanovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwClanovi.Size = new System.Drawing.Size(788, 551);
            this.dgwClanovi.TabIndex = 0;
            // 
            // MainPageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainPageAdmin";
            this.Text = "MainPageAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPageAdmin_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPocetna.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabKnjige.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKnjige)).EndInit();
            this.tabPisci.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPisci)).EndInit();
            this.tabIznajmljivanja.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIznajmljivanja)).EndInit();
            this.tabClanovi.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDobrodosli;
        private System.Windows.Forms.ToolStripStatusLabel lblAdmin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPocetna;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSveKnjige;
        private System.Windows.Forms.Button btnSviPisci;
        private System.Windows.Forms.Button btnSvaIznajmljivanja;
        private System.Windows.Forms.Button btnSviClanovi;
        private System.Windows.Forms.TabPage tabKnjige;
        private System.Windows.Forms.TabPage tabPisci;
        private System.Windows.Forms.TabPage tabIznajmljivanja;
        private System.Windows.Forms.TabPage tabClanovi;
        private System.Windows.Forms.Button btnOAutoru;
        private System.Windows.Forms.Button btnMojProfil;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.DataGridView dgwKnjige;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.Button btnIzmeniKnjigu;
        private System.Windows.Forms.Button btnPocetnaStrana;
        private System.Windows.Forms.Button btnDodajKnjgu;
        private System.Windows.Forms.Button btnKnjigePretraga;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnDodajPisca;
        private System.Windows.Forms.Button btnIzmeniPisca;
        private System.Windows.Forms.Button btnObrisiPisca;
        private System.Windows.Forms.Button btnPretragaPisci;
        private System.Windows.Forms.Button btnPocetnaStranica;
        private System.Windows.Forms.DataGridView dgwPisci;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnOIznajmljivanju;
        private System.Windows.Forms.Button btnPretragaIznajmljivanja;
        private System.Windows.Forms.Button btnPocetnaStranaIznajmljivanja;
        private System.Windows.Forms.DataGridView dgwIznajmljivanja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button BtnISvaIznajmljivanja;
        private System.Windows.Forms.Button btnAktivnaIznajmljivanja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnOClanu;
        private System.Windows.Forms.Button btnPretragaClanovi;
        private System.Windows.Forms.Button btnPocetnaStranaClanovi;
        private System.Windows.Forms.DataGridView dgwClanovi;
    }
}