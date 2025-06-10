namespace KlijentForma
{
    partial class OPiscu
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
            this.lblJmbg = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.btnSvaDela = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.tbJmbg = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbDatumRodjenja = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblJmbg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIme, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrezime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDatumRodjenja, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSvaDela, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNazad, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbJmbg, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbIme, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPrezime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbDatumRodjenja, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 572);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(3, 0);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(58, 20);
            this.lblJmbg.TabIndex = 0;
            this.lblJmbg.Text = "JMBG:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(3, 114);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(46, 20);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "IME: ";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(3, 228);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(85, 20);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "PREZIME:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(3, 342);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(155, 20);
            this.lblDatumRodjenja.TabIndex = 3;
            this.lblDatumRodjenja.Text = "DATUM RODJENJA";
            // 
            // btnSvaDela
            // 
            this.btnSvaDela.Location = new System.Drawing.Point(3, 459);
            this.btnSvaDela.Name = "btnSvaDela";
            this.btnSvaDela.Size = new System.Drawing.Size(200, 70);
            this.btnSvaDela.TabIndex = 4;
            this.btnSvaDela.Text = "SVA DELA";
            this.btnSvaDela.UseVisualStyleBackColor = true;
            this.btnSvaDela.Click += new System.EventHandler(this.btnSvaDela_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNazad.Location = new System.Drawing.Point(398, 459);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(200, 70);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // tbJmbg
            // 
            this.tbJmbg.Location = new System.Drawing.Point(303, 3);
            this.tbJmbg.Name = "tbJmbg";
            this.tbJmbg.ReadOnly = true;
            this.tbJmbg.Size = new System.Drawing.Size(295, 26);
            this.tbJmbg.TabIndex = 6;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(303, 117);
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            this.tbIme.Size = new System.Drawing.Size(295, 26);
            this.tbIme.TabIndex = 7;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(303, 231);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.ReadOnly = true;
            this.tbPrezime.Size = new System.Drawing.Size(295, 26);
            this.tbPrezime.TabIndex = 8;
            // 
            // tbDatumRodjenja
            // 
            this.tbDatumRodjenja.Location = new System.Drawing.Point(303, 345);
            this.tbDatumRodjenja.Name = "tbDatumRodjenja";
            this.tbDatumRodjenja.ReadOnly = true;
            this.tbDatumRodjenja.Size = new System.Drawing.Size(295, 26);
            this.tbDatumRodjenja.TabIndex = 9;
            // 
            // OPiscu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 572);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OPiscu";
            this.Text = "OPiscu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Button btnSvaDela;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.TextBox tbJmbg;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbDatumRodjenja;
    }
}