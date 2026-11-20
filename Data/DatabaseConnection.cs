
using MySql.Data.MySqlClient;

namespace AcademicSupportStudyPlanner.Data
{
    public class DatabaseConnection
    {
        private static string connectionString =
            "Server=localhost;Database=AcademicPlannerDB;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

