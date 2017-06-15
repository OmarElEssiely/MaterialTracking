using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.ProjectFiles.Commands.UploadProjectFiles.Factory;

namespace MT.Application.ProjectFiles.Commands.UploadProjectFiles
{
    public class UploadProjectFileCommand:IUploadProjectFileCommand
    {
        private readonly IDatabaseService _database;
        private readonly IProjectFileFactory _factory;
        public UploadProjectFileCommand(IDatabaseService database, IProjectFileFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(UploadProjectFileModel projectFileModel)
        {
            var projectfile = _factory.Create(projectFileModel);
            _database.ProjectFiles.Add(projectfile);
            _database.Save();
        }
    }
}
