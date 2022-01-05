using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class AddressDetail : IEntity
    {
        public int AddressID { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public string BuildingNumber { get; set; }
        public string OpenAddress { get; set; }

    }
}
