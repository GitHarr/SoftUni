using p01.InitialSetup;
using System;
using System.Data.SqlClient;

namespace p03.MinionNames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int villainId = int.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string villainName = GetVillianName(villainId, connection);

                if (villainName == null)
                {
                    Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                }

                else
                {
                    Console.WriteLine($"Villain: {villainName}");
                    PrintNames(villainId, connection);
                }

                connection.Close();
            }
        }

        private static void PrintNames(int villainId, SqlConnection connection)
        {
            string minionsSql = "SELECT Name, Age FROM Minions AS m " +
                    "JOIN MinionsVillains AS mv ON mv.MinionId = m.Id WHERE mv.VillainId = @Id";

            using (SqlCommand command = new SqlCommand(minionsSql, connection)) 
            {
                command.Parameters.AddWithValue("Id", villainId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("(no minions)");
                    }

                    else
                    {
                        int row = 1;

                        while (reader.Read())
                        {
                            Console.WriteLine($"{row++}. {reader[0]} {reader[1]}");
                        }
                    }
                }
            }
        }

        private static string GetVillianName(int villainId, SqlConnection connection)
        {
            string name = "SELECT Name FROM Villains WHERE Id = @id";

            using (SqlCommand command = new SqlCommand(name, connection))
            {
                command.Parameters.AddWithValue("@id", villainId);

                return (string)command.ExecuteScalar();
            }
        }
    }
}
