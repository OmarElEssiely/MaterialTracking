using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.Admins.Queries.GetAdminByPassword
{
    public interface IGetAdminByPasswordQuery
    {
        AdminModel Execute(string password);
    }
}
