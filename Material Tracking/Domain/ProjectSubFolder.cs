using System.Collections.Generic;

namespace Domain
{
    public class ProjectSubFolder
    {
        public int ProjectSubFolderId { get; set; }
        public string Name { get; set; }
        public ProjectFolder ProjectFolder { get; set; }
        public ICollection<ProjectFile> ProjectFiles { get; set; }
        public string Path { get; set; }

    }
}
