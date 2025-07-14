using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RxFlow
{
    class adminAddCategoriesData
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\rxflow1.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string Category { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<adminAddCategoriesData> listAddcategoriesData()
        {
            List<adminAddCategoriesData> listData = new List<adminAddCategoriesData>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = " SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        adminAddCategoriesData aacData = new adminAddCategoriesData();
                        aacData.ID = (int)reader["ID"];
                        aacData.Category = reader["category"].ToString();
                        aacData.Status = reader["status"].ToString();
                        aacData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");


                        listData.Add(aacData);

                    }
                }
            }

            return listData;

        }
    }
}
