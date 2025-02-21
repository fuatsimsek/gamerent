using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class frmSepet : Form
    {
        private List<int> cartGames;
        private decimal totalPrice = 0;

        public frmSepet(List<int> cartGames)
        {
            InitializeComponent();
            this.cartGames = cartGames;
        }

        void LoadCartItems()
        {
            if (cartGames == null || !cartGames.Any())
            {
                MessageBox.Show("Sepetiniz boş!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblToplamFiyat.Text = "Toplam Fiyat: 0.00 TL";
                return;
            }

            using (SqlConnection connection = SqlCon.Connect())
            {
                connection.Open();
                try
                {
                    string query = "SELECT GameId, GameName, Price FROM Games WHERE GameId IN (" + string.Join(",", cartGames) + ")";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            sepetListele.Items.Clear(); 
                            totalPrice = 0; 

                            while (reader.Read())
                            {
                                string gameName = reader["GameName"].ToString();
                                decimal price = Convert.ToDecimal(reader["Price"]);

                                sepetListele.Items.Add($"{gameName} - {price:0.00} TL");

                                totalPrice += price;
                            }
                        }
                    }

                    lblToplamFiyat.Text = $"Toplam Fiyat: {totalPrice:0.00} TL";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmSepet_Load(object sender, EventArgs e)
        {
            LoadCartItems();
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
        }

        private void btnSatinAl_Click_1(object sender, EventArgs e)
        {
            if (cartGames == null || !cartGames.Any())
            {
                MessageBox.Show("Sepetiniz boş! Önce bir oyun ekleyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = SqlCon.Connect())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int userId = Session.ActiveUserId;

                    decimal totalPrice = 0;
                    foreach (var gameId in cartGames)
                    {
                        string priceQuery = "SELECT Price FROM Games WHERE GameId = @GameId";
                        using (SqlCommand command = new SqlCommand(priceQuery, connection, transaction))
                        {
                            command.Parameters.Add("@GameId", SqlDbType.Int).Value = gameId;
                            object priceObj = command.ExecuteScalar();
                            if (priceObj != null)
                            {
                                totalPrice += Convert.ToDecimal(priceObj);
                            }
                        }
                    }

                    string balanceQuery = "SELECT Balance FROM AppUsers WHERE UserId = @UserId";
                    decimal currentBalance = 0;
                    using (SqlCommand command = new SqlCommand(balanceQuery, connection, transaction))
                    {
                        command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                        object balanceObj = command.ExecuteScalar();
                        if (balanceObj != null)
                        {
                            currentBalance = Convert.ToDecimal(balanceObj);
                        }
                    }

                    if (currentBalance < totalPrice)
                    {
                        MessageBox.Show("Bakiyeniz yetersiz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return;
                    }

                    decimal newBalance = currentBalance - totalPrice;
                    string updateBalanceQuery = "UPDATE AppUsers SET Balance = @NewBalance WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(updateBalanceQuery, connection, transaction))
                    {
                        command.Parameters.Add("@NewBalance", SqlDbType.Decimal).Value = newBalance;
                        command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                        command.ExecuteNonQuery();
                    }

                    foreach (var gameId in cartGames)
                    {
                        string insertQuery = "INSERT INTO UserGamesOwned (UserId, GameId) VALUES (@UserId, @GameId)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                        {
                            command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                            command.Parameters.Add("@GameId", SqlDbType.Int).Value = gameId;
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();

                    cartGames.Clear();
                    sepetListele.Items.Clear();
                    lblToplamFiyat.Text = "Toplam Fiyat: 0.00 TL";
                    numToplamBakiye1.Text = $"Bakiye: {newBalance:C}";

                    MessageBox.Show("Satın alma işlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Satın alma işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnGeriGel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUrunCikar_Click(object sender, EventArgs e)
        {
            int selectedIndex = sepetListele.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Lütfen kaldırmak istediğiniz ürünü seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = sepetListele.Items[selectedIndex].ToString();
            int startIndex = selectedItem.IndexOf(" - ");
            string gameName = selectedItem.Substring(0, startIndex);
            int gameId = cartGames[selectedIndex];

            cartGames.RemoveAt(selectedIndex);
            sepetListele.Items.RemoveAt(selectedIndex);

            using (SqlConnection connection = SqlCon.Connect())
            {
                connection.Open();
                string query = "SELECT Price FROM Games WHERE GameId = @GameId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@GameId", SqlDbType.Int).Value = gameId;
                    object priceObj = command.ExecuteScalar();
                    if (priceObj != null)
                    {
                        totalPrice -= Convert.ToDecimal(priceObj);
                    }
                }
            }

            lblToplamFiyat.Text = $"Toplam Fiyat: {totalPrice:0.00} TL";

            MessageBox.Show($"{gameName} sepetten çıkarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}