using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectFiles.Queries.GetProjectFilesList
{
    public interface IGetProjectFilesQuery
    {
        List<ProjectFilesModel> Execute(int projectId, int projectSubFolderId);
    }
}
