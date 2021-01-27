namespace IT_Administrator.Employee_UserControls
{
    partial class Employee_Update
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Update));
            this.Search_Panel = new System.Windows.Forms.Panel();
            this.Search_PicBox = new System.Windows.Forms.PictureBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.NID_Search_Texbox = new System.Windows.Forms.TextBox();
            this.NID_Search_Label = new System.Windows.Forms.Label();
            this.Found_label = new System.Windows.Forms.Label();
            this.BD_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.EID_Update_Texbox = new System.Windows.Forms.TextBox();
            this.NationalID_label = new System.Windows.Forms.Label();
            this.EAdress_Update_Texbox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.BD_label = new System.Windows.Forms.Label();
            this.EEmail_Update_Texbox = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.ESalary_Update_Texbox = new System.Windows.Forms.TextBox();
            this.Salary_label = new System.Windows.Forms.Label();
            this.EName_Update_Texbox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Type_CBox = new System.Windows.Forms.ComboBox();
            this.Type_label = new System.Windows.Forms.Label();
            this.Employee_UpdateBtn = new System.Windows.Forms.Button();
            this.pass_Label = new System.Windows.Forms.Label();
            this.EPass_Update_Texbox = new System.Windows.Forms.TextBox();
            this.Search_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Panel
            // 
            this.Search_Panel.Controls.Add(this.Search_PicBox);
            this.Search_Panel.Controls.Add(this.Search_btn);
            this.Search_Panel.Controls.Add(this.NID_Search_Texbox);
            this.Search_Panel.Controls.Add(this.NID_Search_Label);
            this.Search_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search_Panel.Location = new System.Drawing.Point(0, 0);
            this.Search_Panel.Name = "Search_Panel";
            this.Search_Panel.Size = new System.Drawing.Size(796, 129);
            this.Search_Panel.TabIndex = 0;
            // 
            // Search_PicBox
            // 
            this.Search_PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search_PicBox.Image = ((System.Drawing.Image)(resources.GetObject("Search_PicBox.Image")));
            this.Search_PicBox.Location = new System.Drawing.Point(230, 78);
            this.Search_PicBox.Name = "Search_PicBox";
            this.Search_PicBox.Size = new System.Drawing.Size(32, 32);
            this.Search_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Search_PicBox.TabIndex = 6;
            this.Search_PicBox.TabStop = false;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Search_btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Search_btn.Location = new System.Drawing.Point(285, 79);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(225, 31);
            this.Search_btn.TabIndex = 5;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // NID_Search_Texbox
            // 
            this.NID_Search_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.NID_Search_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NID_Search_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.NID_Search_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.NID_Search_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.NID_Search_Texbox.Location = new System.Drawing.Point(285, 37);
            this.NID_Search_Texbox.Name = "NID_Search_Texbox";
            this.NID_Search_Texbox.Size = new System.Drawing.Size(225, 36);
            this.NID_Search_Texbox.TabIndex = 4;
            this.NID_Search_Texbox.Text = "National ID";
            // 
            // NID_Search_Label
            // 
            this.NID_Search_Label.AutoSize = true;
            this.NID_Search_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NID_Search_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.NID_Search_Label.Location = new System.Drawing.Point(200, 36);
            this.NID_Search_Label.Name = "NID_Search_Label";
            this.NID_Search_Label.Size = new System.Drawing.Size(62, 30);
            this.NID_Search_Label.TabIndex = 3;
            this.NID_Search_Label.Text = "NID:";
            this.NID_Search_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Found_label
            // 
            this.Found_label.AutoSize = true;
            this.Found_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Found_label.ForeColor = System.Drawing.Color.Lime;
            this.Found_label.Location = new System.Drawing.Point(684, 132);
            this.Found_label.Name = "Found_label";
            this.Found_label.Size = new System.Drawing.Size(0, 23);
            this.Found_label.TabIndex = 1;
            // 
            // BD_DatePicker
            // 
            this.BD_DatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 13.8F);
            this.BD_DatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.BD_DatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BD_DatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BD_DatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.BD_DatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.BD_DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BD_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BD_DatePicker.Location = new System.Drawing.Point(543, 261);
            this.BD_DatePicker.Name = "BD_DatePicker";
            this.BD_DatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BD_DatePicker.Size = new System.Drawing.Size(225, 27);
            this.BD_DatePicker.TabIndex = 30;
            // 
            // EID_Update_Texbox
            // 
            this.EID_Update_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EID_Update_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EID_Update_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EID_Update_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.EID_Update_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.EID_Update_Texbox.Location = new System.Drawing.Point(543, 182);
            this.EID_Update_Texbox.Name = "EID_Update_Texbox";
            this.EID_Update_Texbox.Size = new System.Drawing.Size(225, 36);
            this.EID_Update_Texbox.TabIndex = 29;
            this.EID_Update_Texbox.Text = "E ID";
            // 
            // NationalID_label
            // 
            this.NationalID_label.AutoSize = true;
            this.NationalID_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NationalID_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.NationalID_label.Location = new System.Drawing.Point(378, 185);
            this.NationalID_label.Name = "NationalID_label";
            this.NationalID_label.Size = new System.Drawing.Size(152, 30);
            this.NationalID_label.TabIndex = 28;
            this.NationalID_label.Text = "National ID:";
            this.NationalID_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EAdress_Update_Texbox
            // 
            this.EAdress_Update_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EAdress_Update_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EAdress_Update_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EAdress_Update_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.EAdress_Update_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.EAdress_Update_Texbox.Location = new System.Drawing.Point(543, 330);
            this.EAdress_Update_Texbox.Name = "EAdress_Update_Texbox";
            this.EAdress_Update_Texbox.Size = new System.Drawing.Size(225, 36);
            this.EAdress_Update_Texbox.TabIndex = 27;
            this.EAdress_Update_Texbox.Text = "E Address";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Address_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Address_label.Location = new System.Drawing.Point(398, 333);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(112, 30);
            this.Address_label.TabIndex = 26;
            this.Address_label.Text = "Address:";
            this.Address_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BD_label
            // 
            this.BD_label.AutoSize = true;
            this.BD_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BD_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.BD_label.Location = new System.Drawing.Point(390, 259);
            this.BD_label.Name = "BD_label";
            this.BD_label.Size = new System.Drawing.Size(128, 30);
            this.BD_label.TabIndex = 25;
            this.BD_label.Text = "BirthDate:";
            this.BD_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EEmail_Update_Texbox
            // 
            this.EEmail_Update_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EEmail_Update_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EEmail_Update_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EEmail_Update_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.EEmail_Update_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.EEmail_Update_Texbox.Location = new System.Drawing.Point(136, 342);
            this.EEmail_Update_Texbox.Name = "EEmail_Update_Texbox";
            this.EEmail_Update_Texbox.Size = new System.Drawing.Size(225, 36);
            this.EEmail_Update_Texbox.TabIndex = 24;
            this.EEmail_Update_Texbox.Text = "E Email";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Email_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Email_label.Location = new System.Drawing.Point(28, 345);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(85, 30);
            this.Email_label.TabIndex = 23;
            this.Email_label.Text = "Email:";
            this.Email_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ESalary_Update_Texbox
            // 
            this.ESalary_Update_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ESalary_Update_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ESalary_Update_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ESalary_Update_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.ESalary_Update_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.ESalary_Update_Texbox.Location = new System.Drawing.Point(136, 262);
            this.ESalary_Update_Texbox.Name = "ESalary_Update_Texbox";
            this.ESalary_Update_Texbox.Size = new System.Drawing.Size(225, 36);
            this.ESalary_Update_Texbox.TabIndex = 22;
            this.ESalary_Update_Texbox.Text = "E Salary";
            // 
            // Salary_label
            // 
            this.Salary_label.AutoSize = true;
            this.Salary_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salary_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Salary_label.Location = new System.Drawing.Point(25, 265);
            this.Salary_label.Name = "Salary_label";
            this.Salary_label.Size = new System.Drawing.Size(90, 30);
            this.Salary_label.TabIndex = 21;
            this.Salary_label.Text = "Salary:";
            this.Salary_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EName_Update_Texbox
            // 
            this.EName_Update_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EName_Update_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EName_Update_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EName_Update_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.EName_Update_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.EName_Update_Texbox.Location = new System.Drawing.Point(136, 182);
            this.EName_Update_Texbox.Name = "EName_Update_Texbox";
            this.EName_Update_Texbox.Size = new System.Drawing.Size(225, 36);
            this.EName_Update_Texbox.TabIndex = 18;
            this.EName_Update_Texbox.Text = "E Name";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Name_label.Location = new System.Drawing.Point(23, 185);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(94, 30);
            this.Name_label.TabIndex = 17;
            this.Name_label.Text = "Name:";
            this.Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Type_CBox
            // 
            this.Type_CBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Type_CBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type_CBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Type_CBox.FormattingEnabled = true;
            this.Type_CBox.Items.AddRange(new object[] {
            "Customer Service",
            "Contract Administrator",
            "IT Administrator",
            "Receptionist"});
            this.Type_CBox.Location = new System.Drawing.Point(136, 506);
            this.Type_CBox.Name = "Type_CBox";
            this.Type_CBox.Size = new System.Drawing.Size(225, 29);
            this.Type_CBox.TabIndex = 32;
            this.Type_CBox.Text = "Customer Service";
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Type_label.Location = new System.Drawing.Point(32, 505);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(76, 30);
            this.Type_label.TabIndex = 31;
            this.Type_label.Text = "Type:";
            this.Type_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Employee_UpdateBtn
            // 
            this.Employee_UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employee_UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Employee_UpdateBtn.Location = new System.Drawing.Point(403, 406);
            this.Employee_UpdateBtn.Name = "Employee_UpdateBtn";
            this.Employee_UpdateBtn.Size = new System.Drawing.Size(365, 129);
            this.Employee_UpdateBtn.TabIndex = 33;
            this.Employee_UpdateBtn.Text = "Update Employee";
            this.Employee_UpdateBtn.UseVisualStyleBackColor = true;
            this.Employee_UpdateBtn.Click += new System.EventHandler(this.Employee_UpdateBtn_Click);
            // 
            // pass_Label
            // 
            this.pass_Label.AutoSize = true;
            this.pass_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pass_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.pass_Label.Location = new System.Drawing.Point(3, 425);
            this.pass_Label.Name = "pass_Label";
            this.pass_Label.Size = new System.Drawing.Size(129, 30);
            this.pass_Label.TabIndex = 23;
            this.pass_Label.Text = "Password:";
            this.pass_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pass_Label.Visible = false;
            // 
            // EPass_Update_Texbox
            // 
            this.EPass_Update_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EPass_Update_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EPass_Update_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EPass_Update_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.EPass_Update_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.EPass_Update_Texbox.Location = new System.Drawing.Point(136, 422);
            this.EPass_Update_Texbox.Name = "EPass_Update_Texbox";
            this.EPass_Update_Texbox.Size = new System.Drawing.Size(225, 36);
            this.EPass_Update_Texbox.TabIndex = 24;
            this.EPass_Update_Texbox.Text = "E PassWord";
            this.EPass_Update_Texbox.Visible = false;
            // 
            // Employee_Update
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.Employee_UpdateBtn);
            this.Controls.Add(this.Type_CBox);
            this.Controls.Add(this.Type_label);
            this.Controls.Add(this.BD_DatePicker);
            this.Controls.Add(this.EID_Update_Texbox);
            this.Controls.Add(this.NationalID_label);
            this.Controls.Add(this.EAdress_Update_Texbox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.BD_label);
            this.Controls.Add(this.EPass_Update_Texbox);
            this.Controls.Add(this.pass_Label);
            this.Controls.Add(this.EEmail_Update_Texbox);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.ESalary_Update_Texbox);
            this.Controls.Add(this.Salary_label);
            this.Controls.Add(this.EName_Update_Texbox);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Found_label);
            this.Controls.Add(this.Search_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_Update";
            this.Size = new System.Drawing.Size(796, 582);
            this.Search_Panel.ResumeLayout(false);
            this.Search_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Search_Panel;
        private System.Windows.Forms.Label NID_Search_Label;
        private System.Windows.Forms.PictureBox Search_PicBox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox NID_Search_Texbox;
        private System.Windows.Forms.Label Found_label;
        private System.Windows.Forms.DateTimePicker BD_DatePicker;
        private System.Windows.Forms.TextBox EID_Update_Texbox;
        private System.Windows.Forms.Label NationalID_label;
        private System.Windows.Forms.TextBox EAdress_Update_Texbox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label BD_label;
        private System.Windows.Forms.TextBox EEmail_Update_Texbox;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.TextBox ESalary_Update_Texbox;
        private System.Windows.Forms.Label Salary_label;
        private System.Windows.Forms.TextBox EName_Update_Texbox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.ComboBox Type_CBox;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.Button Employee_UpdateBtn;
        private System.Windows.Forms.Label pass_Label;
        private System.Windows.Forms.TextBox EPass_Update_Texbox;
    }
}
