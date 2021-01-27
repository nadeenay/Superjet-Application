namespace IT_Administrator.Driver_UserControls
{
    partial class Driver_Insert
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
            this.Driver_AddBtn = new System.Windows.Forms.Button();
            this.Blood_CBox = new System.Windows.Forms.ComboBox();
            this.BloodType_label = new System.Windows.Forms.Label();
            this.Gender_CBox = new System.Windows.Forms.ComboBox();
            this.BD_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DriverNID_Insert_Texbox = new System.Windows.Forms.TextBox();
            this.NationalID_label = new System.Windows.Forms.Label();
            this.Gender_label = new System.Windows.Forms.Label();
            this.DriverAdress_Insert_Texbox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.BD_label = new System.Windows.Forms.Label();
            this.DriverLicence_Number_Insert_Texbox = new System.Windows.Forms.TextBox();
            this.Licence_label = new System.Windows.Forms.Label();
            this.DriverSalary_Insert_Texbox = new System.Windows.Forms.TextBox();
            this.Salary_label = new System.Windows.Forms.Label();
            this.DriverPhone_Texbox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_Label = new System.Windows.Forms.Label();
            this.DriverName_Insert_Texbox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Driver_Traffic = new System.Windows.Forms.TextBox();
            this.Driver_Licence_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Bus_ID_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Driver_AddBtn
            // 
            this.Driver_AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Driver_AddBtn.Location = new System.Drawing.Point(429, 458);
            this.Driver_AddBtn.Name = "Driver_AddBtn";
            this.Driver_AddBtn.Size = new System.Drawing.Size(342, 86);
            this.Driver_AddBtn.TabIndex = 39;
            this.Driver_AddBtn.Text = "Add Driver";
            this.Driver_AddBtn.UseVisualStyleBackColor = true;
            this.Driver_AddBtn.Click += new System.EventHandler(this.Driver_AddBtn_Click_1);
            // 
            // Blood_CBox
            // 
            this.Blood_CBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Blood_CBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blood_CBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Blood_CBox.FormattingEnabled = true;
            this.Blood_CBox.Items.AddRange(new object[] {
            "A-",
            "A+",
            "B-",
            "B+",
            "AB-",
            "AB+",
            "O-",
            "O+"});
            this.Blood_CBox.Location = new System.Drawing.Point(175, 294);
            this.Blood_CBox.Name = "Blood_CBox";
            this.Blood_CBox.Size = new System.Drawing.Size(163, 35);
            this.Blood_CBox.TabIndex = 38;
            this.Blood_CBox.Text = "A+";
            // 
            // BloodType_label
            // 
            this.BloodType_label.AutoSize = true;
            this.BloodType_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BloodType_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.BloodType_label.Location = new System.Drawing.Point(-2, 289);
            this.BloodType_label.Name = "BloodType_label";
            this.BloodType_label.Size = new System.Drawing.Size(151, 30);
            this.BloodType_label.TabIndex = 37;
            this.BloodType_label.Text = "Blood Type:";
            this.BloodType_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gender_CBox
            // 
            this.Gender_CBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Gender_CBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender_CBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Gender_CBox.FormattingEnabled = true;
            this.Gender_CBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_CBox.Location = new System.Drawing.Point(546, 305);
            this.Gender_CBox.Name = "Gender_CBox";
            this.Gender_CBox.Size = new System.Drawing.Size(225, 35);
            this.Gender_CBox.TabIndex = 36;
            this.Gender_CBox.Text = "Male";
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
            this.BD_DatePicker.Location = new System.Drawing.Point(546, 145);
            this.BD_DatePicker.Name = "BD_DatePicker";
            this.BD_DatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BD_DatePicker.Size = new System.Drawing.Size(225, 27);
            this.BD_DatePicker.TabIndex = 35;
            // 
            // DriverNID_Insert_Texbox
            // 
            this.DriverNID_Insert_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DriverNID_Insert_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverNID_Insert_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DriverNID_Insert_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.DriverNID_Insert_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.DriverNID_Insert_Texbox.Location = new System.Drawing.Point(546, 58);
            this.DriverNID_Insert_Texbox.Name = "DriverNID_Insert_Texbox";
            this.DriverNID_Insert_Texbox.Size = new System.Drawing.Size(225, 36);
            this.DriverNID_Insert_Texbox.TabIndex = 34;
            this.DriverNID_Insert_Texbox.Text = "D ID";
            // 
            // NationalID_label
            // 
            this.NationalID_label.AutoSize = true;
            this.NationalID_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NationalID_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.NationalID_label.Location = new System.Drawing.Point(381, 61);
            this.NationalID_label.Name = "NationalID_label";
            this.NationalID_label.Size = new System.Drawing.Size(152, 30);
            this.NationalID_label.TabIndex = 33;
            this.NationalID_label.Text = "National ID:";
            this.NationalID_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Gender_label.Location = new System.Drawing.Point(402, 307);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(111, 30);
            this.Gender_label.TabIndex = 32;
            this.Gender_label.Text = "Gender:";
            this.Gender_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriverAdress_Insert_Texbox
            // 
            this.DriverAdress_Insert_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DriverAdress_Insert_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverAdress_Insert_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DriverAdress_Insert_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.DriverAdress_Insert_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.DriverAdress_Insert_Texbox.Location = new System.Drawing.Point(546, 222);
            this.DriverAdress_Insert_Texbox.Name = "DriverAdress_Insert_Texbox";
            this.DriverAdress_Insert_Texbox.Size = new System.Drawing.Size(225, 36);
            this.DriverAdress_Insert_Texbox.TabIndex = 31;
            this.DriverAdress_Insert_Texbox.Text = "D Address";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Address_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Address_label.Location = new System.Drawing.Point(401, 225);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(112, 30);
            this.Address_label.TabIndex = 30;
            this.Address_label.Text = "Address:";
            this.Address_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BD_label
            // 
            this.BD_label.AutoSize = true;
            this.BD_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BD_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.BD_label.Location = new System.Drawing.Point(393, 143);
            this.BD_label.Name = "BD_label";
            this.BD_label.Size = new System.Drawing.Size(128, 30);
            this.BD_label.TabIndex = 29;
            this.BD_label.Text = "BirthDate:";
            this.BD_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriverLicence_Number_Insert_Texbox
            // 
            this.DriverLicence_Number_Insert_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DriverLicence_Number_Insert_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverLicence_Number_Insert_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DriverLicence_Number_Insert_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.DriverLicence_Number_Insert_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.DriverLicence_Number_Insert_Texbox.Location = new System.Drawing.Point(175, 398);
            this.DriverLicence_Number_Insert_Texbox.Name = "DriverLicence_Number_Insert_Texbox";
            this.DriverLicence_Number_Insert_Texbox.Size = new System.Drawing.Size(163, 36);
            this.DriverLicence_Number_Insert_Texbox.TabIndex = 28;
            this.DriverLicence_Number_Insert_Texbox.Text = "D Licence #";
            // 
            // Licence_label
            // 
            this.Licence_label.AutoSize = true;
            this.Licence_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Licence_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Licence_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Licence_label.Location = new System.Drawing.Point(125, 355);
            this.Licence_label.Name = "Licence_label";
            this.Licence_label.Size = new System.Drawing.Size(109, 30);
            this.Licence_label.TabIndex = 27;
            this.Licence_label.Text = "Licence";
            this.Licence_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriverSalary_Insert_Texbox
            // 
            this.DriverSalary_Insert_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DriverSalary_Insert_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverSalary_Insert_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DriverSalary_Insert_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.DriverSalary_Insert_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.DriverSalary_Insert_Texbox.Location = new System.Drawing.Point(175, 210);
            this.DriverSalary_Insert_Texbox.Name = "DriverSalary_Insert_Texbox";
            this.DriverSalary_Insert_Texbox.Size = new System.Drawing.Size(163, 36);
            this.DriverSalary_Insert_Texbox.TabIndex = 26;
            this.DriverSalary_Insert_Texbox.Text = "D Salary";
            // 
            // Salary_label
            // 
            this.Salary_label.AutoSize = true;
            this.Salary_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salary_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Salary_label.Location = new System.Drawing.Point(28, 213);
            this.Salary_label.Name = "Salary_label";
            this.Salary_label.Size = new System.Drawing.Size(90, 30);
            this.Salary_label.TabIndex = 25;
            this.Salary_label.Text = "Salary:";
            this.Salary_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriverPhone_Texbox
            // 
            this.DriverPhone_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DriverPhone_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverPhone_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DriverPhone_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.DriverPhone_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.DriverPhone_Texbox.Location = new System.Drawing.Point(175, 134);
            this.DriverPhone_Texbox.Name = "DriverPhone_Texbox";
            this.DriverPhone_Texbox.Size = new System.Drawing.Size(163, 36);
            this.DriverPhone_Texbox.TabIndex = 24;
            this.DriverPhone_Texbox.Text = "D Phone#";
            // 
            // PhoneNumber_Label
            // 
            this.PhoneNumber_Label.AutoSize = true;
            this.PhoneNumber_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhoneNumber_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.PhoneNumber_Label.Location = new System.Drawing.Point(13, 137);
            this.PhoneNumber_Label.Name = "PhoneNumber_Label";
            this.PhoneNumber_Label.Size = new System.Drawing.Size(120, 30);
            this.PhoneNumber_Label.TabIndex = 23;
            this.PhoneNumber_Label.Text = "Phone #:";
            this.PhoneNumber_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriverName_Insert_Texbox
            // 
            this.DriverName_Insert_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DriverName_Insert_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverName_Insert_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DriverName_Insert_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.DriverName_Insert_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.DriverName_Insert_Texbox.Location = new System.Drawing.Point(175, 58);
            this.DriverName_Insert_Texbox.Name = "DriverName_Insert_Texbox";
            this.DriverName_Insert_Texbox.Size = new System.Drawing.Size(163, 36);
            this.DriverName_Insert_Texbox.TabIndex = 22;
            this.DriverName_Insert_Texbox.Text = "D Name";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Name_label.Location = new System.Drawing.Point(26, 61);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(94, 30);
            this.Name_label.TabIndex = 21;
            this.Name_label.Text = "Name:";
            this.Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.Location = new System.Drawing.Point(3, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 40;
            this.label1.Text = "Licence #:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.Location = new System.Drawing.Point(9, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "End Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.Location = new System.Drawing.Point(24, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 44;
            this.label3.Text = "Traffic :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Driver_Traffic
            // 
            this.Driver_Traffic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Driver_Traffic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Driver_Traffic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Driver_Traffic.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Driver_Traffic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Driver_Traffic.Location = new System.Drawing.Point(175, 514);
            this.Driver_Traffic.Name = "Driver_Traffic";
            this.Driver_Traffic.Size = new System.Drawing.Size(163, 36);
            this.Driver_Traffic.TabIndex = 43;
            this.Driver_Traffic.Text = "Department";
            // 
            // Driver_Licence_EndDate
            // 
            this.Driver_Licence_EndDate.CalendarFont = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Driver_Licence_EndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Driver_Licence_EndDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Driver_Licence_EndDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Driver_Licence_EndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Driver_Licence_EndDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Driver_Licence_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Driver_Licence_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Driver_Licence_EndDate.Location = new System.Drawing.Point(175, 458);
            this.Driver_Licence_EndDate.Name = "Driver_Licence_EndDate";
            this.Driver_Licence_EndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Driver_Licence_EndDate.Size = new System.Drawing.Size(163, 27);
            this.Driver_Licence_EndDate.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.Location = new System.Drawing.Point(412, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Bus ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bus_ID_CB
            // 
            this.Bus_ID_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Bus_ID_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bus_ID_CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Bus_ID_CB.FormattingEnabled = true;
            this.Bus_ID_CB.Location = new System.Drawing.Point(546, 387);
            this.Bus_ID_CB.Name = "Bus_ID_CB";
            this.Bus_ID_CB.Size = new System.Drawing.Size(225, 35);
            this.Bus_ID_CB.TabIndex = 36;
            // 
            // Driver_Insert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.Driver_Licence_EndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Driver_Traffic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Driver_AddBtn);
            this.Controls.Add(this.Blood_CBox);
            this.Controls.Add(this.BloodType_label);
            this.Controls.Add(this.Bus_ID_CB);
            this.Controls.Add(this.Gender_CBox);
            this.Controls.Add(this.BD_DatePicker);
            this.Controls.Add(this.DriverNID_Insert_Texbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NationalID_label);
            this.Controls.Add(this.Gender_label);
            this.Controls.Add(this.DriverAdress_Insert_Texbox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.BD_label);
            this.Controls.Add(this.DriverLicence_Number_Insert_Texbox);
            this.Controls.Add(this.Licence_label);
            this.Controls.Add(this.DriverSalary_Insert_Texbox);
            this.Controls.Add(this.Salary_label);
            this.Controls.Add(this.DriverPhone_Texbox);
            this.Controls.Add(this.PhoneNumber_Label);
            this.Controls.Add(this.DriverName_Insert_Texbox);
            this.Controls.Add(this.Name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Name = "Driver_Insert";
            this.Size = new System.Drawing.Size(796, 582);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Driver_AddBtn;
        private System.Windows.Forms.ComboBox Blood_CBox;
        private System.Windows.Forms.Label BloodType_label;
        private System.Windows.Forms.ComboBox Gender_CBox;
        private System.Windows.Forms.DateTimePicker BD_DatePicker;
        private System.Windows.Forms.TextBox DriverNID_Insert_Texbox;
        private System.Windows.Forms.Label NationalID_label;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.TextBox DriverAdress_Insert_Texbox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label BD_label;
        private System.Windows.Forms.TextBox DriverLicence_Number_Insert_Texbox;
        private System.Windows.Forms.Label Licence_label;
        private System.Windows.Forms.TextBox DriverSalary_Insert_Texbox;
        private System.Windows.Forms.Label Salary_label;
        private System.Windows.Forms.TextBox DriverPhone_Texbox;
        private System.Windows.Forms.Label PhoneNumber_Label;
        private System.Windows.Forms.TextBox DriverName_Insert_Texbox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Driver_Traffic;
        private System.Windows.Forms.DateTimePicker Driver_Licence_EndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Bus_ID_CB;
    }
}
