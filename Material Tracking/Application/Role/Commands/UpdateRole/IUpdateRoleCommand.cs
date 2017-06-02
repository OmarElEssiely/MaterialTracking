using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Role.Commands.UpdateRole
{
    public interface IUpdateRoleCommand
    {
        void Execute(UpdateRoleModel model);
    }
}
