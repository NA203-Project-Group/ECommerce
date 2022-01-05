using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Favorite : IEntity
    {
        public int ID { get; set; }
        public int FavID { get; set; }
        public int ProductID { get; set; }
    }
}
