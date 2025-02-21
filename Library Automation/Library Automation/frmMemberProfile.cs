using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class frmMemberProfile : Form
    {
        public frmMemberProfile()
        {
            InitializeComponent();
            LoadDatas();
        }

        private void LoadDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM AppUsers \r\nWHERE UserId = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", Session.ActiveUserId);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            tbxFirstName.Text = dr["FirstName"].ToString();
                            tbxLastName.Text = dr["LastName"].ToString();
                            tbxIdentityNumber.Text = dr["IdentityNumber"].ToString();
                            dtpBirthdate.Value = Convert.ToDateTime(dr["BirthDate"]);
                            tbxUsername.Text = dr["Username"].ToString();
                            tbxPassword.Text = dr["Password"].ToString();


                            bool gender = Convert.ToBoolean(dr["Gender"]);
                            if (gender == true)
                            {
                                rbMan.Checked = true;
                            }
                            else
                            {
                                rbWoman.Checked = true;
                            }
                        }
                    }
                }
            }
        }
        private void ModifiyUserDatas()
        {
            try
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();

                    string queryForDatas = "UPDATE AppUsers SET FirstName = @firstName," +
                        "LastName = @lastName, IdentityNumber = @identityNumber, Username = @username, Password = @password, " +
                        "BirthDate = @birthDate, Gender = @gender WHERE UserId= @userId";

                    using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstName", tbxFirstName.Text);
                        cmd.Parameters.AddWithValue("@lastName", tbxLastName.Text);
                        cmd.Parameters.AddWithValue("@identityNumber", tbxIdentityNumber.Text);
                        cmd.Parameters.AddWithValue("@birthDate", dtpBirthdate.Value);
                        cmd.Parameters.AddWithValue("@username", tbxUsername.Text);
                        cmd.Parameters.AddWithValue("@password", tbxPassword.Text);

                        bool gender;
                        gender = rbMan.Checked ? true : false;

                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("userId", Session.ActiveUserId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı verisi güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata3 " + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ModifiyUserDatas();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
