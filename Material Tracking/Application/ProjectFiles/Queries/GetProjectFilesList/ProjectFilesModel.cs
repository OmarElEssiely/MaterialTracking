using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectFiles.Queries.GetProjectFilesList
{
    public class ProjectFilesModel
    {
        public int ProjectFileId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
