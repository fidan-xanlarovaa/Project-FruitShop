using FruitShop.Shared;
using FruitShop.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FruitShop.Entities.Concrete
{
    public class WebPageSections : EntityBase, IEntity 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ButtonTitle { get; set; }
    }
}
