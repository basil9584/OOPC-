using System;

namespace OnlineQuizSystem
{
    public class Student : User
    {
        private string status; // "active" or "inactive"

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Student() : base() { }

        public Student(int id, string username, string password, string email, string status)
            : base(id, username, password, email, "Student")
        {
            this.status = status;
        }

        public void PlayQuiz()
        {
            Console.WriteLine("Student is starting a quiz...");
        }

        public void ViewResult(int score, int total)
        {
            Console.WriteLine($"You scored {score} out of {total}.");
        }

        public void SelectCategory()
        {
            Console.WriteLine("Category selected.");
        }
    }
}
