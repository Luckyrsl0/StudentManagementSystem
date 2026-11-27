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

        // Automatic mo-hash gamit ang BCrypt before i-update sa MySQL
        public bool UpdatePassword(string username, string newPlainPassword)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPlainPassword);

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE users SET passwordHash = @passwordHash WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@passwordHash", hashedPassword);
                    cmd.Parameters.AddWithValue("@username", username);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}