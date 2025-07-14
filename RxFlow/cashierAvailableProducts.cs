using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RxFlow
{
    class cashierAvailableProducts
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\rxflow1.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { set; get; } //0
        public string ProductID { set; get; }  //1
        public string productName { set; get; }  //2
        public string Category { set; get; }  //3
        public string Price { set; get; }  //4
        public string Stock { set; get; }  //5

        // public string Image { set; get; }  //6
        //public string Status { set; get; }  //7
        //public string Date { set; get; }  //8

        /* public List<adminAddProductsData> adminProductsList()
         {
             List<adminAddProductsData> listData = new List<adminAddProductsData>();

             using (SqlConnection connect = new SqlConnection(connectionString))
             {
                 connect.Open();

                 string selectData = "select * from products";

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
         }*/

        public List<adminAddProductsData> availableProductsList()
        {
            List<adminAddProductsData> listData = new List<adminAddProductsData>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "select id, prod_id, prod_name, category, price, stock from products where status = 'Active'";

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
        }
    }
}
