using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace MT.Application.ProjectFiles.Commands.UploadProjectFiles.Factory
{
    public interface IProjectFileFactory
    {
        ProjectFile Create(UploadProjectFileModel projectFileModel);
    }
}
