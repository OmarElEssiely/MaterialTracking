using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Users.Commands.Factory
{
    public class UserFactory:IUserFactory
    {

        public User Create(string name, string email, string password, string userName)
        {
            
            var user = new User()
            {
                Email = email,
                Name = name,
                Password = password,
                UserName = userName, 
            };
            return user;
        }
    }
}
