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
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {

        }

        private void btnMagaza_Click(object sender, EventArgs e)
        {
            frmMemberMagaza magaza = new frmMemberMagaza();
            magaza.ShowDialog();
        }

        private void btnKutuphane_Click(object sender, EventArgs e)
        {
            frmMemberKutuphane kutuphane = new frmMemberKutuphane();
            kutuphane.ShowDialog();
        }

        private void btnProfilim_Click(object sender, EventArgs e)
        {
            frmMemberProfile profile = new frmMemberProfile();
            profile.ShowDialog();
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            frmMemberBakiye bakiye = new frmMemberBakiye();
            bakiye.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
