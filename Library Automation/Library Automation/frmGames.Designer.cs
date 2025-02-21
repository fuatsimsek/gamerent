namespace Library_Automation
{
    partial class frmGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGames));
            this.lblSearchGames = new System.Windows.Forms.Label();
            this.tbxSearchGames = new System.Windows.Forms.TextBox();
            this.dgwGames = new System.Windows.Forms.DataGridView();
            this.gbxInsertGames = new System.Windows.Forms.GroupBox();
            this.tbxGamePicture = new System.Windows.Forms.TextBox();
            this.numSetPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGamePicture = new System.Windows.Forms.Label();
            this.btnInsertGames = new System.Windows.Forms.Button();
            this.numStocks = new System.Windows.Forms.NumericUpDown();
            this.NumOfEpisodes = new System.Windows.Forms.NumericUpDown();
            this.dtpReleasedDate = new System.Windows.Forms.DateTimePicker();
            this.cbxDeveloperName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxGameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGamesName = new System.Windows.Forms.Label();
            this.tbxUpdateGamesName = new System.Windows.Forms.TextBox();
            this.lblDevelopersName = new System.Windows.Forms.Label();
            this.tbxUpdateDevelopersName = new System.Windows.Forms.TextBox();
            this.lblPusblishersName = new System.Windows.Forms.Label();
            this.tbxUpdatePublishersName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGames)).BeginInit();
            this.gbxInsertGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfEpisodes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchGames
            // 
            this.lblSearchGames.AutoSize = true;
            this.lblSearchGames.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearchGames.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchGames.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSearchGames.Location = new System.Drawing.Point(16, 520);
            this.lblSearchGames.Name = "lblSearchGames";
            this.lblSearchGames.Size = new System.Drawing.Size(128, 29);
            this.lblSearchGames.TabIndex = 1;
            this.lblSearchGames.Text = "Oyun Ara:";
            // 
            // tbxSearchGames
            // 
            this.tbxSearchGames.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxSearchGames.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchGames.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxSearchGames.Location = new System.Drawing.Point(153, 516);
            this.tbxSearchGames.Name = "tbxSearchGames";
            this.tbxSearchGames.Size = new System.Drawing.Size(243, 37);
            this.tbxSearchGames.TabIndex = 2;
            this.tbxSearchGames.TextChanged += new System.EventHandler(this.tbxSearchGames_TextChanged_1);
            // 
            // dgwGames
            // 
            this.dgwGames.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwGames.Location = new System.Drawing.Point(0, 565);
            this.dgwGames.Name = "dgwGames";
            this.dgwGames.RowHeadersWidth = 51;
            this.dgwGames.RowTemplate.Height = 24;
            this.dgwGames.Size = new System.Drawing.Size(1439, 333);
            this.dgwGames.TabIndex = 0;
            this.dgwGames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGames_CellClick_1);
            // 
            // gbxInsertGames
            // 
            this.gbxInsertGames.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.gbxInsertGames.BackgroundImage = global::Library_Automation.Properties.Resources.background;
            this.gbxInsertGames.Controls.Add(this.tbxGamePicture);
            this.gbxInsertGames.Controls.Add(this.numSetPrice);
            this.gbxInsertGames.Controls.Add(this.lblPrice);
            this.gbxInsertGames.Controls.Add(this.lblGamePicture);
            this.gbxInsertGames.Controls.Add(this.btnInsertGames);
            this.gbxInsertGames.Controls.Add(this.numStocks);
            this.gbxInsertGames.Controls.Add(this.NumOfEpisodes);
            this.gbxInsertGames.Controls.Add(this.dtpReleasedDate);
            this.gbxInsertGames.Controls.Add(this.cbxDeveloperName);
            this.gbxInsertGames.Controls.Add(this.label7);
            this.gbxInsertGames.Controls.Add(this.label6);
            this.gbxInsertGames.Controls.Add(this.label5);
            this.gbxInsertGames.Controls.Add(this.tbxPublisher);
            this.gbxInsertGames.Controls.Add(this.label3);
            this.gbxInsertGames.Controls.Add(this.label2);
            this.gbxInsertGames.Controls.Add(this.tbxGameName);
            this.gbxInsertGames.Controls.Add(this.label1);
            this.gbxInsertGames.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInsertGames.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbxInsertGames.Location = new System.Drawing.Point(686, 12);
            this.gbxInsertGames.Name = "gbxInsertGames";
            this.gbxInsertGames.Size = new System.Drawing.Size(726, 513);
            this.gbxInsertGames.TabIndex = 11;
            this.gbxInsertGames.TabStop = false;
            this.gbxInsertGames.Text = "Yeni Oyun Kaydı";
            // 
            // tbxGamePicture
            // 
            this.tbxGamePicture.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxGamePicture.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGamePicture.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxGamePicture.Location = new System.Drawing.Point(255, 341);
            this.tbxGamePicture.Name = "tbxGamePicture";
            this.tbxGamePicture.Size = new System.Drawing.Size(321, 37);
            this.tbxGamePicture.TabIndex = 41;
            // 
            // numSetPrice
            // 
            this.numSetPrice.BackColor = System.Drawing.SystemColors.Highlight;
            this.numSetPrice.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSetPrice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numSetPrice.Location = new System.Drawing.Point(255, 385);
            this.numSetPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSetPrice.Name = "numSetPrice";
            this.numSetPrice.Size = new System.Drawing.Size(321, 37);
            this.numSetPrice.TabIndex = 40;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblPrice.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(168, 388);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 29);
            this.lblPrice.TabIndex = 39;
            this.lblPrice.Text = "Fiyat:";
            // 
            // lblGamePicture
            // 
            this.lblGamePicture.AutoSize = true;
            this.lblGamePicture.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblGamePicture.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePicture.Location = new System.Drawing.Point(62, 345);
            this.lblGamePicture.Name = "lblGamePicture";
            this.lblGamePicture.Size = new System.Drawing.Size(182, 29);
            this.lblGamePicture.TabIndex = 35;
            this.lblGamePicture.Text = "Ürün Fotoğrafı:";
            // 
            // btnInsertGames
            // 
            this.btnInsertGames.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInsertGames.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertGames.Location = new System.Drawing.Point(324, 437);
            this.btnInsertGames.Name = "btnInsertGames";
            this.btnInsertGames.Size = new System.Drawing.Size(219, 38);
            this.btnInsertGames.TabIndex = 34;
            this.btnInsertGames.Text = "Kayıt Ekle";
            this.btnInsertGames.UseVisualStyleBackColor = false;
            this.btnInsertGames.Click += new System.EventHandler(this.btnInsertGames_Click_1);
            // 
            // numStocks
            // 
            this.numStocks.BackColor = System.Drawing.SystemColors.Highlight;
            this.numStocks.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStocks.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numStocks.Location = new System.Drawing.Point(256, 294);
            this.numStocks.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numStocks.Name = "numStocks";
            this.numStocks.Size = new System.Drawing.Size(321, 37);
            this.numStocks.TabIndex = 33;
            // 
            // NumOfEpisodes
            // 
            this.NumOfEpisodes.BackColor = System.Drawing.SystemColors.Highlight;
            this.NumOfEpisodes.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfEpisodes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NumOfEpisodes.Location = new System.Drawing.Point(257, 238);
            this.NumOfEpisodes.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumOfEpisodes.Name = "NumOfEpisodes";
            this.NumOfEpisodes.Size = new System.Drawing.Size(320, 37);
            this.NumOfEpisodes.TabIndex = 32;
            // 
            // dtpReleasedDate
            // 
            this.dtpReleasedDate.CalendarForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtpReleasedDate.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dtpReleasedDate.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpReleasedDate.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReleasedDate.Location = new System.Drawing.Point(256, 186);
            this.dtpReleasedDate.Name = "dtpReleasedDate";
            this.dtpReleasedDate.Size = new System.Drawing.Size(320, 37);
            this.dtpReleasedDate.TabIndex = 31;
            // 
            // cbxDeveloperName
            // 
            this.cbxDeveloperName.BackColor = System.Drawing.SystemColors.Highlight;
            this.cbxDeveloperName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeveloperName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxDeveloperName.FormattingEnabled = true;
            this.cbxDeveloperName.Location = new System.Drawing.Point(256, 87);
            this.cbxDeveloperName.Name = "cbxDeveloperName";
            this.cbxDeveloperName.Size = new System.Drawing.Size(321, 37);
            this.cbxDeveloperName.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Stok:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bölüm Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Yayın Tarihi:";
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxPublisher.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPublisher.Location = new System.Drawing.Point(255, 138);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.Size = new System.Drawing.Size(321, 37);
            this.tbxPublisher.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Yayıncı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Geliştirici:";
            // 
            // tbxGameName
            // 
            this.tbxGameName.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxGameName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGameName.Location = new System.Drawing.Point(256, 39);
            this.tbxGameName.Name = "tbxGameName";
            this.tbxGameName.Size = new System.Drawing.Size(321, 37);
            this.tbxGameName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Oyun Adı:";
            // 
            // lblGamesName
            // 
            this.lblGamesName.AutoSize = true;
            this.lblGamesName.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblGamesName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblGamesName.Location = new System.Drawing.Point(43, 19);
            this.lblGamesName.Name = "lblGamesName";
            this.lblGamesName.Size = new System.Drawing.Size(128, 29);
            this.lblGamesName.TabIndex = 3;
            this.lblGamesName.Text = "Oyun Adı:";
            // 
            // tbxUpdateGamesName
            // 
            this.tbxUpdateGamesName.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxUpdateGamesName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateGamesName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxUpdateGamesName.Location = new System.Drawing.Point(180, 16);
            this.tbxUpdateGamesName.Name = "tbxUpdateGamesName";
            this.tbxUpdateGamesName.Size = new System.Drawing.Size(243, 37);
            this.tbxUpdateGamesName.TabIndex = 4;
            // 
            // lblDevelopersName
            // 
            this.lblDevelopersName.AutoSize = true;
            this.lblDevelopersName.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblDevelopersName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelopersName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDevelopersName.Location = new System.Drawing.Point(36, 91);
            this.lblDevelopersName.Name = "lblDevelopersName";
            this.lblDevelopersName.Size = new System.Drawing.Size(133, 29);
            this.lblDevelopersName.TabIndex = 5;
            this.lblDevelopersName.Text = "Geliştirici:";
            // 
            // tbxUpdateDevelopersName
            // 
            this.tbxUpdateDevelopersName.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxUpdateDevelopersName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateDevelopersName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxUpdateDevelopersName.Location = new System.Drawing.Point(180, 87);
            this.tbxUpdateDevelopersName.Name = "tbxUpdateDevelopersName";
            this.tbxUpdateDevelopersName.Size = new System.Drawing.Size(243, 37);
            this.tbxUpdateDevelopersName.TabIndex = 6;
            // 
            // lblPusblishersName
            // 
            this.lblPusblishersName.AutoSize = true;
            this.lblPusblishersName.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblPusblishersName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPusblishersName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPusblishersName.Location = new System.Drawing.Point(65, 158);
            this.lblPusblishersName.Name = "lblPusblishersName";
            this.lblPusblishersName.Size = new System.Drawing.Size(104, 29);
            this.lblPusblishersName.TabIndex = 7;
            this.lblPusblishersName.Text = "Yayıncı:";
            // 
            // tbxUpdatePublishersName
            // 
            this.tbxUpdatePublishersName.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbxUpdatePublishersName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdatePublishersName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbxUpdatePublishersName.Location = new System.Drawing.Point(180, 155);
            this.tbxUpdatePublishersName.Name = "tbxUpdatePublishersName";
            this.tbxUpdatePublishersName.Size = new System.Drawing.Size(243, 37);
            this.tbxUpdatePublishersName.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Location = new System.Drawing.Point(180, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(243, 63);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(180, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(243, 63);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGeriDon.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGeriDon.Location = new System.Drawing.Point(180, 388);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(243, 63);
            this.btnGeriDon.TabIndex = 12;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Library_Automation.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.btnGeriDon);
            this.groupBox1.Controls.Add(this.lblGamesName);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.tbxUpdateGamesName);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblDevelopersName);
            this.groupBox1.Controls.Add(this.tbxUpdatePublishersName);
            this.groupBox1.Controls.Add(this.tbxUpdateDevelopersName);
            this.groupBox1.Controls.Add(this.lblPusblishersName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(79, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 475);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // frmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Automation.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(1439, 898);
            this.Controls.Add(this.gbxInsertGames);
            this.Controls.Add(this.tbxSearchGames);
            this.Controls.Add(this.dgwGames);
            this.Controls.Add(this.lblSearchGames);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameRent";
            this.Load += new System.EventHandler(this.frmGames_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGames)).EndInit();
            this.gbxInsertGames.ResumeLayout(false);
            this.gbxInsertGames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfEpisodes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearchGames;
        private System.Windows.Forms.TextBox tbxSearchGames;
        private System.Windows.Forms.DataGridView dgwGames;
        private System.Windows.Forms.GroupBox gbxInsertGames;
        private System.Windows.Forms.NumericUpDown numStocks;
        private System.Windows.Forms.NumericUpDown NumOfEpisodes;
        private System.Windows.Forms.DateTimePicker dtpReleasedDate;
        private System.Windows.Forms.ComboBox cbxDeveloperName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxGameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertGames;
        private System.Windows.Forms.TextBox tbxGamePicture;
        private System.Windows.Forms.NumericUpDown numSetPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGamePicture;
        private System.Windows.Forms.Label lblGamesName;
        private System.Windows.Forms.TextBox tbxUpdateGamesName;
        private System.Windows.Forms.Label lblDevelopersName;
        private System.Windows.Forms.TextBox tbxUpdateDevelopersName;
        private System.Windows.Forms.Label lblPusblishersName;
        private System.Windows.Forms.TextBox tbxUpdatePublishersName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}