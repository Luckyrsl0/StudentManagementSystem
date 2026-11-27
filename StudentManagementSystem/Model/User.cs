using System;
using BCrypt.Net;

namespace StudentManagementSystem.Model
{
    public abstract class User
    {
        private int userId;
        private string username;
        private string passwordHash;
        protected string role;

        public int UserId => userId;
        public string Username => username;
        public string Role => role;

        protected User(int userId, string username, string passwordHash, string role)
        {
            this.userId = userId;
            this.username = username;
            this.passwordHash = passwordHash;
            this.role = role;
        }

        public bool Login(string pw)
        {
            if (string.IsNullOrEmpty(this.passwordHash))
                return false;

            try
            {
                return BCrypt.Net.BCrypt.Verify(pw, this.passwordHash);
            }
            catch (SaltParseException)
            {
                // Dili mo-crash kung plain text pa ang naa sa database
                return false;
            }
        }

        public bool ChangePassword(string oldPw, string newPw)
        {
            if (!Login(oldPw))
                return false;

            this.passwordHash = BCrypt.Net.BCrypt.HashPassword(newPw);
            return true;
        }

        public abstract string GetPermissions();
    }

    public class SystemUser : User
    {
        public SystemUser(int userId, string username, string passwordHash, string role)
            : base(userId, username, passwordHash, role) { }

        public override string GetPermissions()
        {
            return role == "Admin" ? "Full Access" : "Standard Access";
        }
    }
}