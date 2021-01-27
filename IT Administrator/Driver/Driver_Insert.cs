using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperJet.IT_Administrator;
using SuperJet;
using DB_project1;

namespace IT_Administrator.Driver_UserControls
{
    public partial class Driver_Insert : UserControl
    {
        Controller controller;
        public Driver_Insert()
        {
            InitializeComponent();
            controller = new Controller();
            Refreshing();
        }

        public void Refreshing()
        {
            DataTable d = controller.Get_Non_Driven_Buses();
            Bus_ID_CB.DataSource = d;
            Bus_ID_CB.DisplayMember = "Bus_ID";
            Bus_ID_CB.ValueMember = "Bus_ID";
            Bus_ID_CB.Refresh();

            if (d == null)
                Bus_ID_CB.Text = "";
            else
                Bus_ID_CB.Text = d.Rows[0][0].ToString();
        }

        private void Driver_AddBtn_Click_1(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (Bus_ID_CB.Text == "")
            {
                MessageBox.Show("Please Enter a Bus ID");
                return;
            }
            if (v.Check_Name(DriverName_Insert_Texbox.Text) && v.PhoneNumber(DriverPhone_Texbox.Text) && v.IsPositiveNumber(DriverSalary_Insert_Texbox.Text))
            {
                if (v.NationalID(DriverNID_Insert_Texbox.Text) && v.Two_Dates(BD_DatePicker.Value, DateTime.Today.AddYears(-18)))
                {
                    if (v.Is_Empty(DriverAdress_Insert_Texbox.Text) && v.IsPositiveNumber(DriverLicence_Number_Insert_Texbox.Text) && v.Check_Name(Driver_Traffic.Text) && v.Two_Dates(DateTime.Today, Driver_Licence_EndDate.Value))
                    {
                        string name = DriverName_Insert_Texbox.Text;
                        string phone = DriverPhone_Texbox.Text;
                        int salary = Convert.ToInt32(DriverSalary_Insert_Texbox.Text);
                        string blood = Blood_CBox.Text;
                        string NID = DriverNID_Insert_Texbox.Text;
                        DateTime BD = BD_DatePicker.Value;
                        string address = DriverAdress_Insert_Texbox.Text;
                        string gender = Gender_CBox.Text;
                        string DrivingLicence = DriverLicence_Number_Insert_Texbox.Text;
                        string trafficDepartment = Driver_Traffic.Text;
                        DateTime RDate = Driver_Licence_EndDate.Value;
                        int result = controller.Insert_Driver(name, BD, phone, address, salary, NID, gender, blood, trafficDepartment, DrivingLicence, RDate, Convert.ToInt32(Bus_ID_CB.Text));
                        if (result == 0)
                        {
                            Message_Form message = new Message_Form();
                            message.Title("There was an Error inserting the Driver");
                            message.Title_Color(Color.Red);
                            message.Show();
                        }
                        else
                        {
                            Message_Form message = new Message_Form();
                            Object id = controller.Last_Driver_ID();
                            message.Title("Driver was added with ID = " + id.ToString());
                            message.Show();
                            DataTable d = controller.Get_Non_Driven_Buses();
                            Bus_ID_CB.DataSource = d;
                            Bus_ID_CB.DisplayMember = "Bus_ID";
                            Bus_ID_CB.ValueMember = "Bus_ID";
                            Bus_ID_CB.Refresh();
                        }
                    }
                }
            }
        }
    }
}
