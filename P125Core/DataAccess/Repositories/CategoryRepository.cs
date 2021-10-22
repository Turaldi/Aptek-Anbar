using DataAccess.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        public bool Create(Category entitiy)
        {
            try
            {
                DbContext.Drug_Categories.Add(entitiy);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Category entitiy)
        {
            try
            {
                DbContext.Drug_Categories.Remove(entitiy);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Category Get(Predicate<Category> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Drugs[0]
                    : DbContext.Drugs.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Category> GetAll(Predicate<Category> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Drugs
                    : DbContext.Drugs.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Category entitiy)
        {
            try
            {
                Category dbDrug = Get(s => s.Id == entitiy.Id);
                dbDrug.Category = entitiy.Category;
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
