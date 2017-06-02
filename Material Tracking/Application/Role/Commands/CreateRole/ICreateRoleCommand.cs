using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Role.Commands.CreateRole
{
    public interface ICreateRoleCommand
    {
        void Execute(CreateRoleModel model);

    }
}
