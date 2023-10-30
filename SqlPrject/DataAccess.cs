using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using System.Data;



namespace SqlPrject
{
    public class DataAccess
    {


        //private static void CreateCommand(string quaryString, string connectoinString)
        //{
        //    using (SqlConnection connection=new SqlConnection(connectoinString)) 
        //    {
        //        SqlCommand command = new SqlCommand(quaryString, connection);
        //        command.Connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}

        public int InsertDataCategory(string connectionString)
        {

            string categoryName;


            Console.WriteLine("insert categoryName");
            categoryName = Console.ReadLine();
            string query = "INSERT INTO Category( Name)" +
                            "VALUES ( @Name)";

            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@Name", SqlDbType.NChar, 20).Value = categoryName;

                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cn.Close();

                return rowsAffected;

            }
        }

        internal void readDataCategory(string connectionString)
        {
            string queryString = "select * from Category";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}",
                            reader[0], reader[1]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
        public int InsertDate(string connectionString)
        {

            string categoryId, Name, Price, Des, image;
            Console.WriteLine("insert categoryId");
            categoryId = Console.ReadLine();

            Console.WriteLine("insert Name");
            Name = Console.ReadLine();

            Console.WriteLine("insert Price");
            Price = Console.ReadLine();

            Console.WriteLine("insert Des");
            Des = Console.ReadLine();

            Console.WriteLine("insert image");
            image = Console.ReadLine();


            string query = "INSERT INTO Product(CategoryId, Name, Price, Des, Image)" +
                            "VALUES (@CategoryId, @Name, @Price, @Des, @Image )";

            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = categoryId;
                cmd.Parameters.Add("@Name", SqlDbType.NChar, 20).Value = Name;
                cmd.Parameters.Add("@Price", SqlDbType.Float).Value = Price;
                cmd.Parameters.Add("@Des", SqlDbType.NChar, 30).Value = Des;
                cmd.Parameters.Add("@Image", SqlDbType.NChar, 10).Value = image;

                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cn.Close();

                return rowsAffected;
            }

        }


        internal void readData(string connectionString)
        {
            string queryString = "select * from Product";
            using(SqlConnection connection=
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try 
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                            reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }


    }
}
