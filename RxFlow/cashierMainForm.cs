using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RxFlow
{
    public partial class cashierMainForm: Form
    {
        public cashierMainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form2 loginForm = new Form2();
                loginForm.Show();

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            cashierOrders1.Visible = false;
            adminCustomers1.Visible = false;

            adminDashboard aDashboard = adminDashboard1 as adminDashboard;

            if (aDashboard != null)
            {
                aDashboard.refreshData();
            }

        }

        private void orders_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            cashierOrders1.Visible = true;
            adminCustomers1.Visible = false;

            CashierOrders cOrders = cashierOrders1 as CashierOrders;

            if (cOrders != null)
            {
                cOrders.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            cashierOrders1.Visible = false;
            adminCustomers1.Visible = true;

            adminCustomers aCustomers = adminCustomers1 as adminCustomers;

            if (aCustomers != null)
            {
                aCustomers.refreshData();
            }
        }
    }
}
