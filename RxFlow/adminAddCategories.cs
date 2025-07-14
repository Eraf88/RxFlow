using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RxFlow
{
    public partial class adminAddCategories: UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\rxflow1.mdf;Integrated Security=True;Connect Timeout=30";
        public adminAddCategories()
        {
            InitializeComponent();
            displayCategoriesData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategoriesData();
        }

        public void displayCategoriesData()
        {
           adminAddCategoriesData aacData = new adminAddCategoriesData();
            List<adminAddCategoriesData> listData = aacData.listAddcategoriesData();

            dataGridView1.DataSource = listData;
        }
        private void addcategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addcategories_category.Text == "" || addcategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string insertCategory = "INSERT INTO categories (category, status, date_insert) VALUES(@category, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertCategory, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", addcategories_category.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", addcategories_status.SelectedItem.ToString());

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Category Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            displayCategoriesData();
        }
        public void clearFields()
        {
            addcategories_category.Text = "";
            addcategories_status.SelectedIndex = -1;
        }

        private void addcategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addcategories_updateBtn_Click(object sender, EventArgs e)
        {
            if (addcategories_category.Text == "" || addcategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update ID:" + getID + "?", "comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        string updateData = "UPDATE categories SET category = @category, status = @status WHERE id = @id ";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@category", addcategories_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", addcategories_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Category Updated Successfully!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        }


                    }

                }

            }
            displayCategoriesData();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                addcategories_category.Text = row.Cells[1].Value.ToString();
                addcategories_status.Text = row.Cells[2].Value.ToString();
            }
        }

        private void addcategories_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addcategories_category.Text == "" || addcategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID:" + getID + "?", "comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        string updateData = "DELETE FROM categories WHERE id = @id ";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Category Deleted Successfully!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        }


                    }

                }

            }
            displayCategoriesData();
        }
    }
}
