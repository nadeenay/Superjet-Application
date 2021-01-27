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
    public partial class Employee_Delete : UserControl
    {
        Controller controller;
        public Employee_Delete()
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
                    ESSN.Text = result.Rows[0][0].ToString();
                    EName_Label.Text = result.Rows[0][1].ToString();
                    E_DOB.Text = String.Format("{0:dd-MM-yyyy}", result.Rows[0][2]);
                    E_Email.Text = result.Rows[0][3].ToString();
                    EAddrees.Text = result.Rows[0][4].ToString();
                    ESalary.Text = result.Rows[0][6].ToString();
                    ENationalID.Text = result.Rows[0][7].ToString();
                    EType.Text = result.Rows[0][10].ToString();
                }
            }
        }

        private void Employee_DeleteBtn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.NationalID(NID_Search_Texbox.Text))
            {
                int result = controller.Delete_Employee(NID_Search_Texbox.Text);
                if (result == 0)
                {
                    Message_Form message = new Message_Form();
                    message.Title("There was an Error Deleting this Employee");
                    message.Title_Color(Color.Red);
                    message.Show();
                }
                else
                {
                    Message_Form message = new Message_Form();
                    message.Title("Employee was Deleted Successfully");
                    message.Show();
                    Disable();
                    Found_label.Text = "";
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
            EName_Label.Visible = true;

            SSN_Label.Visible = true;
            ESSN.Visible = true;

            Salary_label.Visible = true;
            ESalary.Visible = true;

            Email_label.Visible = true;
            E_Email.Visible = true;

            NationalID_label.Visible = true;
            ENationalID.Visible = true;

            BD_label.Visible = true;
            E_DOB.Visible = true;

            Address_label.Visible = true;
            EAddrees.Visible = true;

            Type_label.Visible = true;
            EType.Visible = true;

            Employee_DeleteBtn.Visible = true;
        }
        private void Disable()
        {
            Name_label.Visible = false;
            EName_Label.Visible = false;

            SSN_Label.Visible = false;
            ESSN.Visible = false;

            Salary_label.Visible = false;
            ESalary.Visible = false;

            Email_label.Visible = false;
            E_Email.Visible = false;

            NationalID_label.Visible = false;
            ENationalID.Visible = false;

            BD_label.Visible = false;
            E_DOB.Visible = false;

            Address_label.Visible = false;
            EAddrees.Visible = false;

            Type_label.Visible = false;
            EType.Visible = false;

            Employee_DeleteBtn.Visible = false;
        }

    }
}
