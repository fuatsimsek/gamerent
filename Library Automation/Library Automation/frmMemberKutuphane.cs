using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class frmMemberKutuphane : Form
    {
        public frmMemberKutuphane()
        {
            InitializeComponent();
        }

        void LoadOwnedGamesToUI()
        {
            using (SqlConnection connection = SqlCon.Connect())
            {
                connection.Open();
                try
                {
                    int userId = Session.ActiveUserId;
                    string query = "SELECT G.GameName, G.GameImg FROM UserGamesOwned UGO INNER JOIN Games G ON UGO.GameId = G.GameId WHERE UGO.UserId = @UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                        SqlDataReader reader = command.ExecuteReader();

                        int index = 1;

                        while (reader.Read() && index <= 10)
                        {
                            string gameName = reader["GameName"].ToString();
                            string imagePath = reader["GameImg"].ToString();

                            PictureBox pb = this.Controls.Find($"pbGame{index}", true).FirstOrDefault() as PictureBox;
                            Label lblName = this.Controls.Find($"lblGame{index}", true).FirstOrDefault() as Label;

                            if (pb != null && lblName != null)
                            {
                                if (!string.IsNullOrEmpty(gameName) && !string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                                {
                                    pb.Image = Image.FromFile(imagePath);
                                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                                    pb.Visible = true;

                                    lblName.Text = gameName;
                                    lblName.Visible = true;
                                }
                                else
                                {
                                    pb.Visible = false;
                                    lblName.Visible = false;
                                }
                            }

                            index++;
                        }

                        for (int i = index; i <= 10; i++)
                        {
                            PictureBox pb = this.Controls.Find($"pbGame{i}", true).FirstOrDefault() as PictureBox;
                            Label lblName = this.Controls.Find($"lblGame{i}", true).FirstOrDefault() as Label;

                            if (pb != null) pb.Visible = false;
                            if (lblName != null) lblName.Visible = false;
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
        private void frmMemberKutuphane_Load_1(object sender, EventArgs e)
        {
            LoadOwnedGamesToUI();
        }
    }
}
