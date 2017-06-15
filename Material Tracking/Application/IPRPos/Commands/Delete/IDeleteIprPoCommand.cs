using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRPos.Commands.Delete
{
    public interface IDeleteIprPoCommand
    {
        void Execute(int iprPoId);
    }
}
