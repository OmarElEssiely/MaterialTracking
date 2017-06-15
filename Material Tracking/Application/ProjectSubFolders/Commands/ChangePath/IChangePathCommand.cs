using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectSubFolders.Commands.ChangePath
{
    public interface IChangePathCommand
    {
        void Execute(ChangePathModel pathModel);
    }
}
