using DB_project1;
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
    public partial class WeeklyTrip_Delete_Form : Form
    {
        int TripID;
        Controller controller;
        public WeeklyTrip_Delete_Form(int tripid)
        {
            InitializeComponent();
            controller = new Controller();
            TripID = tripid;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int result = controller.Delete_WeeklyTrip(TripID);
            if (result == 1)
            {
                Message_Form message = new Message_Form();
                Object id = controller.Last_WeeklyTrip_ID();
                message.Title("Weekly Trip is Successfully unavailable");
                message.Show();
            }
            else
            {
                Message_Form message = new Message_Form();
                message.Title("There was an Error Deleting this Weekly Trip");
                message.Title_Color(Color.Red);
                message.Show();
            }
            Exit_btn_Click(sender, e);
        }
    }
}
