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
using DB_project1;

namespace IT_Administrator.Weekly_Trips
{
    public partial class WeeklyTrips_Update : UserControl
    {
        Controller controller;
        public WeeklyTrips_Update()
        {
            InitializeComponent();
            controller = new Controller();
            flowLayoutPanel1.VerticalScroll.Enabled = true;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable data;
            if (Start_Search_tb.Text == "" && End_Search_tb.Text == "")
            {
                Message_Form message = new Message_Form();
                message.Title("Please Enter any Location");
                message.Show();
                return;
            }
            else if (Start_Search_tb.Text == "")
                data = controller.Search_WeeklyTrip_End(End_Search_tb.Text);
            else if (End_Search_tb.Text == "")
                data = controller.Search_WeeklyTrip_Start(Start_Search_tb.Text);
            else
                data = controller.Search_WeeklyTrip_Start_End(Start_Search_tb.Text, End_Search_tb.Text);


            int count;
            if (data == null)
            {
                Message_Form message = new Message_Form();
                message.Title("There is no Trips with the Provided Location(s)");
                message.Show();
            }
            else
            {
                count = data.Rows.Count;
                WeeklyTripListItem[] list = new WeeklyTripListItem[count];

                for (int i = 0; i < count; i++)
                {
                    list[i] = new WeeklyTripListItem();
                    list[i].StartPoint = data.Rows[i][1].ToString();
                    list[i].Endpoint = data.Rows[i][2].ToString();
                    list[i].PriCe = data.Rows[i][6].ToString();
                    list[i].DaY = data.Rows[i][4].ToString();
                    list[i].TimE = data.Rows[i][5].ToString();
                    list[i].DriverID = data.Rows[i][3].ToString();
                    list[i].AvilabilitY = data.Rows[i][7].ToString();
                    list[i].Index = i + 1;
                    list[i].TripID = Convert.ToInt32(data.Rows[i][0]);
                    list[i].DeleteButtonVisable = false;

                    if (list[i].DriverID != "")
                    {
                        DataTable driver = controller.Search_Driver(Convert.ToInt32(data.Rows[i][3]));
                        list[i].Drivername = driver.Rows[0][1].ToString();
                        list[i].DriverPhone = driver.Rows[0][3].ToString();
                    }
                    else
                    {
                        list[i].Drivername = "";
                        list[i].DriverPhone = "";
                    }

                    flowLayoutPanel1.Controls.Add(list[i]);
                }
            }
        }
    }
}
