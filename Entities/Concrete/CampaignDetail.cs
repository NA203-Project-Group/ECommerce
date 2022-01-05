using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
   public class CampaignDetail : IEntity
    {
        public int CampaingDetailID { get; set; }
        public int CampaingID { get; set; }
        public int Discount { get; set; }
        public string CampaingImage { get; set; }

    }
}
