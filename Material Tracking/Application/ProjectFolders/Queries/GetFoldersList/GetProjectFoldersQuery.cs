using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.ProjectFolders.Queries.GetFoldersList
{
    public class GetProjectFoldersQuery:IGetProjectFoldersQuery
    {
        private readonly IDatabaseService _database;

        public GetProjectFoldersQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<ProjectFolderModel> Execute()
        {
            var projectFolders = _database.ProjectFolders
                .Select(p => new ProjectFolderModel()
                {
                    ProjectFolderId = p.ProjectFolderId,
                    Name = p.Name
                });
            return projectFolders.ToList();
        }
    }
}
