using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Runtime.InteropServices;

namespace Application.Admins.Commands.Factory
{
    public interface IAdminFactory
    {
        Admin Create(string name, string password, string mail, [Optional] int adminid);
    }
}
