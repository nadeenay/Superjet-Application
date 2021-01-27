using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_Administrator;
using DB_project1;

namespace Contract_Administrator
{
    public partial class SearchPakages : UserControl
    {
        Controller controller;
        public SearchPakages()
        {
            InitializeComponent();
            controller = new Controller();
            panelgrid.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelgrid.Visible = true;
            DataTable D = controller.Get_All_Available_Package();
            dataGridView1.DataSource = D;
            dataGridView1.Refresh();
        }
    }
}
