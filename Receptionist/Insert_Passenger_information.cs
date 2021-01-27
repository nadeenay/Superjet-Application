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

namespace DB_project1
{
    public partial class Insert_Passenger_information : Form
    {
        Controller controllerObj;
        Form Myparent;
        int Num_Of_Seats;
        int Trip_Id;
        int Trip_Total_Price;
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
        public Insert_Passenger_information(Form L, int S, int Trip_id,int Total_Price)
        {
            Num_Of_Seats = S;
            Trip_Id = Trip_id;
            Trip_Total_Price = Total_Price;
            InitializeComponent();
            Passenger_Email_textBox.Visible = false;
            Passenger_Gender_comboBox.Visible = false;
            Passenger_Name_textBox.Visible = false;
            Done_Button.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            Passenger_Gender_comboBox.Visible = false;
            Passenger_PhoneNumber_textBox.Visible = true;
            controllerObj = new Controller();
            Myparent = L;
            Myparent.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Done_Button_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.Check_Name(Passenger_Name_textBox.Text) && v.PhoneNumber(Passenger_PhoneNumber_textBox.Text) /*v.IsValidEmail(Passenger_Email_textBox.Text) &&*/ )
            {
                int result = controllerObj.Insert_Passenger(Passenger_Name_textBox.Text, Passenger_PhoneNumber_textBox.Text, Passenger_Email_textBox.Text, Passenger_Gender_comboBox.Text);
                if (result == 1)
                {
                    MessageBox.Show("Insertion done succesfully");
                    Passenger_Name_textBox.Text = "";
                    Passenger_Email_textBox.Text = "";
                    Passenger_Gender_comboBox.Text = "";
                    DataTable P = controllerObj.Get_Passenger_id(Passenger_PhoneNumber_textBox.Text);
                    result = controllerObj.Insert_Passenger_Trip((int)P.Rows[0][0], Trip_Id, Num_Of_Seats,Trip_Total_Price);
                    Passenger_PhoneNumber_textBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Insertion Failed"); //shouldn't appear to the user
                }

            }
        }

        private void Search_For_Passenger_Click_1(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.PhoneNumber(Passenger_PhoneNumber_textBox.Text))
            {
                DataTable P = controllerObj.Get_Passenger_id(Passenger_PhoneNumber_textBox.Text);
                if (P == null) //we need to store Passenger's information
                {
                    Passenger_Email_textBox.Visible = true;
                    Passenger_Gender_comboBox.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label2.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    Passenger_Gender_comboBox.Visible = true;
                    Passenger_Name_textBox.Visible = true;
                    Done_Button.Visible = true;
                    Search_For_Passenger.Visible = false;

                    MessageBox.Show("It is the first time for that Passenger So Get his information first ");
                }
                else
                {
                    MessageBox.Show("We have already the information of that Passenger and reservation done succesfully ");
                    int result = controllerObj.Insert_Passenger_Trip((int)P.Rows[0][0], Trip_Id, Num_Of_Seats,Trip_Total_Price);

                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {
            Myparent.Show();
            this.Hide();
        }

        private void Insert_Passenger_information_Load(object sender, EventArgs e)
        {

        }
    }
}

