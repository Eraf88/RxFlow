using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxFlow
{
    class adminAddProductsData
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\rxflow1.mdf;Integrated Security=True;Connect Timeout=30";


        public int ID { set; get; }
        public string ProductID { set; get; }
        public string productName { set; get; }
        public string Category { set; get; }
        public string Price { set; get; }
        public string Stock { set; get; }

        public string Image { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<adminAddProductsData> addProductsList()
        {
            List<adminAddProductsData> listData = new List<adminAddProductsData>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        adminAddProductsData aapData = new adminAddProductsData();

                        aapData.ID = (int)reader["id"];

                        aapData.ProductID = reader["prod_id"].ToString();

                        aapData.productName = reader["prod_name"].ToString();
                        aapData.Category = reader["category"].ToString();
                        aapData.Price = reader["price"].ToString();
                        aapData.Stock = reader["stock"].ToString();
                        aapData.Image = reader["image"].ToString();
                        aapData.Status = reader["status"].ToString();
                        aapData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(aapData);
                    }
                }
            }

            return listData;
        }


        /*    public List<adminAddProductsData> availableProductsList()
         {
             List<adminAddProductsData> listData = new List<adminAddProductsData>();

             using (SqlConnection connect = new SqlConnection(connectionString))
             {
                 connect.Open();

                 string selectData = "SELECT * FROM products WHERE status = 'Active'";

                 using (SqlCommand cmd = new SqlCommand(selectData, connect))
                 {
                     SqlDataReader reader = cmd.ExecuteReader();

                     while (reader.Read())
                     {
                         adminAddProductsData aapData = new adminAddProductsData();

                         aapData.ID = (int)reader["id"];

                         aapData.ProductID = reader["prod_id"].ToString();

                         aapData.productName = reader["prod_name"].ToString();
                         aapData.Category = reader["category"].ToString();
                         aapData.Price = reader["price"].ToString();
                         aapData.Stock = reader["stock"].ToString();
                         //aapData.Image = reader["image"].ToString();
                         //aapData.Status = reader["status"].ToString();
                         //aapData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                         listData.Add(aapData);
                     }
                 }
             }

             return listData;
          } */

    }
}
