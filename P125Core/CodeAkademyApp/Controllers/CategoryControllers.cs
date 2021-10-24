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

        public void Delete()
        {
            GetAllCategories();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter categories Id:");
            string input = Console.ReadLine();
            int categoryId;
            bool isTrue = int.TryParse(input, out categoryId);
            if (isTrue)
            {
                if (categoryService.Delete(categoryId)!=null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Categories is deleted");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{categoryId} is not find");
                    return;  
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Please, select correct format");
            }
        }

        public void GetCategorieswithdose()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter category dose");
            string input = Console.ReadLine();
            int maxDose;
            bool isTrue = int.TryParse(input, out maxDose);
            if (isTrue)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Categories which dose is {maxDose}");
                foreach (var item in categoryService.GetAll(maxDose))
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, item.Name);
                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Please,select correct format");

        }
    }
}
