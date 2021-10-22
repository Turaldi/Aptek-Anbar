using Entities.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Drug_Category:IEntity
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Category { get; set; }

    }
}
