using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project1.Receptionist
{
    public partial class Weekly_Trip_List_For_Search : UserControl
    {
        public Weekly_Trip_List_For_Search()
        {
            InitializeComponent();
        }
        private string Day;
        private string Time;
        public string DAY
        {
            get { return Day; }
            set { Day = value; day.Text = Day; }
        }
        public string TIME
        {
            get { return Time; }
            set { Time = value; Take_Off_Time.Text = Time; }
        }
    }
}
