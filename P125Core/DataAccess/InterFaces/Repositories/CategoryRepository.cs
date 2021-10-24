using DataAccess.InterFaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class CategoryRepository : IRepository<Drug_Category>
    {
        public bool Create(Drug_Category entitiy)
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

        public bool Delete(Drug_Category entitiy)
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

        public Drug_Category Get(Predicate<Drug_Category> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Drug_Categories[0]
                    : DbContext.Drug_Categories.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Drug_Category> GetAll(Predicate<Drug_Category> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Drug_Categories
                    : DbContext.Drug_Categories.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Drug_Category entitiy)
        {
            try
            {
                Drug_Category Drug_Category = Get(s => s.Id == entitiy.Id);
                Drug_Category.Name = entitiy.Name;
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
