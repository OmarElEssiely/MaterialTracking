using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectSubFolders.Queries
{
    public interface IProjectSubFoldersQuery
    {
        List<ProjectSubFoldersModel> Execute(int projectFolderId);
    }
}
