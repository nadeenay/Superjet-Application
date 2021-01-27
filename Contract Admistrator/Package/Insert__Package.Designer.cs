namespace Contract_Administrator.Package
{
    partial class Insert__Package
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
            this.Insert_btn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.intervaltxt = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert_btn
            // 
            this.Insert_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(211, 309);
            this.Insert_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(344, 101);
            this.Insert_btn.TabIndex = 35;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(390, 41);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(130, 28);
            this.name.TabIndex = 34;
            // 
            // intervaltxt
            // 
            this.intervaltxt.Location = new System.Drawing.Point(390, 118);
            this.intervaltxt.Margin = new System.Windows.Forms.Padding(4);
            this.intervaltxt.Name = "intervaltxt";
            this.intervaltxt.Size = new System.Drawing.Size(130, 28);
            this.intervaltxt.TabIndex = 33;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(390, 219);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.price.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(130, 28);
            this.price.TabIndex = 32;
            this.price.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(207, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(207, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "Interval";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(207, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Name";
            // 
            // Insert__Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.intervaltxt);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Insert__Package";
            this.Size = new System.Drawing.Size(762, 450);
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox intervaltxt;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}
