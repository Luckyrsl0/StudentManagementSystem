using System.Configuration;
using MySqlConnector;
using StudentManagementSystem.Model;

namespace StudentManagementSystem
{
    public class UserRepository
    {
        private readonly string connString;

        public UserRepository()
        {
            connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public User? GetUserByUsername(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT userId, username, passwordHash, role FROM users WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string uname = reader.GetString(1);
                            string dbPassHash = reader.GetString(2);
                            string userRole = reader.GetString(3);

                            return new SystemUser(id, uname, dbPassHash, userRole);
                        }
                    }
                }
            }

            return null;
        }
    }
}