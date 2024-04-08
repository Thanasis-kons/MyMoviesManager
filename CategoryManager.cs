using System;
using System.Windows.Forms;

public class CategoryManager
{
    private CmbMovieCategories cmbMovieCategories;

    public CategoryManager(ComboBox comboBox)
    {
        this.CmbMovieCategories = cmbMovieCategories;
    }

    public void AddCategory(string category)
    {
        if (!CategoryExists(category))
        {
            cmbMovieCategories.Items.Add(category);
        }
    }

    public void RemoveCategory(string category)
    {
        if (CategoryExists(category))
        {
            cmbMovieCategories.Items.Remove(category);
        }
    }

    public bool CategoryExists(string category)
    {
        foreach (object item in cmbMovieCategories.Items)
        {
            if (item.ToString() == category)
            {
                return true;
            }
        }
        return false;
    }
}

