namespace RxFlow
{
    partial class cashierMainForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.orders_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.adminCustomers1 = new RxFlow.adminCustomers();
            this.cashierOrders1 = new RxFlow.CashierOrders();
            this.adminDashboard1 = new RxFlow.adminDashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(786, 39);
            this.panel1.TabIndex = 1;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(758, 6);
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 425);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.orders_btn);
            this.panel3.Controls.Add(this.logout_btn);
            this.panel3.Controls.Add(this.customers_btn);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 425);
            this.panel3.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Image = global::RxFlow.Properties.Resources.icons8_logout_24;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 386);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 27);
            this.button6.TabIndex = 10;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // orders_btn
            // 
            this.orders_btn.FlatAppearance.BorderSize = 0;
            this.orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.orders_btn.Image = global::RxFlow.Properties.Resources.icons8_package_24;
            this.orders_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orders_btn.Location = new System.Drawing.Point(3, 176);
            this.orders_btn.Name = "orders_btn";
            this.orders_btn.Size = new System.Drawing.Size(145, 27);
            this.orders_btn.TabIndex = 9;
            this.orders_btn.Text = "     Orders";
            this.orders_btn.UseVisualStyleBackColor = true;
            this.orders_btn.Click += new System.EventHandler(this.orders_btn_Click);
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
            // 
            // customers_btn
            // 
            this.customers_btn.FlatAppearance.BorderSize = 0;
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.customers_btn.Image = global::RxFlow.Properties.Resources.customers;
            this.customers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customers_btn.Location = new System.Drawing.Point(3, 209);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(145, 27);
            this.customers_btn.TabIndex = 7;
            this.customers_btn.Text = "Customers";
            this.customers_btn.UseVisualStyleBackColor = true;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::RxFlow.Properties.Resources.icons8_dashboard_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Cashier";
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
            // panel4
            // 
            this.panel4.Controls.Add(this.adminDashboard1);
            this.panel4.Controls.Add(this.cashierOrders1);
            this.panel4.Controls.Add(this.adminCustomers1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(174, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(612, 425);
            this.panel4.TabIndex = 5;
            // 
            // adminCustomers1
            // 
            this.adminCustomers1.Location = new System.Drawing.Point(0, 0);
            this.adminCustomers1.Name = "adminCustomers1";
            this.adminCustomers1.Size = new System.Drawing.Size(628, 464);
            this.adminCustomers1.TabIndex = 0;
            // 
            // cashierOrders1
            // 
            this.cashierOrders1.Location = new System.Drawing.Point(0, 0);
            this.cashierOrders1.Name = "cashierOrders1";
            this.cashierOrders1.Size = new System.Drawing.Size(612, 425);
            this.cashierOrders1.TabIndex = 1;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(628, 464);
            this.adminDashboard1.TabIndex = 2;
            // 
            // cashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 464);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cashierMainForm";
            this.Text = "cashierMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button orders_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel4;
        private adminDashboard adminDashboard1;
        private CashierOrders cashierOrders1;
        private adminCustomers adminCustomers1;
    }
}