namespace DB_project1.Receptionist
{
    partial class Weekly_Trip_List_For_Search
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
            this.TakeOfTime_Lable = new System.Windows.Forms.Label();
            this.Day_Lable = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.Take_Off_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TakeOfTime_Lable
            // 
            this.TakeOfTime_Lable.AutoSize = true;
            this.TakeOfTime_Lable.Location = new System.Drawing.Point(135, 70);
            this.TakeOfTime_Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TakeOfTime_Lable.Name = "TakeOfTime_Lable";
            this.TakeOfTime_Lable.Size = new System.Drawing.Size(161, 28);
            this.TakeOfTime_Lable.TabIndex = 0;
            this.TakeOfTime_Lable.Text = "Take Of Time :";
            // 
            // Day_Lable
            // 
            this.Day_Lable.AutoSize = true;
            this.Day_Lable.Location = new System.Drawing.Point(222, 111);
            this.Day_Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Day_Lable.Name = "Day_Lable";
            this.Day_Lable.Size = new System.Drawing.Size(62, 28);
            this.Day_Lable.TabIndex = 1;
            this.Day_Lable.Text = "Day :";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(330, 111);
            this.day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(50, 28);
            this.day.TabIndex = 2;
            this.day.Text = "Day";
            // 
            // Take_Off_Time
            // 
            this.Take_Off_Time.AutoSize = true;
            this.Take_Off_Time.Location = new System.Drawing.Point(329, 70);
            this.Take_Off_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Take_Off_Time.Name = "Take_Off_Time";
            this.Take_Off_Time.Size = new System.Drawing.Size(96, 28);
            this.Take_Off_Time.TabIndex = 3;
            this.Take_Off_Time.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Weekly Trip :";
            // 
            // Weekly_Trip_List_For_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Take_Off_Time);
            this.Controls.Add(this.day);
            this.Controls.Add(this.Day_Lable);
            this.Controls.Add(this.TakeOfTime_Lable);
            this.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Weekly_Trip_List_For_Search";
            this.Size = new System.Drawing.Size(612, 164);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TakeOfTime_Lable;
        private System.Windows.Forms.Label Day_Lable;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label Take_Off_Time;
        private System.Windows.Forms.Label label1;
    }
}
