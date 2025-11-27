using System;

namespace OnlineQuizSystem
{
    public class Category
    {
        // Private fields
        private int categoryID;
        private string categoryName;
        private string categoryDescription;

        // Public Properties
        public int CategoryID
        {
            get { return categoryID; }
            // Read-only logic is handled by setting it only in constructor
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public string CategoryDescription
        {
            get { return categoryDescription; }
            set { categoryDescription = value; }
        }

        // Default Constructor
        public Category() { }

        // Custom Constructor
        public Category(int id, string name, string desc)
        {
            this.categoryID = id;
            this.categoryName = name;
            this.categoryDescription = desc;
        }

        // Method to return info string
        public string GetCategoryInfo()
        {
            return $"{CategoryID}: {CategoryName} - {CategoryDescription}";
        }

        // Method to update details
        public void UpdateCategory(string name, string desc)
        {
            this.categoryName = name;
            this.categoryDescription = desc;
        }
    }
}
