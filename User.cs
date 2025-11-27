using System;

namespace OnlineQuizSystem
{
    // Abstract class as per requirements (cannot be instantiated directly)
    public abstract class User
    {
        // Private fields
        private int iD;
        private string username;
        private string password;
        private string email;
        private string role;

        // Public Properties
        public int ID { get { return iD; } } // Read-only

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        // Default Constructor
        public User() { }

        // Custom Constructor
        public User(int id, string username, string password, string email, string role)
        {
            this.iD = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        // Virtual methods to allow overriding if necessary, or standard inheritance
        public void UpdateProfile(string newEmail, string newPassword)
        {
            this.email = newEmail;
            this.password = newPassword;
            Console.WriteLine("Profile updated successfully.");
        }

        public void Logout()
        {
            Console.WriteLine($"{Username} has logged out.");
        }
    }
}
