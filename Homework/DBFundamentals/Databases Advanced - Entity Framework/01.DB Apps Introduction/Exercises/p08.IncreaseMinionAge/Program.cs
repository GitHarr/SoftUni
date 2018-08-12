using p01.InitialSetup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace p08.IncreaseMinionAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> minionIds = Console.ReadLine().Split().Select(int.Parse).ToList();

            SqlConnection connection = new SqlConnection(Configuration.ConnectionString);
            
            connection.Open();

            using (connection)
            {
                string updateQuery = $@"UPDATE Minions
                                       SET Age = Age + 1, Name = UPPER(LEFT(Name,1)) + SUBSTRING(Name,2,LEN(Name))
                                       WHERE Id IN ({string.Join(", ", minionIds)})";

                SqlCommand updateCmd = new SqlCommand(updateQuery, connection);

                updateCmd.ExecuteNonQuery();
                
                string resultQuery = $@"SELECT m.Name, m.Age FROM Minions AS m";

                SqlCommand getResultsCmd = new SqlCommand(resultQuery, connection);

                SqlDataReader reader = getResultsCmd.ExecuteReader();
                
                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]} | {reader[1]}");
                }
            }
        }
    }
}
