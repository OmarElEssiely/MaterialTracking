using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectSubFolders.Commands.ChangePath
{
    public class ChangePathModel
    {
        public int ProjectSubFolderId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
