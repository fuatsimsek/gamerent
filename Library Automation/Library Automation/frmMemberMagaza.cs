using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class frmMemberMagaza : Form
    {
        private List<int> cartGameIds = new List<int>();

        public frmMemberMagaza()
        {
            InitializeComponent();
        }

        void LoadGamesToUI()
        {
            using (SqlConnection connection = SqlCon.Connect())
            {
                connection.Open();
                try
                {
                    string query = "SELECT ISNULL(Balance, 0) AS Balance FROM AppUsers WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@UserId", SqlDbType.Int).Value = Session.ActiveUserId;
                        object result = command.ExecuteScalar();
                        numToplamBakiye1.Text = result == DBNull.Value ? "0" : Convert.ToDecimal(result).ToString();
                        numToplamBakiye1.Text = $"Bakiye: {result:C}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bakiye yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            using (SqlConnection connection = SqlCon.Connect())
            {
                connection.Open();
                try
                {
                    int userId = Session.ActiveUserId;
                    string ownedGamesQuery = "SELECT GameId FROM UserGamesOwned WHERE UserId = @UserId";
                    var ownedGameIds = new List<int>();

                    using (SqlCommand ownedGamesCommand = new SqlCommand(ownedGamesQuery, connection))
                    {
                        ownedGamesCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                        using (SqlDataReader reader = ownedGamesCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ownedGameIds.Add(Convert.ToInt32(reader["GameId"]));
                            }
                        }
                    }

                    string query = @"SELECT TOP 10 GameId, GameName, GameImg, Price 
                             FROM Games 
                             WHERE Status = 1 AND GameId NOT IN (" + string.Join(",", ownedGameIds.DefaultIfEmpty(0)) + @") 
                             ORDER BY GameId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        int index = 1;

                        while (reader.Read() && index <= 10)
                        {
                            int gameId = Convert.ToInt32(reader["GameId"]);
                            string gameName = reader["GameName"].ToString();
                            string imagePath = reader["GameImg"].ToString();
                            decimal price = Convert.ToDecimal(reader["Price"]);

                            PictureBox pb = this.Controls.Find($"pbBuyGame{index}", true).FirstOrDefault() as PictureBox;
                            Label lblName = this.Controls.Find($"lblBuyGame{index}", true).FirstOrDefault() as Label;
                            Label lblPrice = this.Controls.Find($"lblPrice{index}", true).FirstOrDefault() as Label;
                            Button btnBuy = this.Controls.Find($"btnSatinAl{index}", true).FirstOrDefault() as Button;

                            if (pb != null && lblName != null && lblPrice != null && btnBuy != null)
                            {
                                if (!string.IsNullOrEmpty(gameName) && !string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                                {
                                    pb.Image = Image.FromFile(imagePath);
                                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                                    pb.Visible = true;

                                    lblName.Text = gameName;
                                    lblName.Visible = true;

                                    lblPrice.Text = $"Fiyat: {price:0.00} TL";
                                    lblPrice.Visible = true;

                                    if (cartGameIds.Contains(gameId))
                                    {
                                        btnBuy.Text = "Sepette";
                                        btnBuy.Enabled = false;
                                    }
                                    else
                                    {
                                        btnBuy.Text = "Sepete Ekle";
                                        btnBuy.Enabled = true;
                                    }

                                    btnBuy.Tag = gameId; 
                                    btnBuy.Click -= BtnBuy_Click; 
                                    btnBuy.Click += BtnBuy_Click; 
                                    btnBuy.Visible = true;
                                }
                                else
                                {
                                    pb.Visible = false;
                                    lblName.Visible = false;
                                    lblPrice.Visible = false;
                                    btnBuy.Visible = false;
                                }
                            }

                            index++;
                        }

                        for (int i = index; i <= 10; i++)
                        {
                            PictureBox pb = this.Controls.Find($"pbBuyGame{i}", true).FirstOrDefault() as PictureBox;
                            Label lblName = this.Controls.Find($"lblBuyGame{i}", true).FirstOrDefault() as Label;
                            Label lblPrice = this.Controls.Find($"lblPrice{i}", true).FirstOrDefault() as Label;
                            Button btnBuy = this.Controls.Find($"btnSatinAl{i}", true).FirstOrDefault() as Button;

                            if (pb != null) pb.Visible = false;
                            if (lblName != null) lblName.Visible = false;
                            if (lblPrice != null) lblPrice.Visible = false;
                            if (btnBuy != null) btnBuy.Visible = false;
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnBuy_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag != null && int.TryParse(btn.Tag.ToString(), out int gameId))
            {
                AddToCart(gameId, btn);
            }
        }

        void AddToCart(int gameId, Button btnToUpdate)
        {
            // Eğer oyun zaten sepette yoksa ekle
            if (!cartGameIds.Contains(gameId))
            {
                cartGameIds.Add(gameId);

                // Sepete eklenen butonun metnini ve durumunu güncelle
                btnToUpdate.Text = "Sepete Eklendi";
                btnToUpdate.Enabled = false; // Yeniden eklenmesini önlemek için devre dışı bırak

                MessageBox.Show("Oyun sepete eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu oyun zaten sepete eklenmiş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSepeteGit_Click(object sender, EventArgs e)
        {
            // Sepet formunu aç ve kapandığında güncelle
            frmSepet frmSepet = new frmSepet(cartGameIds);
            frmSepet.FormClosed += FrmSepet_FormClosed; // Form kapandıktan sonra güncellemeyi dinle
            frmSepet.ShowDialog();
        }

        private void frmMemberMagaza_Load(object sender, EventArgs e)
        {
            LoadGamesToUI();
        }
        private void FrmSepet_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Kullanıcının bakiyesi ve oyun listesini güncelle
            LoadGamesToUI();
        }

        private void btnSatinAl1_Click(object sender, EventArgs e)
        {

        }
    }
}