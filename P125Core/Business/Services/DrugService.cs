using Business.InterFaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic; 
using System.Text;

namespace Business.Services
{
    public class DrugService : IDrug
    {
        private DrugRepository drugRepository { get;  }
        public CategoryService categoryService { get; }
        private static int count;
        public DrugService()
        {
            drugRepository = new DrugRepository();
            categoryService = new CategoryService();
        }
        public Drug Create(Drug drug, string categoryName)
        {
            Drug_Category dbCategory = categoryService.Get(categoryName);
            if (dbCategory !=null)
            {
                drug.Drug_Category = dbCategory;
                drug.Id = count;
                drugRepository.Create(drug);
                count++;
                return drug;
            }
            else
            {
                return null;
            }
        }

        public Drug Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Drug> Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetAll(string categoryName)
        {
            Drug_Category dbCategory = categoryService.Get(categoryName);
            if (dbCategory!=null)
            {
                return drugRepository.GetAll(s => s.Drug_Category.Name == dbCategory.Name);

            }
            else
            {
                return null;
            }
        }

        public List<Drug> GetAll()
        {
            throw new NotImplementedException();
        }

        public Drug Update(Drug drug, string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
