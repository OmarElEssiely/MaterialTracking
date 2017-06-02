using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Projects.Commands.DeleteProject
{
    public interface IDeleteProjectCommand
    {
        void Execute(int projectId);
    }
}
