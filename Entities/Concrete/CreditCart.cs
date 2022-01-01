using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class CreditCart : IEntity
    {
        public int ID { get; set; }
        public int CartID { get; set; }
        public string CartNumber { get; set; }
        public string CartNameSurname { get; set; }
        public string CartMouth { get; set; }
        public string CartYear { get; set; }
        public string CartCvs { get; set; }
    }
}
