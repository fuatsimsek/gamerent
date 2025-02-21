namespace Library_Automation
{
    partial class frmMemberBakiye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberBakiye));
            this.gbBakiye = new System.Windows.Forms.GroupBox();
            this.btnBakiyeYukle = new System.Windows.Forms.Button();
            this.btnBakiyeİptal = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblBakiyeYukle = new System.Windows.Forms.Label();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.tbxBakiyeYukle = new System.Windows.Forms.TextBox();
            this.numToplamBakiye1 = new System.Windows.Forms.Label();
            this.gbBakiye.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBakiye
            // 
            this.gbBakiye.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbBakiye.Controls.Add(this.numToplamBakiye1);
            this.gbBakiye.Controls.Add(this.btnBakiyeYukle);
            this.gbBakiye.Controls.Add(this.btnBakiyeİptal);
            this.gbBakiye.Controls.Add(this.lblSifre);
            this.gbBakiye.Controls.Add(this.lblBakiyeYukle);
            this.gbBakiye.Controls.Add(this.tbxSifre);
            this.gbBakiye.Controls.Add(this.tbxBakiyeYukle);
            this.gbBakiye.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBakiye.ForeColor = System.Drawing.Color.Blue;
            this.gbBakiye.Location = new System.Drawing.Point(12, 12);
            this.gbBakiye.Name = "gbBakiye";
            this.gbBakiye.Size = new System.Drawing.Size(1427, 626);
            this.gbBakiye.TabIndex = 66;
            this.gbBakiye.TabStop = false;
            this.gbBakiye.Text = "Bakiye";
            // 
            // btnBakiyeYukle
            // 
            this.btnBakiyeYukle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBakiyeYukle.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBakiyeYukle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBakiyeYukle.Location = new System.Drawing.Point(580, 322);
            this.btnBakiyeYukle.Name = "btnBakiyeYukle";
            this.btnBakiyeYukle.Size = new System.Drawing.Size(331, 52);
            this.btnBakiyeYukle.TabIndex = 2;
            this.btnBakiyeYukle.Text = "Yükle";
            this.btnBakiyeYukle.UseVisualStyleBackColor = false;
            this.btnBakiyeYukle.Click += new System.EventHandler(this.btnBakiyeYukle_Click_1);
            // 
            // btnBakiyeİptal
            // 
            this.btnBakiyeİptal.BackColor = System.Drawing.Color.Red;
            this.btnBakiyeİptal.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBakiyeİptal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBakiyeİptal.Location = new System.Drawing.Point(580, 390);
            this.btnBakiyeİptal.Name = "btnBakiyeİptal";
            this.btnBakiyeİptal.Size = new System.Drawing.Size(331, 52);
            this.btnBakiyeİptal.TabIndex = 3;
            this.btnBakiyeİptal.Text = "İptal Et";
            this.btnBakiyeİptal.UseVisualStyleBackColor = false;
            this.btnBakiyeİptal.Click += new System.EventHandler(this.btnBakiyeİptal_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(486, 231);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(75, 29);
            this.lblSifre.TabIndex = 58;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblBakiyeYukle
            // 
            this.lblBakiyeYukle.AutoSize = true;
            this.lblBakiyeYukle.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBakiyeYukle.Location = new System.Drawing.Point(392, 160);
            this.lblBakiyeYukle.Name = "lblBakiyeYukle";
            this.lblBakiyeYukle.Size = new System.Drawing.Size(168, 29);
            this.lblBakiyeYukle.TabIndex = 53;
            this.lblBakiyeYukle.Text = "Bakiye Yükle:";
            // 
            // tbxSifre
            // 
            this.tbxSifre.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxSifre.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSifre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxSifre.Location = new System.Drawing.Point(573, 228);
            this.tbxSifre.Multiline = true;
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(338, 53);
            this.tbxSifre.TabIndex = 1;
            // 
            // tbxBakiyeYukle
            // 
            this.tbxBakiyeYukle.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxBakiyeYukle.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBakiyeYukle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxBakiyeYukle.Location = new System.Drawing.Point(573, 157);
            this.tbxBakiyeYukle.Multiline = true;
            this.tbxBakiyeYukle.Name = "tbxBakiyeYukle";
            this.tbxBakiyeYukle.Size = new System.Drawing.Size(338, 51);
            this.tbxBakiyeYukle.TabIndex = 0;
            // 
            // numToplamBakiye1
            // 
            this.numToplamBakiye1.AutoSize = true;
            this.numToplamBakiye1.BackColor = System.Drawing.SystemColors.Highlight;
            this.numToplamBakiye1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numToplamBakiye1.Location = new System.Drawing.Point(391, 57);
            this.numToplamBakiye1.Name = "numToplamBakiye1";
            this.numToplamBakiye1.Size = new System.Drawing.Size(94, 31);
            this.numToplamBakiye1.TabIndex = 66;
            this.numToplamBakiye1.Text = "label1";
            this.numToplamBakiye1.Click += new System.EventHandler(this.numToplamBakiye1_Click);
            // 
            // frmMemberBakiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 650);
            this.Controls.Add(this.gbBakiye);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMemberBakiye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameRent";
            this.Load += new System.EventHandler(this.frmMemberBakiye_Load_1);
            this.gbBakiye.ResumeLayout(false);
            this.gbBakiye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBakiye;
        private System.Windows.Forms.Button btnBakiyeYukle;
        private System.Windows.Forms.Button btnBakiyeİptal;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblBakiyeYukle;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.TextBox tbxBakiyeYukle;
        private System.Windows.Forms.Label numToplamBakiye1;
    }
}