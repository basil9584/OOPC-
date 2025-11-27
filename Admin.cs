using System;

namespace OnlineQuizSystem
{
    public class Admin : User
    {
        private DateTime loginDate;

        public DateTime LoginDate
        {
            get { return loginDate; }
            set { loginDate = value; }
        }

        public Admin() : base() { }

        public Admin(int id, string username, string password, string email, DateTime loginDate) 
            : base(id, username, password, email, "Admin")
        {
            this.loginDate = loginDate;
        }

        public void AddUser() { Console.WriteLine("User added."); }
        public void RemoveUser() { Console.WriteLine("User removed."); }
        
        // This method must exist to be called from QuizSystem
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
