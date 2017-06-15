using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.ProjectSubFolders.Commands.ChangePath
{
    public class ChangePathCommand:IChangePathCommand
    {
        private readonly IDatabaseService _database;
        public ChangePathCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(ChangePathModel pathModel)
        {
            var subfolder =
                _database.ProjectSubFolders.FirstOrDefault(p => p.ProjectSubFolderId == pathModel.ProjectSubFolderId);
            if (subfolder!=null)
            {
                subfolder.Name = pathModel.Name;
                subfolder.Path = pathModel.Path;
                _database.Save();
            }
        }
    }
}
