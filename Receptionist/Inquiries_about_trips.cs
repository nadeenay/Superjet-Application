using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DB_project1.Receptionist
{
    public partial class Inquiries_about_trips : Form
    {
        Form Myparent;
        Controller controllerObj;
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
        public Inquiries_about_trips(Form L)
        {
            InitializeComponent();
            controllerObj = new Controller();
            flowLayoutPanel1.VerticalScroll.Enabled = true;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            DataTable L1 = controllerObj.Get_Location1();
            DataTable L2 = controllerObj.Get_Location2();
            comboBox1.DataSource = L1;
            comboBox1.DisplayMember = "Starting_Point";
            comboBox2.DataSource = L2;
            comboBox2.DisplayMember = "Ending_Point";
            Trip_Reservation.Visible = false;
            Myparent = L;
            Myparent.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                flowLayoutPanel1.Controls.Clear();
                DataTable data = controllerObj.Find_Weekly_Trips_Start_End(comboBox1.Text, comboBox2.Text);
                int count;
                if (data == null)
                {

                    MessageBox.Show("There is no Trips with the Provided Location(s)");
                    Trip_Reservation.Visible = false;

                }
                else
                {
                    count = data.Rows.Count;
                    Weekly_Trip_List_For_Search[] list = new Weekly_Trip_List_For_Search[count];

                    for (int i = 0; i < count; i++)
                    {
                        list[i] = new Weekly_Trip_List_For_Search();
                        list[i].DAY = data.Rows[i][0].ToString();
                        list[i].TIME = data.Rows[i][1].ToString();
                        flowLayoutPanel1.Controls.Add(list[i]);
                    }
                    Trip_Reservation.Visible = true;
                }
            }
            else
                MessageBox.Show("please Enter the data required");
        }

        private void Trip_Reservation_Click(object sender, EventArgs e)
        {
            FindTrip F = new FindTrip(this,comboBox1.Text,comboBox2.Text);
            F.Show();
        }
    }
}
