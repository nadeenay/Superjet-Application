namespace DB_project1
{
    partial class FindTrip
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
            this.Search_Button = new System.Windows.Forms.Button();
            this.Seats_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Date_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.Time_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PromoCode_textBox = new System.Windows.Forms.TextBox();
            this.PromoCode_Lable = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Seats_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Search_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Search_Button.Location = new System.Drawing.Point(538, 496);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(346, 77);
            this.Search_Button.TabIndex = 4;
            this.Search_Button.Text = "Reserve for Passenger";
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Click);
            // 
            // Seats_Numeric
            // 
            this.Seats_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Seats_Numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Seats_Numeric.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Seats_Numeric.Location = new System.Drawing.Point(372, 373);
            this.Seats_Numeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Seats_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Seats_Numeric.Name = "Seats_Numeric";
            this.Seats_Numeric.Size = new System.Drawing.Size(307, 35);
            this.Seats_Numeric.TabIndex = 14;
            this.Seats_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Date_TimePicker
            // 
            this.Date_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Date_TimePicker.Location = new System.Drawing.Point(372, 285);
            this.Date_TimePicker.Name = "Date_TimePicker";
            this.Date_TimePicker.Size = new System.Drawing.Size(307, 39);
            this.Date_TimePicker.TabIndex = 15;
            // 
            // Time_TimePicker
            // 
            this.Time_TimePicker.CustomFormat = "time";
            this.Time_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Time_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_TimePicker.Location = new System.Drawing.Point(372, 202);
            this.Time_TimePicker.Name = "Time_TimePicker";
            this.Time_TimePicker.ShowUpDown = true;
            this.Time_TimePicker.Size = new System.Drawing.Size(307, 39);
            this.Time_TimePicker.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(388, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 43);
            this.label7.TabIndex = 17;
            this.label7.Text = "Trip Reservation";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::DB_project1.Properties.Resources.date;
            this.pictureBox4.Location = new System.Drawing.Point(642, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::DB_project1.Properties.Resources.hours;
            this.pictureBox5.Location = new System.Drawing.Point(641, 168);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::DB_project1.Properties.Resources.seat;
            this.pictureBox6.Location = new System.Drawing.Point(641, 339);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(153, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(153, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.Location = new System.Drawing.Point(129, 370);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "Number of Seats";
            // 
            // PromoCode_textBox
            // 
            this.PromoCode_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PromoCode_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoCode_textBox.Location = new System.Drawing.Point(373, 441);
            this.PromoCode_textBox.Name = "PromoCode_textBox";
            this.PromoCode_textBox.Size = new System.Drawing.Size(306, 32);
            this.PromoCode_textBox.TabIndex = 32;
            // 
            // PromoCode_Lable
            // 
            this.PromoCode_Lable.AutoSize = true;
            this.PromoCode_Lable.BackColor = System.Drawing.Color.Transparent;
            this.PromoCode_Lable.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PromoCode_Lable.Location = new System.Drawing.Point(46, 448);
            this.PromoCode_Lable.Name = "PromoCode_Lable";
            this.PromoCode_Lable.Size = new System.Drawing.Size(304, 25);
            this.PromoCode_Lable.TabIndex = 33;
            this.PromoCode_Lable.Text = "Apply Promo Code if available";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::DB_project1.Properties.Resources.hooome;
            this.pictureBox7.Location = new System.Drawing.Point(854, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 47;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::DB_project1.Properties.Resources.back;
            this.pictureBox8.Location = new System.Drawing.Point(12, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 23);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 46;
            this.pictureBox8.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(890, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 45;
            this.label6.Text = "Home";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 44;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FindTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_project1.Properties.Resources.reserve;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 850);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PromoCode_Lable);
            this.Controls.Add(this.PromoCode_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Time_TimePicker);
            this.Controls.Add(this.Date_TimePicker);
            this.Controls.Add(this.Seats_Numeric);
            this.Controls.Add(this.Search_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindTrip";
            this.Load += new System.EventHandler(this.FindTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Seats_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.NumericUpDown Seats_Numeric;
        private System.Windows.Forms.DateTimePicker Date_TimePicker;
        private System.Windows.Forms.DateTimePicker Time_TimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PromoCode_textBox;
        private System.Windows.Forms.Label PromoCode_Lable;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}