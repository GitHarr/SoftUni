using p01.InitialSetup;
using System;
using System.Data.SqlClient;

namespace p02.VillainNames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string vilainsInfo = "SELECT v.[Name], COUNT(mv.MinionId) AS [MinionsCount] FROM Villains AS v " +
                    "JOIN MinionsVillains AS mv ON mv.VillainId = v.Id " +
                    "GROUP BY v.[Name] HAVING COUNT(mv.MinionId) >= 3 ORDER BY [MinionsCount] DESC";

                using (SqlCommand command = new SqlCommand(vilainsInfo, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[0]} -> {reader[1]}");
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
