namespace SuperJet.Contract_Admistrator.Rent
{
    partial class Bus_Rent_Search_Form
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
            this.panelgrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startd = new System.Windows.Forms.DateTimePicker();
            this.endd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelgrid
            // 
            this.panelgrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelgrid.Controls.Add(this.dataGridView1);
            this.panelgrid.ForeColor = System.Drawing.Color.Black;
            this.panelgrid.Location = new System.Drawing.Point(0, 58);
            this.panelgrid.Name = "panelgrid";
            this.panelgrid.Size = new System.Drawing.Size(744, 345);
            this.panelgrid.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // startd
            // 
            this.startd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.startd.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.startd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startd.Location = new System.Drawing.Point(187, 19);
            this.startd.Name = "startd";
            this.startd.Size = new System.Drawing.Size(141, 22);
            this.startd.TabIndex = 11;
            this.startd.ValueChanged += new System.EventHandler(this.startd_ValueChanged);
            // 
            // endd
            // 
            this.endd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.endd.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.endd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endd.Location = new System.Drawing.Point(515, 21);
            this.endd.Name = "endd";
            this.endd.Size = new System.Drawing.Size(141, 22);
            this.endd.TabIndex = 12;
            this.endd.ValueChanged += new System.EventHandler(this.startd_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(382, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(54, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Date";
            // 
            // Bus_Rent_Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(744, 403);
            this.Controls.Add(this.panelgrid);
            this.Controls.Add(this.startd);
            this.Controls.Add(this.endd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Bus_Rent_Search_Form";
            this.Text = "Bus_Rent_Search_Form";
            this.panelgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelgrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker startd;
        private System.Windows.Forms.DateTimePicker endd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}