using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
 

        private void AssignRoleToUser(SqlConnection conn,SqlTransaction transaction, int identityUserId,int v)
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

        private void BringAndSearchUserDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForUsers = "SELECT au.UserId, au.FirstName, au.LastName,\r\nSTRING_AGG(ar.RoleName, ', ') as Roles,\r\nau.IdentityNumber, au.BirthDate,au.CreatedDate\r\nFROM AppUsers au\r\nINNER JOIN\r\nUserRoles ur\r\nON ur.UserId = au.UserId\r\nINNER JOIN\r\nAppRoles ar\r\nON ar.RoleId = ur.RoleId\r\nWHERE au.Status = 1 GROUP BY \r\n au.UserId, au.FirstName, au.LastName, au.IdentityNumber,au.BirthDate,au.CreatedDate\r\nHAVING au.FirstName + ' ' + au.LastName LIKE @usersName OR au.IdentityNumber LIKE @IdentityNumber";
                using(SqlCommand cmd = new SqlCommand(queryForUsers, conn))
                {
                    cmd.Parameters.AddWithValue("@usersName",'%' + tbxSearchUsers.Text + '%');
                    cmd.Parameters.AddWithValue("@IdentityNumber", '%' + tbxSearchUsers.Text + '%');
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();    
                    adapter.Fill(dataSet);
                    dgwUsers.DataSource = dataSet.Tables[0];

                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string query = "UPDATE AppUsers SET Status = 0 WHERE UserId = @userId";
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _selectedUserId);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seçili Üye Silindi.");

                    BringAndSearchUserDatas();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateUsers frmUpdateUsers = new FrmUpdateUsers(_selectedUserId);
            frmUpdateUsers.ShowDialog();

            BringAndSearchUserDatas();
        }

        int _selectedUserId;
        private void dgwUsers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedUserId = Convert.ToInt32(dgwUsers.CurrentRow.Cells[0].Value);
                tbxUpdateFirstName.Text = dgwUsers.CurrentRow.Cells[1].Value.ToString();
                tbxUpdateLastName.Text = dgwUsers.CurrentRow.Cells[2].Value.ToString();
                tbxUpdateRoles.Text = dgwUsers.CurrentRow.Cells[3].Value.ToString();
                tbxUpdateIdentityNumber.Text = dgwUsers.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Bir Satırı Seçin.", "Yanlış Seçim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmUsers_Load_1(object sender, EventArgs e)
        {
            BringAndSearchUserDatas();
            tbxUpdateFirstName.ReadOnly = true;
            tbxUpdateLastName.ReadOnly = true;
            tbxUpdateIdentityNumber.ReadOnly = true;
            tbxUpdateRoles.ReadOnly = true;
        }

        private void tbxSearchUsers_TextChanged_1(object sender, EventArgs e)
        {
            if (tbxSearchUsers.Text != string.Empty)
            {
                BringAndSearchUserDatas();
            }
            if (string.IsNullOrEmpty(tbxSearchUsers.Text))
            {
                BringAndSearchUserDatas();
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
