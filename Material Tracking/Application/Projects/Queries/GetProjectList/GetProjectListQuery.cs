using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Projects.Queries.GetProjectList
{
    public class GetProjectListQuery:IGetProjectListQuery
    {
        private readonly IDatabaseService _database;

        public GetProjectListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<ProjectModel> Execute()
        {
            var projects = _database.Projects
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
                });
            return projects.ToList();
        }
    }
}
