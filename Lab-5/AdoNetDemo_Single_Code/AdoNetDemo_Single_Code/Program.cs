using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    class Program
    {
        // Connection string to your SQL Server database
        static string connectionString = "Server=localhost;Database=StudentDB;Integrated Security=true;";

        static void Main(string[] args)
        {
            Console.WriteLine("Connected Architecture Demo:");
            ConnectedArchitectureDemo();

            Console.WriteLine("\nDisconnected Architecture Demo:");
            DisconnectedArchitectureDemo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void ConnectedArchitectureDemo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Students";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"StudentId: {reader["StudentId"]}, StudentName: {reader["StudentName"]}, Course: {reader["Course"]}, Semester: {reader["Semester"]}");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred in the connected architecture demo: " + ex.Message);
            }
        }

        static void DisconnectedArchitectureDemo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Students";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Students");

                    DataTable studentsTable = dataSet.Tables["Students"];

                    foreach (DataRow row in studentsTable.Rows)
                    {
                        Console.WriteLine($"StudentId: {row["StudentId"]}, StudentName: {row["StudentName"]}, Course: {row["Course"]}, Semester: {row["Semester"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred in the disconnected architecture demo: " + ex.Message);
            }
        }
    }
}
