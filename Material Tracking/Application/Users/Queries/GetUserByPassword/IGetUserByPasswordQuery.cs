using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.Users.Queries.GetUserByPassword
{
    public interface IGetUserByPasswordQuery
    {
        UserModel Execute(string password);
    }
}
