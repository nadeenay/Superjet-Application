using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project1
{
    public partial class Addpromo : Form
    {
        Controller controllerObj = new Controller();
        Form Myparent;
        int LoggedinEmployee;
        public Addpromo(Form L, int LoggedinID)
        {
            InitializeComponent();
            Myparent = L;
            LoggedinEmployee = LoggedinID;
            Myparent.Hide();
        }

        private void confirmAddPromo_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.Is_Empty(PC_name.Text) && v.IsPositiveNumber(WT_id.Text))
            {
                if (Convert.ToInt32(controllerObj.CheckPromoCodeName(PC_name.Text)) == 1)
                    MessageBox.Show("This name is already taken");
                else if (Convert.ToInt32(controllerObj.CheckWTID(WT_id.Text)) == 0)
                    MessageBox.Show("Weekly trip  ID is invalid !");
                else
                {
                    controllerObj.AddPromoCode(PC_name.Text, discount.Value.ToString(), LoggedinEmployee);
                    controllerObj.AddPromoToWT(PC_name.Text, WT_id.Text);
                    MessageBox.Show("Promo Code is added Successfully");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you return to home page ,you will be logged out ,Are you sure you want to log out ?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Myparent.Show();
        }
    }
}
