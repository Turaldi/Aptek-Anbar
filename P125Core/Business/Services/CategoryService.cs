using Business.InterFaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class CategoryService : ICategory
    {
        public CategoryRepository categoryRepository { get; set; }
        private static int count  { get; set; }
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }
        public Drug_Category Create(Drug_Category drug_Category)
        {
            try
            {
                drug_Category.Id = count;
                Drug_Category isExist = categoryRepository.Get(g => g.Name.ToLower() == drug_Category.Name.ToLower());
                if (isExist != null)
                    return null;
                categoryRepository.Create(drug_Category);
                count++;
                return drug_Category;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Drug_Category Delete(int Id)
        {
            Drug_Category dbCategory = categoryRepository.Get(g => g.Id == Id);
            if (dbCategory!=null)
            {
                categoryRepository.Delete(dbCategory);
                return dbCategory;
            }
            else
            {
                return null;
            }
        }

        public Drug_Category Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Drug_Category Get(string name)
        {
            return categoryRepository.Get(g => g.Name.ToLower() == name.ToLower());
        }

        public List<Drug_Category> GetAll()
        {
            return categoryRepository.GetAll(); 
        }

        public List<Drug_Category> GetAll(int Category)
        {
            return categoryRepository.GetAll(g => g.Category == Category);
        }

        public Drug_Category Update(int Id, Drug_Category drug_Category)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }
    }
}
