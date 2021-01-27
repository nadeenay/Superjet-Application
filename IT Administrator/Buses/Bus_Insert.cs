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
    public partial class Bus_Insert : UserControl
    {
        Controller controller;
        public Bus_Insert()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void BUS_Insert_btn_Click(object sender, EventArgs e)
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
                        string type = Type_CB.SelectedItem.ToString();
                        string licnece = License_TB.Text;
                        int seats = Convert.ToInt32(Seats_Numeric.Value);

                        int result = controller.Insert_Bus(modelYear, engineNO, mac, model, Rdate, department, licnece, type, seats);
                        if (result == 0)
                        {
                            Message_Form message = new Message_Form();
                            message.Title("There was an Error Inserting this Bus");
                            message.Title_Color(Color.Red);
                            message.Show();
                        }
                        else
                        {
                            Message_Form message = new Message_Form();
                            Object id = controller.Last_Bus_ID();
                            message.Title("Bus was added with ID = " + id.ToString());
                            message.Show();
                        }
                    }
                }
            }
        }
    }
}
