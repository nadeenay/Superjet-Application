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
using IT_Administrator;
using SuperJet;
using Contract_Administrator;
using DB_project1.Receptionist;

namespace DB_project1
{

    public partial class LoginFormForAdmin : Form
    {
        Controller controllerObj;
        Form Myparent;
        string TypeE;
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
        public LoginFormForAdmin(Form L, string Type)
        {
            InitializeComponent();
            Myparent = L;
            Myparent.Hide();
            TypeE = Type;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();

            if (v.IsValidEmail(Email_textbox.Text) && v.Is_Empty(Password_textbox.Text))
            {
                DataTable employee = controllerObj.Get_Employee_byEmail(Email_textbox.Text);
                if (employee == null)
                {
                    MessageBox.Show("There is no Employee with the Provided Email");
                }
                else
                {
                    string pass = v.Decrypt_PassWord(employee.Rows[0][5].ToString());
                    if (pass == Password_textbox.Text)
                    {
                        string type = employee.Rows[0][11].ToString();
                        /*Customer Service
                          Contract Administrator
                          IT Administrator
                          Receptionist*/
                        this.Hide();
                        if (type == "Contract Administrator")
                        {
                            ContractAdministrator _Administrator = new ContractAdministrator();
                            _Administrator.Show();
                        }
                        else if (type == "IT Administrator")
                        {
                            ITAdministrator t_Administrator = new ITAdministrator();
                            t_Administrator.Show();
                        }
                        else if (type == "Customer Service")
                        {
                            CS_Main_Functions CS = new CS_Main_Functions(this, Convert.ToInt32(employee.Rows[0][0]));
                            CS.Show();
                        }
                        else if (type == "Receptionist")
                        {
                            Inquiries_about_trips I = new Inquiries_about_trips(this);
                            I.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                        Password_textbox.Text = "";
                    }

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Email_textbox.Clear();
            Password_textbox.Clear();
            Email_textbox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Welcome W = new Welcome();
            this.Hide();
            W.Show();

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

        private void Password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Myparent.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            Welcome W = new Welcome();
            this.Hide();
            W.Show();

        }
    }
}