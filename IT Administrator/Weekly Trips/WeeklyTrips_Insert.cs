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

namespace IT_Administrator.Weekly_Trips
{
    public partial class WeeklyTrips_Insert : UserControl
    {
        Controller controller;
        public WeeklyTrips_Insert()
        {
            InitializeComponent();
            controller = new Controller();
            TimeAns_Picker.Format = DateTimePickerFormat.Time;
            TimeAns_Picker.ShowUpDown = true;

        }

        private void Weekly_Insert_btn_Click(object sender, EventArgs e)
        {
            string start, end, day;
            TimeSpan time;
            int price;
            int Available;

            Validation_Class v = new Validation_Class();

            if (v.Check_Name(Start_Point_tb.Text) && v.Check_Name(End_Point_tb.Text) && v.IsPositiveNumber(PriceAns_tb.Text))
            {
                if(Start_Point_tb.Text == End_Point_tb.Text)
                {
                    Message_Form message = new Message_Form();
                    message.Title("Start Point Can't be the same as the End Point");
                    message.Title_Color(Color.Red);
                    message.Show();
                    return;
                }

                start = Start_Point_tb.Text;
                end = End_Point_tb.Text;
                day = DayAns_CB.Text;
                time = TimeAns_Picker.Value.TimeOfDay;
                price = Convert.ToInt32(PriceAns_tb.Text);

                if (Available_CheckBox.Checked == true)
                {
                    Available = 0;
                    int result = controller.Insert_WeeklyTrip_WithoutDriver(start, end, day, time, price, Available);
                    if (result == 0)
                    {
                        Message_Form message = new Message_Form();
                        message.Title("There was an Error Inserting this Weekly Trip");
                        message.Title_Color(Color.Red);
                        message.Extra_Message("There is another WeeklyTrip with Same Paramters");
                        message.Show();
                        return;
                    }
                    else
                    {
                        Message_Form message = new Message_Form();
                        Object id = controller.Last_WeeklyTrip_ID();
                        message.Title("Weekly Trip was added with ID = " + id.ToString());
                        message.Extra_Message("NOTE: This weekly trip has no Driver");
                        message.Extra_Message_Color(Color.Red);
                        message.Show();
                        return;
                    }
                }
                else if (v.PhoneNumber(Driver_Phone_tb.Text))
                {
                    Available = 1;

                    DataTable Driver = controller.Search_Driver(Driver_Phone_tb.Text);
                    if (Driver == null)
                    {
                        Message_Form message = new Message_Form();
                        message.Title("The Driver is not Found");
                        message.Title_Color(Color.Red);
                        message.Show();
                        return;
                    }
                    else
                    {
                        int driverid = Convert.ToInt32(Driver.Rows[0][0].ToString());

                        DataTable DriverTrips = controller.Search_Weekly_Trips_Driver(driverid, day);
                        if (DriverTrips != null)
                            if (DriverTrips.Rows.Count > 1)
                            {
                                Message_Form message = new Message_Form();
                                message.Title("The Driver already make two Trips on this day");
                                message.Title_Color(Color.Red);
                                message.Show();
                                return;
                            }
                            else if (DriverTrips.Rows.Count == 1)
                            {
                                TimeSpan t = Convert.ToDateTime(DriverTrips.Rows[0][5].ToString()).TimeOfDay;
                                TimeSpan constant = new TimeSpan(5, 0, 0);
                                TimeSpan a = t.Add(constant);
                                TimeSpan s = t.Subtract(constant);

                                if (time < a && time > s)
                                {
                                    Message_Form message = new Message_Form();
                                    message.Title("The Driver already make Trips in");
                                    message.Title_Color(Color.Red);
                                    message.Extra_Message("the same day and the time is not Sufficent");
                                    message.Extra_Message_Color(Color.Red);
                                    message.Show();
                                    return;
                                }
                                
                                if (start != DriverTrips.Rows[0][2].ToString() || end != DriverTrips.Rows[0][1].ToString())
                                {
                                    Message_Form message = new Message_Form();
                                    message.Title("The Driver already make Trips in");
                                    message.Title_Color(Color.Red);
                                    message.Extra_Message("Another Place at the same day");
                                    message.Extra_Message_Color(Color.Red);
                                    message.Show();
                                    return;
                                }

                            }

                        int result = controller.Insert_WeeklyTrip_WithDriver(start, end, driverid, day, time, price, Available);
                        if (result == 0)
                        {
                            Message_Form message = new Message_Form();
                            message.Title("There was an Error Inserting this Weekly Trip");
                            message.Title_Color(Color.Red);
                            message.Extra_Message("There is another WeeklyTrip with Same Paramters");
                            message.Show();
                            return;
                        }
                        else
                        {
                            Message_Form message = new Message_Form();
                            Object id = controller.Last_WeeklyTrip_ID();
                            message.Title("Weekly Trip was added with ID = " + id.ToString());
                            message.Show();
                            return;
                        }
                    }
                }
            }


        }

        private void Available_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Available_CheckBox.Checked == true)
                Driver_Phone_tb.Visible = false;
            else
                Driver_Phone_tb.Visible = true;
        }
    }
}
