using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DB_project1.Receptionist;

namespace DB_project1
{/*try{*/
    public partial class FindTrip : Form
    {
        Controller controllerObj;
        Form Myparent;
        DataTable T;
        DataTable dT;
        int Trip_Price;
        int Total_Price;
        int Discount;
        int ID_B = -1; //ID OF THE BUS TRIP
        int ID_W; //ID OF THE WEEKLY TRIP
        //to make rounded form 
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
        ////////// ///////////////////////////////////////////////////////////////////////
        string location1;
        string location2;
        public FindTrip(Form L,string Lo1,string Lo2)// should  write Form l
        {
            InitializeComponent();
            controllerObj = new Controller();
          
            Myparent = L;
            Myparent.Hide();
            DataTable L1 = controllerObj.Get_Location1();
            DataTable L2 = controllerObj.Get_Location2();
         
            PromoCode_textBox.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
             location1 = Lo1;
             location2 = Lo2;


        }

        private void Search_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.Is_Empty(location1) && v.Is_Empty(location2) && v.Is_Empty(Time_TimePicker.Text) && v.Two_Dates(DateTime.Today, Date_TimePicker.Value))
            {
                T = controllerObj.Check(location1, location2, Date_TimePicker.Value.DayOfWeek.ToString(), Time_TimePicker.Value.TimeOfDay, Date_TimePicker.Value);
               
                 
                if (T != null)
                {
                    Trip_Price = (int)T.Rows[0][1];
                    ID_B = (int)T.Rows[0][0];

                    //if The Bus Trip was Found, Then there will be passengers in this trip 
                    Object Seatsum = controllerObj.Count_Current_seats(ID_B);
                    DataTable Num = controllerObj.Find_Num_Of_Seats_in_the_Bus(ID_B);
                    // check number of seats in this trip
                    if ((int)Num.Rows[0][0] - Convert.ToInt32(Seatsum) > Seats_Numeric.Value)
                    {
                        MessageBox.Show("There is an available trip ,You can reserve for Passenger now ");
                        //Calculate the total money the passenger should pay
                        Total_Price = Trip_Price * (int)Seats_Numeric.Value;
                        //check frist if the promo code valid for this trip or not
                        DataTable P = controllerObj.Check_Promo_Code_Validation(PromoCode_textBox.Text, ID_B);
                        Discount = (int)P.Rows[0][0];
                        if (P != null)
                        {
                            Total_Price = Total_Price - Convert.ToInt16(Total_Price * (Discount / 100.0));
                            MessageBox.Show("Promo Code is Applied succefully");
                        }
                        else if (PromoCode_textBox.Text != "")
                        {
                            MessageBox.Show("Promo Code is not valid for this trip");
                        }
                        MessageBox.Show("Total Price is " + Total_Price.ToString());
                        Insert_Passenger_information p = new Insert_Passenger_information(this, (int)Seats_Numeric.Value, ID_B,Total_Price);
                        p.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Sorry, but the trip is fully booked");
                    }
                }
                else
                {
                    dT = controllerObj.Find_Weekly_Trips(location1, location2, Date_TimePicker.Value.DayOfWeek.ToString(), Time_TimePicker.Value.TimeOfDay);
                    
                    if (dT != null)
                    {
                        Trip_Price = (int)dT.Rows[0][1];
                        ID_W = (int)dT.Rows[0][0];
                      DataTable Numseats_W = controllerObj.Find_Num_Of_Seats_in_the_Bus_Using_IDW(ID_W);
                        if ((int)Numseats_W.Rows[0][0] < Seats_Numeric.Value)
                        {
                            MessageBox.Show("Too much number of seats ,Can't reserve for that passenger ");
                        
                        }
                        else
                        {
                            int result = controllerObj.Insert_Bus_Trip(Date_TimePicker.Value, ID_W);
                            T = controllerObj.Check(location1, location2, Date_TimePicker.Value.DayOfWeek.ToString(), Time_TimePicker.Value.TimeOfDay, Date_TimePicker.Value);
                            ID_B = (int)T.Rows[0][0];


                            if (result == 1)
                            {
                                MessageBox.Show("there is an available trip ,You can reserve for Passenger now ");
                                //Calculate the total money the passenger should pay
                                Total_Price = Trip_Price * (int)Seats_Numeric.Value; 
                                //check frist if the promo code valid for this trip or not
                                DataTable P = controllerObj.Check_Promo_Code_Validation(PromoCode_textBox.Text, ID_B);
                                
                                if (P != null)
                                {
                                    Discount = (int)P.Rows[0][0];
                                    Total_Price = Total_Price-Convert.ToInt16(Total_Price * (Discount / 100.0));
                                    MessageBox.Show("Promo Code is Applied succefully");
                                }
                                else if (PromoCode_textBox.Text != "")
                                {
                                    MessageBox.Show("Promo Code is not valid for this trip");
                                }
                                MessageBox.Show("Total Price is "+ Total_Price.ToString());
                                Insert_Passenger_information p = new Insert_Passenger_information(this, (int)Seats_Numeric.Value, ID_B,Total_Price);
                                p.Show();
      
                            }
                            else
                                MessageBox.Show("Insertion failed");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Sorry,There is no Trip available so You can't reserve for the passenger");
                    }
                }
            }
        }


      

        private void Back_Click_1(object sender, EventArgs e)
        {

            Myparent.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You will log out ,if you sure enter yes", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Welcome W = new Welcome();
                this.Hide();
                W.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You will log out ,if you sure enter yes", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Welcome W = new Welcome();
                this.Hide();
                W.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Myparent.Show();
            this.Hide();
        }

        private void FindTrip_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }
    }
}