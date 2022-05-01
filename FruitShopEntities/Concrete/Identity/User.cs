using Blog.Shared.Extentions;
using FruitShop.Entities.Concrete.Identity;
using FruitShop.Shared;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Blog.Entities.Concrete
{
    public class User : IdentityUser<int>, IEntity
    {
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // relations 

        public ICollection<Customer> Customers { get; set; }

        // methods
        public void SetPassword(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                this.PasswordHash = password.HashPassword();
            }
        }
    }
}


