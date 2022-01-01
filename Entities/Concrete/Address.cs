using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public int ID { get; set; }
        public int AddressID { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public string BuildingNumber { get; set; }

    }
}
