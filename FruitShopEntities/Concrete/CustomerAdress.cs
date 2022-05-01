using FruitShop.Entities.Concrete.Identity;
using FruitShop.Shared;
using FruitShop.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.Entities.Concrete
{
    public class CustomerAdress : EntityBase, IEntity
    {
        public int CustomerId { get; set; }
        public int CityId { get; set; }
        public int StreetId { get; set; }
        public string FullAdress { get; set; }

        #region relations

        public City City { get; set; }
        public Customer Customer { get; set; }
        public Street Street { get; set; }

        #endregion
    }
}
