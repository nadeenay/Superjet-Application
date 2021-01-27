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
    public partial class Driver_Update : UserControl
    {
        Controller controller;
        string OldPhone;
        public Driver_Update()
        {
            InitializeComponent();
            controller = new Controller();
            Refreshing();
        }

        public void Refreshing()
        {
            Disable();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.PhoneNumber(DPhone_Search_Texbox.Text))
            {
                DataTable result = controller.Search_Driver(DPhone_Search_Texbox.Text);
                if (result == null)
                    NotFound();
                else
                {
                    Found();

                    DataTable d = controller.Get_Non_Driven_Buses();
                    Bus_ID_CB.DataSource = d;
                    Bus_ID_CB.DisplayMember = "Bus_ID";
                    Bus_ID_CB.ValueMember = "Bus_ID";
                    Bus_ID_CB.Refresh();

                    if (d == null)
                        Bus_ID_CB.Text = "";
                    else
                        Bus_ID_CB.Text = d.Rows[0][0].ToString();

                    DName_Update_Texbox.Text = result.Rows[0][1].ToString();
                    BD_DatePicker.Value = Convert.ToDateTime(result.Rows[0][2].ToString());
                    DriverPhone_Update_Texbox.Text = result.Rows[0][3].ToString();
                    DAdress_Update_Texbox.Text = result.Rows[0][4].ToString();
                    DSalary_Update_Texbox.Text = result.Rows[0][5].ToString();
                    DID_Update_Texbox.Text = result.Rows[0][6].ToString();
                    Blood_CBox.Text = result.Rows[0][9].ToString();
                    Driver_Traffic_Update_TB.Text = result.Rows[0][10].ToString();
                    DriverLicence_Number_Update_Texbox.Text = result.Rows[0][11].ToString();
                    Driver_Licence_EndDate.Value = Convert.ToDateTime(result.Rows[0][12].ToString());
                    OldPhone = DriverPhone_Update_Texbox.Text;
                }
            }
        }

        private void NotFound()
        {
            Found_label.Text = "Not Found";
            Found_label.ForeColor = Color.Red;
            Disable();

        }
        private void Disable()
        {
            Name_label.Visible = false;
            DName_Update_Texbox.Visible = false;

            PhoneNumber_Label.Visible = false;
            DriverPhone_Update_Texbox.Visible = false;

            Salary_label.Visible = false;
            DSalary_Update_Texbox.Visible = false;

            IicenceNumber_Label.Visible = false;
            DriverLicence_Number_Update_Texbox.Visible = false;

            Traffic_Label.Visible = false;
            Driver_Traffic_Update_TB.Visible = false;

            EndDate_Label.Visible = false;
            Driver_Licence_EndDate.Visible = false;

            NationalID_label.Visible = false;
            DID_Update_Texbox.Visible = false;

            BD_label.Visible = false;
            BD_DatePicker.Visible = false;

            Address_label.Visible = false;
            DAdress_Update_Texbox.Visible = false;

            BloodType_label.Visible = false;
            Blood_CBox.Visible = false;

            Bus_Label.Visible = false;
            Bus_ID_CB.Visible = false;

            Driver_UpdateBtn.Visible = false;

            Change_CheckBox.Visible = false;
        }

        private void Found()
        {
            Found_label.Text = "Found";
            Found_label.ForeColor = Color.Lime;

            Name_label.Visible = true;
            DName_Update_Texbox.Visible = true;

            PhoneNumber_Label.Visible = true;
            DriverPhone_Update_Texbox.Visible = true;

            Salary_label.Visible = true;
            DSalary_Update_Texbox.Visible = true;

            IicenceNumber_Label.Visible = true;
            DriverLicence_Number_Update_Texbox.Visible = true;

            Traffic_Label.Visible = true;
            Driver_Traffic_Update_TB.Visible = true;

            EndDate_Label.Visible = true;
            Driver_Licence_EndDate.Visible = true;

            NationalID_label.Visible = true;
            DID_Update_Texbox.Visible = true;

            BD_label.Visible = true;
            BD_DatePicker.Visible = true;

            Address_label.Visible = true;
            DAdress_Update_Texbox.Visible = true;

            BloodType_label.Visible = true;
            Blood_CBox.Visible = true;

            Bus_Label.Visible = true;
            Bus_ID_CB.Visible = true;

            Driver_UpdateBtn.Visible = true;

            Change_CheckBox.Visible = true;
        }

        private void Driver_UpdateBtn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            int busid = -1;
            if (Change_CheckBox.Checked)
                if (Bus_ID_CB.Text == "")
                {
                    Message_Form message = new Message_Form();
                    message.Title("Error: The Driver does not have a Bus ID");
                    message.Title_Color(Color.Red);
                    message.Show();
                    return;
                }
                else if (v.IsPositiveNumber(Bus_ID_CB.Text))
                    busid = Convert.ToInt32(Bus_ID_CB.Text);
                else
                {
                    Message_Form message = new Message_Form();
                    message.Title("Please Enter a Positive Bus ID");
                    message.Title_Color(Color.Red);
                    message.Show();
                    return;
                }

            if (v.Check_Name(DName_Update_Texbox.Text) && v.PhoneNumber(DriverPhone_Update_Texbox.Text) && v.IsPositiveNumber(DSalary_Update_Texbox.Text))
            {
                if (v.NationalID(DID_Update_Texbox.Text) && v.Two_Dates(BD_DatePicker.Value, DateTime.Today.AddYears(-18)))
                {
                    if (v.Is_Empty(DAdress_Update_Texbox.Text) && v.IsPositiveNumber(DriverLicence_Number_Update_Texbox.Text) && v.Check_Name(Driver_Traffic_Update_TB.Text) && v.Two_Dates(DateTime.Today, Driver_Licence_EndDate.Value))
                    {
                        string name = DName_Update_Texbox.Text;
                        string phone = DriverPhone_Update_Texbox.Text;
                        int salary = Convert.ToInt32(DSalary_Update_Texbox.Text);
                        string blood = Blood_CBox.Text;
                        string NID = DID_Update_Texbox.Text;
                        DateTime BD = BD_DatePicker.Value;
                        string address = DAdress_Update_Texbox.Text;
                        string DrivingLicence = DriverLicence_Number_Update_Texbox.Text;
                        string trafficDepartment = Driver_Traffic_Update_TB.Text;
                        DateTime RDate = Driver_Licence_EndDate.Value;

                        int resulut = controller.Update_Driver(name, BD, OldPhone, phone, address, salary, NID, blood, trafficDepartment, DrivingLicence, RDate, busid);
                        if (resulut == 0)
                        {
                            Message_Form message = new Message_Form();
                            message.Title("There was an Error Updating this Driver");
                            message.Title_Color(Color.Red);
                            message.Show();
                        }
                        else
                        {
                            Message_Form message = new Message_Form();
                            message.Title("Driver was Updated Successfully");
                            message.Show();

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
                    }
                }

            }

        }

        private void Change_CheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            Bus_ID_CB.Visible = !Bus_ID_CB.Visible;
            Bus_Label.Visible = !Bus_Label.Visible;
        }
    }
}
