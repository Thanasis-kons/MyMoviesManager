using MyMoviesManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyMoviesManager
{
    public class CategoryManager
    {
        private static CategoryManager instance;
        public List<Movies> Categories { get; private set; }

        private CategoryManager()
        {
            Categories = new List<Movies>();
        }

        public static CategoryManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CategoryManager();
            }
            return instance;
        }

        public void AddCategory(Movies category)
        {
            if (!Categories.Any(c => c.Category == category.Category))
            {
                Categories.Add(category);
            }
        }

        public void UpdateCategoryName(Movies category, string newName)
        {
            if (category != null)
            {
                category.Category = newName;
            }
        }

        public void DeleteCategory(Movies category)
        {
            Categories.Remove(category);
        }
    }
}
