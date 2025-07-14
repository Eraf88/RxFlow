using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RxFlow
{
    class adminAddUsersData
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\rxflow1.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { set; get; }
        public string Username { get; set; }
        public string Password { set; get; }
        public string Role { get; set; }

        public string Status { get; set; }
        public string Date { get; set; }
        public List<adminAddUsersData>listAddUsersData()
        {
            List<adminAddUsersData> listData = new List<adminAddUsersData>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT * FROM userss ";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        adminAddUsersData aauData = new adminAddUsersData();
                        aauData.ID = (int)reader["ID"];
                        aauData.Username = reader["username"].ToString();
                        aauData.Password = reader["password"].ToString();
                        aauData.Role = reader["role"].ToString();
                        aauData.Status = reader["status"].ToString();

                        if (reader["date_register"] != null)
                        {

                            aauData.Date = ((DateTime)reader["date_register"]).ToString("MM-dd-yyyy");

                        }


                        listData.Add(aauData);

                    }

                }
            }
            return listData;
        }


    }
}
