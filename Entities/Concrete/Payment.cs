using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Payment : IEntity
    {
        public int PaymentID { get; set; }
        public int CustomerID { get; set; }
        public int BasketID { get; set; }
        public string Note { get; set; }
        public int ExpenseID { get; set; }
        public int CampaingID { get; set; }
        public int TotalPrice { get; set; }
    }
}
