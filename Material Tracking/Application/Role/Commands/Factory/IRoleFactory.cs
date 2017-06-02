using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Role.Commands.Factory
{
    public interface IRoleFactory
    {
        Domain.Role Create(string name);
    }
}
