using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectFiles.Commands.UploadProjectFiles
{
    public class UploadProjectFileModel
    {
        public int ProjectId { get; set; }
        public int ProjectSubFolderId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
