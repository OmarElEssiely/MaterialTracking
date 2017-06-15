using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Domain;

namespace MT.Application.ProjectInstallments.Queries
{
    public class GetProjectInstallmentsQuery:IGetProjectInstallmentsQuery
    {
        private readonly IDatabaseService _database;

        public GetProjectInstallmentsQuery(IDatabaseService database)
        {
            _database = database;
        }
        public List<ProjectInstallmentsModel> Execute(int projectId)
        {
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == projectId);
            var projectInstallments = project?.Installments.Select(i=>new ProjectInstallmentsModel()
            {
                DueDate = i.DueDate,
                InstallmentId = i.InstallmentId,
                Amount = i.Amount,
                Comments = i.Comments
            });
            return projectInstallments?.ToList();
        }
    }
}
