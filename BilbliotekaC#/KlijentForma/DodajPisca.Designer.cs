namespace KlijentForma
{
    partial class DodajPisca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPisca = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbIme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPrezime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatumRodjenja, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDodajPisca, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNazad, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PREZIME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATUM RODJENJA:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(402, 3);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(394, 26);
            this.tbIme.TabIndex = 3;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(402, 101);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(394, 26);
            this.tbPrezime.TabIndex = 4;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(402, 199);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(394, 26);
            this.dtpDatumRodjenja.TabIndex = 5;
            // 
            // btnDodajPisca
            // 
            this.btnDodajPisca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDodajPisca.Location = new System.Drawing.Point(74, 297);
            this.btnDodajPisca.Name = "btnDodajPisca";
            this.btnDodajPisca.Size = new System.Drawing.Size(250, 70);
            this.btnDodajPisca.TabIndex = 6;
            this.btnDodajPisca.Text = "DODAJ PISCA";
            this.btnDodajPisca.UseVisualStyleBackColor = true;
            this.btnDodajPisca.Click += new System.EventHandler(this.btnDodajPisca_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNazad.Location = new System.Drawing.Point(474, 297);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(250, 70);
            this.btnNazad.TabIndex = 7;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // DodajPisca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 393);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DodajPisca";
            this.Text = "DodajPisca";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Button btnDodajPisca;
        private System.Windows.Forms.Button btnNazad;
    }
}