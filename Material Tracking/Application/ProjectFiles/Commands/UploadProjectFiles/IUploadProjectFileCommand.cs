using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectFiles.Commands.UploadProjectFiles
{
    public interface IUploadProjectFileCommand
    {
        void Execute(UploadProjectFileModel projectFileModel);
    }
}
