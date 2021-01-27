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

namespace Contract_Administrator.Package
{
    public partial class Insert__Package : UserControl
    {
        Controller controller;
        public Insert__Package()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if(v.Check_Name(name.Text) && v.IsPositiveNumber(intervaltxt.Text))
            {
                int x = controller.Insert_Packages(name.Text, Convert.ToInt32(intervaltxt.Text), Convert.ToInt32(price.Value));
                if (x == 0)
                    MessageBox.Show("There is a Package with the same Name");
                else
                    MessageBox.Show("Inserted");
            }
        }
    }
}
