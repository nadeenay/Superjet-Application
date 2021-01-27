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
    public partial class Delete_packages : UserControl
    {
        Controller controler;
        public Delete_packages()
        {

            InitializeComponent();
            controler = new Controller();
            Refreshing();
        }

        public void Refreshing()
        {
            DataTable d = controler.Get_All_Available_Package();
            comboBox1.DataSource = d;
            comboBox1.DisplayMember = "Package_Name";
            comboBox1.ValueMember = "Package_Name";
            comboBox1.Refresh();

            interval1.Visible = false;
            interval2.Visible = false;
            price1.Visible = false;
            price2.Visible = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            interval1.Visible = false;
            interval2.Visible = false;
            price1.Visible = false;
            price2.Visible = false;
            Validation_Class v = new Validation_Class();


            if (v.Is_Empty(comboBox1.Text))
            {
               int y = controler.Delete_package(comboBox1.Text);
                if (y == 0)
                {
                    MessageBox.Show("There is an Error Deleting this Package");
                    return;
                }
                else
                    MessageBox.Show("Deleted");

                Refreshing();
            }
        }

        private void Get_info_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.Is_Empty(comboBox1.Text))
            {
                interval1.Visible = true;
                interval2.Visible = true;
                price1.Visible = true;
                price2.Visible = true;
                DataTable d = controler.Search_Package(comboBox1.Text);

                interval2.Text = d.Rows[0][1].ToString();
                price2.Text = d.Rows[0][2].ToString();
            }
        }
    }
}
