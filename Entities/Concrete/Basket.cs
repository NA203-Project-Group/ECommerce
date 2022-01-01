using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Basket :IEntity
    {
        public int BasketID { get; set; }
        public int ProductID { get; set; }
        public DateTime BasketDate { get; set; }
        public int CustomerID { get; set; }
        public DateTime RequiredDate { get; set; }
        public int Quantity { get; set; }
        public decimal MinPrice { get; set; }

    }
}
