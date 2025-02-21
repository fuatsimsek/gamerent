namespace Library_Automation
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(12, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(454, 133);
            this.button1.TabIndex = 3;
            this.button1.Text = "Oyun Bilgileri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUyeEkle.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUyeEkle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUyeEkle.Location = new System.Drawing.Point(1053, 319);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(380, 143);
            this.btnUyeEkle.TabIndex = 4;
            this.btnUyeEkle.Text = "Üye Bilgileri";
            this.btnUyeEkle.UseVisualStyleBackColor = false;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Library_Automation.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.btnGeriDon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUserId);
            this.groupBox1.Controls.Add(this.lblRoleName);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(464, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 642);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİLER";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGeriDon.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGeriDon.Location = new System.Drawing.Point(173, 418);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(243, 63);
            this.btnGeriDon.TabIndex = 13;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(92, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 35);
            this.label5.TabIndex = 17;
            this.label5.Text = "Yetki:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.ForestGreen;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(92, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(92, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID Numarası:";
            // 
            // lblUserId
            // 
            this.lblUserId.BackColor = System.Drawing.Color.ForestGreen;
            this.lblUserId.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUserId.Location = new System.Drawing.Point(305, 134);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(238, 35);
            this.lblUserId.TabIndex = 13;
            this.lblUserId.Text = "label3";
            // 
            // lblRoleName
            // 
            this.lblRoleName.BackColor = System.Drawing.Color.ForestGreen;
            this.lblRoleName.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRoleName.Location = new System.Drawing.Point(305, 325);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(238, 35);
            this.lblRoleName.TabIndex = 12;
            this.lblRoleName.Text = "label2";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.ForestGreen;
            this.lblUsername.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUsername.Location = new System.Drawing.Point(305, 235);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(238, 35);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Automation.Properties.Resources.arkaplan1;
            this.ClientSize = new System.Drawing.Size(1445, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameRent";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnGeriDon;
    }
}