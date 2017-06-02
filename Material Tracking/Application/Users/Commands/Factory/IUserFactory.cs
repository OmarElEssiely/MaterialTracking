using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Users.Commands.Factory
{
    public interface IUserFactory
    {
        User Create(
           string name,
           string email,
           string password,
           string userName
            );
    }
}
