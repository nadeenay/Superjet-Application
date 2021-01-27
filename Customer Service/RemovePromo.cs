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
    public partial class RemovePromo : Form
    {
        Controller controllerObj = new Controller();
        Form Myparent;
        public RemovePromo(Form L)
        {
            InitializeComponent();
            Myparent = L;
            Myparent.Hide();
        }

        private void RemovePromo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            if (v.Is_Empty(textBox1.Text))
            {
                if (Convert.ToInt32(controllerObj.CheckPromoCodeName(textBox1.Text)) == 0)
                    MessageBox.Show("There is no promo code with this name !");
                else
                {
                    int res = controllerObj.RemovePromoCode(textBox1.Text);
                    if (res == 1)
                        MessageBox.Show("Promo code is removed Successfully !");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Myparent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you return to home page ,you will be logged out ,Are you sure you want to log out ?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
            }
        }
    }
}
