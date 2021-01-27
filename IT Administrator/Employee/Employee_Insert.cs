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


namespace IT_Administrator.UserControls
{
    public partial class Employee_Insert : UserControl
    {
        Controller controller;
        public Employee_Insert()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Employee_AddBtn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.Check_Name(EmployeeName_Insert_Texbox.Text) && v.IsPositiveNumber(EmployeeSalary_Insert_Texbox.Text) && v.IsValidEmail(EmployeeEmail_Insert_Texbox.Text))
            {
                if (EPassword_TB.Text.Length < 8)
                {
                    MessageBox.Show("PassWord cannot be less than 8 Characters");
                    return;
                }                                                                                                                             // It Should me before 18 years from today 
                else if (v.NationalID(EmployeeID_Insert_Texbox.Text) && v.Is_Empty(EmployeeAdress_Insert_Texbox.Text) && v.Two_Dates(BD_DatePicker.Value, DateTime.Today.AddYears(-18)))
                {
                    if (EPassword_TB.Text.Length < 8)
                    {
                        MessageBox.Show("PassWord cannot be less than 8 Characters");
                        return;
                    }
                    string name = EmployeeName_Insert_Texbox.Text;
                    int salary = Convert.ToInt32(EmployeeSalary_Insert_Texbox.Text);
                    string email = EmployeeEmail_Insert_Texbox.Text;
                    string pass = v.Encrypt_PassWord(EPassword_TB.Text);
                    string type = Type_CBox.Text;
                    string NID = EmployeeID_Insert_Texbox.Text;
                    DateTime BOD = BD_DatePicker.Value;
                    string adress = EmployeeAdress_Insert_Texbox.Text;
                    string gender = Gender_CBox.Text;
                    if (controller.Insert_Employee(name, salary, email, pass, type, NID, BOD, adress, gender) == 1)
                    {
                        Message_Form message = new Message_Form();
                        Object id = controller.Last_Emplopyee_ID();
                        message.Title("Employee was added with ID = " + id.ToString());
                        message.Show();
                    }
                    else
                    {
                        Message_Form message = new Message_Form();
                        message.Title("There was an Error inserting this Emoployee");
                        message.Title_Color(Color.Red);
                        message.Show();
                    }
                }

            }

        }
    }
}
