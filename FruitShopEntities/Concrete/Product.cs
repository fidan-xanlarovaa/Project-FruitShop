using FruitShop.Shared;
using FruitShop.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.Entities.Concrete.Identity
{
    public class Product : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }


        #region relations

        public Category Category { get; set; }

        #endregion
    }
}
