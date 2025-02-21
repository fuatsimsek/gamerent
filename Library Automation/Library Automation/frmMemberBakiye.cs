using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class frmMemberBakiye : Form
    {
        public frmMemberBakiye()
        {
            InitializeComponent();
        }

        private void frmMemberBakiye_Load_1(object sender, EventArgs e)
        {
            tbxSifre.PasswordChar = '*';
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

        private void btnBakiyeYukle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxBakiyeYukle.Text) || string.IsNullOrWhiteSpace(tbxSifre.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tbxBakiyeYukle.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Geçerli bir bakiye miktarı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = SqlCon.Connect())
            {
                connection.Open();
                try
                {
                    string queryPassword = "SELECT Password FROM AppUsers WHERE UserId = @UserId";
                    using (SqlCommand cmdPassword = new SqlCommand(queryPassword, connection))
                    {
                        cmdPassword.Parameters.Add("@UserId", SqlDbType.Int).Value = Session.ActiveUserId;
                        string storedPassword = cmdPassword.ExecuteScalar()?.ToString();

                        if (storedPassword == null || storedPassword != tbxSifre.Text)
                        {
                            MessageBox.Show("Şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    string queryUpdateBalance = "UPDATE AppUsers SET Balance = ISNULL(Balance, 0) + @Amount WHERE UserId = @UserId";
                    using (SqlCommand cmdUpdateBalance = new SqlCommand(queryUpdateBalance, connection))
                    {
                        cmdUpdateBalance.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        cmdUpdateBalance.Parameters.Add("@UserId", SqlDbType.Int).Value = Session.ActiveUserId;
                        cmdUpdateBalance.ExecuteNonQuery();
                    }

                    string queryGetBalance = "SELECT ISNULL(Balance, 0) AS Balance FROM AppUsers WHERE UserId = @UserId";
                    using (SqlCommand cmdGetBalance = new SqlCommand(queryGetBalance, connection))
                    {
                        cmdGetBalance.Parameters.Add("@UserId", SqlDbType.Int).Value = Session.ActiveUserId;
                        object result = cmdGetBalance.ExecuteScalar();
                        numToplamBakiye1.Text = result == DBNull.Value ? "0" : Convert.ToDecimal(result).ToString();
                        numToplamBakiye1.Text = $"Bakiye: {result:C}";
                    }

                    MessageBox.Show("Bakiye başarıyla yüklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbxBakiyeYukle.Clear();
                    tbxSifre.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBakiyeİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numToplamBakiye1_Click(object sender, EventArgs e)
        {

        }
    }
}
