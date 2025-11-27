using System;

namespace OnlineQuizSystem
{
    public class Category
    {
        private int categoryID;
        private string categoryName;
        private string categoryDescription;

        public int CategoryID
        {
            get { return categoryID; }
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

        public Category() { }

        public Category(int id, string name, string desc)
        {
            this.categoryID = id;
            this.categoryName = name;
            this.categoryDescription = desc;
        }

        public string GetCategoryInfo()
        {
            return $"{CategoryID}: {CategoryName} - {CategoryDescription}";
        }

        public void UpdateCategory(string name, string desc)
        {
            this.categoryName = name;
            this.categoryDescription = desc;
        }
    }
}
