using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.ProjectFiles.Queries.GetProjectFilesList
{
    public class GetProjectFilesQuery:IGetProjectFilesQuery
    {
        private readonly IDatabaseService _database;

        public GetProjectFilesQuery(IDatabaseService database)
        {
            _database = database;
        }
        public List<ProjectFilesModel> Execute(int projectId, int projectSubFolderId)
        {
            var projectFiles = _database.ProjectFiles
                .Where(
                    p => p.Project.ProjectId == projectId & p.ProjectSubFolder.ProjectSubFolderId == projectSubFolderId)
                .Select(p => new ProjectFilesModel()
                {
                    ProjectFileId = p.ProjectFileId,
                    Name = p.Name,
                    Path = p.Path
                });
            return projectFiles.ToList();
        }
    }
}
