using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class frmUpdateGames : Form
    {
        private int _selectedGameId;
        private int _selectedDeveloperId;
        public frmUpdateGames(int selectedGameId, int selectedDeveloperId)
        {
            InitializeComponent();
            _selectedGameId = selectedGameId;
            _selectedDeveloperId = selectedDeveloperId;

        }
        void BringOtherDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string queryForDatas = "SELECT * FROM Games WHERE GameId = @gameId";
                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    cmd.Parameters.AddWithValue("@gameId", _selectedGameId);
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            tbxGameName.Text = dataReader["GameName"].ToString();
                            tbxPublisher.Text = dataReader["PublisherName"].ToString();
                            dtpReleasedDate.Value = Convert.ToDateTime(dataReader["ReleasedDate"]);
                            NumOfEpisodes.Value = Convert.ToInt16(dataReader["NumberOfEpisodes"]);
                            numStocks.Value = Convert.ToInt16(dataReader["Stocks"]);
                            tbxUpdateGamePicture.Text = dataReader["GameImg"].ToString();
                            numUpdateSetPrice.Value = Convert.ToDecimal(dataReader["Price"]);

                            bool isDeleted = Convert.ToBoolean(dataReader["Status"]);
                            if (isDeleted == true)
                            {
                                rbDeleted.Checked = true;
                            }
                            else
                            {
                                rbNotDeleted.Checked = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bir Hata Oluştu.");
                        }
                    }
                }
            }
        }
        void ListDevelopers()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string queryForDeveloper = "SELECT DeveloperId,FirstName + ' ' + LastName AS FullName FROM Developers";
                using (SqlCommand cmd = new SqlCommand(queryForDeveloper, conn))

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
        void UpdateDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                bool isUpdated = false;
                conn.Open();

                string queryForDeveloper = "UPDATE GameDevelopers SET DeveloperId = @developerId " +
                    "WHERE GameId = @gameId";

                using (SqlCommand cmd = new SqlCommand(queryForDeveloper, conn))
                {
                    cmd.Parameters.AddWithValue("@developerId", cbxDeveloperName.SelectedValue);
                    cmd.Parameters.AddWithValue("@gameId", _selectedGameId);
                    isUpdated = true;
                    cmd.ExecuteNonQuery();
                }

                string queryForUpdate = "UPDATE Games SET " +
                    "GameName = @gameName, PublisherName = @publisherName, " +
                    "ReleasedDate = @releasedDate, NumberOfEpisodes = @numberOfEpisodes, " +
                    "Stocks = @stocks, Status = @status, " +
                    "GameImg = @gameImg, Price = @price, " +
                    "ModifiedDate = @modifiedDate WHERE GameId = @gameId";

                using (SqlCommand cmd = new SqlCommand(queryForUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("@gameId", _selectedGameId);
                    cmd.Parameters.AddWithValue("@GameName", tbxGameName.Text);
                    cmd.Parameters.AddWithValue("@publisherName", tbxPublisher.Text);
                    cmd.Parameters.AddWithValue("@releasedDate", Convert.ToDateTime(dtpReleasedDate.Value));
                    cmd.Parameters.AddWithValue("@numberOfEpisodes", Convert.ToInt16(NumOfEpisodes.Value));
                    cmd.Parameters.AddWithValue("@stocks", Convert.ToInt16(numStocks.Value));
                    cmd.Parameters.AddWithValue("@gameImg", tbxUpdateGamePicture.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(numUpdateSetPrice.Value));
                    cmd.Parameters.AddWithValue("@modifiedDate", DateTime.Now);

                    if (rbDeleted.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@status", false);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@status", true);
                    }
                    if (isUpdated == true)
                    {
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Veriler başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Hata.");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDatas();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmUpdateGames_Load_1(object sender, EventArgs e)
        {
            ListDevelopers();
            cbxDeveloperName.SelectedValue = _selectedDeveloperId;
            BringOtherDatas();
        }
    }
}
