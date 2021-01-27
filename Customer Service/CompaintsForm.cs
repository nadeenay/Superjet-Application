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
    public partial class CompaintsForm : Form
    {
        Controller controllerObj;
        Form Myparent;
        public CompaintsForm(Form L)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Myparent = L;
            L.Hide();
        }

        private void complaintadding_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (pID.Text == "" || Tid.Text == "" || !v.Is_Empty(complaintdiscpribtion.Text))
                MessageBox.Show("all values are required ");
            else if (v.IsPositiveNumber(Tid.Text)  && v.PhoneNumber(pID.Text))
            {
                DataTable passengerid = controllerObj.Get_Passenger_id(pID.Text);
                if (passengerid == null)
                    MessageBox.Show("No passenger with this Phone number exists ");
                else if (Convert.ToInt32(controllerObj.CheckTripID(Tid.Text)) == 0)
                    MessageBox.Show("No trip with this ID exists ");
                else if (Convert.ToInt32(controllerObj.PassengerinTrip(passengerid.Rows[0][0].ToString(), Tid.Text)) == 0)
                {
                    MessageBox.Show("This passenger is not in this Bus trip ");
                }
                else
                {
                    DataTable dt1 = controllerObj.DriverOfWeeklTrip(Tid.Text);
                    string driverid = dt1.Rows[0][0].ToString();
                    int res = controllerObj.AddComplaint(Tid.Text, passengerid.Rows[0][0].ToString(), complaintdiscpribtion.Text, driverid);
                    if (res == 1) MessageBox.Show("Complaint's added successfully !");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Myparent.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you return to home page ,you will be logged out ,Are you sure you want to log out ?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
            }
        }
    }
}
