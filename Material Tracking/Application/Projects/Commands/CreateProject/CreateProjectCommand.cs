using Application.Admins.Commands.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Projects.Commands.Factory;
using Common.Dates;

namespace Application.Projects.Commands.CreateProject
{
    public class CreateProjectCommand : ICreateProjectCommand
    {
        private readonly IDatabaseService _database;
        private readonly IProjectFactory _factory;
        private readonly IDateService _dateService;

        public CreateProjectCommand(IDateService dateService, IDatabaseService database, IProjectFactory factory)
        {
            _dateService = dateService;
            _database = database;
            _factory = factory;

        }

        public int Execute(CreateProjectModel model)
        {
            var date = _dateService.GetDate();
            var project = _factory.Create(
                model.CustomerName,
                model.ProjectSapNumber,
                model.StartDate,
                model.EndDate,
                date,
                model.Description,
                model.Status,
                model.Budget);
            _database.Projects.Add(project);
            _database.Save();
            return _database.Projects.FirstOrDefault(p=>p.ProjectSapNumber == model.ProjectSapNumber).ProjectId;
           
        }

    }
    
}
