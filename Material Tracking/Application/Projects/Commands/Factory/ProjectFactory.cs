using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Projects.Commands.Factory
{
    public class ProjectFactory:IProjectFactory
    {
        public Project Create(string customerName, string projectSapNumber, DateTime startDate, DateTime endDate, DateTime creationDate,
            string description, string status,decimal budget)
        {
            var project = new Project()
            {
                ProjectSapNumber = projectSapNumber,
                CreationDate = creationDate,
                CustomerName = customerName,
                Description = description,
                EndDate = endDate,
                StartDate = startDate,
                Status = status,
                Budget = budget
            };
            return project;
        }
    }
}
