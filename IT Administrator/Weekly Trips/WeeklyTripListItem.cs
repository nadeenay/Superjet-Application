using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Administrator.Weekly_Trips
{
    public partial class WeeklyTripListItem : UserControl
    {
        public WeeklyTripListItem()
        {
            InitializeComponent();
        }

        private string startpoint;
        private string EndPoint;
        private string Price;
        private string Driverphone;
        private string Day;
        private string Time;
        private string Avilability;
        private int index;
        private string DriverName;
        private string Driverid;
        private int TripId;
        private bool EditButton_Visable;
        private bool DeleteButton_Visable;

        public string StartPoint
        {
            get { return startpoint; }
            set { startpoint = value; start.Text = startpoint; }
        }
        public string Endpoint
        {
            get { return EndPoint; }
            set { EndPoint = value; end.Text = EndPoint; }
        }
        public string PriCe
        {
            get { return Price; }
            set { Price = value; price.Text = Price; }
        }
        public string DriverPhone
        {
            get { return Driverphone; }
            set { Driverphone = value; DriverPhone_Label.Text = Driverphone; }
        }
        public string DaY
        {
            get { return Day; }
            set { Day = value; day.Text = Day; }
        }
        public string TimE
        {
            get { return Time; }
            set { Time = value; time.Text = Time; }
        }
        public string AvilabilitY
        {
            get { return Avilability; }
            set { Avilability = value; Available.Text = Avilability; }
        }
        public int Index
        {
            get { return index; }
            set { index = value; Index_Label.Text = index.ToString(); }
        }
        public string Drivername
        {
            get { return DriverName; }
            set { DriverName = value; DriverName_Label.Text = DriverName; }
        }
        public string DriverID
        {
            get { return Driverid; }
            set { Driverid = value; ID_Label.Text = Driverid.ToString(); }
        }
        public int TripID
        {
            get { return TripId; }
            set { TripId = value; }
        }
        public bool EditButtonVisable
        {
            get { return EditButton_Visable; }
            set { EditButton_Visable = value; EditButton.Visible = EditButton_Visable; }
        }
        public bool DeleteButtonVisable
        {
            get { return DeleteButton_Visable; }
            set { DeleteButton_Visable = value; DeleteButton.Visible = DeleteButton_Visable; }
        }



        private void EditButton_Click(object sender, EventArgs e)
        {
            int av = (Avilability == "False") ? 0 : 1;

            WeeklyTrips_UpdateForm Update_Form = new WeeklyTrips_UpdateForm(startpoint, EndPoint,
               TripId, Driverid, Driverphone, Price, Day, Time, av);
            Update_Form.Show();
        }

        private void WeeklyTripListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 22, 50);
        }
        private void WeeklyTripListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 22, 31);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            WeeklyTrip_Delete_Form _DeleteForm = new WeeklyTrip_Delete_Form(TripId);
            _DeleteForm.Show();
        }

        private void WeeklyTripListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
