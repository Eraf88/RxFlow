namespace RxFlow
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addCategories_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.addUsers_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminAddCategories1 = new RxFlow.adminAddCategories();
            this.adminCustomers1 = new RxFlow.adminCustomers();
            this.adminAddProducts1 = new RxFlow.adminAddProducts();
            this.adminAddUsers1 = new RxFlow.adminAddUsers();
            this.adminDashboard1 = new RxFlow.adminDashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 39);
            this.panel1.TabIndex = 0;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(774, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 20);
            this.close.TabIndex = 3;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "RxFlow";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.addCategories_btn);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.addProducts_btn);
            this.panel2.Controls.Add(this.addUsers_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 464);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addCategories_btn
            // 
            this.addCategories_btn.FlatAppearance.BorderSize = 0;
            this.addCategories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.addCategories_btn.Image = global::RxFlow.Properties.Resources.icons8_package_24;
            this.addCategories_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategories_btn.Location = new System.Drawing.Point(15, 315);
            this.addCategories_btn.Name = "addCategories_btn";
            this.addCategories_btn.Size = new System.Drawing.Size(145, 27);
            this.addCategories_btn.TabIndex = 9;
            this.addCategories_btn.Text = "      Add Categories";
            this.addCategories_btn.UseVisualStyleBackColor = true;
            this.addCategories_btn.Click += new System.EventHandler(this.addCategories_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.logout_btn.Image = global::RxFlow.Properties.Resources.icons8_logout_24;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(12, 425);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(145, 27);
            this.logout_btn.TabIndex = 8;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // customers_btn
            // 
            this.customers_btn.FlatAppearance.BorderSize = 0;
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.customers_btn.Image = global::RxFlow.Properties.Resources.customers;
            this.customers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customers_btn.Location = new System.Drawing.Point(12, 282);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(145, 27);
            this.customers_btn.TabIndex = 7;
            this.customers_btn.Text = "Customers";
            this.customers_btn.UseVisualStyleBackColor = true;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.FlatAppearance.BorderSize = 0;
            this.addProducts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.addProducts_btn.Image = global::RxFlow.Properties.Resources.icons8_products_30;
            this.addProducts_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProducts_btn.Location = new System.Drawing.Point(15, 239);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(145, 27);
            this.addProducts_btn.TabIndex = 6;
            this.addProducts_btn.Text = "  Add Products";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // addUsers_btn
            // 
            this.addUsers_btn.FlatAppearance.BorderSize = 0;
            this.addUsers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.addUsers_btn.Image = global::RxFlow.Properties.Resources.icons8_users_30;
            this.addUsers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUsers_btn.Location = new System.Drawing.Point(15, 189);
            this.addUsers_btn.Name = "addUsers_btn";
            this.addUsers_btn.Size = new System.Drawing.Size(145, 27);
            this.addUsers_btn.TabIndex = 5;
            this.addUsers_btn.Text = "Add Users";
            this.addUsers_btn.UseVisualStyleBackColor = true;
            this.addUsers_btn.Click += new System.EventHandler(this.addUsers_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.dashboard_btn.Image = global::RxFlow.Properties.Resources.icons8_dashboard_24;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 143);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(145, 27);
            this.dashboard_btn.TabIndex = 4;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RxFlow.Properties.Resources.icons8_doctor_96;
            this.pictureBox1.Location = new System.Drawing.Point(33, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.adminAddUsers1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.adminCustomers1);
            this.panel3.Controls.Add(this.adminAddCategories1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(174, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 464);
            this.panel3.TabIndex = 4;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(0, 0);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(628, 464);
            this.adminAddCategories1.TabIndex = 0;
            // 
            // adminCustomers1
            // 
            this.adminCustomers1.Location = new System.Drawing.Point(0, 0);
            this.adminCustomers1.Name = "adminCustomers1";
            this.adminCustomers1.Size = new System.Drawing.Size(628, 464);
            this.adminCustomers1.TabIndex = 1;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(628, 464);
            this.adminAddProducts1.TabIndex = 2;
            // 
            // adminAddUsers1
            // 
            this.adminAddUsers1.Location = new System.Drawing.Point(0, 0);
            this.adminAddUsers1.Name = "adminAddUsers1";
            this.adminAddUsers1.Size = new System.Drawing.Size(628, 464);
            this.adminAddUsers1.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(628, 464);
            this.adminDashboard1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 503);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Button addUsers_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addCategories_btn;
        private adminAddCategories adminAddCategories1;
        private adminDashboard adminDashboard1;
        private adminAddUsers adminAddUsers1;
        private adminAddProducts adminAddProducts1;
        private adminCustomers adminCustomers1;
    }
}