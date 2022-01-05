using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderID { get; set; }
        public int PaymentID { get; set; }
        public DateTime OrderDate { get; set; } 

    }
}
