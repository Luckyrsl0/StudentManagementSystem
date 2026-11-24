using System;
using System.Collections.Generic;
using System.Text;

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
            return this.passwordHash == pw;
        }

        public bool ChangePassword(string oldPw, string newPw)
        {
            if (this.passwordHash != oldPw) return false;
            this.passwordHash = newPw;
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
