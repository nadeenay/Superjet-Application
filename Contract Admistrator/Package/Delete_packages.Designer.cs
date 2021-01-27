namespace Contract_Administrator
{
    partial class Delete_packages
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
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.interval1 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.interval2 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Get_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Name";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(86, 122);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(263, 46);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // interval1
            // 
            this.interval1.AutoSize = true;
            this.interval1.Location = new System.Drawing.Point(208, 260);
            this.interval1.Name = "interval1";
            this.interval1.Size = new System.Drawing.Size(74, 24);
            this.interval1.TabIndex = 5;
            this.interval1.Text = "Interval:";
            // 
            // price1
            // 
            this.price1.AutoSize = true;
            this.price1.Location = new System.Drawing.Point(208, 356);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(58, 24);
            this.price1.TabIndex = 6;
            this.price1.Text = "Price:";
            // 
            // interval2
            // 
            this.interval2.AutoSize = true;
            this.interval2.Location = new System.Drawing.Point(370, 260);
            this.interval2.Name = "interval2";
            this.interval2.Size = new System.Drawing.Size(0, 24);
            this.interval2.TabIndex = 7;
            // 
            // price2
            // 
            this.price2.AutoSize = true;
            this.price2.Location = new System.Drawing.Point(370, 356);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(0, 24);
            this.price2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(318, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 30);
            this.comboBox1.TabIndex = 9;
            // 
            // Get_info
            // 
            this.Get_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Get_info.Location = new System.Drawing.Point(407, 122);
            this.Get_info.Name = "Get_info";
            this.Get_info.Size = new System.Drawing.Size(263, 46);
            this.Get_info.TabIndex = 10;
            this.Get_info.Text = "Get info";
            this.Get_info.UseVisualStyleBackColor = true;
            this.Get_info.Click += new System.EventHandler(this.Get_info_Click);
            // 
            // Delete_packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.Get_info);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.interval2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.interval1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Delete_packages";
            this.Size = new System.Drawing.Size(762, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label interval1;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label interval2;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Get_info;
    }
}
