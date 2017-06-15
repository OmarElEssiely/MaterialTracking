using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.ProjectSubFolders.Queries
{
    public class ProjectSubFoldersQuery:IProjectSubFoldersQuery
    {
        private readonly IDatabaseService _database;
        public ProjectSubFoldersQuery(IDatabaseService database)
        {
            _database = database;
        }
        public List<ProjectSubFoldersModel> Execute(int projectFolderId)
        {
            var projectSubFolders = _database.ProjectSubFolders.Where(
                    p => p.ProjectFolder.ProjectFolderId == projectFolderId)
                .Select(p => new ProjectSubFoldersModel()
                {
                    ProjectSubFolderId = p.ProjectSubFolderId,
                    Name = p.Name,
                    Path = p.Path
                });
           return projectSubFolders.ToList();
        }
    }
}
