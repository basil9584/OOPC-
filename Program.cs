using System;

namespace OnlineQuizSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Title for the Console Window
            Console.Title = "Ulster University Online Quiz System";

            // Instantiate the main controller
            QuizSystem system = new QuizSystem();

            // Load required sample data (Admin, Students, Quizzes, Questions)
            system.LoadSampleData();

            // Start the application
            system.ShowMainMenu();
        }
    }
}
