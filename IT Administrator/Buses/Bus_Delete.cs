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
    public partial class Bus_Delete : UserControl
    {
        Controller controller;
        DataTable Bus;
        public Bus_Delete()
        {
            InitializeComponent();
            controller = new Controller();
            Refreshing();
        }

        public void Refreshing()
        {
            Disable();
            Bus = null;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

            Validation_Class v = new Validation_Class();
            if (v.Is_Empty(Bus_Search_Texbox.Text))
            {
                Bus = controller.Search_Bus(Bus_Search_Texbox.Text);
                if (Bus == null)
                    NotFound();
                else
                {
                    Found();
                    EngineNo_Label.Text = Bus.Rows[0][2].ToString();
                    Manufacturer_Label.Text = Bus.Rows[0][3].ToString();
                    ModelAns_Label.Text = Bus.Rows[0][4].ToString();
                    ModelYearAns_Label.Text = Bus.Rows[0][1].ToString();
                    RDateAns_label.Text = String.Format("{0:dd-MM-yyyy}", Bus.Rows[0][5]);
                    DepartmentAns_Label.Text = Bus.Rows[0][6].ToString();
                    TypeAns_Label.Text = Bus.Rows[0][8].ToString();
                    LicenseAns_Label.Text = Bus.Rows[0][7].ToString();
                    SeatsAns_Label.Text = Bus.Rows[0][9].ToString();
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

        private void BUS_Delete_btn_Click(object sender, EventArgs e)
        {
            if (Bus == null)
            {
                Message_Form message = new Message_Form();
                message.Title("Please Enter a Valid License Number");
                message.Title_Color(Color.Red);
                message.Show();
                return;
            }
            Object Count;
            if (Bus.Rows[0][8].ToString() == "Rent")
            {
                Count = controller.Search_Bus_In_Rent(Convert.ToInt32(Bus.Rows[0][0]));
                if (Convert.ToInt32(Count) > 0)
                {
                    Message_Form message = new Message_Form();
                    message.Title("Cannot Delete this Bus Beacuse");
                    message.Title_Color(Color.Red);
                    message.Extra_Message("It has a Rent Contract");
                    message.Extra_Message_Color(Color.Red);
                    message.Show();
                    return;
                }
            }
            else
            {
                Count = controller.Search_Bus_In_AD(Convert.ToInt32(Bus.Rows[0][0]));
                if (Convert.ToInt32(Count) > 0)
                {
                    Message_Form message = new Message_Form();
                    message.Title("Cannot Delete this Bus Beacuse");
                    message.Title_Color(Color.Red);
                    message.Extra_Message("It has a AD Contract");
                    message.Extra_Message_Color(Color.Red);
                    message.Show();
                    return;
                }
                Count = controller.Search_Bus_In_WeeklyTrip(Convert.ToInt32(Bus.Rows[0][0]));
                if (Convert.ToInt32(Count) > 0)
                {
                    Message_Form message = new Message_Form();
                    message.Title("Cannot Delete this Bus Beacuse");
                    message.Title_Color(Color.Red);
                    message.Extra_Message("There is Upcoming Trips with this Bus");
                    message.Extra_Message_Color(Color.Red);
                    message.Show();
                    return;
                }
            }


            int result = controller.Delete_Bus(Bus.Rows[0][7].ToString());
            if (result == 0)
            {
                Message_Form message = new Message_Form();
                message.Title("There was an Error Deleting this Bus");
                message.Title_Color(Color.Red);
                message.Show();
            }
            else
            {
                Message_Form message = new Message_Form();
                message.Title("The Bus is Deleted Successfully");
                message.Show();
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
            EngineNo_Label.Visible = false;

            ManufacturerCo_Label.Visible = false;
            Manufacturer_Label.Visible = false;

            Model_Label.Visible = false;
            ModelAns_Label.Visible = false;

            ModelYear_Label.Visible = false;
            ModelYearAns_Label.Visible = false;

            RDate_Label.Visible = false;
            RDateAns_label.Visible = false;

            Department_Label.Visible = false;
            DepartmentAns_Label.Visible = false;

            Type_Label.Visible = false;
            TypeAns_Label.Visible = false;

            License_Label.Visible = false;
            LicenseAns_Label.Visible = false;

            Seats_Label.Visible = false;
            SeatsAns_Label.Visible = false;

            BUS_Delete_btn.Visible = false;
        }

        private void Found()
        {
            Found_label.Text = "Found";
            Found_label.ForeColor = Color.Lime;

            Bus_Engine_Label.Visible = true;
            EngineNo_Label.Visible = true;

            ManufacturerCo_Label.Visible = true;
            Manufacturer_Label.Visible = true;

            Model_Label.Visible = true;
            ModelAns_Label.Visible = true;

            ModelYear_Label.Visible = true;
            ModelYearAns_Label.Visible = true;

            RDate_Label.Visible = true;
            RDateAns_label.Visible = true;

            Department_Label.Visible = true;
            DepartmentAns_Label.Visible = true;

            Type_Label.Visible = true;
            TypeAns_Label.Visible = true;

            License_Label.Visible = true;
            LicenseAns_Label.Visible = true;

            Seats_Label.Visible = true;
            SeatsAns_Label.Visible = true;

            BUS_Delete_btn.Visible = true;
        }
    }
}
