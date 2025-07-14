using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RxFlow
{
    public partial class Form2: Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\rxflow1.mdf;Integrated Security=True;Connect Timeout=30";

        public Form2()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            registerForm regForm = new registerForm();
            regForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectData = "SELECT * FROM userss WHERE username=@usern AND password = @pass AND status = 'Active'";

                    using(SqlCommand  cmd = new SqlCommand(selectData,connection))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());


                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Sucessfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataRow row = table.Rows[0];
                            string role = row["role"].ToString();
                            if(role=="Admin")
                            {
                                MainForm mForm = new MainForm();
                                mForm.Show();
                            }
                            else if(role == "Cashier")
                            {
                                cashierMainForm cmForm = new cashierMainForm();
                                cmForm.Show();
                                    
                            }

                           
                            this.Hide();
                        } else
                        {
                            MessageBox.Show("Incorrect Username/Password or You need Admin's approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
