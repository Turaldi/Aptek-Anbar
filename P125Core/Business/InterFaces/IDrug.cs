using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.InterFaces
{
    public  interface IDrug
    {
        Drug Create(Drug drug, string categoryName);
        Drug Delete(int Id);
        Drug Update(Drug drug, string categoryName);
        List<Drug> Get(string name);
        List<Drug> GetAll(string categoryName);
        List<Drug> GetAll();

    }
}
