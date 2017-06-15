using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectFolders.Queries.GetFoldersList
{
    public interface IGetProjectFoldersQuery
    {
        List<ProjectFolderModel> Execute();
    }
}
