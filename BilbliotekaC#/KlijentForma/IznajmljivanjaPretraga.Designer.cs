namespace KlijentForma
{
    partial class IznajmljivanjaPretraga
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
            this.lblPretraga = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.btnPretragaPoIdu = new System.Windows.Forms.Button();
            this.btnPretragaPoNazivu = new System.Windows.Forms.Button();
            this.rbAktivnaIznajmljivanja = new System.Windows.Forms.RadioButton();
            this.rbSvaIznajmljivanja = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPretragaPoIdu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPretragaPoNazivu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbAktivnaIznajmljivanja, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbSvaIznajmljivanja, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 149);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(12, 18);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(102, 20);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "PRETRAGA:";
            this.lblPretraga.Click += new System.EventHandler(this.lblPretraga_Click);
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPretraga.Location = new System.Drawing.Point(120, 12);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(668, 26);
            this.tbPretraga.TabIndex = 2;
            // 
            // btnPretragaPoIdu
            // 
            this.btnPretragaPoIdu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPretragaPoIdu.Location = new System.Drawing.Point(75, 3);
            this.btnPretragaPoIdu.Name = "btnPretragaPoIdu";
            this.btnPretragaPoIdu.Size = new System.Drawing.Size(250, 70);
            this.btnPretragaPoIdu.TabIndex = 0;
            this.btnPretragaPoIdu.Text = "PRETRAGA PO ID-U PRETRAGE";
            this.btnPretragaPoIdu.UseVisualStyleBackColor = true;
            this.btnPretragaPoIdu.Click += new System.EventHandler(this.btnPretragaPoIdu_Click);
            // 
            // btnPretragaPoNazivu
            // 
            this.btnPretragaPoNazivu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPretragaPoNazivu.Location = new System.Drawing.Point(475, 3);
            this.btnPretragaPoNazivu.Name = "btnPretragaPoNazivu";
            this.btnPretragaPoNazivu.Size = new System.Drawing.Size(250, 70);
            this.btnPretragaPoNazivu.TabIndex = 1;
            this.btnPretragaPoNazivu.Text = "PRETRAGA PO NAZIVU KNJIGE";
            this.btnPretragaPoNazivu.UseVisualStyleBackColor = true;
            this.btnPretragaPoNazivu.Click += new System.EventHandler(this.btnPretragaPoNazivu_Click);
            // 
            // rbAktivnaIznajmljivanja
            // 
            this.rbAktivnaIznajmljivanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbAktivnaIznajmljivanja.AutoSize = true;
            this.rbAktivnaIznajmljivanja.Location = new System.Drawing.Point(108, 153);
            this.rbAktivnaIznajmljivanja.Name = "rbAktivnaIznajmljivanja";
            this.rbAktivnaIznajmljivanja.Size = new System.Drawing.Size(183, 24);
            this.rbAktivnaIznajmljivanja.TabIndex = 2;
            this.rbAktivnaIznajmljivanja.TabStop = true;
            this.rbAktivnaIznajmljivanja.Text = "Aktivna Iznajmljivanja";
            this.rbAktivnaIznajmljivanja.UseVisualStyleBackColor = true;
            // 
            // rbSvaIznajmljivanja
            // 
            this.rbSvaIznajmljivanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbSvaIznajmljivanja.AutoSize = true;
            this.rbSvaIznajmljivanja.Location = new System.Drawing.Point(521, 153);
            this.rbSvaIznajmljivanja.Name = "rbSvaIznajmljivanja";
            this.rbSvaIznajmljivanja.Size = new System.Drawing.Size(158, 24);
            this.rbSvaIznajmljivanja.TabIndex = 3;
            this.rbSvaIznajmljivanja.TabStop = true;
            this.rbSvaIznajmljivanja.Text = "Sva Iznajmljivanja";
            this.rbSvaIznajmljivanja.UseVisualStyleBackColor = true;
            // 
            // IznajmljivanjaPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IznajmljivanjaPretraga";
            this.Text = "IznajmljivanjaPretraga";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Button btnPretragaPoIdu;
        private System.Windows.Forms.Button btnPretragaPoNazivu;
        private System.Windows.Forms.RadioButton rbAktivnaIznajmljivanja;
        private System.Windows.Forms.RadioButton rbSvaIznajmljivanja;
    }
}