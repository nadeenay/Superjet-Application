using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project1
{
    class Validation_Class
    {
        public bool PhoneNumber(string phone)
        {
            if (phone.Length != 11) // What if non Egyptian person (i.e. +1 (201) 141-151)
            {
                MessageBox.Show("Phone Number must contain 11 Digit");
                return false;
            }

            if (phone[0] != '0' || phone[1] != '1')
            {
                MessageBox.Show("Phone Number is not Valid");
                return false;
            }

            if (phone[2] != '0' && phone[2] != '1' && phone[2] != '2' && phone[2] != '5')
            {
                MessageBox.Show("Phone Number is not Valid");
                return false;
            }

            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone Number can not contain Characters");
                return false;
            }
            return true;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address == email)
                    return true;
                MessageBox.Show("Please Enter a Valid Email address");
                return false;
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Email address");
                return false;
            }
        }

        //For Salary
        public bool IsPositiveNumber(string number)
        {
            try
            {
                long x = Convert.ToInt64(number);
                if (x > 0)
                    return true;
                else
                    MessageBox.Show("Please Enter a Positive Number");
                return false;
            }
            catch
            {
                MessageBox.Show("Please Enter a Positive Number");
                return false;
            }
        }

        public bool IsPositiveNumber(int number)
        {
            return (number > 0);
        }

        public bool Two_Dates(DateTime start, DateTime end)
        {
            if (start > end)
            {
                MessageBox.Show("Please Enter a Valid Dates");
                return false;
            }
            return true;
        }

        public bool NationalID(string nid)
        {
            if (nid.Length != 14)
            {
                MessageBox.Show("National ID Length is not Correct");
                return false;
            }

            if (nid[0] != '2' && nid[0] != '3')
            {
                MessageBox.Show("Please Enter a Valid National ID");
                return false;
            }

            if (!nid.All(char.IsDigit))
            {
                MessageBox.Show("National ID can not contain Characters");
                return false;
            }
            return true;
        }

        public bool Check_Name(string name)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Please Enter a Name");
                return false;
            }
            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name Could not Contain Digits");
                return false;
            }
            return true;
        }

        public bool Is_Empty(string s)
        {
            if (s.Length == 0)
            {
                MessageBox.Show("Please Enter All Values");
                return false;
            }
            return true;
        }

        public string Encrypt_PassWord(string pass)
        {
            string NewPass = "4";

            for (int i = pass.Length - 1; i >= 0; i--)
                NewPass += pass[i];

            NewPass += "5";
            return NewPass;
        }

        public string Decrypt_PassWord(string pass)
        {
            string NewPass = "";

            for (int i = pass.Length - 2; i >= 1; i--)
               NewPass += pass[i];

            return NewPass;
        }
    }
}
