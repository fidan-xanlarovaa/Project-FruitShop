using FruitShop.Shared;
using FruitShop.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.Entities.Concrete.Identity
{
    public class Street : EntityBase, IEntity
    {
        public string StreetName { get; set; }

        #region relations

        public ICollection<CustomerAdress> CustomerAdresses;

        #endregion
    }
}

#region relations

#endregion