using System;
using System.Data.SqlClient;

namespace DBmigration
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Data Source=(local);Initial Catalog=Source;"
                    + "Integrated Security=true;Connect Timeout=1200;Enlist=false";

            string queryString = "select first, second from dbo.first where first=@f";

            int paramValue = 1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@f", paramValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            "\t{0}\t{1}",
                            reader[0],
                            reader[1]);
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
