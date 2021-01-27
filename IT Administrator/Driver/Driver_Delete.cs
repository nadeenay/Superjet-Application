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

namespace IT_Administrator.Driver_UserControls
{
    public partial class Driver_Delete : UserControl
    {
        Controller Controller;
        public Driver_Delete()
        {
            InitializeComponent();
            Controller = new Controller();
            Refreshing();
        }

        public void Refreshing()
        {
            Disable();
        }

        private void Employee_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Controller.Delete_Driver(DPhone_Label.Text) == 1)
            {
                Message_Form message = new Message_Form();
                message.Title("Driver was Deleted Successfully ");
                message.Show();
                Found_label.Text = "";
                Disable();
            }
            else
            {
                Message_Form message = new Message_Form();
                message.Title("There was an Error Deleting this Driver");
                message.Title_Color(Color.Red);
                message.Show();
            }
        }


        private void NotFound()
        {
            Found_label.Text = "Not Found";
            Found_label.ForeColor = Color.Red;
            Disable();

        }
        private void Disable()
        {
            Name_label.Visible = false;
            DName_Label.Visible = false;

            Phone_Label.Visible = false;
            DPhone_Label.Visible = false;

            Salary_label.Visible = false;
            DSalary_Label.Visible = false;

            Licence_Label.Visible = false;
            DLicence.Visible = false;

            Taffic_label.Visible = false;
            DTraffic.Visible = false;

            End_label.Visible = false;
            DEndDate.Visible = false;

            NationalID_label.Visible = false;
            DNationalID.Visible = false;

            BD_label.Visible = false;
            D_DOB.Visible = false;

            Address_label.Visible = false;
            DAddrees.Visible = false;

            BloodType_label.Visible = false;
            DType.Visible = false;

            BUS_ID_Label.Visible = false;
            DBUSID.Visible = false;

            Driver_DeleteBtn.Visible = false;
        }
        private void Found()
        {
            Found_label.Text = "Found";
            Found_label.ForeColor = Color.Lime;

            Name_label.Visible = true;
            DName_Label.Visible = true;

            Phone_Label.Visible = true;
            DPhone_Label.Visible = true;

            Salary_label.Visible = true;
            DSalary_Label.Visible = true;

            Licence_Label.Visible = true;
            DLicence.Visible = true;

            Taffic_label.Visible = true;
            DTraffic.Visible = true;

            End_label.Visible = true;
            DEndDate.Visible = true;

            NationalID_label.Visible = true;
            DNationalID.Visible = true;

            BD_label.Visible = true;
            D_DOB.Visible = true;

            Address_label.Visible = true;
            DAddrees.Visible = true;

            BloodType_label.Visible = true;
            DType.Visible = true;

            BUS_ID_Label.Visible = true;
            DBUSID.Visible = true;

            Driver_DeleteBtn.Visible = true;
        }

        private void BloodTypeConvert(string type)
        {
            if (type == "0")
                DType.Text = "A-";
            else if (type == "1")
                DType.Text = "A+";
            else if (type == "2")
                DType.Text = "B-";
            else if (type == "3")
                DType.Text = "B+";
            else if (type == "4")
                DType.Text = "AB-";
            else if (type == "5")
                DType.Text = "AB+";
            else if (type == "6")
                DType.Text = "O-";
            else if (type == "7")
                DType.Text = "O+";
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.PhoneNumber(DPhone_Search_Texbox.Text))
            {
                DataTable result = Controller.Search_Driver(DPhone_Search_Texbox.Text);
                if (result == null)
                    NotFound();
                else
                {
                    Found();
                    DName_Label.Text = result.Rows[0][1].ToString();
                    D_DOB.Text = String.Format("{0:dd-MM-yyyy}", result.Rows[0][2]); 
                    DPhone_Label.Text = result.Rows[0][3].ToString();
                    DAddrees.Text = result.Rows[0][4].ToString();
                    DSalary_Label.Text = result.Rows[0][5].ToString();
                    DNationalID.Text = result.Rows[0][6].ToString();
                    DType.Text = result.Rows[0][9].ToString();
                    DTraffic.Text = result.Rows[0][10].ToString();
                    DLicence.Text = result.Rows[0][11].ToString();
                    DEndDate.Text = String.Format("{0:dd-MM-yyyy}", result.Rows[0][12]);
                    BloodTypeConvert(DType.Text);
                    DBUSID.Text = result.Rows[0][13].ToString();
                }
            }
            
        }
    }
}
