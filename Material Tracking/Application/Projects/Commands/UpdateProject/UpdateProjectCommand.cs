using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Projects.Commands.UpdateProject
{
    public class UpdateProjectCommand:IUpdateProjectCommand
    {
        private readonly IDatabaseService _database;

        public UpdateProjectCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(UpdateProjectModel model)
        {
            var project = _database.Projects.FirstOrDefault(a => a.ProjectId == model.ProjectId);
            if (project != null)
            {
                project.CreationDate = model.CreationDate;
                project.CustomerName = model.CustomerName;
                project.Description = model.Description;
                project.EndDate = model.EndDate;
                project.ProjectSapNumber = model.ProjectSapNumber;
                project.StartDate = model.StartDate;
                project.Status = model.Status;
                project.ClosedDate = model.ClosedDate;
                project.Budget = model.Budget;
                _database.Save();
            }
        }
    }
}
