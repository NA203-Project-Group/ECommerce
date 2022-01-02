using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class BasketDetail : IEntity
    {
        public int BasketDetailID { get; set; }
        public int  BasketID { get; set; }
        public int ProductID { get; set; }
        public DateTime InstalmentDate { get; set; }
        public int CustomerID { get; set; }
    }
}
