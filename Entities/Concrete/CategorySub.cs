using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class CategorySub : IEntity
    {
        public int CategorySubID { get; set; }
        public int CategoryID { get; set; }
        public string CategorySubName { get; set; }

    }
}
