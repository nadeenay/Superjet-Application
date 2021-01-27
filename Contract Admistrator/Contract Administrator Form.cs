using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contract_Administrator
{

    public partial class ContractAdministrator : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        int page;

        public ContractAdministrator()
        {
            InitializeComponent();
            random = new Random();
            page = 0;
            Delete.Visible = false;
            CenterLogoPanel.Visible = true;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    disableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }
        private void disableButton()
        {
            foreach (Control previousBtn in panelmenue.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Ad_btn_MouseEnter(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void Rent_btn_MouseEnter(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Ad_btn_Click(object sender, EventArgs e)
        {
            page = 0;
            Delete.Visible = false;

            insert_Ad_Contact1.Refreshing();

            insert_Ad_Contact1.Visible = true;
            rent_insert1.Visible = false;
            insert__Package1.Visible = false;
            search_Ad_contract1.Visible = false;
            rent_Search1.Visible = false;
            searchPakages1.Visible = false;
            delete_packages1.Visible = false;
            CenterLogoPanel.Visible = false;
            CenterLogoPanel.Visible = false;
        }

        private void Rent_btn_Click(object sender, EventArgs e)
        {
            page = 1;
            Delete.Visible = false;

            rent_insert1.Refreshing();

            insert_Ad_Contact1.Visible = false;
            rent_insert1.Visible = true;
            insert__Package1.Visible = false;
            search_Ad_contract1.Visible = false;
            rent_Search1.Visible = false;
            searchPakages1.Visible = false;
            delete_packages1.Visible = false;
            CenterLogoPanel.Visible = false;
        }

        private void Package_btn_Click(object sender, EventArgs e)
        {
            page = 2;
            Delete.Visible = true;

            delete_packages1.Refreshing();

            insert_Ad_Contact1.Visible = false;
            rent_insert1.Visible = false;
            insert__Package1.Visible = true;
            search_Ad_contract1.Visible = false;
            rent_Search1.Visible = false;
            searchPakages1.Visible = false;
            delete_packages1.Visible = false;
            CenterLogoPanel.Visible = false;
        }


        private void Insert_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                insert_Ad_Contact1.Visible = true;
                rent_insert1.Visible = false;
                insert__Package1.Visible = false;
                search_Ad_contract1.Visible = false;
                rent_Search1.Visible = false;
                searchPakages1.Visible = false;
                delete_packages1.Visible = false;
                CenterLogoPanel.Visible = false;
                insert_Ad_Contact1.Refreshing();
            }
            else if (page == 1)
            {
                rent_insert1.Refreshing();

                insert_Ad_Contact1.Visible = false;
                rent_insert1.Visible = true;
                insert__Package1.Visible = false;
                search_Ad_contract1.Visible = false;
                rent_Search1.Visible = false;
                searchPakages1.Visible = false;
                delete_packages1.Visible = false;
                CenterLogoPanel.Visible = false;
            }
            else if (page == 2)
            {
                insert_Ad_Contact1.Visible = false;
                rent_insert1.Visible = false;
                insert__Package1.Visible = true;
                search_Ad_contract1.Visible = false;
                rent_Search1.Visible = false;
                searchPakages1.Visible = false;
                delete_packages1.Visible = false;
                CenterLogoPanel.Visible = false;
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                insert_Ad_Contact1.Visible = false;
                rent_insert1.Visible = false;
                insert__Package1.Visible = false;
                search_Ad_contract1.Visible = true;
                rent_Search1.Visible = false;
                searchPakages1.Visible = false;
                delete_packages1.Visible = false;
                CenterLogoPanel.Visible = false;
            }
            else if (page == 1)
            {
                insert_Ad_Contact1.Visible = false;
                rent_insert1.Visible = false;
                insert__Package1.Visible = false;
                search_Ad_contract1.Visible = false;
                rent_Search1.Visible = true;
                searchPakages1.Visible = false;
                delete_packages1.Visible = false;
                CenterLogoPanel.Visible = false;
            }
            else if (page == 2)
            {
                insert_Ad_Contact1.Visible = false;
                rent_insert1.Visible = false;
                insert__Package1.Visible = false;
                search_Ad_contract1.Visible = false;
                rent_Search1.Visible = false;
                searchPakages1.Visible = true;
                delete_packages1.Visible = false;
                CenterLogoPanel.Visible = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            delete_packages1.Refreshing();

            insert_Ad_Contact1.Visible = false;
            rent_insert1.Visible = false;
            insert__Package1.Visible = false;
            search_Ad_contract1.Visible = false;
            rent_Search1.Visible = false;
            searchPakages1.Visible = false;
            delete_packages1.Visible = true;
            CenterLogoPanel.Visible = false;
        }

    }
}
