using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Comment : IEntity
    {
        public int CommentID { get; set; }
        public int Star { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentDescription { get; set; }

    }
}
