using Blog.Entities.Concrete;
using FruitShop.Shared;
using FruitShop.Shared.Entities;
using System.Collections.Generic;

namespace FruitShop.Entities.Concrete.Identity
{
    public class Customer : EntityBase, IEntity
    {
        public int UserId { get; set; }

        #region relations

        public User User { get; set; }

        public ICollection<CustomerAdress> CustomerAdresses;


        #endregion
    }
}
