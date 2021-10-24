using DataAccess.InterFaces;
using Entities.InterFace;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class DrugRepository : IRepository<Drug>

    {
        public bool Create(Drug entitiy)
        {
            try
            {
                DbContext.Drugs.Add(entitiy);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Drug entitiy)
        {
            try
            {
                DbContext.Drugs.Remove(entitiy);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Drug Get(Predicate<Drug> filter = null)
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

        public List<Drug> GetAll(Predicate<Drug> filter = null)
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

        public bool Update(Drug entitiy)
        {
            try
            {
                Drug dbDrug = Get(s => s.Id == entitiy.Id);
                dbDrug = entitiy;
                return true;
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
