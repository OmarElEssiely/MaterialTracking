using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Projects.Commands.DeleteProject
{
    public class DeleteProjectCommand:IDeleteProjectCommand
    {
        private readonly IDatabaseService _database;

        public DeleteProjectCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(int projectId)
        {
            var project=_database.Projects.FirstOrDefault(a => a.ProjectId == projectId);
            if (project != null)
            {
                _database.Projects.Remove(project);
                _database.Save();
            }
        }
    }
}
