using System;
using System.Collections.Generic;

namespace OnlineQuizSystem
{
    public class Quiz
    {
        // Private fields
        private int quizID;
        private string quizTitle;
        private string quizDescription;
        private Category quizCategory;
        private List<Question> questions;
        private DateTime quizDate;

        // Public Properties
        public int QuizID { get { return quizID; } }
        
        public string QuizTitle
        {
            get { return quizTitle; }
            set { quizTitle = value; }
        }

        public string QuizDescription
        {
            get { return quizDescription; }
            set { quizDescription = value; }
        }

        public Category QuizCategory
        {
            get { return quizCategory; }
            set { quizCategory = value; }
        }

        public List<Question> Questions
        {
            get { return questions; }
            set { questions = value; }
        }

        public DateTime QuizDate
        {
            get { return quizDate; }
            set { quizDate = value; }
        }

        // Default Constructor
        public Quiz() 
        {
            questions = new List<Question>();
        }

        // Custom Constructor
        public Quiz(int id, string title, string desc, Category category, DateTime date)
        {
            this.quizID = id;
            this.quizTitle = title;
            this.quizDescription = desc;
            this.quizCategory = category;
            this.quizDate = date;
            this.questions = new List<Question>();
        }

        // Methods
        public void AddQuestion(Question q)
        {
            questions.Add(q);
        }

        public void RemoveQuestion(Question q)
        {
            questions.Remove(q);
        }

        public List<Question> GetQuestions()
        {
            return questions;
        }
    }
}
