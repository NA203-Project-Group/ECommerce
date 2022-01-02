using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class ProductDetail :IEntity
    {
        public int ProductDetailID { get; set; }
        public int ProductID { get; set; }
        public DateTime ProductAddedTime { get; set; }
        public int StockAmount { get; set; }
        public string ProductDescription { get; set; }
        public int CommentID { get; set; }

    }
}
