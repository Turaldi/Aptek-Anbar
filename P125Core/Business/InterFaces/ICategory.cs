using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.InterFaces
{
    public interface ICategory
    {
        Drug_Category Create(Drug_Category drug_Category);
        Drug_Category Update(int Id, Drug_Category drug_Category);
        Drug_Category Delete(int Id);
        Drug_Category Get(int Id);
        Drug_Category Get(string name);
        List<Drug_Category> GetAll();
        List<Drug_Category> GetAll(int Category);
    }
}
