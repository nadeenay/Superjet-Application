namespace IT_Administrator.Buses
{
    partial class Bus_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bus_Update));
            this.Search_Panel = new System.Windows.Forms.Panel();
            this.Found_label = new System.Windows.Forms.Label();
            this.Search_PicBox = new System.Windows.Forms.PictureBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Bus_Search_Texbox = new System.Windows.Forms.TextBox();
            this.BusID_Search_Label = new System.Windows.Forms.Label();
            this.Model_TB = new System.Windows.Forms.TextBox();
            this.Model_Label = new System.Windows.Forms.Label();
            this.Seats_Numeric = new System.Windows.Forms.NumericUpDown();
            this.RDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.License_TB = new System.Windows.Forms.TextBox();
            this.ModelYear_TB = new System.Windows.Forms.TextBox();
            this.Manufacturer_TB = new System.Windows.Forms.TextBox();
            this.Department_TB = new System.Windows.Forms.TextBox();
            this.EngineNo_TB = new System.Windows.Forms.TextBox();
            this.BUS_Update_btn = new System.Windows.Forms.Button();
            this.Seats_Label = new System.Windows.Forms.Label();
            this.RDate_Label = new System.Windows.Forms.Label();
            this.ModelYear_Label = new System.Windows.Forms.Label();
            this.License_Label = new System.Windows.Forms.Label();
            this.Department_Label = new System.Windows.Forms.Label();
            this.ManufacturerCo_Label = new System.Windows.Forms.Label();
            this.Bus_Engine_Label = new System.Windows.Forms.Label();
            this.Search_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seats_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Panel
            // 
            this.Search_Panel.Controls.Add(this.Found_label);
            this.Search_Panel.Controls.Add(this.Search_PicBox);
            this.Search_Panel.Controls.Add(this.Search_btn);
            this.Search_Panel.Controls.Add(this.Bus_Search_Texbox);
            this.Search_Panel.Controls.Add(this.BusID_Search_Label);
            this.Search_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search_Panel.Location = new System.Drawing.Point(0, 0);
            this.Search_Panel.Name = "Search_Panel";
            this.Search_Panel.Size = new System.Drawing.Size(796, 135);
            this.Search_Panel.TabIndex = 0;
            // 
            // Found_label
            // 
            this.Found_label.AutoSize = true;
            this.Found_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Found_label.ForeColor = System.Drawing.Color.Lime;
            this.Found_label.Location = new System.Drawing.Point(699, 102);
            this.Found_label.Name = "Found_label";
            this.Found_label.Size = new System.Drawing.Size(0, 23);
            this.Found_label.TabIndex = 35;
            // 
            // Search_PicBox
            // 
            this.Search_PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search_PicBox.Image = ((System.Drawing.Image)(resources.GetObject("Search_PicBox.Image")));
            this.Search_PicBox.Location = new System.Drawing.Point(273, 77);
            this.Search_PicBox.Name = "Search_PicBox";
            this.Search_PicBox.Size = new System.Drawing.Size(32, 32);
            this.Search_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Search_PicBox.TabIndex = 10;
            this.Search_PicBox.TabStop = false;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Search_btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(323, 78);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(225, 31);
            this.Search_btn.TabIndex = 9;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Bus_Search_Texbox
            // 
            this.Bus_Search_Texbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Bus_Search_Texbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bus_Search_Texbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bus_Search_Texbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Bus_Search_Texbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Bus_Search_Texbox.Location = new System.Drawing.Point(323, 36);
            this.Bus_Search_Texbox.Name = "Bus_Search_Texbox";
            this.Bus_Search_Texbox.Size = new System.Drawing.Size(225, 36);
            this.Bus_Search_Texbox.TabIndex = 8;
            // 
            // BusID_Search_Label
            // 
            this.BusID_Search_Label.AutoSize = true;
            this.BusID_Search_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusID_Search_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.BusID_Search_Label.Location = new System.Drawing.Point(143, 36);
            this.BusID_Search_Label.Name = "BusID_Search_Label";
            this.BusID_Search_Label.Size = new System.Drawing.Size(162, 30);
            this.BusID_Search_Label.TabIndex = 7;
            this.BusID_Search_Label.Text = "Bus Licence:";
            this.BusID_Search_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Model_TB
            // 
            this.Model_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Model_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Model_TB.Location = new System.Drawing.Point(225, 333);
            this.Model_TB.Name = "Model_TB";
            this.Model_TB.Size = new System.Drawing.Size(163, 36);
            this.Model_TB.TabIndex = 69;
            // 
            // Model_Label
            // 
            this.Model_Label.AutoSize = true;
            this.Model_Label.Location = new System.Drawing.Point(59, 336);
            this.Model_Label.Name = "Model_Label";
            this.Model_Label.Size = new System.Drawing.Size(90, 30);
            this.Model_Label.TabIndex = 68;
            this.Model_Label.Text = "Model";
            // 
            // Seats_Numeric
            // 
            this.Seats_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.Seats_Numeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Seats_Numeric.Location = new System.Drawing.Point(597, 414);
            this.Seats_Numeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Seats_Numeric.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Seats_Numeric.Name = "Seats_Numeric";
            this.Seats_Numeric.Size = new System.Drawing.Size(163, 36);
            this.Seats_Numeric.TabIndex = 66;
            this.Seats_Numeric.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // RDate_Picker
            // 
            this.RDate_Picker.CalendarFont = new System.Drawing.Font("Century Gothic", 13.8F);
            this.RDate_Picker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.RDate_Picker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.RDate_Picker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.RDate_Picker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.RDate_Picker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.RDate_Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.RDate_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RDate_Picker.Location = new System.Drawing.Point(225, 504);
            this.RDate_Picker.Name = "RDate_Picker";
            this.RDate_Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RDate_Picker.Size = new System.Drawing.Size(163, 27);
            this.RDate_Picker.TabIndex = 65;
            // 
            // License_TB
            // 
            this.License_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.License_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.License_TB.Location = new System.Drawing.Point(597, 292);
            this.License_TB.Name = "License_TB";
            this.License_TB.Size = new System.Drawing.Size(163, 36);
            this.License_TB.TabIndex = 63;
            // 
            // ModelYear_TB
            // 
            this.ModelYear_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ModelYear_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.ModelYear_TB.Location = new System.Drawing.Point(225, 414);
            this.ModelYear_TB.Name = "ModelYear_TB";
            this.ModelYear_TB.Size = new System.Drawing.Size(163, 36);
            this.ModelYear_TB.TabIndex = 62;
            // 
            // Manufacturer_TB
            // 
            this.Manufacturer_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Manufacturer_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Manufacturer_TB.Location = new System.Drawing.Point(225, 252);
            this.Manufacturer_TB.Name = "Manufacturer_TB";
            this.Manufacturer_TB.Size = new System.Drawing.Size(163, 36);
            this.Manufacturer_TB.TabIndex = 61;
            // 
            // Department_TB
            // 
            this.Department_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Department_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Department_TB.Location = new System.Drawing.Point(597, 171);
            this.Department_TB.Name = "Department_TB";
            this.Department_TB.Size = new System.Drawing.Size(163, 36);
            this.Department_TB.TabIndex = 64;
            // 
            // EngineNo_TB
            // 
            this.EngineNo_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EngineNo_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.EngineNo_TB.Location = new System.Drawing.Point(225, 171);
            this.EngineNo_TB.Name = "EngineNo_TB";
            this.EngineNo_TB.Size = new System.Drawing.Size(163, 36);
            this.EngineNo_TB.TabIndex = 60;
            // 
            // BUS_Update_btn
            // 
            this.BUS_Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUS_Update_btn.Location = new System.Drawing.Point(427, 478);
            this.BUS_Update_btn.Name = "BUS_Update_btn";
            this.BUS_Update_btn.Size = new System.Drawing.Size(321, 74);
            this.BUS_Update_btn.TabIndex = 59;
            this.BUS_Update_btn.Text = "Update Bus";
            this.BUS_Update_btn.UseVisualStyleBackColor = true;
            this.BUS_Update_btn.Click += new System.EventHandler(this.BUS_Update_btn_Click);
            // 
            // Seats_Label
            // 
            this.Seats_Label.AutoSize = true;
            this.Seats_Label.Location = new System.Drawing.Point(418, 416);
            this.Seats_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Seats_Label.Name = "Seats_Label";
            this.Seats_Label.Size = new System.Drawing.Size(135, 30);
            this.Seats_Label.TabIndex = 57;
            this.Seats_Label.Text = "# Of Seats";
            // 
            // RDate_Label
            // 
            this.RDate_Label.AutoSize = true;
            this.RDate_Label.Location = new System.Drawing.Point(0, 498);
            this.RDate_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RDate_Label.Name = "RDate_Label";
            this.RDate_Label.Size = new System.Drawing.Size(208, 30);
            this.RDate_Label.TabIndex = 56;
            this.RDate_Label.Text = "Redemtion date";
            // 
            // ModelYear_Label
            // 
            this.ModelYear_Label.AutoSize = true;
            this.ModelYear_Label.Location = new System.Drawing.Point(28, 417);
            this.ModelYear_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelYear_Label.Name = "ModelYear_Label";
            this.ModelYear_Label.Size = new System.Drawing.Size(152, 30);
            this.ModelYear_Label.TabIndex = 54;
            this.ModelYear_Label.Text = "Model Year";
            // 
            // License_Label
            // 
            this.License_Label.AutoSize = true;
            this.License_Label.Location = new System.Drawing.Point(422, 295);
            this.License_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.License_Label.Name = "License_Label";
            this.License_Label.Size = new System.Drawing.Size(127, 30);
            this.License_Label.TabIndex = 53;
            this.License_Label.Text = "License #";
            // 
            // Department_Label
            // 
            this.Department_Label.AutoSize = true;
            this.Department_Label.Location = new System.Drawing.Point(407, 174);
            this.Department_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Department_Label.Name = "Department_Label";
            this.Department_Label.Size = new System.Drawing.Size(157, 30);
            this.Department_Label.TabIndex = 52;
            this.Department_Label.Text = "Department";
            // 
            // ManufacturerCo_Label
            // 
            this.ManufacturerCo_Label.AutoSize = true;
            this.ManufacturerCo_Label.Location = new System.Drawing.Point(0, 255);
            this.ManufacturerCo_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManufacturerCo_Label.Name = "ManufacturerCo_Label";
            this.ManufacturerCo_Label.Size = new System.Drawing.Size(225, 30);
            this.ManufacturerCo_Label.TabIndex = 58;
            this.ManufacturerCo_Label.Text = "Manufacturer Co.";
            // 
            // Bus_Engine_Label
            // 
            this.Bus_Engine_Label.AutoSize = true;
            this.Bus_Engine_Label.Location = new System.Drawing.Point(6, 174);
            this.Bus_Engine_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bus_Engine_Label.Name = "Bus_Engine_Label";
            this.Bus_Engine_Label.Size = new System.Drawing.Size(197, 30);
            this.Bus_Engine_Label.TabIndex = 51;
            this.Bus_Engine_Label.Text = "Engine Number";
            // 
            // Bus_Update
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.Model_TB);
            this.Controls.Add(this.Model_Label);
            this.Controls.Add(this.Seats_Numeric);
            this.Controls.Add(this.RDate_Picker);
            this.Controls.Add(this.License_TB);
            this.Controls.Add(this.ModelYear_TB);
            this.Controls.Add(this.Manufacturer_TB);
            this.Controls.Add(this.Department_TB);
            this.Controls.Add(this.EngineNo_TB);
            this.Controls.Add(this.BUS_Update_btn);
            this.Controls.Add(this.Seats_Label);
            this.Controls.Add(this.RDate_Label);
            this.Controls.Add(this.ModelYear_Label);
            this.Controls.Add(this.License_Label);
            this.Controls.Add(this.Department_Label);
            this.Controls.Add(this.ManufacturerCo_Label);
            this.Controls.Add(this.Bus_Engine_Label);
            this.Controls.Add(this.Search_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Bus_Update";
            this.Size = new System.Drawing.Size(796, 582);
            this.Search_Panel.ResumeLayout(false);
            this.Search_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seats_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Search_Panel;
        private System.Windows.Forms.PictureBox Search_PicBox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Bus_Search_Texbox;
        private System.Windows.Forms.Label BusID_Search_Label;
        private System.Windows.Forms.TextBox Model_TB;
        private System.Windows.Forms.Label Model_Label;
        private System.Windows.Forms.NumericUpDown Seats_Numeric;
        private System.Windows.Forms.DateTimePicker RDate_Picker;
        private System.Windows.Forms.TextBox License_TB;
        private System.Windows.Forms.TextBox ModelYear_TB;
        private System.Windows.Forms.TextBox Manufacturer_TB;
        private System.Windows.Forms.TextBox Department_TB;
        private System.Windows.Forms.TextBox EngineNo_TB;
        private System.Windows.Forms.Button BUS_Update_btn;
        private System.Windows.Forms.Label Seats_Label;
        private System.Windows.Forms.Label RDate_Label;
        private System.Windows.Forms.Label ModelYear_Label;
        private System.Windows.Forms.Label License_Label;
        private System.Windows.Forms.Label Department_Label;
        private System.Windows.Forms.Label ManufacturerCo_Label;
        private System.Windows.Forms.Label Bus_Engine_Label;
        private System.Windows.Forms.Label Found_label;
    }
}
