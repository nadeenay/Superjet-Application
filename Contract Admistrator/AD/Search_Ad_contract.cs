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
using SuperJet;
using DB_project1;

namespace Contract_Administrator
{
    public partial class Search_Ad_contract : UserControl
    {
        Controller control;
        public Search_Ad_contract()
        {
            InitializeComponent();
            control = new Controller();
            panelgrid.Visible = false;
        }

        private void view_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.NationalID(id.Text))
            {
                DataTable d = control.Search_Ad_Package_Price(id.Text);
                if (d == null)
                {
                    panelgrid.Visible = false;
                    find.Text = "Not Found";
                    find.ForeColor = Color.Red;
                }
                else
                {
                    panelgrid.Visible = true;
                    find.Text = "Found";
                    find.ForeColor = Color.LimeGreen;
                    dataGridView1.DataSource = d;
                    dataGridView1.Refresh();
                }
            }
            
        }
    }
}
