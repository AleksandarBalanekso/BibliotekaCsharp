namespace KlijentForma
{
    partial class DodajKnjigu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblKolicinaUBiblioteci = new System.Windows.Forms.Label();
            this.lblGodinaIzdavanja = new System.Windows.Forms.Label();
            this.btnDodajKnjgu = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbKolicinaUBiblioteci = new System.Windows.Forms.TextBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.cbGodinaIzdavanja = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAutor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKolicinaUBiblioteci, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGodinaIzdavanja, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDodajKnjgu, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNazad, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbKolicinaUBiblioteci, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbGodinaIzdavanja, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbAutor, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(3, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(65, 20);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "NAZIV: ";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(3, 90);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(73, 20);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "AUTOR: ";
            // 
            // lblKolicinaUBiblioteci
            // 
            this.lblKolicinaUBiblioteci.AutoSize = true;
            this.lblKolicinaUBiblioteci.Location = new System.Drawing.Point(3, 180);
            this.lblKolicinaUBiblioteci.Name = "lblKolicinaUBiblioteci";
            this.lblKolicinaUBiblioteci.Size = new System.Drawing.Size(200, 20);
            this.lblKolicinaUBiblioteci.TabIndex = 2;
            this.lblKolicinaUBiblioteci.Text = "KOLICINA U BIBLIOTECI: ";
            // 
            // lblGodinaIzdavanja
            // 
            this.lblGodinaIzdavanja.AutoSize = true;
            this.lblGodinaIzdavanja.Location = new System.Drawing.Point(3, 270);
            this.lblGodinaIzdavanja.Name = "lblGodinaIzdavanja";
            this.lblGodinaIzdavanja.Size = new System.Drawing.Size(175, 20);
            this.lblGodinaIzdavanja.TabIndex = 3;
            this.lblGodinaIzdavanja.Text = "GODINA IZDAVANJA: ";
            // 
            // btnDodajKnjgu
            // 
            this.btnDodajKnjgu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDodajKnjgu.Location = new System.Drawing.Point(92, 363);
            this.btnDodajKnjgu.Name = "btnDodajKnjgu";
            this.btnDodajKnjgu.Size = new System.Drawing.Size(200, 60);
            this.btnDodajKnjgu.TabIndex = 4;
            this.btnDodajKnjgu.Text = "DODAJ KNJIGU";
            this.btnDodajKnjgu.UseVisualStyleBackColor = true;
            this.btnDodajKnjgu.Click += new System.EventHandler(this.btnDodajKnjgu_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNazad.Location = new System.Drawing.Point(477, 363);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(200, 60);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(388, 3);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(379, 26);
            this.tbNaziv.TabIndex = 6;
            // 
            // tbKolicinaUBiblioteci
            // 
            this.tbKolicinaUBiblioteci.Location = new System.Drawing.Point(388, 183);
            this.tbKolicinaUBiblioteci.Name = "tbKolicinaUBiblioteci";
            this.tbKolicinaUBiblioteci.Size = new System.Drawing.Size(160, 26);
            this.tbKolicinaUBiblioteci.TabIndex = 8;
            // 
            // cbAutor
            // 
            this.cbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(388, 93);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(277, 28);
            this.cbAutor.TabIndex = 9;
            // 
            // cbGodinaIzdavanja
            // 
            this.cbGodinaIzdavanja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGodinaIzdavanja.FormattingEnabled = true;
            this.cbGodinaIzdavanja.Location = new System.Drawing.Point(388, 273);
            this.cbGodinaIzdavanja.Name = "cbGodinaIzdavanja";
            this.cbGodinaIzdavanja.Size = new System.Drawing.Size(160, 28);
            this.cbGodinaIzdavanja.TabIndex = 10;
            // 
            // DodajKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DodajKnjigu";
            this.Text = "DodajKnjigu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblKolicinaUBiblioteci;
        private System.Windows.Forms.Label lblGodinaIzdavanja;
        private System.Windows.Forms.Button btnDodajKnjgu;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbKolicinaUBiblioteci;
        private System.Windows.Forms.ComboBox cbGodinaIzdavanja;
        private System.Windows.Forms.ComboBox cbAutor;
    }
}