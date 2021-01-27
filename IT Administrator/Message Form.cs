using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet.IT_Administrator
{
    public partial class Message_Form : Form
    {
        public Message_Form()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Title(string title)
        {
            Title_Label.Text = title;
        }

        public void Extra_Message(string message)
        {
            Extra_Message_Label.Text = message;
        }

        public void Title_Color(Color c)
        {
            Title_Label.ForeColor = c;
        }

        public void Extra_Message_Color(Color c)
        {
            Extra_Message_Label.ForeColor = c;
        }
    }
}
