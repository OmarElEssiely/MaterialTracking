using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain;

namespace MT.Application.ProjectFiles.Commands.UploadProjectFiles.Factory
{
    public class ProjectFileFactory:IProjectFileFactory
    {
        private readonly IDatabaseService _database;

        public ProjectFileFactory(IDatabaseService database)
        {
            _database = database;
        }
        public ProjectFile Create(UploadProjectFileModel projectFileModel)
        {
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == projectFileModel.ProjectId);
            var projectSubFolder =
                _database.ProjectSubFolders.FirstOrDefault(
                    p => p.ProjectSubFolderId == projectFileModel.ProjectSubFolderId);

            ProjectFile projectFile= new ProjectFile()
            {
                ProjectSubFolder = projectSubFolder,
                Project = project,
                Name = projectFileModel.Name,
                Path = projectFileModel.Path
            };
            return projectFile;
        }
    }
}
