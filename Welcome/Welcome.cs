using Contract_Administrator;
using DB_project1.Receptionist;
using IT_Administrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project1
{
    public partial class Welcome : Form
    {
        
        public Welcome()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            LoginFormForAdmin l = new LoginFormForAdmin(this, "IT Administrator");
            l.Show();
        }

        private void Receptionist_Click(object sender, EventArgs e)
        {
            LoginFormForAdmin L = new LoginFormForAdmin(this, "Receptionist");
            L.Show();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            LoginFormForAdmin L = new LoginFormForAdmin(this, "Customer Service");
            L.Show();
        }

        private void Contract_Click(object sender, EventArgs e)
        {
            LoginFormForAdmin L = new LoginFormForAdmin(this, "Contract Administrator");
            L.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
