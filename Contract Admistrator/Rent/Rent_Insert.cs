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
using SuperJet.Contract_Admistrator.Rent;
using SuperJet;
using DB_project1;

namespace Contract_Administrator
{
    public partial class Rent_insert : UserControl
    {
        Controller controller;
        public Rent_insert()
        {
            InitializeComponent();
            controller = new Controller();

            Refreshing();
            genderCombo.Text = "Male";
        }

        public void Refreshing()
        {
            DataTable dt = controller.Search_Available_Rent_Buses(startd.Value, endd.Value);
            if (dt != null)
            {
                busID.DataSource = dt;
                busID.DisplayMember = "Bus_ID";
                busID.Text = dt.Rows[0][0].ToString();
                busID.Refresh();
            }
            else
                busID.Text = "";
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            if (busID.Text == "")
            {
                MessageBox.Show("Please Select a Bus ID");
                return;
            }
            Validation_Class v = new Validation_Class();

            DateTime startDate = startd.Value;
            DateTime Enddate = endd.Value;
            int price = Convert.ToInt32(Price.Value);
            string Gender = genderCombo.Text;
            string Name = name.Text;
            string NID = id.Text;
            string Address = address.Text;
            string PhoneNumber = phonenum.Text;

            if (v.Check_Name(Name) && v.NationalID(NID) && v.Is_Empty(Address) && v.PhoneNumber(PhoneNumber) && v.Two_Dates(startDate, Enddate))
            {
                int BusID = Convert.ToInt32(busID.Text);
                int result = controller.Insert_Rent_Contract(startDate, Enddate, price, Name, NID, Address, Gender, BusID, PhoneNumber);
                if (result == 0)
                    MessageBox.Show("Error");
                else
                    MessageBox.Show("Inserted");
                Date_ValueChanged(sender, e);
            }
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = startd.Value;
            DateTime Enddate = endd.Value;
            DataTable dt = controller.Search_Available_Rent_Buses(startd.Value, endd.Value);
            if (dt != null)
            {
                busID.DataSource = dt;
                busID.DisplayMember = "Bus_ID";
                busID.Text = dt.Rows[0][0].ToString();
                busID.Refresh();
            }
            else
                busID.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Bus_Rent_Search_Form bus = new Bus_Rent_Search_Form();
            bus.Show();
        }
    }
}
