using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Admins.Commands.CreateAdmin
{
    public interface ICreateAdminCommand
    {
        void Execute(CreateAdminModel model);
    }
}
