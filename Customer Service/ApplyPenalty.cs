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
    public partial class ApplyPenalty : Form
    {
        Controller controllerObj = new Controller();
        Form Myparent;
        public ApplyPenalty(Form L)
        {
            InitializeComponent();
            Myparent = L;
            Myparent.Hide();
        }

        private void Customer_Services_functionalities_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Drivers_with_Complaints(numericUpDown1.Value.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = dt;
            if (dt == null)
                MessageBox.Show("There is no drivers");
            dataGridView1.Refresh();
        }

        private void UpdateSalary_Click(object sender, EventArgs e)
        {
            controllerObj.DecrementSalary(numericUpDown2.Value.ToString(), numericUpDown1.Value.ToString());
            DataTable dt = controllerObj.Drivers_with_Complaints(numericUpDown1.Value.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = dt;
            if (dt == null)
                MessageBox.Show("There is no drivers to be updated");
            else
                MessageBox.Show("Here is the new salaries");
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Myparent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you return to home page ,you will be logged out ,Are you sure you want to log out ?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
