using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_Administrator;
using SuperJet;
using DB_project1;

namespace Contract_Administrator.Rent
{
    public partial class Rent_Search : UserControl
    {
        Controller controller;
        public Rent_Search()
        {
            InitializeComponent();
            controller = new Controller();
            flowLayoutPanel1.VerticalScroll.Enabled = true;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Validation_Class v = new Validation_Class();
            flowLayoutPanel1.Controls.Clear();
            if (v.NationalID(Search_tb.Text))
            {
                DataTable result = controller.Search_Rent_contract(Search_tb.Text);

                if (result == null)
                    MessageBox.Show("No Rent with the Provided ID");
                else
                {
                    int count = result.Rows.Count;
                    Rent_Search_Item[] _Items = new Rent_Search_Item[count];

                    for (int i = 0; i < count; i++)
                    {
                        _Items[i] = new Rent_Search_Item();
                        _Items[i].Contract_ID = result.Rows[i][0].ToString();
                        _Items[i].StartDate = result.Rows[i][1].ToString().Substring(0, 10);
                        _Items[i].End_Date = result.Rows[i][2].ToString().Substring(0, 10);
                        _Items[i].PriCe = result.Rows[i][3].ToString();
                        _Items[i].NAme = result.Rows[i][4].ToString();
                        _Items[i].National_Id = result.Rows[i][5].ToString();
                        _Items[i].AddreSs = result.Rows[i][6].ToString();
                        _Items[i].GendEr = result.Rows[i][7].ToString();
                        _Items[i].Bus_ID = result.Rows[i][8].ToString();
                        _Items[i].Phone_Number = result.Rows[i][9].ToString();

                        flowLayoutPanel1.Controls.Add(_Items[i]);
                    }
                }
            }         
        }
    }
}
