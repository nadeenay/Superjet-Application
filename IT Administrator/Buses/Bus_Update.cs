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

namespace IT_Administrator.Buses
{
    public partial class Bus_Update : UserControl
    {
        Controller controller;
        string OldLicence;
        public Bus_Update()
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
            if (v.Is_Empty(Bus_Search_Texbox.Text))
            {
                DataTable result = controller.Search_Bus(Bus_Search_Texbox.Text);
                if (result == null)
                    NotFound();
                else
                {
                    Found();
                    EngineNo_TB.Text = result.Rows[0][2].ToString();
                    Manufacturer_TB.Text = result.Rows[0][3].ToString();
                    Model_TB.Text = result.Rows[0][4].ToString();
                    ModelYear_TB.Text = result.Rows[0][1].ToString();
                    RDate_Picker.Value = Convert.ToDateTime(result.Rows[0][5].ToString());
                    Department_TB.Text = result.Rows[0][6].ToString();
                    //Type_CB.Text = result.Rows[0][8].ToString();
                    License_TB.Text = result.Rows[0][7].ToString();
                    OldLicence = License_TB.Text;
                    Seats_Numeric.Value = Convert.ToDecimal(result.Rows[0][9].ToString());
                }
            }
            else
            {
                Message_Form message = new Message_Form();
                message.Title("Please Enter a Valid License Number");
                message.Title_Color(Color.Red);
                message.Show();
            }
           
        }

        private void BUS_Update_btn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.Is_Empty(EngineNo_TB.Text) && v.Check_Name(Manufacturer_TB.Text) && v.Check_Name(Model_TB.Text))
            {
                if (v.IsPositiveNumber(ModelYear_TB.Text))
                {
                    int modelYear = Convert.ToInt32(ModelYear_TB.Text);
                    if (modelYear < 2010 || modelYear > 2021)
                    {
                        Message_Form message = new Message_Form();
                        message.Title("Please Enter Model Year");
                        message.Title_Color(Color.Red);
                        message.Extra_Message("Between 2010 and 2021");
                        message.Extra_Message_Color(Color.Red);
                        message.Show();
                        return;
                    }

                    if (v.Two_Dates(DateTime.Today, RDate_Picker.Value) && v.Check_Name(Department_TB.Text) && v.Is_Empty(License_TB.Text))
                    {
                        string engineNO = EngineNo_TB.Text;
                        string mac = Manufacturer_TB.Text;
                        string model = Model_TB.Text;
                        DateTime Rdate = RDate_Picker.Value;
                        string department = Department_TB.Text;
                        //string type = Type_CB.SelectedItem.ToString();
                        string licnece = License_TB.Text;
                        int seats = Convert.ToInt32(Seats_Numeric.Value);

                        int result = controller.Update_Bus(modelYear, engineNO, mac, model, Rdate, department, OldLicence, licnece, seats);
                        if (result == 0)
                        {
                            Message_Form message = new Message_Form();
                            message.Title("There is an Error Updating the Bus");
                            message.Title_Color(Color.Red);
                            message.Show();
                        }
                        else
                        {
                            Message_Form message = new Message_Form();
                            message.Title("The Bus is Updated Successfully");
                            message.Show();
                        }
                    }
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
            Bus_Engine_Label.Visible = false;
            EngineNo_TB.Visible = false;

            ManufacturerCo_Label.Visible = false;
            Manufacturer_TB.Visible = false;

            Model_Label.Visible = false;
            Model_TB.Visible = false;

            ModelYear_Label.Visible = false;
            ModelYear_TB.Visible = false;

            RDate_Label.Visible = false;
            RDate_Picker.Visible = false;

            Department_Label.Visible = false;
            Department_TB.Visible = false;

            //Type_Label.Visible = false;
            //Type_CB.Visible = false;

            License_Label.Visible = false;
            License_TB.Visible = false;

            Seats_Label.Visible = false;
            Seats_Numeric.Visible = false;

            BUS_Update_btn.Visible = false;
        }

        private void Found()
        {
            Found_label.Text = "Found";
            Found_label.ForeColor = Color.Lime;

            Bus_Engine_Label.Visible = true;
            EngineNo_TB.Visible = true;

            ManufacturerCo_Label.Visible = true;
            Manufacturer_TB.Visible = true;

            Model_Label.Visible = true;
            Model_TB.Visible = true;

            ModelYear_Label.Visible = true;
            ModelYear_TB.Visible = true;

            RDate_Label.Visible = true;
            RDate_Picker.Visible = true;

            Department_Label.Visible = true;
            Department_TB.Visible = true;

            //Type_Label.Visible = true;
            //Type_CB.Visible = true;

            License_Label.Visible = true;
            License_TB.Visible = true;

            Seats_Label.Visible = true;
            Seats_Numeric.Visible = true;

            BUS_Update_btn.Visible = true;
        }
    }
}
