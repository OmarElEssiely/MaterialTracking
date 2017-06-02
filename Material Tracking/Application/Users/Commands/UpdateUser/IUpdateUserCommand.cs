using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Commands.UpdateUser
{
    public interface IUpdateUserCommand
    {
        void Execute(UpdateUserModel model);
    }
}
