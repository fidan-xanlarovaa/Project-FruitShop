using FruitShop.Shared;
using FruitShop.Shared.Entities;
using System.Collections.Generic;

namespace FruitShop.Entities.Concrete.Identity
{
    public class Category :EntityBase,IEntity
    {
        public string Title { get; set; }

        #region relations

        public ICollection<Product> Products { get; set; }

        #endregion
    }
}
