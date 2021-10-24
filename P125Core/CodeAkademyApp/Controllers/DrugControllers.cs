using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace CodeAkademyApp.Controllers
{
    public  class DrugControllers
    {
        private DrugService drugService { get; }
        public CategoryService categoryService { get; set; }
        public DrugControllers()
        {
            drugService = new DrugService();
            categoryService = new CategoryService();
        }

        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible category:");
            string categoryName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter drug name");
            string name = Console.ReadLine();
            Drug drug = new Drug { Name = name };
            Drug newDrug = drugService.Create(drug, categoryName);
            if (newDrug!=null)
            {
                Helper.ChangeTextColor(ConsoleColor.Green, $"New drug created -{newDrug.Name}");
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Couldn't find such as category-{categoryName}");

        }

        public void GetAllDrugwithCategory()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible category");
            string categoryName = Console.ReadLine();
            List<Drug> drugs = drugService.GetAll(categoryName);
            if (drugs!=null)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Category {categoryName}");
                foreach (var item in drugs)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{item.Id}-{item.Name}");

                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Couldn't find such as category-{categoryName}");
        }
    }
}
