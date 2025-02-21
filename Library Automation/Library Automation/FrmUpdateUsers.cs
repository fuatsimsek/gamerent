using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class FrmUpdateUsers : Form
    {
        int _selectedUserId;
        public FrmUpdateUsers(int selectedMemberId)
        {
            InitializeComponent();
            _selectedUserId = selectedMemberId;
        }

        private void FrmUpdateMembers_Load(object sender, EventArgs e)
        {
            LoadDatas();
            chkUser.Checked = true;
            chkUser.Enabled = false;
        }

        private void LoadDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string query = "SELECT au.UserId, au.FirstName, au.LastName, STRING_AGG(ar.RoleName, ', ') as Roles, au.IdentityNumber, au.BirthDate, au.CreatedDate, au.Gender, au.Username, au.Password\nFROM AppUsers au \nINNER JOIN UserRoles ur \nON ur.UserId = au.UserId INNER JOIN AppRoles ar \nON ar.RoleId = ur.RoleId \nWHERE au.UserId = @userId\nGROUP BY au.UserId, au.FirstName, au.LastName, au.IdentityNumber, au.BirthDate, au.CreatedDate, au.Gender, au.Username, au.Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _selectedUserId);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            tbxFirstName.Text = dr["FirstName"].ToString();
                            tbxLastName.Text = dr["LastName"].ToString();
                            tbxIdentityNumber.Text = dr["IdentityNumber"].ToString();
                            dtpBirthdate.Value = Convert.ToDateTime(dr["BirthDate"]);

                            bool gender = Convert.ToBoolean(dr["Gender"]);
                            if (gender == true)
                            {
                                rbMan.Checked = true;
                            }
                            else
                            {
                                rbWoman.Checked = true;
                            }

                            string roles = dr["Roles"].ToString();
                            string[] roleList = roles.Split(',').Select(r => r.Trim()).ToArray();

                            if (roleList.Contains("Admin"))
                            {
                                chkAdmin.Checked = true;
                            }

                            if (roleList.Contains("Member"))
                            {
                                chkUser.Checked = true;
                            }
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ModifyUserRoles();
            ModifiyUserDatas();
            LoadDatas();
        }

        private void ModifiyUserDatas()
        {
            try
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string queryForDatas = "UPDATE AppUsers SET FirstName = @firstName, LastName = @lastName, IdentityNumber = @identityNumber, BirthDate = @birthDate, Gender = @gender, ModifiedBy = @modifiedBy WHERE UserId= @userId";

                            using (SqlCommand cmd = new SqlCommand(queryForDatas, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@firstName", tbxFirstName.Text);
                                cmd.Parameters.AddWithValue("@lastName", tbxLastName.Text);
                                cmd.Parameters.AddWithValue("@identityNumber", tbxIdentityNumber.Text);
                                cmd.Parameters.AddWithValue("@birthDate", dtpBirthdate.Value);

                                bool gender = rbMan.Checked ? true : false;
                                cmd.Parameters.AddWithValue("@gender", gender);
                                cmd.Parameters.AddWithValue("@modifiedBy", Session.ActiveUserId);
                                cmd.Parameters.AddWithValue("@userId", _selectedUserId);

                                cmd.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            MessageBox.Show("Kullanıcı verisi güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata3 " + ex);
            }
        }

        private void ModifyUserRoles()
        {
            try
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            List<int> selectedRoles = new List<int>();
                            if (chkAdmin.Checked) selectedRoles.Add(1);
                            if (chkUser.Checked) selectedRoles.Add(2);

                            List<int> currentUserRoles = new List<int>();
                            string rolesQuery = "SELECT RoleId FROM UserRoles WHERE UserId = @userId";

                            using (SqlCommand cmd = new SqlCommand(rolesQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@userId", _selectedUserId);
                                using (SqlDataReader dr = cmd.ExecuteReader())
                                {
                                    while (dr.Read())
                                    {
                                        currentUserRoles.Add(Convert.ToInt32(dr["RoleId"]));
                                    }
                                }
                            }

                            foreach (var roleId in selectedRoles.Except(currentUserRoles))
                            {
                                string queryForInsert = "INSERT INTO UserRoles (RoleId, UserId) VALUES (@roleId, @userId)";
                                using (SqlCommand cmdForInsert = new SqlCommand(queryForInsert, conn, transaction))
                                {
                                    cmdForInsert.Parameters.AddWithValue("@roleId", roleId);
                                    cmdForInsert.Parameters.AddWithValue("@userId", _selectedUserId);
                                    cmdForInsert.ExecuteNonQuery();
                                }
                            }

                            foreach (var roleId in currentUserRoles.Except(selectedRoles))
                            {
                                string queryForDelete = "DELETE FROM UserRoles WHERE UserId = @userId AND RoleId = @roleId";
                                using (SqlCommand cmdForDelete = new SqlCommand(queryForDelete, conn, transaction))
                                {
                                    cmdForDelete.Parameters.AddWithValue("@userId", _selectedUserId);
                                    cmdForDelete.Parameters.AddWithValue("@roleId", roleId);
                                    cmdForDelete.ExecuteNonQuery();
                                }
                            }
                            transaction.Commit();
                            MessageBox.Show("Kullanıcı rolleri güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
