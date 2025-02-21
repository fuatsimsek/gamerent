using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserId.Text = Session.ActiveUserId.ToString();
            lblUsername.Text = Session.ActiveUserName.ToString();
            lblRoleName.Text = Session.ActiveRoleName.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGames games = new frmGames();
            games.Show();
            this.Hide();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
            this.Hide();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
