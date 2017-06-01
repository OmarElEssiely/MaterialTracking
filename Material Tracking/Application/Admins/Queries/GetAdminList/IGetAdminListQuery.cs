using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Admins.Queries.GetAdminList
{
    public interface IGetAdminListQuery
    {
        List<AdminModel> Execute();
    }
}
