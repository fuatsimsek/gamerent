using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Automation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminpaneliShow_Click_1(object sender, EventArgs e)
        {
            if (gbAdmin.Visible == false)
            {
                gbAdmin.Visible = true;
            }
            else
            {
                gbAdmin.Visible = false;
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            gbUser.Visible = false;
            gbAdmin.Visible = false;
            gbRegister.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            gbRegister.Visible = false;
            gbUser.Visible = true;
        }
        private void AssignRoleToUser(SqlConnection conn, SqlTransaction transaction, int identityUserId, int v)
        {
            string queryForRule = "INSERT INTO UserRoles(RoleId, UserId) " +
                "VALUES(@roleId, @userId)";
            using (SqlCommand cmdForRole = new SqlCommand(queryForRule, conn, transaction))
            {
                cmdForRole.Parameters.AddWithValue("@roleId", v);
                cmdForRole.Parameters.AddWithValue("@userId", identityUserId);
                cmdForRole.ExecuteNonQuery();
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string queryForUser = "INSERT INTO AppUsers (FirstName" +
                        ", LastName, IdentityNumber, Username, Password, BirthDate, Gender,Status) " +
                        "VALUES(@firstName, @lastName, @identityNumber, @username, @password" +
                        ", @birthDate, @gender,@status) ; SELECT SCOPE_IDENTITY()";

                    using (SqlCommand cmdForUser = new SqlCommand(queryForUser, conn, transaction))
                    {

                        cmdForUser.Parameters.AddWithValue("@firstName", tbxFirstName.Text);
                        cmdForUser.Parameters.AddWithValue("@lastName", tbxLastName.Text);
                        cmdForUser.Parameters.AddWithValue("@identityNumber", tbxIdentityNumber.Text);
                        cmdForUser.Parameters.AddWithValue("@username", tbxRegUsername.Text);
                        cmdForUser.Parameters.AddWithValue("@password", tbxRegPassword.Text);
                        cmdForUser.Parameters.AddWithValue("@birthDate", dtpBirthDate.Value);
                        cmdForUser.Parameters.AddWithValue("@status", true);

                        bool gender;
                        gender = rbMan.Checked ? true : false;
                        cmdForUser.Parameters.AddWithValue("@gender", gender);
                        int insertedUserId = Convert.ToInt32(cmdForUser.ExecuteScalar());
                        AssignRoleToUser(conn, transaction, insertedUserId, 2);
                        transaction.Commit();
                        MessageBox.Show("Veri ekleme başarılı.", "Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Hatalı işlem Yaptımız " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void gbRegister_Enter(object sender, EventArgs e)
        {

        }
        private void btnAdminForLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            if (username.Trim().Length == 0 || password.Trim().Length == 0 || username.Contains(" ") || password.Contains(" ") || username.Length < 3 || password.Length < 3 || username.Length > 49 || password.Length > 49)
            {

                MessageBox.Show("Hatalı giriş şekli. Lütfen en az 3 karakter giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                using (SqlConnection connection = SqlCon.Connect())
                {
                    connection.Open();
                    string queryForLogin = "SELECT TOP(1) au.UserId as UserId,ur.RoleId as RoleId,ar.RoleName as RoleName,au.FirstName + ' ' + au.LastName as FullName FROM AppUsers au\r\nINNER JOIN \r\nUserRoles ur \r\non ur.UserId = au.UserId\r\nINNER JOIN\r\nAppRoles ar\r\non ar.RoleId = ur.RoleId\r\nWHERE Username = @username AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(queryForLogin, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", tbxUsername.Text);
                        cmd.Parameters.AddWithValue("@password", tbxPassword.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                if (dr["RoleId"].ToString() == "2")
                                {
                                    MessageBox.Show("Yetkiniz yetersiz.");
                                    return;
                                }
                                int userId = Convert.ToInt32(dr["UserId"]);
                                int roleId = Convert.ToInt32(dr["RoleId"]);
                                string roleName = dr["RoleName"].ToString();
                                string fullName = dr["FullName"].ToString();
                                Session.ActiveUserId = userId;
                                Session.ActiveRoleId = roleId;
                                Session.ActiveUserName = fullName;
                                Session.ActiveRoleName = roleName;
                                MessageBox.Show($"Hoşgeldiniz, {fullName} \n{roleId}-{roleName}", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                frmMain main = new frmMain();
                                main.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Hatalı Kullanıcı adı veya şifre");
                            }
                        }
                    }
                }

            }
        }

        private void btnForLogin_Click_1(object sender, EventArgs e)
        {
            string username = tbxForUsername.Text;
            string password = tbxForPassword.Text;

            if (username.Trim().Length == 0 || password.Trim().Length == 0 || username.Contains(" ") || password.Contains(" ") || username.Length < 3 || password.Length < 3 || username.Length > 49 || password.Length > 49)
            {

                MessageBox.Show("Hatalı giriş şekli. Lütfen en az 3 karakter giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                using (SqlConnection connection = SqlCon.Connect())
                {
                    connection.Open();
                    string queryForLogin = "SELECT TOP(1) au.UserId as UserId,ur.RoleId as RoleId,ar.RoleName as RoleName,au.FirstName + ' ' + au.LastName as FullName FROM AppUsers au\r\nINNER JOIN \r\nUserRoles ur \r\non ur.UserId = au.UserId\r\nINNER JOIN\r\nAppRoles ar\r\non ar.RoleId = ur.RoleId\r\nWHERE Username = @username AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(queryForLogin, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", tbxForUsername.Text);
                        cmd.Parameters.AddWithValue("@password", tbxForPassword.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                int userId = Convert.ToInt32(dr["UserId"]);
                                int roleId = Convert.ToInt32(dr["RoleId"]);
                                string roleName = dr["RoleName"].ToString();
                                string fullName = dr["FullName"].ToString();
                                Session.ActiveUserId = userId;
                                Session.ActiveRoleId = roleId;
                                Session.ActiveUserName = fullName;
                                Session.ActiveRoleName = roleName;
                                MessageBox.Show($"Hoşgeldiniz, {fullName} \n{roleId}-{roleName}", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                frmMember member = new frmMember();
                                member.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                            }
                        }
                    }
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
