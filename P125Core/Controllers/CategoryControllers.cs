using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace CodeAkademyApp.Controllers
{
    public class CategoryControllers
    {
        public CategoryService categoryService { get; set; }

        public CategoryControllers()
        {
            categoryService = new CategoryService();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Drug Name");
            string name = Console.ReadLine();
        EnterName: Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Drug Category Name");
            string category = Console.ReadLine();
            int Category;
            bool isTrueCategory = int.TryParse(category, out Category);
            if (isTrueCategory)
            {
                Drug_Category _Category = new Drug_Category { Name = name, Category = Category };
                if (categoryService.Create(_Category) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{_Category.Name} created");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Something is wrong!");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Enter correct Category");
                goto EnterName;
            }
        }

        public void GetAllCategories()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "All categories:");
            foreach (Drug_Category _Category in categoryService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"{_Category.Id}-{_Category.Name}");
            }
        }
    }
}
