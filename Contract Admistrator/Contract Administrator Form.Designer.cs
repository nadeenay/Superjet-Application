namespace Contract_Administrator
{
    partial class ContractAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractAdministrator));
            this.panelmenue = new System.Windows.Forms.Panel();
            this.Package_btn = new System.Windows.Forms.Button();
            this.Rent_btn = new System.Windows.Forms.Button();
            this.Ad_btn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SJ = new System.Windows.Forms.Label();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.CenterLogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insert__Package1 = new Contract_Administrator.Package.Insert__Package();
            this.searchPakages1 = new Contract_Administrator.SearchPakages();
            this.delete_packages1 = new Contract_Administrator.Delete_packages();
            this.search_Ad_contract1 = new Contract_Administrator.Search_Ad_contract();
            this.insert_Ad_Contact1 = new Contract_Administrator.Insert_Ad_Contact();
            this.rent_Search1 = new Contract_Administrator.Rent.Rent_Search();
            this.rent_insert1 = new Contract_Administrator.Rent_insert();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.panelmenue.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.CenterLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenue
            // 
            this.panelmenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelmenue.Controls.Add(this.Package_btn);
            this.panelmenue.Controls.Add(this.Rent_btn);
            this.panelmenue.Controls.Add(this.Ad_btn);
            this.panelmenue.Controls.Add(this.panelLogo);
            this.panelmenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenue.Location = new System.Drawing.Point(0, 0);
            this.panelmenue.Name = "panelmenue";
            this.panelmenue.Size = new System.Drawing.Size(220, 530);
            this.panelmenue.TabIndex = 0;
            // 
            // Package_btn
            // 
            this.Package_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Package_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Package_btn.FlatAppearance.BorderSize = 0;
            this.Package_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Package_btn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Package_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Package_btn.Image = ((System.Drawing.Image)(resources.GetObject("Package_btn.Image")));
            this.Package_btn.Location = new System.Drawing.Point(0, 388);
            this.Package_btn.Name = "Package_btn";
            this.Package_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Package_btn.Size = new System.Drawing.Size(220, 142);
            this.Package_btn.TabIndex = 3;
            this.Package_btn.Text = "Package";
            this.Package_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Package_btn.UseVisualStyleBackColor = true;
            this.Package_btn.Click += new System.EventHandler(this.Package_btn_Click);
            this.Package_btn.MouseEnter += new System.EventHandler(this.Rent_btn_MouseEnter);
            // 
            // Rent_btn
            // 
            this.Rent_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rent_btn.BackgroundImage")));
            this.Rent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rent_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Rent_btn.FlatAppearance.BorderSize = 0;
            this.Rent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rent_btn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rent_btn.Location = new System.Drawing.Point(0, 234);
            this.Rent_btn.Name = "Rent_btn";
            this.Rent_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Rent_btn.Size = new System.Drawing.Size(220, 154);
            this.Rent_btn.TabIndex = 2;
            this.Rent_btn.Text = "Rent Contract";
            this.Rent_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Rent_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Rent_btn.UseVisualStyleBackColor = true;
            this.Rent_btn.Click += new System.EventHandler(this.Rent_btn_Click);
            this.Rent_btn.MouseEnter += new System.EventHandler(this.Rent_btn_MouseEnter);
            // 
            // Ad_btn
            // 
            this.Ad_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ad_btn.BackgroundImage")));
            this.Ad_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ad_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Ad_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ad_btn.FlatAppearance.BorderSize = 0;
            this.Ad_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ad_btn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ad_btn.Location = new System.Drawing.Point(0, 80);
            this.Ad_btn.Name = "Ad_btn";
            this.Ad_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Ad_btn.Size = new System.Drawing.Size(220, 154);
            this.Ad_btn.TabIndex = 1;
            this.Ad_btn.Text = "Advertisement";
            this.Ad_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ad_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Ad_btn.UseVisualStyleBackColor = true;
            this.Ad_btn.Click += new System.EventHandler(this.Ad_btn_Click);
            this.Ad_btn.MouseEnter += new System.EventHandler(this.Ad_btn_MouseEnter);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.SJ);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 56);
            this.label1.TabIndex = 1;
            // 
            // SJ
            // 
            this.SJ.AutoSize = true;
            this.SJ.Font = new System.Drawing.Font("Lucida Calligraphy", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJ.ForeColor = System.Drawing.Color.Salmon;
            this.SJ.Location = new System.Drawing.Point(113, 9);
            this.SJ.Name = "SJ";
            this.SJ.Size = new System.Drawing.Size(74, 56);
            this.SJ.TabIndex = 1;
            this.SJ.Text = "SJ";
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_Panel.Controls.Add(this.CenterLogoPanel);
            this.Main_Panel.Controls.Add(this.insert__Package1);
            this.Main_Panel.Controls.Add(this.searchPakages1);
            this.Main_Panel.Controls.Add(this.delete_packages1);
            this.Main_Panel.Controls.Add(this.search_Ad_contract1);
            this.Main_Panel.Controls.Add(this.insert_Ad_Contact1);
            this.Main_Panel.Controls.Add(this.rent_Search1);
            this.Main_Panel.Controls.Add(this.rent_insert1);
            this.Main_Panel.Location = new System.Drawing.Point(220, 80);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(762, 450);
            this.Main_Panel.TabIndex = 1;
            // 
            // CenterLogoPanel
            // 
            this.CenterLogoPanel.Controls.Add(this.pictureBox1);
            this.CenterLogoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.CenterLogoPanel.Name = "CenterLogoPanel";
            this.CenterLogoPanel.Size = new System.Drawing.Size(762, 450);
            this.CenterLogoPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // insert__Package1
            // 
            this.insert__Package1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.insert__Package1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insert__Package1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.insert__Package1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insert__Package1.Location = new System.Drawing.Point(0, 0);
            this.insert__Package1.Margin = new System.Windows.Forms.Padding(4);
            this.insert__Package1.Name = "insert__Package1";
            this.insert__Package1.Size = new System.Drawing.Size(762, 450);
            this.insert__Package1.TabIndex = 6;
            this.insert__Package1.Visible = false;
            // 
            // searchPakages1
            // 
            this.searchPakages1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.searchPakages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPakages1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPakages1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchPakages1.Location = new System.Drawing.Point(0, 0);
            this.searchPakages1.Margin = new System.Windows.Forms.Padding(4);
            this.searchPakages1.Name = "searchPakages1";
            this.searchPakages1.Size = new System.Drawing.Size(762, 450);
            this.searchPakages1.TabIndex = 5;
            this.searchPakages1.Visible = false;
            // 
            // delete_packages1
            // 
            this.delete_packages1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.delete_packages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_packages1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_packages1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_packages1.Location = new System.Drawing.Point(0, 0);
            this.delete_packages1.Margin = new System.Windows.Forms.Padding(4);
            this.delete_packages1.Name = "delete_packages1";
            this.delete_packages1.Size = new System.Drawing.Size(762, 450);
            this.delete_packages1.TabIndex = 4;
            this.delete_packages1.Visible = false;
            // 
            // search_Ad_contract1
            // 
            this.search_Ad_contract1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.search_Ad_contract1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_Ad_contract1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Ad_contract1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_Ad_contract1.Location = new System.Drawing.Point(0, 0);
            this.search_Ad_contract1.Margin = new System.Windows.Forms.Padding(4);
            this.search_Ad_contract1.Name = "search_Ad_contract1";
            this.search_Ad_contract1.Size = new System.Drawing.Size(762, 450);
            this.search_Ad_contract1.TabIndex = 3;
            this.search_Ad_contract1.Visible = false;
            // 
            // insert_Ad_Contact1
            // 
            this.insert_Ad_Contact1.AutoScroll = true;
            this.insert_Ad_Contact1.AutoSize = true;
            this.insert_Ad_Contact1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insert_Ad_Contact1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.insert_Ad_Contact1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insert_Ad_Contact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_Ad_Contact1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insert_Ad_Contact1.Location = new System.Drawing.Point(0, 0);
            this.insert_Ad_Contact1.Margin = new System.Windows.Forms.Padding(4);
            this.insert_Ad_Contact1.Name = "insert_Ad_Contact1";
            this.insert_Ad_Contact1.Size = new System.Drawing.Size(762, 450);
            this.insert_Ad_Contact1.TabIndex = 2;
            this.insert_Ad_Contact1.Visible = false;
            // 
            // rent_Search1
            // 
            this.rent_Search1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.rent_Search1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rent_Search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent_Search1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rent_Search1.Location = new System.Drawing.Point(0, 0);
            this.rent_Search1.Margin = new System.Windows.Forms.Padding(5);
            this.rent_Search1.Name = "rent_Search1";
            this.rent_Search1.Size = new System.Drawing.Size(762, 450);
            this.rent_Search1.TabIndex = 1;
            this.rent_Search1.Visible = false;
            // 
            // rent_insert1
            // 
            this.rent_insert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.rent_insert1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rent_insert1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent_insert1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rent_insert1.Location = new System.Drawing.Point(0, 0);
            this.rent_insert1.Margin = new System.Windows.Forms.Padding(4);
            this.rent_insert1.Name = "rent_insert1";
            this.rent_insert1.Size = new System.Drawing.Size(762, 450);
            this.rent_insert1.TabIndex = 0;
            this.rent_insert1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.Search_btn);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Insert);
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 80);
            this.panel1.TabIndex = 3;
            // 
            // Search_btn
            // 
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(528, 17);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(222, 46);
            this.Search_btn.TabIndex = 5;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Delete
            // 
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(267, 17);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(222, 46);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Insert
            // 
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(6, 17);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(222, 46);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // ContractAdministrator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(982, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panelmenue);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ContractAdministrator";
            this.Text = "Contract Administrator";
            this.panelmenue.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.CenterLogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenue;
        private System.Windows.Forms.Button Ad_btn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button Rent_btn;
        private System.Windows.Forms.Label SJ;
        private System.Windows.Forms.Panel Main_Panel;
        private Rent_insert rent_insert1;
        private System.Windows.Forms.Button Package_btn;
        private System.Windows.Forms.Label label1;
        private Rent.Rent_Search rent_Search1;
        private Search_Ad_contract search_Ad_contract1;
        private Insert_Ad_Contact insert_Ad_Contact1;
        private SearchPakages searchPakages1;
        private Delete_packages delete_packages1;
        private Package.Insert__Package insert__Package1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Panel CenterLogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

