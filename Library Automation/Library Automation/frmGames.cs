using FluentValidation;
using Library_Automation.Objects.Games;
using Library_Automation.Tools.FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class frmGames : Form
    {
        public frmGames()
        {
            InitializeComponent();
        }

        void BringAndSearchDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForDatas = "SELECT Games.GameId AS Id, Games.GameName AS [Oyun Adı], " +
                                  "Developers.DeveloperId [Geliştirici ID], Developers.FirstName + ' ' + Developers.LastName AS [Geliştirici], " +
                                  "Games.PublisherName AS Yayıncı, Games.NumberOfEpisodes AS [Bölüm Sayısı], " +
                                  "Games.Stocks AS Stok, Games.GameImg AS [Ürün Fotoğrafı], Games.Price AS Fiyat " +
                                  "FROM Games INNER JOIN GameDevelopers ON Games.GameId = GameDevelopers.GameId " +
                                  "INNER JOIN Developers ON Developers.DeveloperId = GameDevelopers.DeveloperId " +
                                  "WHERE (Games.GameName LIKE @Words OR Games.PublisherName LIKE @Words " +
                                  "OR Developers.FirstName + ' ' + Developers.LastName LIKE @Words) AND Games.Status = 1";

                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    cmd.Parameters.AddWithValue("@Words", '%' + tbxSearchGames.Text + '%');

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dgwGames.DataSource = dataSet.Tables[0];
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateGames updateForm = new frmUpdateGames(_selectedGamesId, _selectedDevelopersId);
            updateForm.ShowDialog();

            // Güncelleme ekranından sonra verileri yenile
            BringAndSearchDatas();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bu veriyi silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();
                    string queryForDelete = "UPDATE Games SET Status = 0 WHERE GameId = @gameId";

                    using (SqlCommand cmd = new SqlCommand(queryForDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("@gameId", _selectedGamesId);
                        cmd.ExecuteNonQuery();

                        // DataGridView'den seçilen oyunu kaldır
                        foreach (DataGridViewRow row in dgwGames.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["Id"].Value) == _selectedGamesId)
                            {
                                dgwGames.Rows.Remove(row);
                                break;
                            }
                        }

                        MessageBox.Show("Veri Başarıyla Silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        void ListDevelopers()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string queryForDevelopers = "SELECT DeveloperId, FirstName + ' ' + LastName AS FullName FROM Developers";
                using (SqlCommand cmd = new SqlCommand(queryForDevelopers, conn))
                {
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);

                        cbxDeveloperName.DataSource = dataTable;
                        cbxDeveloperName.DisplayMember = "FullName";
                        cbxDeveloperName.ValueMember = "DeveloperId";
                    }
                }
            }
        }

        private void insertNewGame()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string queryForNewGames = "INSERT INTO Games " +
                        "(GameName, PublisherName, ReleasedDate, NumberOfEpisodes, Stocks, GameImg, Price, CreatedBy, Status) " +
                        "VALUES(@gameName, @publisherName, @releasedDate, @numberOfEpisodes, @stocks, @gameImg, @price, @createdBy, @status); " +
                        "SELECT SCOPE_IDENTITY()";

                    using (SqlCommand cmd = new SqlCommand(queryForNewGames, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@gameName", tbxGameName.Text);
                        cmd.Parameters.AddWithValue("@publisherName", tbxPublisher.Text);
                        cmd.Parameters.AddWithValue("@releasedDate", Convert.ToDateTime(dtpReleasedDate.Value));
                        cmd.Parameters.AddWithValue("@numberOfEpisodes", NumOfEpisodes.Value);
                        cmd.Parameters.AddWithValue("@stocks", numStocks.Value);
                        cmd.Parameters.AddWithValue("@gameImg", tbxGamePicture.Text);
                        cmd.Parameters.AddWithValue("@price", numSetPrice.Value);
                        cmd.Parameters.AddWithValue("@createdBy", Session.ActiveUserId);
                        cmd.Parameters.AddWithValue("@status", true);

                        int insertedGameId = Convert.ToInt32(cmd.ExecuteScalar());

                        string queryForNewDevelopers = "INSERT INTO GameDevelopers (GameId, DeveloperId) " +
                            "VALUES(@gameId, @developerId)";
                        using (SqlCommand cmdDevelopers = new SqlCommand(queryForNewDevelopers, conn, transaction))
                        {
                            cmdDevelopers.Parameters.AddWithValue("@gameId", insertedGameId);
                            cmdDevelopers.Parameters.AddWithValue("@developerId", cbxDeveloperName.SelectedValue);
                            cmdDevelopers.ExecuteNonQuery();

                            // DataGridView'e yeni veriyi ekle
                            DataRow newRow = ((DataTable)dgwGames.DataSource).NewRow();
                            newRow["Id"] = insertedGameId;
                            newRow["Oyun Adı"] = tbxGameName.Text;
                            newRow["Geliştirici ID"] = cbxDeveloperName.SelectedValue;
                            newRow["Geliştirici"] = cbxDeveloperName.Text;
                            newRow["Yayıncı"] = tbxPublisher.Text;
                            newRow["Bölüm Sayısı"] = NumOfEpisodes.Value;
                            newRow["Stok"] = numStocks.Value;
                            newRow["Ürün Fotoğrafı"] = tbxGamePicture.Text;
                            newRow["Fiyat"] = numSetPrice.Value;
                            ((DataTable)dgwGames.DataSource).Rows.Add(newRow);

                            MessageBox.Show("Veri ekleme işlemi başarılı.", "Veri Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void frmGames_Load_1(object sender, EventArgs e)
        {
            ListDevelopers();
            BringAndSearchDatas();
            tbxUpdateDevelopersName.ReadOnly = true;
            tbxUpdateGamesName.ReadOnly = true;
            tbxUpdatePublishersName.ReadOnly = true;
        }

        private void tbxSearchGames_TextChanged_1(object sender, EventArgs e)
        {
            if (tbxSearchGames.Text != string.Empty)
            {
                BringAndSearchDatas();
            }
            if (string.IsNullOrEmpty(tbxSearchGames.Text))
            {
                BringAndSearchDatas();
            }
        }

        int _selectedGamesId;
        int _selectedDevelopersId;

        private void dgwGames_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedGamesId = Convert.ToInt32(dgwGames.CurrentRow.Cells[0].Value);
                tbxUpdateGamesName.Text = dgwGames.CurrentRow.Cells[1].Value.ToString();
                _selectedDevelopersId = Convert.ToInt32(dgwGames.CurrentRow.Cells[2].Value);
                tbxUpdateDevelopersName.Text = dgwGames.CurrentRow.Cells[3].Value.ToString();
                tbxUpdatePublishersName.Text = dgwGames.CurrentRow.Cells[4].Value.ToString();
                tbxGamePicture.Text = dgwGames.CurrentRow.Cells[7].Value?.ToString();
                numSetPrice.Value = Convert.ToDecimal(dgwGames.CurrentRow.Cells[8].Value);
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Bir Satırı Seçin.", "Yanlış Seçim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsertGames_Click_1(object sender, EventArgs e)
        {
            var validator = new GamesInsertValidator();
            var insertGamesObject = new InsertGames
            {
                GamesName = tbxGameName.Text,
                PublisherName = tbxPublisher.Text,
            };
            var result = validator.Validate(insertGamesObject);

            if (result.IsValid)
            {
                insertNewGame();
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    MessageBox.Show("Hata: " + error.ErrorMessage);
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
