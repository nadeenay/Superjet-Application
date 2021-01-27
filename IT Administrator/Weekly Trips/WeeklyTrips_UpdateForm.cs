using DB_project1;
using SuperJet;
using SuperJet.IT_Administrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Administrator.Weekly_Trips
{
    public partial class WeeklyTrips_UpdateForm : Form
    {
        Controller controller;
        string Start;
        string End;
        string Phone;
        int Price;
        int WeekTripID;
        string DriverID;
        string Day;
        TimeSpan Time;
        int Av;

        public WeeklyTrips_UpdateForm(string start, string end, int TripsId, string diverId, string phone,
            string price, string day, string time, int avliabal)
        {
            InitializeComponent();
            controller = new Controller();
            TimeAns_Picker.Format = DateTimePickerFormat.Time;
            TimeAns_Picker.ShowUpDown = true;

            Start = start;
            Start_Point_tb.Text = Start;

            End = end;
            End_Point_tb.Text = End;

            WeekTripID = TripsId;

            Phone = phone;
            Driver_Phone_tb.Text = phone;

            Price = Convert.ToInt32(price);
            PriceAns_tb.Text = price;

            Day = day;
            DayAns_CB.SelectedItem = day;

            TimeAns_Picker.Value = Convert.ToDateTime(time);

            Av = avliabal;
            Available_CHB.Checked = Convert.ToBoolean(Av);
            Driver_Phone_tb.Visible = Convert.ToBoolean(Av);
        }

        private void Weekly_Update_btn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();

            if (v.Check_Name(Start_Point_tb.Text) && v.Check_Name(End_Point_tb.Text) && v.IsPositiveNumber(PriceAns_tb.Text))
            {
                Start = Start_Point_tb.Text;
                End = End_Point_tb.Text;
                Price = Convert.ToInt32(PriceAns_tb.Text);
                Day = DayAns_CB.SelectedItem.ToString();
                Time = TimeAns_Picker.Value.TimeOfDay;


                if(v.PhoneNumber(Driver_Phone_tb.Text))
                {
                    if (Av == 1)
                    {
                        if (Phone == Driver_Phone_tb.Text)
                        {
                            int result = controller.Update_Weeklytrip(Start, End, WeekTripID, -1
                            , Price, Day, Time, Av);
                            if (result == 0)
                            {
                                Message_Form message = new Message_Form();
                                message.Title("There was an Error Updating this Weekly Trip");
                                message.Title_Color(Color.Red);
                                message.Show();
                            }
                            else
                            {
                                this.Close();
                                Message_Form message = new Message_Form();
                                Object id = controller.Last_WeeklyTrip_ID();
                                message.Title("Weekly Trip was Updated Successfully");
                                message.Show();
                            }
                        }
                        else
                        {
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

                                DataTable DriverTrips = controller.Search_Weekly_Trips_Driver(driverid, Day);
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

                                        if (Time < a && Time > s)
                                        {
                                            Message_Form message = new Message_Form();
                                            message.Title("The Driver already make Trips in");
                                            message.Title_Color(Color.Red);
                                            message.Extra_Message("the same day and the time is not Sufficent");
                                            message.Extra_Message_Color(Color.Red);
                                            message.Show();
                                            return;
                                        }

                                        if (Start != DriverTrips.Rows[0][2].ToString() || End != DriverTrips.Rows[0][1].ToString())
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

                                int result = controller.Update_Weeklytrip(Start, End, WeekTripID, driverid, Price, Day, Time, Av);
                                if (result == 0)
                                {
                                    Message_Form message = new Message_Form();
                                    message.Title("There was an Error Updating this Weekly Trip");
                                    message.Title_Color(Color.Red);
                                    message.Show();
                                }
                                else
                                {
                                    this.Close();
                                    Message_Form message = new Message_Form();
                                    Object id = controller.Last_WeeklyTrip_ID();
                                    message.Title("Weekly Trip was Updated Successfully");
                                    message.Show();
                                }

                            }
                        }
                    }
                    else
                    {
                        int result = controller.Update_Weeklytrip(Start, End, WeekTripID, 0, Price, Day, Time, Av);
                        if (result == 0)
                        {
                            Message_Form message = new Message_Form();
                            message.Title("There was an Error Updating this Weekly Trip");
                            message.Title_Color(Color.Red);
                            message.Show();
                        }
                        else
                        {
                            this.Close();
                            Message_Form message = new Message_Form();
                            Object id = controller.Last_WeeklyTrip_ID();
                            message.Title("Weekly Trip was Updated Successfully");
                            message.Show();
                        }
                    }
                }
            }
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Available_CHB_Click(object sender, EventArgs e)
        {
            Driver_Phone_tb.Visible = !Driver_Phone_tb.Visible;
            Av = Convert.ToInt32(Available_CHB.Checked);
        }
    }
}
