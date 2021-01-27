using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Administrator
{
    public partial class ITAdministrator : Form
    {
        int page;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public ITAdministrator()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            employee_Insert1.Visible = true;
            employee_Update1.Visible = false;
            employee_Delete1.Visible = false;
            page = 0;
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employee_btn_Click(object sender, EventArgs e)
        {
            Moving_Panel.Top = Employee_btn.Top;
            page = 0;
            employee_Insert1.Visible = true;
            employee_Update1.Visible = false;
            employee_Delete1.Visible = false;
            

            driver_Delete1.Visible = false;
            driver_Insert1.Visible = false;
            driver_Update1.Visible = false;

            bus_Insert1.Visible = false;
            bus_Update1.Visible = false;
            bus_Delete1.Visible = false;

            weeklyTrips_Insert1.Visible = false;
            weeklyTrips_Update1.Visible = false;
            weeklyTrip_Delete1.Visible = false;
        }

        private void Driver_btn_Click(object sender, EventArgs e)
        {
            Moving_Panel.Top = Driver_btn.Top;
            page = 1;
            employee_Insert1.Visible = false;
            employee_Update1.Visible = false;
            employee_Delete1.Visible = false;
            

            driver_Delete1.Visible = false;
            driver_Insert1.Visible = true;
            driver_Update1.Visible = false;
            driver_Insert1.Refreshing();

            bus_Insert1.Visible = false;
            bus_Update1.Visible = false;
            bus_Delete1.Visible = false;

            weeklyTrips_Insert1.Visible = false;
            weeklyTrips_Update1.Visible = false;
            weeklyTrip_Delete1.Visible = false;
        }

        private void Buses_btn_Click(object sender, EventArgs e)
        {
            Moving_Panel.Top = Buses_btn.Top;
            page = 2;
            employee_Insert1.Visible = false;
            employee_Update1.Visible = false;
            employee_Delete1.Visible = false;
            

            driver_Delete1.Visible = false;
            driver_Insert1.Visible = false;
            driver_Update1.Visible = false;

            bus_Insert1.Visible = true;
            bus_Update1.Visible = false;
            bus_Delete1.Visible = false;

            weeklyTrips_Insert1.Visible = false;
            weeklyTrips_Update1.Visible = false;
            weeklyTrip_Delete1.Visible = false;
        }

        private void WeeklyTrips_btn_Click(object sender, EventArgs e)
        {
            Moving_Panel.Top = WeeklyTrips_btn.Top;
            page = 3;
            employee_Insert1.Visible = false;
            employee_Update1.Visible = false;
            employee_Delete1.Visible = false;
            

            driver_Delete1.Visible = false;
            driver_Insert1.Visible = false;
            driver_Update1.Visible = false;

            bus_Insert1.Visible = false;
            bus_Update1.Visible = false;
            bus_Delete1.Visible = false;

            weeklyTrips_Insert1.Visible = true;
            weeklyTrips_Update1.Visible = false;
            weeklyTrip_Delete1.Visible = false;
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                employee_Insert1.Visible = true;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
            else if (page == 1)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = true;
                driver_Update1.Visible = false;
                driver_Insert1.Refreshing();

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
            else if (page == 2)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;

                bus_Insert1.Visible = true;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
            else if (page == 3)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = true;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = true;
                employee_Delete1.Visible = false;
                employee_Update1.Refreshing();
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
            else if (page == 1)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = true;
                driver_Update1.Refreshing();

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
            else if (page == 2)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;

                bus_Insert1.Visible = false;
                bus_Update1.Visible = true;
                bus_Delete1.Visible = false;
                bus_Update1.Refreshing();

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
            else if (page == 3)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = true;
                weeklyTrip_Delete1.Visible = false;
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = true;
                employee_Delete1.Refreshing();
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
            else if (page == 1)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = true;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;
                driver_Delete1.Refreshing();

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
            else if (page == 2)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = true;
                bus_Delete1.Refreshing();

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = false;
            }
            else if (page == 3)
            {
                employee_Insert1.Visible = false;
                employee_Update1.Visible = false;
                employee_Delete1.Visible = false;
                

                driver_Delete1.Visible = false;
                driver_Insert1.Visible = false;
                driver_Update1.Visible = false;

                bus_Insert1.Visible = false;
                bus_Update1.Visible = false;
                bus_Delete1.Visible = false;

                weeklyTrips_Insert1.Visible = false;
                weeklyTrips_Update1.Visible = false;
                weeklyTrip_Delete1.Visible = true;
            }
        }

   
    }
}
