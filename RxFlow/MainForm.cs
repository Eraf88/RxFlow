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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form2 loginForm = new Form2();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            adminCustomers1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = false;

            adminDashboard aDash = adminDashboard1 as adminDashboard;

            if(aDash != null)
            {
                aDash.refreshData();
            }

        }

        private void addUsers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = false;
            adminCustomers1.Visible = false;
            adminAddUsers1.Visible = true;
            adminAddUsers aaUsers = adminAddUsers1 as adminAddUsers;

            if (aaUsers != null)
            {

                aaUsers.refreshData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts aaProd = adminAddProducts1 as adminAddProducts;

            if (aaProd != null)
            {

                aaProd.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = false;
           
            adminCustomers1.Visible = true;

            adminCustomers aCust = adminCustomers1 as adminCustomers;

            if (aCust != null)
            {

                aCust.refreshData();
            }
        }

        private void addCategories_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = true;
            adminCustomers1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddCategories aaCat = adminAddCategories1 as adminAddCategories;

            if (aaCat != null)
            {

                aaCat.refreshData();
            }
        }
    }
}
