namespace IT_Administrator
{
    partial class ITAdministrator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITAdministrator));
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.WeeklyTrips_btn = new System.Windows.Forms.Button();
            this.Buses_btn = new System.Windows.Forms.Button();
            this.Driver_btn = new System.Windows.Forms.Button();
            this.Employee_btn = new System.Windows.Forms.Button();
            this.Logo_panel = new System.Windows.Forms.Panel();
            this.Logo_Label = new System.Windows.Forms.Label();
            this.Moving_Panel = new System.Windows.Forms.Panel();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.weeklyTrip_Delete1 = new IT_Administrator.Weekly_Trips.WeeklyTrip_Delete();
            this.weeklyTrips_Update1 = new IT_Administrator.Weekly_Trips.WeeklyTrips_Update();
            this.weeklyTrips_Insert1 = new IT_Administrator.Weekly_Trips.WeeklyTrips_Insert();
            this.bus_Delete1 = new IT_Administrator.Buses.Bus_Delete();
            this.bus_Update1 = new IT_Administrator.Buses.Bus_Update();
            this.bus_Insert1 = new IT_Administrator.Buses.Bus_Insert();
            this.driver_Update1 = new IT_Administrator.Driver_UserControls.Driver_Update();
            this.driver_Delete1 = new IT_Administrator.Driver_UserControls.Driver_Delete();
            this.driver_Insert1 = new IT_Administrator.Driver_UserControls.Driver_Insert();
            this.employee_Delete1 = new IT_Administrator.Employee_UserControls.Employee_Delete();
            this.employee_Update1 = new IT_Administrator.Employee_UserControls.Employee_Update();
            this.employee_Insert1 = new IT_Administrator.UserControls.Employee_Insert();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Left_Panel.SuspendLayout();
            this.Logo_panel.SuspendLayout();
            this.Main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Panel
            // 
            this.Left_Panel.Controls.Add(this.WeeklyTrips_btn);
            this.Left_Panel.Controls.Add(this.Buses_btn);
            this.Left_Panel.Controls.Add(this.Driver_btn);
            this.Left_Panel.Controls.Add(this.Employee_btn);
            this.Left_Panel.Controls.Add(this.Logo_panel);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(200, 658);
            this.Left_Panel.TabIndex = 0;
            // 
            // WeeklyTrips_btn
            // 
            this.WeeklyTrips_btn.FlatAppearance.BorderSize = 0;
            this.WeeklyTrips_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeeklyTrips_btn.ForeColor = System.Drawing.Color.White;
            this.WeeklyTrips_btn.Image = ((System.Drawing.Image)(resources.GetObject("WeeklyTrips_btn.Image")));
            this.WeeklyTrips_btn.Location = new System.Drawing.Point(3, 512);
            this.WeeklyTrips_btn.Name = "WeeklyTrips_btn";
            this.WeeklyTrips_btn.Size = new System.Drawing.Size(194, 120);
            this.WeeklyTrips_btn.TabIndex = 4;
            this.WeeklyTrips_btn.Text = "Weekly Trips";
            this.WeeklyTrips_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WeeklyTrips_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.WeeklyTrips_btn.UseVisualStyleBackColor = true;
            this.WeeklyTrips_btn.Click += new System.EventHandler(this.WeeklyTrips_btn_Click);
            // 
            // Buses_btn
            // 
            this.Buses_btn.FlatAppearance.BorderSize = 0;
            this.Buses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buses_btn.ForeColor = System.Drawing.Color.White;
            this.Buses_btn.Image = ((System.Drawing.Image)(resources.GetObject("Buses_btn.Image")));
            this.Buses_btn.Location = new System.Drawing.Point(3, 366);
            this.Buses_btn.Name = "Buses_btn";
            this.Buses_btn.Size = new System.Drawing.Size(194, 120);
            this.Buses_btn.TabIndex = 3;
            this.Buses_btn.Text = "Buses";
            this.Buses_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buses_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buses_btn.UseVisualStyleBackColor = true;
            this.Buses_btn.Click += new System.EventHandler(this.Buses_btn_Click);
            // 
            // Driver_btn
            // 
            this.Driver_btn.FlatAppearance.BorderSize = 0;
            this.Driver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Driver_btn.ForeColor = System.Drawing.Color.White;
            this.Driver_btn.Image = ((System.Drawing.Image)(resources.GetObject("Driver_btn.Image")));
            this.Driver_btn.Location = new System.Drawing.Point(3, 240);
            this.Driver_btn.Name = "Driver_btn";
            this.Driver_btn.Size = new System.Drawing.Size(194, 120);
            this.Driver_btn.TabIndex = 2;
            this.Driver_btn.Text = "Driver";
            this.Driver_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Driver_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Driver_btn.UseVisualStyleBackColor = true;
            this.Driver_btn.Click += new System.EventHandler(this.Driver_btn_Click);
            // 
            // Employee_btn
            // 
            this.Employee_btn.FlatAppearance.BorderSize = 0;
            this.Employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employee_btn.ForeColor = System.Drawing.Color.White;
            this.Employee_btn.Image = ((System.Drawing.Image)(resources.GetObject("Employee_btn.Image")));
            this.Employee_btn.Location = new System.Drawing.Point(3, 116);
            this.Employee_btn.Name = "Employee_btn";
            this.Employee_btn.Size = new System.Drawing.Size(194, 120);
            this.Employee_btn.TabIndex = 1;
            this.Employee_btn.Text = "Employee";
            this.Employee_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Employee_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Employee_btn.UseVisualStyleBackColor = true;
            this.Employee_btn.Click += new System.EventHandler(this.Employee_btn_Click);
            // 
            // Logo_panel
            // 
            this.Logo_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Logo_panel.Controls.Add(this.Logo_Label);
            this.Logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_panel.Name = "Logo_panel";
            this.Logo_panel.Size = new System.Drawing.Size(200, 100);
            this.Logo_panel.TabIndex = 0;
            // 
            // Logo_Label
            // 
            this.Logo_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo_Label.Font = new System.Drawing.Font("Elephant", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo_Label.Location = new System.Drawing.Point(38, 12);
            this.Logo_Label.Name = "Logo_Label";
            this.Logo_Label.Size = new System.Drawing.Size(117, 76);
            this.Logo_Label.TabIndex = 0;
            this.Logo_Label.Text = "SJ";
            this.Logo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Moving_Panel
            // 
            this.Moving_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Moving_Panel.ForeColor = System.Drawing.Color.Yellow;
            this.Moving_Panel.Location = new System.Drawing.Point(200, 117);
            this.Moving_Panel.Name = "Moving_Panel";
            this.Moving_Panel.Size = new System.Drawing.Size(7, 120);
            this.Moving_Panel.TabIndex = 2;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(963, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(34, 37);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Main_panel
            // 
            this.Main_panel.Controls.Add(this.weeklyTrip_Delete1);
            this.Main_panel.Controls.Add(this.weeklyTrips_Update1);
            this.Main_panel.Controls.Add(this.weeklyTrips_Insert1);
            this.Main_panel.Controls.Add(this.bus_Delete1);
            this.Main_panel.Controls.Add(this.bus_Update1);
            this.Main_panel.Controls.Add(this.bus_Insert1);
            this.Main_panel.Controls.Add(this.driver_Update1);
            this.Main_panel.Controls.Add(this.driver_Delete1);
            this.Main_panel.Controls.Add(this.driver_Insert1);
            this.Main_panel.Controls.Add(this.employee_Delete1);
            this.Main_panel.Controls.Add(this.employee_Update1);
            this.Main_panel.Controls.Add(this.employee_Insert1);
            this.Main_panel.Location = new System.Drawing.Point(213, 76);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(796, 582);
            this.Main_panel.TabIndex = 4;
            // 
            // weeklyTrip_Delete1
            // 
            this.weeklyTrip_Delete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.weeklyTrip_Delete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weeklyTrip_Delete1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.weeklyTrip_Delete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.weeklyTrip_Delete1.Location = new System.Drawing.Point(0, 0);
            this.weeklyTrip_Delete1.Margin = new System.Windows.Forms.Padding(5);
            this.weeklyTrip_Delete1.Name = "weeklyTrip_Delete1";
            this.weeklyTrip_Delete1.Size = new System.Drawing.Size(796, 582);
            this.weeklyTrip_Delete1.TabIndex = 11;
            this.weeklyTrip_Delete1.Visible = false;
            // 
            // weeklyTrips_Update1
            // 
            this.weeklyTrips_Update1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.weeklyTrips_Update1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weeklyTrips_Update1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.weeklyTrips_Update1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.weeklyTrips_Update1.Location = new System.Drawing.Point(0, 0);
            this.weeklyTrips_Update1.Margin = new System.Windows.Forms.Padding(5);
            this.weeklyTrips_Update1.Name = "weeklyTrips_Update1";
            this.weeklyTrips_Update1.Size = new System.Drawing.Size(796, 582);
            this.weeklyTrips_Update1.TabIndex = 10;
            this.weeklyTrips_Update1.Visible = false;
            // 
            // weeklyTrips_Insert1
            // 
            this.weeklyTrips_Insert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.weeklyTrips_Insert1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weeklyTrips_Insert1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.weeklyTrips_Insert1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.weeklyTrips_Insert1.Location = new System.Drawing.Point(0, 0);
            this.weeklyTrips_Insert1.Margin = new System.Windows.Forms.Padding(5);
            this.weeklyTrips_Insert1.Name = "weeklyTrips_Insert1";
            this.weeklyTrips_Insert1.Size = new System.Drawing.Size(796, 582);
            this.weeklyTrips_Insert1.TabIndex = 9;
            this.weeklyTrips_Insert1.Visible = false;
            // 
            // bus_Delete1
            // 
            this.bus_Delete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.bus_Delete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bus_Delete1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.bus_Delete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.bus_Delete1.Location = new System.Drawing.Point(0, 0);
            this.bus_Delete1.Margin = new System.Windows.Forms.Padding(5);
            this.bus_Delete1.Name = "bus_Delete1";
            this.bus_Delete1.Size = new System.Drawing.Size(796, 582);
            this.bus_Delete1.TabIndex = 8;
            this.bus_Delete1.Visible = false;
            // 
            // bus_Update1
            // 
            this.bus_Update1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.bus_Update1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bus_Update1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.bus_Update1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.bus_Update1.Location = new System.Drawing.Point(0, 0);
            this.bus_Update1.Margin = new System.Windows.Forms.Padding(5);
            this.bus_Update1.Name = "bus_Update1";
            this.bus_Update1.Size = new System.Drawing.Size(796, 582);
            this.bus_Update1.TabIndex = 7;
            this.bus_Update1.Visible = false;
            // 
            // bus_Insert1
            // 
            this.bus_Insert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.bus_Insert1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bus_Insert1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.bus_Insert1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.bus_Insert1.Location = new System.Drawing.Point(0, 0);
            this.bus_Insert1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bus_Insert1.Name = "bus_Insert1";
            this.bus_Insert1.Size = new System.Drawing.Size(796, 582);
            this.bus_Insert1.TabIndex = 6;
            this.bus_Insert1.Visible = false;
            // 
            // driver_Update1
            // 
            this.driver_Update1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.driver_Update1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_Update1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.driver_Update1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.driver_Update1.Location = new System.Drawing.Point(0, 0);
            this.driver_Update1.Margin = new System.Windows.Forms.Padding(4);
            this.driver_Update1.Name = "driver_Update1";
            this.driver_Update1.Size = new System.Drawing.Size(796, 582);
            this.driver_Update1.TabIndex = 5;
            this.driver_Update1.Visible = false;
            // 
            // driver_Delete1
            // 
            this.driver_Delete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.driver_Delete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_Delete1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.driver_Delete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.driver_Delete1.Location = new System.Drawing.Point(0, 0);
            this.driver_Delete1.Margin = new System.Windows.Forms.Padding(4);
            this.driver_Delete1.Name = "driver_Delete1";
            this.driver_Delete1.Size = new System.Drawing.Size(796, 582);
            this.driver_Delete1.TabIndex = 4;
            this.driver_Delete1.Visible = false;
            // 
            // driver_Insert1
            // 
            this.driver_Insert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.driver_Insert1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_Insert1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.driver_Insert1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.driver_Insert1.Location = new System.Drawing.Point(0, 0);
            this.driver_Insert1.Name = "driver_Insert1";
            this.driver_Insert1.Size = new System.Drawing.Size(796, 582);
            this.driver_Insert1.TabIndex = 3;
            this.driver_Insert1.Visible = false;
            // 
            // employee_Delete1
            // 
            this.employee_Delete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.employee_Delete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employee_Delete1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.employee_Delete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.employee_Delete1.Location = new System.Drawing.Point(0, 0);
            this.employee_Delete1.Margin = new System.Windows.Forms.Padding(4);
            this.employee_Delete1.Name = "employee_Delete1";
            this.employee_Delete1.Size = new System.Drawing.Size(796, 582);
            this.employee_Delete1.TabIndex = 2;
            // 
            // employee_Update1
            // 
            this.employee_Update1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.employee_Update1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employee_Update1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_Update1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.employee_Update1.Location = new System.Drawing.Point(0, 0);
            this.employee_Update1.Margin = new System.Windows.Forms.Padding(4);
            this.employee_Update1.Name = "employee_Update1";
            this.employee_Update1.Size = new System.Drawing.Size(796, 582);
            this.employee_Update1.TabIndex = 1;
            // 
            // employee_Insert1
            // 
            this.employee_Insert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.employee_Insert1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employee_Insert1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.employee_Insert1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.employee_Insert1.Location = new System.Drawing.Point(0, 0);
            this.employee_Insert1.Name = "employee_Insert1";
            this.employee_Insert1.Size = new System.Drawing.Size(796, 582);
            this.employee_Insert1.TabIndex = 0;
            // 
            // Insert_btn
            // 
            this.Insert_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_btn.Location = new System.Drawing.Point(257, 28);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(113, 30);
            this.Insert_btn.TabIndex = 5;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.Location = new System.Drawing.Point(526, 28);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(113, 30);
            this.Update_btn.TabIndex = 5;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Location = new System.Drawing.Point(795, 28);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(113, 30);
            this.Delete_btn.TabIndex = 5;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // ITAdministrator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1009, 658);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Moving_Panel);
            this.Controls.Add(this.Left_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ITAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Left_Panel.ResumeLayout(false);
            this.Logo_panel.ResumeLayout(false);
            this.Main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.Button Driver_btn;
        private System.Windows.Forms.Button Employee_btn;
        private System.Windows.Forms.Panel Logo_panel;
        private System.Windows.Forms.Label Logo_Label;
        private System.Windows.Forms.Button WeeklyTrips_btn;
        private System.Windows.Forms.Button Buses_btn;
        private System.Windows.Forms.Panel Moving_Panel;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Delete_btn;
        private IT_Administrator.UserControls.Employee_Insert employee_Insert1;
        private Employee_UserControls.Employee_Delete employee_Delete1;
        private Employee_UserControls.Employee_Update employee_Update1;
        private Driver_UserControls.Driver_Insert driver_Insert1;
        private Driver_UserControls.Driver_Update driver_Update1;
        private Driver_UserControls.Driver_Delete driver_Delete1;
        private Buses.Bus_Insert bus_Insert1;
        private Buses.Bus_Update bus_Update1;
        private Buses.Bus_Delete bus_Delete1;
        private Weekly_Trips.WeeklyTrips_Insert weeklyTrips_Insert1;
        private Weekly_Trips.WeeklyTrips_Update weeklyTrips_Update1;
        private Weekly_Trips.WeeklyTrip_Delete weeklyTrip_Delete1;
    }
}

