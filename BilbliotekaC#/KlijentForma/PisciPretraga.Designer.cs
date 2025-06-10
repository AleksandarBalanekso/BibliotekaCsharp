namespace KlijentForma
{
    partial class PisciPretraga
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
            this.btnPretragaPoJmbgu = new System.Windows.Forms.Button();
            this.btnPretragaPoImenu = new System.Windows.Forms.Button();
            this.btnPretragaPoPrezimenu = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.btnPretragaPoJmbgu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPretragaPoImenu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPretragaPoPrezimenu, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 194);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 256);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPretragaPoJmbgu
            // 
            this.btnPretragaPoJmbgu.Location = new System.Drawing.Point(3, 3);
            this.btnPretragaPoJmbgu.Name = "btnPretragaPoJmbgu";
            this.btnPretragaPoJmbgu.Size = new System.Drawing.Size(200, 60);
            this.btnPretragaPoJmbgu.TabIndex = 0;
            this.btnPretragaPoJmbgu.Text = "PRETRAGA PO JMBG-U";
            this.btnPretragaPoJmbgu.UseVisualStyleBackColor = true;
            this.btnPretragaPoJmbgu.Click += new System.EventHandler(this.btnPretragaPoJmbgu_Click);
            // 
            // btnPretragaPoImenu
            // 
            this.btnPretragaPoImenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPretragaPoImenu.Location = new System.Drawing.Point(299, 3);
            this.btnPretragaPoImenu.Name = "btnPretragaPoImenu";
            this.btnPretragaPoImenu.Size = new System.Drawing.Size(200, 60);
            this.btnPretragaPoImenu.TabIndex = 1;
            this.btnPretragaPoImenu.Text = "PRETRAGA PO IMENU";
            this.btnPretragaPoImenu.UseVisualStyleBackColor = true;
            this.btnPretragaPoImenu.Click += new System.EventHandler(this.btnPretragaPoImenu_Click);
            // 
            // btnPretragaPoPrezimenu
            // 
            this.btnPretragaPoPrezimenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPretragaPoPrezimenu.Location = new System.Drawing.Point(597, 3);
            this.btnPretragaPoPrezimenu.Name = "btnPretragaPoPrezimenu";
            this.btnPretragaPoPrezimenu.Size = new System.Drawing.Size(200, 60);
            this.btnPretragaPoPrezimenu.TabIndex = 2;
            this.btnPretragaPoPrezimenu.Text = "PRETRAGA PO PREZIMENU";
            this.btnPretragaPoPrezimenu.UseVisualStyleBackColor = true;
            this.btnPretragaPoPrezimenu.Click += new System.EventHandler(this.btnPretragaPoPrezimenu_Click);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(-1, -2);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(106, 20);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "PRETRAGA: ";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPretraga.Location = new System.Drawing.Point(132, -2);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(668, 26);
            this.tbPretraga.TabIndex = 2;
            // 
            // PisciPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PisciPretraga";
            this.Text = "PisciPretraga";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPretragaPoJmbgu;
        private System.Windows.Forms.Button btnPretragaPoImenu;
        private System.Windows.Forms.Button btnPretragaPoPrezimenu;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox tbPretraga;
    }
}