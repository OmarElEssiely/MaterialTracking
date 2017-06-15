using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProjectFolder
    {
        public int ProjectFolderId { get; set; }
        public string Name { get; set; }
        public ICollection<ProjectSubFolder> ProjectSubFolders { get; set; }

    }
}
