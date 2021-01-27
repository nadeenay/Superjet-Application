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
    public partial class Insert_Ad_Contact : UserControl
    {
        Controller controller;
        public Insert_Ad_Contact()
        {
            InitializeComponent();
            controller = new Controller();
            Refreshing();
        }

        public void Refreshing()
        {
            DataTable dt = controller.Get_All_Available_Package();
            packageCombo.DataSource = dt;
            packageCombo.DisplayMember = "Package_Name";
            packageCombo.ValueMember = "Package_Name";
            packageCombo.Refresh();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();

            if (v.Check_Name(nametxt.Text) && v.NationalID(id.Text) && v.PhoneNumber(phonenum.Text) && v.Is_Empty(address.Text) && v.Two_Dates(DateTime.Today, startd.Value))
            {
                int interval = Convert.ToInt32(controller.Find_Duration(packageCombo.Text).Rows[0][0]);
                DateTime s = startd.Value;
                DateTime end = s.AddDays(interval);
                DataTable Buses = controller.Search_Bus_For_AD_Contract(s, end);

                if (Buses != null)
                {
                    int x = controller.Insert_Ad_Contract(s, end, nametxt.Text, id.Text, address.Text, genderCombo.Text, packageCombo.Text, phonenum.Text, Convert.ToInt32(Buses.Rows[0][0]));
                    if (x == 0)
                        MessageBox.Show("Error");
                    else
                        MessageBox.Show("Inserted");
                }
                else
                {
                    MessageBox.Show("No Available Buses With this Dates");
                }


            }
        }
    }
}
