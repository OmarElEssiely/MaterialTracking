using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRs.Commands.Delete
{
    public interface IDeleteIprCommand
    {
        void Execute(int iprId);
    }
}
