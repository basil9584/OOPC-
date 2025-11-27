using System;

namespace OnlineQuizSystem
{
    public class Student : User
    {
        // Additional Property
        private string status; // "active" or "inactive"

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Default Constructor
        public Student() : base() { }

        // Custom Constructor
        public Student(int id, string username, string password, string email, string status)
            : base(id, username, password, email, "Student")
        {
            this.status = status;
        }

        // Methods
        public void PlayQuiz()
        {
            // Logic handled in main controller, but method exists for class diagram compliance
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
