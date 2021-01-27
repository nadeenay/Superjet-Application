using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contract_Administrator.Rent
{
    public partial class Rent_Search_Item : UserControl
    {
        public Rent_Search_Item()
        {
            InitializeComponent();
        }

        private string CID;
        private string Startdate;
        private string End;
        private string price;
        private string Bus_Id;
        private string NaMe;
        private string National_ID;
        private string address;
        private string gender;
        private string PhoneNumber;

        public string Contract_ID
        {
            get { return CID; }
            set { CID = value; ContractID.Text = CID; }
        }
        public string StartDate
        {
            get { return Startdate; }
            set { Startdate = value; Start_Date.Text = Startdate; }
        }
        public string End_Date
        {
            get { return End; }
            set { End = value; EndD.Text = End; }
        }
        public string PriCe
        {
            get { return price; }
            set { price = value; Price.Text = price; }
        }
        public string Bus_ID
        {
            get { return Bus_Id; }
            set { Bus_Id = value; BusID.Text = Bus_Id; }
        }
        public string NAme
        {
            get { return NaMe; }
            set { NaMe = value; NamE.Text = NaMe; }
        }
        public string National_Id
        {
            get { return National_ID; }
            set { National_ID = value; NID.Text = National_Id; }
        }
        public string AddreSs
        {
            get { return address; }
            set { address = value; Address.Text = address; }
        }
        public string GendEr
        {
            get { return gender; }
            set { gender = value; Gender.Text = gender; }
        }
        public string Phone_Number
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; Phone.Text = PhoneNumber; }
        }

    }
}
