using DB_project1;
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

namespace SuperJet.Contract_Admistrator.Rent
{
    public partial class Bus_Rent_Search_Form : Form
    {
        Controller controller;
        public Bus_Rent_Search_Form()
        {
            InitializeComponent();
            controller = new Controller();
            DataTable dt = controller.Search_Available_Rent_Buses(startd.Value, endd.Value);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void startd_ValueChanged(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();

            if (v.Two_Dates(startd.Value, endd.Value) && v.Two_Dates(DateTime.Today , startd.Value))
            {
                DataTable dt = controller.Search_Available_Rent_Buses(startd.Value, endd.Value);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }



        }
    }
}
