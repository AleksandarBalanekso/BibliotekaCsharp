namespace KlijentForma
{
    partial class MainPageUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPocetna = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKnjige = new System.Windows.Forms.Button();
            this.btnPisci = new System.Windows.Forms.Button();
            this.btnMojaIznajmljivajna = new System.Windows.Forms.Button();
            this.btnMojProfil = new System.Windows.Forms.Button();
            this.btnOAutoru = new System.Windows.Forms.Button();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDobrodosli = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabKnjige = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOKnjizi = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnPocetnaStrana = new System.Windows.Forms.Button();
            this.dgwKnjige = new System.Windows.Forms.DataGridView();
            this.tabPisci = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOPiscu = new System.Windows.Forms.Button();
            this.btnPretragaPisci = new System.Windows.Forms.Button();
            this.btnPocetnaStranaPisci = new System.Windows.Forms.Button();
            this.dgwPisci = new System.Windows.Forms.DataGridView();
            this.tabIznajmljivanja = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPretragaIznajmljivanja = new System.Windows.Forms.Button();
            this.btnPocetnaStranaIznajmljivanja = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAktivnaIznajmljivanja = new System.Windows.Forms.Button();
            this.btnSvaIznajmljivanja = new System.Windows.Forms.Button();
            this.btnOIznajmljivanju = new System.Windows.Forms.Button();
            this.dgwIznajmljivanja = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPocetna.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPocetna);
            this.tabControl1.Controls.Add(this.tabKnjige);
            this.tabControl1.Controls.Add(this.tabPisci);
            this.tabControl1.Controls.Add(this.tabIznajmljivanja);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1289, 618);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPocetna
            // 
            this.tabPocetna.Controls.Add(this.tableLayoutPanel1);
            this.tabPocetna.Controls.Add(this.statusStrip1);
            this.tabPocetna.Location = new System.Drawing.Point(4, 29);
            this.tabPocetna.Name = "tabPocetna";
            this.tabPocetna.Padding = new System.Windows.Forms.Padding(3);
            this.tabPocetna.Size = new System.Drawing.Size(1281, 585);
            this.tabPocetna.TabIndex = 0;
            this.tabPocetna.Text = "Pocetna";
            this.tabPocetna.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnKnjige, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPisci, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMojaIznajmljivajna, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMojProfil, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOAutoru, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOdjaviSe, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1275, 543);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnKnjige
            // 
            this.btnKnjige.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKnjige.BackColor = System.Drawing.Color.DarkGray;
            this.btnKnjige.Location = new System.Drawing.Point(143, 3);
            this.btnKnjige.Name = "btnKnjige";
            this.btnKnjige.Size = new System.Drawing.Size(350, 80);
            this.btnKnjige.TabIndex = 0;
            this.btnKnjige.Text = "KNJIGE";
            this.btnKnjige.UseVisualStyleBackColor = false;
            this.btnKnjige.Click += new System.EventHandler(this.btnKnjige_Click);
            // 
            // btnPisci
            // 
            this.btnPisci.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPisci.BackColor = System.Drawing.Color.DarkGray;
            this.btnPisci.Location = new System.Drawing.Point(781, 3);
            this.btnPisci.Name = "btnPisci";
            this.btnPisci.Size = new System.Drawing.Size(350, 80);
            this.btnPisci.TabIndex = 1;
            this.btnPisci.Text = "PISCI";
            this.btnPisci.UseVisualStyleBackColor = false;
            this.btnPisci.Click += new System.EventHandler(this.btnPisci_Click);
            // 
            // btnMojaIznajmljivajna
            // 
            this.btnMojaIznajmljivajna.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMojaIznajmljivajna.BackColor = System.Drawing.Color.DarkGray;
            this.btnMojaIznajmljivajna.Location = new System.Drawing.Point(143, 183);
            this.btnMojaIznajmljivajna.Name = "btnMojaIznajmljivajna";
            this.btnMojaIznajmljivajna.Size = new System.Drawing.Size(350, 80);
            this.btnMojaIznajmljivajna.TabIndex = 2;
            this.btnMojaIznajmljivajna.Text = "MOJA IZNAJMLJIVANJA";
            this.btnMojaIznajmljivajna.UseVisualStyleBackColor = false;
            this.btnMojaIznajmljivajna.Click += new System.EventHandler(this.btnMojaIznajmljivajna_Click);
            // 
            // btnMojProfil
            // 
            this.btnMojProfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMojProfil.BackColor = System.Drawing.Color.DarkGray;
            this.btnMojProfil.Location = new System.Drawing.Point(781, 183);
            this.btnMojProfil.Name = "btnMojProfil";
            this.btnMojProfil.Size = new System.Drawing.Size(350, 80);
            this.btnMojProfil.TabIndex = 3;
            this.btnMojProfil.Text = "MOJ PROFIL";
            this.btnMojProfil.UseVisualStyleBackColor = false;
            this.btnMojProfil.Click += new System.EventHandler(this.btnMojProfil_Click);
            // 
            // btnOAutoru
            // 
            this.btnOAutoru.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOAutoru.BackColor = System.Drawing.Color.DarkGray;
            this.btnOAutoru.Location = new System.Drawing.Point(143, 363);
            this.btnOAutoru.Name = "btnOAutoru";
            this.btnOAutoru.Size = new System.Drawing.Size(350, 80);
            this.btnOAutoru.TabIndex = 4;
            this.btnOAutoru.Text = "O AUTORU";
            this.btnOAutoru.UseVisualStyleBackColor = false;
            this.btnOAutoru.Click += new System.EventHandler(this.btnOAutoru_Click);
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdjaviSe.BackColor = System.Drawing.Color.DarkGray;
            this.btnOdjaviSe.Location = new System.Drawing.Point(781, 363);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(350, 80);
            this.btnOdjaviSe.TabIndex = 5;
            this.btnOdjaviSe.Text = "ODJAVI SE";
            this.btnOdjaviSe.UseVisualStyleBackColor = false;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDobrodosli});
            this.statusStrip1.Location = new System.Drawing.Point(3, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1275, 36);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(126, 29);
            this.lblDobrodosli.Text = "Dobrodosli";
            // 
            // tabKnjige
            // 
            this.tabKnjige.Controls.Add(this.tableLayoutPanel2);
            this.tabKnjige.Controls.Add(this.dgwKnjige);
            this.tabKnjige.Location = new System.Drawing.Point(4, 29);
            this.tabKnjige.Name = "tabKnjige";
            this.tabKnjige.Padding = new System.Windows.Forms.Padding(3);
            this.tabKnjige.Size = new System.Drawing.Size(1281, 585);
            this.tabKnjige.TabIndex = 1;
            this.tabKnjige.Text = "Knijge";
            this.tabKnjige.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnOKnjizi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPretraga, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnPocetnaStrana, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(488, 579);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnOKnjizi
            // 
            this.btnOKnjizi.BackColor = System.Drawing.Color.DarkGray;
            this.btnOKnjizi.Location = new System.Drawing.Point(3, 3);
            this.btnOKnjizi.Name = "btnOKnjizi";
            this.btnOKnjizi.Size = new System.Drawing.Size(300, 80);
            this.btnOKnjizi.TabIndex = 0;
            this.btnOKnjizi.Text = "O KNJIZI";
            this.btnOKnjizi.UseVisualStyleBackColor = false;
            this.btnOKnjizi.Click += new System.EventHandler(this.btnOKnjizi_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.Color.DarkGray;
            this.btnPretraga.Location = new System.Drawing.Point(3, 195);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(300, 80);
            this.btnPretraga.TabIndex = 1;
            this.btnPretraga.Text = "PRETRAGA";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnPocetnaStrana
            // 
            this.btnPocetnaStrana.BackColor = System.Drawing.Color.DarkGray;
            this.btnPocetnaStrana.Location = new System.Drawing.Point(3, 387);
            this.btnPocetnaStrana.Name = "btnPocetnaStrana";
            this.btnPocetnaStrana.Size = new System.Drawing.Size(300, 80);
            this.btnPocetnaStrana.TabIndex = 2;
            this.btnPocetnaStrana.Text = "POCETNA STRANA";
            this.btnPocetnaStrana.UseVisualStyleBackColor = false;
            this.btnPocetnaStrana.Click += new System.EventHandler(this.btnPocetnaStrana_Click);
            // 
            // dgwKnjige
            // 
            this.dgwKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKnjige.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwKnjige.Location = new System.Drawing.Point(491, 3);
            this.dgwKnjige.MultiSelect = false;
            this.dgwKnjige.Name = "dgwKnjige";
            this.dgwKnjige.RowHeadersWidth = 62;
            this.dgwKnjige.RowTemplate.Height = 28;
            this.dgwKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKnjige.Size = new System.Drawing.Size(787, 579);
            this.dgwKnjige.TabIndex = 0;
            this.dgwKnjige.Click += new System.EventHandler(this.dgwKnjige_Click);
            this.dgwKnjige.DoubleClick += new System.EventHandler(this.dgwKnjige_DoubleClick);
            // 
            // tabPisci
            // 
            this.tabPisci.Controls.Add(this.tableLayoutPanel3);
            this.tabPisci.Controls.Add(this.dgwPisci);
            this.tabPisci.Location = new System.Drawing.Point(4, 29);
            this.tabPisci.Name = "tabPisci";
            this.tabPisci.Size = new System.Drawing.Size(1281, 585);
            this.tabPisci.TabIndex = 2;
            this.tabPisci.Text = "Pisci";
            this.tabPisci.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnOPiscu, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPretragaPisci, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnPocetnaStranaPisci, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(504, 585);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnOPiscu
            // 
            this.btnOPiscu.BackColor = System.Drawing.Color.DarkGray;
            this.btnOPiscu.Location = new System.Drawing.Point(3, 3);
            this.btnOPiscu.Name = "btnOPiscu";
            this.btnOPiscu.Size = new System.Drawing.Size(300, 80);
            this.btnOPiscu.TabIndex = 0;
            this.btnOPiscu.Text = "O PISCU ";
            this.btnOPiscu.UseVisualStyleBackColor = false;
            this.btnOPiscu.Click += new System.EventHandler(this.btnOPiscu_Click);
            // 
            // btnPretragaPisci
            // 
            this.btnPretragaPisci.BackColor = System.Drawing.Color.DarkGray;
            this.btnPretragaPisci.Location = new System.Drawing.Point(3, 197);
            this.btnPretragaPisci.Name = "btnPretragaPisci";
            this.btnPretragaPisci.Size = new System.Drawing.Size(300, 80);
            this.btnPretragaPisci.TabIndex = 1;
            this.btnPretragaPisci.Text = "PRETRAGA";
            this.btnPretragaPisci.UseVisualStyleBackColor = false;
            this.btnPretragaPisci.Click += new System.EventHandler(this.btnPretragaPisci_Click);
            // 
            // btnPocetnaStranaPisci
            // 
            this.btnPocetnaStranaPisci.BackColor = System.Drawing.Color.DarkGray;
            this.btnPocetnaStranaPisci.Location = new System.Drawing.Point(3, 391);
            this.btnPocetnaStranaPisci.Name = "btnPocetnaStranaPisci";
            this.btnPocetnaStranaPisci.Size = new System.Drawing.Size(300, 80);
            this.btnPocetnaStranaPisci.TabIndex = 2;
            this.btnPocetnaStranaPisci.Text = "POCETNA STRANA";
            this.btnPocetnaStranaPisci.UseVisualStyleBackColor = false;
            this.btnPocetnaStranaPisci.Click += new System.EventHandler(this.btnPocetnaStranaPisci_Click);
            // 
            // dgwPisci
            // 
            this.dgwPisci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPisci.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwPisci.Location = new System.Drawing.Point(504, 0);
            this.dgwPisci.MultiSelect = false;
            this.dgwPisci.Name = "dgwPisci";
            this.dgwPisci.RowHeadersWidth = 62;
            this.dgwPisci.RowTemplate.Height = 28;
            this.dgwPisci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPisci.Size = new System.Drawing.Size(777, 585);
            this.dgwPisci.TabIndex = 0;
            // 
            // tabIznajmljivanja
            // 
            this.tabIznajmljivanja.Controls.Add(this.tableLayoutPanel4);
            this.tabIznajmljivanja.Controls.Add(this.dgwIznajmljivanja);
            this.tabIznajmljivanja.Location = new System.Drawing.Point(4, 29);
            this.tabIznajmljivanja.Name = "tabIznajmljivanja";
            this.tabIznajmljivanja.Size = new System.Drawing.Size(1281, 585);
            this.tabIznajmljivanja.TabIndex = 3;
            this.tabIznajmljivanja.Text = "Moja Iznajmljivajna";
            this.tabIznajmljivanja.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnPretragaIznajmljivanja, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnPocetnaStranaIznajmljivanja, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnOIznajmljivanju, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(512, 585);
            this.tableLayoutPanel4.TabIndex = 1;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // btnPretragaIznajmljivanja
            // 
            this.btnPretragaIznajmljivanja.BackColor = System.Drawing.Color.DarkGray;
            this.btnPretragaIznajmljivanja.Location = new System.Drawing.Point(3, 149);
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
            this.btnPocetnaStranaIznajmljivanja.Location = new System.Drawing.Point(3, 295);
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
            this.tableLayoutPanel5.Controls.Add(this.btnAktivnaIznajmljivanja, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSvaIznajmljivanja, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 441);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(506, 141);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // btnAktivnaIznajmljivanja
            // 
            this.btnAktivnaIznajmljivanja.BackColor = System.Drawing.Color.DarkGray;
            this.btnAktivnaIznajmljivanja.Location = new System.Drawing.Point(3, 3);
            this.btnAktivnaIznajmljivanja.Name = "btnAktivnaIznajmljivanja";
            this.btnAktivnaIznajmljivanja.Size = new System.Drawing.Size(200, 60);
            this.btnAktivnaIznajmljivanja.TabIndex = 0;
            this.btnAktivnaIznajmljivanja.Text = "AKTIVNA IZNAJMLJIVANJA";
            this.btnAktivnaIznajmljivanja.UseVisualStyleBackColor = false;
            this.btnAktivnaIznajmljivanja.Click += new System.EventHandler(this.btnAktivnaIznajmljivanja_Click);
            // 
            // btnSvaIznajmljivanja
            // 
            this.btnSvaIznajmljivanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSvaIznajmljivanja.BackColor = System.Drawing.Color.DarkGray;
            this.btnSvaIznajmljivanja.Location = new System.Drawing.Point(303, 3);
            this.btnSvaIznajmljivanja.Name = "btnSvaIznajmljivanja";
            this.btnSvaIznajmljivanja.Size = new System.Drawing.Size(200, 60);
            this.btnSvaIznajmljivanja.TabIndex = 1;
            this.btnSvaIznajmljivanja.Text = "SVA IZNAJMLJIVAJA";
            this.btnSvaIznajmljivanja.UseVisualStyleBackColor = false;
            this.btnSvaIznajmljivanja.Click += new System.EventHandler(this.btnSvaIznajmljivanja_Click);
            // 
            // btnOIznajmljivanju
            // 
            this.btnOIznajmljivanju.BackColor = System.Drawing.Color.DarkGray;
            this.btnOIznajmljivanju.Location = new System.Drawing.Point(3, 3);
            this.btnOIznajmljivanju.Name = "btnOIznajmljivanju";
            this.btnOIznajmljivanju.Size = new System.Drawing.Size(300, 80);
            this.btnOIznajmljivanju.TabIndex = 4;
            this.btnOIznajmljivanju.Text = "O IZNAJMLJIVANJU";
            this.btnOIznajmljivanju.UseVisualStyleBackColor = false;
            this.btnOIznajmljivanju.Click += new System.EventHandler(this.btnOIznajmljivanju_Click);
            // 
            // dgwIznajmljivanja
            // 
            this.dgwIznajmljivanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIznajmljivanja.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwIznajmljivanja.Location = new System.Drawing.Point(512, 0);
            this.dgwIznajmljivanja.MultiSelect = false;
            this.dgwIznajmljivanja.Name = "dgwIznajmljivanja";
            this.dgwIznajmljivanja.RowHeadersWidth = 62;
            this.dgwIznajmljivanja.RowTemplate.Height = 28;
            this.dgwIznajmljivanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwIznajmljivanja.Size = new System.Drawing.Size(769, 585);
            this.dgwIznajmljivanja.TabIndex = 0;
            // 
            // MainPageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 618);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainPageUser";
            this.Text = "MainPaigeUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPaigeUser_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPocetna.ResumeLayout(false);
            this.tabPocetna.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPocetna;
        private System.Windows.Forms.TabPage tabKnjige;
        private System.Windows.Forms.TabPage tabPisci;
        private System.Windows.Forms.TabPage tabIznajmljivanja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDobrodosli;
        private System.Windows.Forms.Button btnKnjige;
        private System.Windows.Forms.Button btnPisci;
        private System.Windows.Forms.Button btnMojaIznajmljivajna;
        private System.Windows.Forms.Button btnMojProfil;
        private System.Windows.Forms.Button btnOAutoru;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOKnjizi;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnPocetnaStrana;
        private System.Windows.Forms.DataGridView dgwKnjige;
        private System.Windows.Forms.DataGridView dgwPisci;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnOPiscu;
        private System.Windows.Forms.Button btnPretragaPisci;
        private System.Windows.Forms.Button btnPocetnaStranaPisci;
        private System.Windows.Forms.DataGridView dgwIznajmljivanja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnPretragaIznajmljivanja;
        private System.Windows.Forms.Button btnPocetnaStranaIznajmljivanja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnAktivnaIznajmljivanja;
        private System.Windows.Forms.Button btnSvaIznajmljivanja;
        private System.Windows.Forms.Button btnOIznajmljivanju;
    }
}