using Entities.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.InterFaces
{
   public  interface IRepository<T> where T:IEntity
    {
        bool Create(T entitiy);
        bool Update(T entitiy);
        bool Delete(T entitiy);
        List<T> GetAll(Predicate<T> filter=null);
        T Get(Predicate<T> filter=null);
    }
}
