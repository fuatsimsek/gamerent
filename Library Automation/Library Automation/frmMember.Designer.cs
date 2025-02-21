namespace Library_Automation
{
    partial class frmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMember));
            this.btnMagaza = new System.Windows.Forms.Button();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.btnProfilim = new System.Windows.Forms.Button();
            this.btnKutuphane = new System.Windows.Forms.Button();
            this.gbMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMagaza
            // 
            this.btnMagaza.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMagaza.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagaza.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMagaza.Location = new System.Drawing.Point(6, 21);
            this.btnMagaza.Name = "btnMagaza";
            this.btnMagaza.Size = new System.Drawing.Size(253, 88);
            this.btnMagaza.TabIndex = 47;
            this.btnMagaza.Text = "Mağaza";
            this.btnMagaza.UseVisualStyleBackColor = false;
            this.btnMagaza.Click += new System.EventHandler(this.btnMagaza_Click);
            // 
            // gbMember
            // 
            this.gbMember.BackgroundImage = global::Library_Automation.Properties.Resources.background;
            this.gbMember.Controls.Add(this.btnCikis);
            this.gbMember.Controls.Add(this.btnBakiye);
            this.gbMember.Controls.Add(this.btnProfilim);
            this.gbMember.Controls.Add(this.btnKutuphane);
            this.gbMember.Controls.Add(this.btnMagaza);
            this.gbMember.Location = new System.Drawing.Point(12, 36);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(265, 535);
            this.gbMember.TabIndex = 48;
            this.gbMember.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCikis.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCikis.Location = new System.Drawing.Point(6, 422);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(253, 82);
            this.btnCikis.TabIndex = 51;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBakiye.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBakiye.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBakiye.Location = new System.Drawing.Point(6, 326);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(253, 82);
            this.btnBakiye.TabIndex = 50;
            this.btnBakiye.Text = "Bakiye";
            this.btnBakiye.UseVisualStyleBackColor = false;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // btnProfilim
            // 
            this.btnProfilim.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProfilim.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilim.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProfilim.Location = new System.Drawing.Point(6, 225);
            this.btnProfilim.Name = "btnProfilim";
            this.btnProfilim.Size = new System.Drawing.Size(253, 82);
            this.btnProfilim.TabIndex = 49;
            this.btnProfilim.Text = "Profilim";
            this.btnProfilim.UseVisualStyleBackColor = false;
            this.btnProfilim.Click += new System.EventHandler(this.btnProfilim_Click);
            // 
            // btnKutuphane
            // 
            this.btnKutuphane.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKutuphane.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKutuphane.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnKutuphane.Location = new System.Drawing.Point(6, 123);
            this.btnKutuphane.Name = "btnKutuphane";
            this.btnKutuphane.Size = new System.Drawing.Size(253, 82);
            this.btnKutuphane.TabIndex = 48;
            this.btnKutuphane.Text = "Kütüphane";
            this.btnKutuphane.UseVisualStyleBackColor = false;
            this.btnKutuphane.Click += new System.EventHandler(this.btnKutuphane_Click);
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Automation.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1449, 652);
            this.Controls.Add(this.gbMember);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameRent";
            this.Load += new System.EventHandler(this.frmMember_Load);
            this.gbMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMagaza;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Button btnProfilim;
        private System.Windows.Forms.Button btnKutuphane;
    }
}