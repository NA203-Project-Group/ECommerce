using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Campaign : IEntity
    {
        public int CampaingID { get; set; }
        public string  CampaingName { get; set; }   

    }
}
