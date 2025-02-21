namespace Library_Automation
{
    partial class frmSepet
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
            this.sepetListele = new System.Windows.Forms.ListBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.btnGeriGel = new System.Windows.Forms.Button();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.numToplamBakiye1 = new System.Windows.Forms.Label();
            this.btnUrunCikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sepetListele
            // 
            this.sepetListele.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sepetListele.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepetListele.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sepetListele.FormattingEnabled = true;
            this.sepetListele.ItemHeight = 29;
            this.sepetListele.Location = new System.Drawing.Point(59, 23);
            this.sepetListele.Name = "sepetListele";
            this.sepetListele.Size = new System.Drawing.Size(550, 294);
            this.sepetListele.TabIndex = 0;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSatinAl.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatinAl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSatinAl.Location = new System.Drawing.Point(624, 255);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(242, 62);
            this.btnSatinAl.TabIndex = 1;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = false;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click_1);
            // 
            // btnGeriGel
            // 
            this.btnGeriGel.BackColor = System.Drawing.Color.Red;
            this.btnGeriGel.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriGel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGeriGel.Location = new System.Drawing.Point(902, 255);
            this.btnGeriGel.Name = "btnGeriGel";
            this.btnGeriGel.Size = new System.Drawing.Size(265, 62);
            this.btnGeriGel.TabIndex = 2;
            this.btnGeriGel.Text = "Geri Gel";
            this.btnGeriGel.UseVisualStyleBackColor = false;
            this.btnGeriGel.Click += new System.EventHandler(this.btnGeriGel_Click_1);
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamFiyat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblToplamFiyat.Location = new System.Drawing.Point(629, 126);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(84, 29);
            this.lblToplamFiyat.TabIndex = 3;
            this.lblToplamFiyat.Text = "label1";
            // 
            // numToplamBakiye1
            // 
            this.numToplamBakiye1.AutoSize = true;
            this.numToplamBakiye1.BackColor = System.Drawing.SystemColors.Highlight;
            this.numToplamBakiye1.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numToplamBakiye1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numToplamBakiye1.Location = new System.Drawing.Point(628, 23);
            this.numToplamBakiye1.Name = "numToplamBakiye1";
            this.numToplamBakiye1.Size = new System.Drawing.Size(91, 31);
            this.numToplamBakiye1.TabIndex = 68;
            this.numToplamBakiye1.Text = "label1";
            // 
            // btnUrunCikar
            // 
            this.btnUrunCikar.BackColor = System.Drawing.Color.Red;
            this.btnUrunCikar.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunCikar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUrunCikar.Location = new System.Drawing.Point(624, 188);
            this.btnUrunCikar.Name = "btnUrunCikar";
            this.btnUrunCikar.Size = new System.Drawing.Size(195, 47);
            this.btnUrunCikar.TabIndex = 69;
            this.btnUrunCikar.Text = "Ürün Çıkar";
            this.btnUrunCikar.UseVisualStyleBackColor = false;
            this.btnUrunCikar.Click += new System.EventHandler(this.btnUrunCikar_Click);
            // 
            // frmSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Automation.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1194, 380);
            this.Controls.Add(this.btnUrunCikar);
            this.Controls.Add(this.numToplamBakiye1);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.btnGeriGel);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.sepetListele);
            this.Name = "frmSepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSepet";
            this.Load += new System.EventHandler(this.frmSepet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sepetListele;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Button btnGeriGel;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label numToplamBakiye1;
        private System.Windows.Forms.Button btnUrunCikar;
    }
}