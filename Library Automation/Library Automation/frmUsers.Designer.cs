namespace Library_Automation
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.tbxSearchUsers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxUpdateIdentityNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxUpdateLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxUpdateFirstName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxUpdateRoles = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxUpdateUser = new System.Windows.Forms.GroupBox();
            this.lblSearchMember = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.gbxUpdateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUsers
            // 
            this.dgwUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwUsers.Location = new System.Drawing.Point(0, 530);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.RowHeadersWidth = 51;
            this.dgwUsers.RowTemplate.Height = 24;
            this.dgwUsers.Size = new System.Drawing.Size(1451, 298);
            this.dgwUsers.TabIndex = 18;
            this.dgwUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsers_CellClick_1);
            // 
            // tbxSearchUsers
            // 
            this.tbxSearchUsers.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxSearchUsers.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchUsers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxSearchUsers.Location = new System.Drawing.Point(126, 479);
            this.tbxSearchUsers.Multiline = true;
            this.tbxSearchUsers.Name = "tbxSearchUsers";
            this.tbxSearchUsers.Size = new System.Drawing.Size(280, 45);
            this.tbxSearchUsers.TabIndex = 19;
            this.tbxSearchUsers.TextChanged += new System.EventHandler(this.tbxSearchUsers_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(501, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tc No:";
            // 
            // tbxUpdateIdentityNumber
            // 
            this.tbxUpdateIdentityNumber.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxUpdateIdentityNumber.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateIdentityNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxUpdateIdentityNumber.Location = new System.Drawing.Point(605, 157);
            this.tbxUpdateIdentityNumber.Name = "tbxUpdateIdentityNumber";
            this.tbxUpdateIdentityNumber.Size = new System.Drawing.Size(261, 37);
            this.tbxUpdateIdentityNumber.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(496, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Soyad:";
            // 
            // tbxUpdateLastName
            // 
            this.tbxUpdateLastName.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxUpdateLastName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateLastName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxUpdateLastName.Location = new System.Drawing.Point(605, 105);
            this.tbxUpdateLastName.Name = "tbxUpdateLastName";
            this.tbxUpdateLastName.Size = new System.Drawing.Size(261, 37);
            this.tbxUpdateLastName.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(537, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ad:";
            // 
            // tbxUpdateFirstName
            // 
            this.tbxUpdateFirstName.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxUpdateFirstName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateFirstName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxUpdateFirstName.Location = new System.Drawing.Point(603, 48);
            this.tbxUpdateFirstName.Name = "tbxUpdateFirstName";
            this.tbxUpdateFirstName.Size = new System.Drawing.Size(263, 37);
            this.tbxUpdateFirstName.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Location = new System.Drawing.Point(625, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 53);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(625, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 53);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxUpdateRoles
            // 
            this.tbxUpdateRoles.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxUpdateRoles.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateRoles.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxUpdateRoles.Location = new System.Drawing.Point(605, 209);
            this.tbxUpdateRoles.Name = "tbxUpdateRoles";
            this.tbxUpdateRoles.Size = new System.Drawing.Size(261, 37);
            this.tbxUpdateRoles.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(516, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Rolü:";
            // 
            // gbxUpdateUser
            // 
            this.gbxUpdateUser.BackgroundImage = global::Library_Automation.Properties.Resources.arkaplan2;
            this.gbxUpdateUser.Controls.Add(this.btnDelete);
            this.gbxUpdateUser.Controls.Add(this.label8);
            this.gbxUpdateUser.Controls.Add(this.tbxUpdateFirstName);
            this.gbxUpdateUser.Controls.Add(this.tbxUpdateRoles);
            this.gbxUpdateUser.Controls.Add(this.label7);
            this.gbxUpdateUser.Controls.Add(this.tbxUpdateLastName);
            this.gbxUpdateUser.Controls.Add(this.btnUpdate);
            this.gbxUpdateUser.Controls.Add(this.label6);
            this.gbxUpdateUser.Controls.Add(this.label5);
            this.gbxUpdateUser.Controls.Add(this.tbxUpdateIdentityNumber);
            this.gbxUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbxUpdateUser.Location = new System.Drawing.Point(0, 3);
            this.gbxUpdateUser.Name = "gbxUpdateUser";
            this.gbxUpdateUser.Size = new System.Drawing.Size(1451, 444);
            this.gbxUpdateUser.TabIndex = 27;
            this.gbxUpdateUser.TabStop = false;
            this.gbxUpdateUser.Text = "Güncelle";
            // 
            // lblSearchMember
            // 
            this.lblSearchMember.AutoSize = true;
            this.lblSearchMember.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMember.ForeColor = System.Drawing.Color.Blue;
            this.lblSearchMember.Location = new System.Drawing.Point(12, 487);
            this.lblSearchMember.Name = "lblSearchMember";
            this.lblSearchMember.Size = new System.Drawing.Size(107, 29);
            this.lblSearchMember.TabIndex = 27;
            this.lblSearchMember.Text = "Üye ara:";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGeriDon.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGeriDon.Location = new System.Drawing.Point(1196, 453);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(243, 63);
            this.btnGeriDon.TabIndex = 27;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 828);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lblSearchMember);
            this.Controls.Add(this.gbxUpdateUser);
            this.Controls.Add(this.tbxSearchUsers);
            this.Controls.Add(this.dgwUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsers";
            this.Text = "GameRent";
            this.Load += new System.EventHandler(this.frmUsers_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.gbxUpdateUser.ResumeLayout(false);
            this.gbxUpdateUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.TextBox tbxSearchUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxUpdateIdentityNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxUpdateLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxUpdateFirstName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxUpdateRoles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxUpdateUser;
        private System.Windows.Forms.Label lblSearchMember;
        private System.Windows.Forms.Button btnGeriDon;
    }
}