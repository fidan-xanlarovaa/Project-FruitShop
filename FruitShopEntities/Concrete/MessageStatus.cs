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
    public class MessageStatus : EntityBase, IEntity
    {
        public string Title { get; set; }

        #region relations

        public ICollection<Message> Messages { get; set; }


        #endregion

    }
}
