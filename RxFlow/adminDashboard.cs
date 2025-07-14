using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RxFlow
{
    public partial class adminDashboard: UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\rxflow1.mdf;Integrated Security=True;Connect Timeout=30";
        public adminDashboard()
        {
            InitializeComponent();
            displayTotalCashier();
            displayTotalOrders();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayTotalCashier();
            displayTotalOrders();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayCustomers();
            //  displayProducts();
        }




        public void displayCustomers()
        {
            adminCustomersData acData = new adminCustomersData();
            dataGridView1.DataSource = acData.customersDataList();
        }

        public void displayTotalCashier()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT count(id) as totalCashier FROM userss WHERE role = 'Cashier'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["totalCashier"] != DBNull.Value)
                        {
                            int totalCash = (int)reader["totalCashier"];

                            totalCashier.Text = Convert.ToString(totalCash);
                        }
                    }
                }
            }
        }


        public void displayTotalOrders()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT count(id) as totalOrders FROM transactionss";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["totalOrders"] != DBNull.Value)
                        {
                            int totalOrds = (int)reader["totalOrders"];

                            totalOrders.Text = Convert.ToString(totalOrds);
                        }
                    }
                }
            }

        }


        public void displayTodaysRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                DateTime today = DateTime.Today;
                string selectData = "SELECT SUM(total_price) as todaysRevenue FROM transactionss WHERE date_trans = '" + today + "'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["todaysRevenue"] != DBNull.Value)
                        {
                            decimal totalRevs = Convert.ToDecimal(reader["todaysRevenue"]);

                            todayRevenue.Text = "$" + totalRevs.ToString();
                        }
                    }
                }
            }

        }


        public void displayTotalRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                DateTime today = DateTime.Today;
                string selectData = "SELECT SUM(total_price) as totalRevenue FROM transactionss";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["totalRevenue"] != DBNull.Value)
                        {
                            decimal totalRevs = Convert.ToDecimal(reader["totalRevenue"]);

                            totalRevenue.Text = "$" + totalRevs.ToString();
                        }
                    }
                }
            }

        }



    }
}
