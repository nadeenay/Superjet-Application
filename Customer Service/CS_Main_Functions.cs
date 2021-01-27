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
    public partial class CS_Main_Functions : Form
    {
        Controller controllerObj = new Controller();
        Form Myparent;
        int LoggedinEmployee;
        public CS_Main_Functions(Form L ,int LoggedinID)
        {
            InitializeComponent();
            Myparent = L;
            LoggedinEmployee = LoggedinID;
            Myparent.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addpromo apc = new Addpromo(this,LoggedinEmployee);
            apc.Show();
        }

        private void toComplaint_Click(object sender, EventArgs e)
        {
            CompaintsForm f = new CompaintsForm(this);
            f.Show();
        }

        private void applypenalty_Click(object sender, EventArgs e)
        {
            ApplyPenalty ap = new ApplyPenalty(this);
            ap.Show();
        }

        private void CS_Main_Functions_Load(object sender, EventArgs e)
        {

        }

        private void removePromo_Click(object sender, EventArgs e)
        {
            RemovePromo rp = new RemovePromo(this);
            rp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you return to home page ,you will be logged out , '\n' Are you sure you want to log out ?", "Return to home page", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
            }
        }
    }
}
