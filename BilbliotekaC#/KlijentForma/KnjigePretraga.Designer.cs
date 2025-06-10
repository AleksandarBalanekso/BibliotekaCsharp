namespace KlijentForma
{
    partial class KnjigePretraga
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
            this.btnPretragaId = new System.Windows.Forms.Button();
            this.btnPretragaNaziv = new System.Windows.Forms.Button();
            this.btnPretragaPisac = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Controls.Add(this.btnPretragaId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPretragaNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPretragaPisac, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 194);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 256);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(-4, -1);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(102, 20);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "PRETRAGA:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPretraga.Location = new System.Drawing.Point(146, -1);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(654, 26);
            this.tbPretraga.TabIndex = 2;
            // 
            // btnPretragaId
            // 
            this.btnPretragaId.Location = new System.Drawing.Point(3, 3);
            this.btnPretragaId.Name = "btnPretragaId";
            this.btnPretragaId.Size = new System.Drawing.Size(200, 60);
            this.btnPretragaId.TabIndex = 0;
            this.btnPretragaId.Text = "PRETRAGA PO ID-U";
            this.btnPretragaId.UseVisualStyleBackColor = true;
            this.btnPretragaId.Click += new System.EventHandler(this.btnPretragaId_Click);
            // 
            // btnPretragaNaziv
            // 
            this.btnPretragaNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPretragaNaziv.Location = new System.Drawing.Point(299, 3);
            this.btnPretragaNaziv.Name = "btnPretragaNaziv";
            this.btnPretragaNaziv.Size = new System.Drawing.Size(200, 60);
            this.btnPretragaNaziv.TabIndex = 1;
            this.btnPretragaNaziv.Text = "PRETRAGA PO NAZIVU";
            this.btnPretragaNaziv.UseVisualStyleBackColor = true;
            this.btnPretragaNaziv.Click += new System.EventHandler(this.btnPretragaNaziv_Click);
            // 
            // btnPretragaPisac
            // 
            this.btnPretragaPisac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPretragaPisac.Location = new System.Drawing.Point(597, 3);
            this.btnPretragaPisac.Name = "btnPretragaPisac";
            this.btnPretragaPisac.Size = new System.Drawing.Size(200, 60);
            this.btnPretragaPisac.TabIndex = 2;
            this.btnPretragaPisac.Text = "PRETRAGA PO ID-U PISCA";
            this.btnPretragaPisac.UseVisualStyleBackColor = true;
            this.btnPretragaPisac.Click += new System.EventHandler(this.btnPretragaPisac_Click);
            // 
            // KnjigePretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KnjigePretraga";
            this.Text = "KnjigePretraga";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPretragaId;
        private System.Windows.Forms.Button btnPretragaNaziv;
        private System.Windows.Forms.Button btnPretragaPisac;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox tbPretraga;
    }
}