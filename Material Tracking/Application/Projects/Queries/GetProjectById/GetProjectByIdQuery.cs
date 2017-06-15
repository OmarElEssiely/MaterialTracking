using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.Projects.Queries.GetProjectById
{
    public class GetProjectByIdQuery:IGetProjectByIdQuery
    {
        private readonly IDatabaseService _database;

        public GetProjectByIdQuery(IDatabaseService database)
        {
            _database = database;
        }
        public ProjectModel Execute(int projectId)
        {
            var project = _database.Projects.Where(p=>p.ProjectId ==projectId)
              .Select(p => new ProjectModel()
              {
                  ProjectId = p.ProjectId,
                  CustomerName = p.CustomerName,
                  EndDate = p.EndDate,
                  StartDate = p.StartDate,
                  CreationDate = p.CreationDate,
                  Status = p.Status,
                  Description = p.Description,
                  ProjectSapNumber = p.ProjectSapNumber,
                  ClosedDate = p.ClosedDate,
                  Budget = p.Budget
              }).FirstOrDefault();
            return project;
        }
    }
}
