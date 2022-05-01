using FruitShop.Shared;
using FruitShop.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FruitShop.Entities.Concrete.Identity
{
    public class Employee : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmployeeComment { get; set; }
        public string EmployeeJob { get; set; }

    }
}
