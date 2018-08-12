using p01.InitialSetup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace p07.PrintAllMinionNames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                List<string> minionNames = GetMinionNames(connection);

                if (minionNames.Count() > 0)
                {
                    PrintMinionNamesBySpecificOrder(minionNames);
                }
                else
                {
                    Console.WriteLine("You have no minions :(");
                }


                connection.Close();
            }
        }

        private static void PrintMinionNamesBySpecificOrder(List<string> minionNames)
        {
            int limit = (int)(minionNames.Count() / 2.00);

            int last = minionNames.Count() - 1;

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(minionNames[i]);
                Console.WriteLine(minionNames[last - i]);
            }
            if (minionNames.Count() % 2 != 0)
            {
                Console.WriteLine(minionNames[limit]);
            }
        }

        private static List<string> GetMinionNames(SqlConnection connection)
        {
            List<string> names = new List<string>();

            string namesSql = "SELECT Name FROM Minions";

            using (SqlCommand command = new SqlCommand(namesSql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        names.Add((string)reader[0]);
                    }
                }
            }

            return names;
        }
    }
}
