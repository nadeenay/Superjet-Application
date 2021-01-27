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

namespace IT_Administrator.Employee_UserControls
{
    public partial class Employee_Update : UserControl
    {
        Controller controller;
        public Employee_Update()
        {
            InitializeComponent();
            controller = new Controller();
            Refreshing();
        }

        public void Refreshing()
        {
            Disable();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.NationalID(NID_Search_Texbox.Text))
            {
                DataTable result = controller.Search_Employee(NID_Search_Texbox.Text);
                if (result == null)
                    NotFound();
                else
                {
                    Found();
                    EName_Update_Texbox.Text = result.Rows[0][1].ToString();
                    BD_DatePicker.Value = Convert.ToDateTime(result.Rows[0][2].ToString());
                    EEmail_Update_Texbox.Text = result.Rows[0][3].ToString();
                    EAdress_Update_Texbox.Text = result.Rows[0][4].ToString();
                    EPass_Update_Texbox.Text = v.Decrypt_PassWord(result.Rows[0][5].ToString());
                    ESalary_Update_Texbox.Text = result.Rows[0][6].ToString();
                    EID_Update_Texbox.Text = result.Rows[0][7].ToString();
                    Type_CBox.Text = result.Rows[0][10].ToString();
                }
            }

        }

        private void Employee_UpdateBtn_Click(object sender, EventArgs e)
        {

            Validation_Class v = new Validation_Class();
            if (v.Check_Name(EName_Update_Texbox.Text) && v.IsPositiveNumber(ESalary_Update_Texbox.Text) && v.IsValidEmail(EEmail_Update_Texbox.Text))
            {
                if (EPass_Update_Texbox.Text.Length < 8)
                {
                    MessageBox.Show("PassWord cannot be less than 8 Characters");
                    return;
                }                                                                                                                             // It Should me before 18 years from today 
                else if (v.NationalID(EID_Update_Texbox.Text) && v.Is_Empty(EAdress_Update_Texbox.Text) && v.Two_Dates(BD_DatePicker.Value, DateTime.Today.AddYears(-18)))
                {
                    string name = EName_Update_Texbox.Text;
                    string email = EEmail_Update_Texbox.Text;
                    string pass = v.Encrypt_PassWord(EPass_Update_Texbox.Text);
                    int salary = Convert.ToInt32(ESalary_Update_Texbox.Text);
                    string NID = EID_Update_Texbox.Text;
                    DateTime BD = BD_DatePicker.Value;
                    string address = EAdress_Update_Texbox.Text;
                    string type = Type_CBox.SelectedItem.ToString();

                    int result = controller.Update_Employee(name, salary, email, pass, type, NID, BD, address);
                    if (result == 0)
                    {
                        Message_Form message = new Message_Form();
                        message.Title("There was an Error Updating this Employee");
                        message.Title_Color(Color.Red);
                        message.Show();
                    }
                    else
                    {
                        Message_Form message = new Message_Form();
                        message.Title("The Employee is Updated Successfully");
                        message.Show();
                    }
                }
            }
        }

        private void NotFound()
        {
            Found_label.Text = "Not Found";
            Found_label.ForeColor = Color.Red;
            Disable();
        }
        private void Found()
        {
            Found_label.Text = "Found";
            Found_label.ForeColor = Color.Lime;

            Name_label.Visible = true;
            EName_Update_Texbox.Visible = true;

            pass_Label.Visible = true;
            EPass_Update_Texbox.Visible = true;

            Salary_label.Visible = true;
            ESalary_Update_Texbox.Visible = true;

            Email_label.Visible = true;
            EEmail_Update_Texbox.Visible = true;

            NationalID_label.Visible = true;
            EID_Update_Texbox.Visible = true;

            BD_label.Visible = true;
            BD_DatePicker.Visible = true;

            Address_label.Visible = true;
            EAdress_Update_Texbox.Visible = true;

            Type_label.Visible = true;
            Type_CBox.Visible = true;

            Employee_UpdateBtn.Visible = true;
        }
        private void Disable()
        {
            Name_label.Visible = false;
            EName_Update_Texbox.Visible = false;

            pass_Label.Visible = false;
            EPass_Update_Texbox.Visible = false;

            Salary_label.Visible = false;
            ESalary_Update_Texbox.Visible = false;

            Email_label.Visible = false;
            EEmail_Update_Texbox.Visible = false;

            NationalID_label.Visible = false;
            EID_Update_Texbox.Visible = false;

            BD_label.Visible = false;
            BD_DatePicker.Visible = false;

            Address_label.Visible = false;
            EAdress_Update_Texbox.Visible = false;

            Type_label.Visible = false;
            Type_CBox.Visible = false;

            Employee_UpdateBtn.Visible = false;
        }

    }
}
