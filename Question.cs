using System;
using System.Collections.Generic;

namespace OnlineQuizSystem
{
    public class Question
    {
        // Private fields
        private int questionID;
        private string questionText;
        private List<string> questionOptions;
        private string correctAnswer;
        private string difficultyLevel;

        // Public Properties
        public int QuestionID { get { return questionID; } }

        public string QuestionText
        {
            get { return questionText; }
            set { questionText = value; }
        }

        public List<string> QuestionOptions
        {
            get { return questionOptions; }
            set { questionOptions = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        public string DifficultyLevel
        {
            get { return difficultyLevel; }
            set { difficultyLevel = value; }
        }

        // Default Constructor
        public Question() { }

        // Custom Constructor
        public Question(int id, string text, List<string> options, string correctAns, string difficulty)
        {
            this.questionID = id;
            this.questionText = text;
            this.questionOptions = options;
            this.correctAnswer = correctAns;
            this.difficultyLevel = difficulty;
        }

        // Method to display text
        public string GetQuestionText()
        {
            return questionText;
        }

        // Method to validate answer
        public bool ValidateAnswer(string answer)
        {
            // Case-insensitive comparison
            return string.Equals(answer.Trim(), correctAnswer.Trim(), StringComparison.OrdinalIgnoreCase);
        }
    }
}
