using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public static class DbContext
    {
        public static List<Drug> Drugs { get;  }
        public static List<Drug_Category> Drug_Categories { get;  }
        static  DbContext()
        {
            Drugs = new List<Drug>();
            Drug_Categories = new List<Drug_Category>();
        }
    }
}
