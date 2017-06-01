using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Admins.Commands.UpdateAdmin
{
    public interface IUpdateAdminCommand
    {
        void Execute(UpdateAdminModel model);
    }
}
