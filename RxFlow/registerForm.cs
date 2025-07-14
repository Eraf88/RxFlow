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
    public partial class registerForm: Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\rxflow1.mdf;Integrated Security=True;Connect Timeout=30";
        public registerForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_confrimPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();

            this.Hide();
        }

        private void register_Btn_Click(object sender, EventArgs e)
        {
            if(register_username.Text == "" || register_password.Text == "" || register_confrimPassword.Text =="")
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkUserQuery = "SELECT * FROM userss WHERE username=@usern";

                    using(SqlCommand checkUsern = new SqlCommand(checkUserQuery,connection))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();

                        adapter.Fill(table);
                        if(table.Rows.Count != 0)
                        {
                            string tempUsern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                            MessageBox.Show(tempUsern + " is existing aready", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        } else if(register_password.Text.Length < 8)
                        {
                            MessageBox.Show( "Invalid Password,at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else if(register_password.Text != register_confrimPassword.Text)
                        {
                            MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else
                        {
                            string insertData = "INSERT INTO userss (username,password,role,status,date_register)" +
                                          "VALUES(@usern,@pass,@role,@status,@date)";

                            using(SqlCommand cmd = new SqlCommand(insertData,connection))
                            {
                                cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Cashier");
                                cmd.Parameters.AddWithValue("@status", "Approval");

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form2 loginForm = new Form2();
                                loginForm.Show();

                                this.Hide();
                            }

                        }

                    }
                }
            }
        }
    }
}
