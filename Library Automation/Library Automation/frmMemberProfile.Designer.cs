namespace Library_Automation
{
    partial class frmMemberProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberProfile));
            this.gbProfilim = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxIdentityNumber = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.gbProfilim.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProfilim
            // 
            this.gbProfilim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbProfilim.Controls.Add(this.btnUpdate);
            this.gbProfilim.Controls.Add(this.btnDelete);
            this.gbProfilim.Controls.Add(this.rbWoman);
            this.gbProfilim.Controls.Add(this.rbMan);
            this.gbProfilim.Controls.Add(this.label6);
            this.gbProfilim.Controls.Add(this.label5);
            this.gbProfilim.Controls.Add(this.dtpBirthdate);
            this.gbProfilim.Controls.Add(this.label4);
            this.gbProfilim.Controls.Add(this.label3);
            this.gbProfilim.Controls.Add(this.label2);
            this.gbProfilim.Controls.Add(this.label1);
            this.gbProfilim.Controls.Add(this.tbxPassword);
            this.gbProfilim.Controls.Add(this.tbxIdentityNumber);
            this.gbProfilim.Controls.Add(this.tbxUsername);
            this.gbProfilim.Controls.Add(this.tbxLastName);
            this.gbProfilim.Controls.Add(this.tbxFirstName);
            this.gbProfilim.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProfilim.ForeColor = System.Drawing.Color.Blue;
            this.gbProfilim.Location = new System.Drawing.Point(12, 12);
            this.gbProfilim.Name = "gbProfilim";
            this.gbProfilim.Size = new System.Drawing.Size(1433, 625);
            this.gbProfilim.TabIndex = 50;
            this.gbProfilim.TabStop = false;
            this.gbProfilim.Text = "Profilim";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Location = new System.Drawing.Point(936, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(331, 52);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(936, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(331, 52);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "İptal Et";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWoman.Location = new System.Drawing.Point(555, 324);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(100, 33);
            this.rbWoman.TabIndex = 62;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Kadın";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMan.Location = new System.Drawing.Point(374, 324);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(102, 33);
            this.rbMan.TabIndex = 61;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Erkek";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(838, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 58;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(755, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(364, 381);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(343, 37);
            this.dtpBirthdate.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tc No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ad:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxPassword.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxPassword.Location = new System.Drawing.Point(936, 177);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(331, 47);
            this.tbxPassword.TabIndex = 51;
            // 
            // tbxIdentityNumber
            // 
            this.tbxIdentityNumber.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxIdentityNumber.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdentityNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxIdentityNumber.Location = new System.Drawing.Point(364, 257);
            this.tbxIdentityNumber.Multiline = true;
            this.tbxIdentityNumber.Name = "tbxIdentityNumber";
            this.tbxIdentityNumber.Size = new System.Drawing.Size(331, 47);
            this.tbxIdentityNumber.TabIndex = 50;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxUsername.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxUsername.Location = new System.Drawing.Point(936, 106);
            this.tbxUsername.Multiline = true;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(331, 47);
            this.tbxUsername.TabIndex = 49;
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxLastName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxLastName.Location = new System.Drawing.Point(364, 174);
            this.tbxLastName.Multiline = true;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(331, 47);
            this.tbxLastName.TabIndex = 48;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxFirstName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxFirstName.Location = new System.Drawing.Point(364, 103);
            this.tbxFirstName.Multiline = true;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(331, 47);
            this.tbxFirstName.TabIndex = 47;
            // 
            // frmMemberProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 649);
            this.Controls.Add(this.gbProfilim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMemberProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameRent";
            this.gbProfilim.ResumeLayout(false);
            this.gbProfilim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProfilim;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxIdentityNumber;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
    }
}