using System;

namespace OnlineQuizSystem
{
    public class Admin : User
    {
        // Additional Property
        private DateTime loginDate;

        public DateTime LoginDate
        {
            get { return loginDate; }
            set { loginDate = value; }
        }

        // Default Constructor
        public Admin() : base() { }

        // Custom Constructor using Base
        public Admin(int id, string username, string password, string email, DateTime loginDate) 
            : base(id, username, password, email, "Admin")
        {
            this.loginDate = loginDate;
        }

        // Admin Specific Methods (Stubs for functionality handled in System class or extended logic)
        public void AddUser() { Console.WriteLine("User added."); }
        public void RemoveUser() { Console.WriteLine("User removed."); }
        
        public void AddQuestion(Quiz quiz, Question q) 
        {
            quiz.AddQuestion(q);
            Console.WriteLine("Question added to quiz.");
        }
        
        public void UpdateQuestion() { Console.WriteLine("Question updated."); }
        
        public void RemoveQuestion(Quiz quiz, Question q)
        {
            quiz.RemoveQuestion(q);
            Console.WriteLine("Question removed.");
        }

        public void ManageCategory() { Console.WriteLine("Category managed."); }
    }
}
