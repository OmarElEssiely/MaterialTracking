using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Domain;

namespace MT.Application.RFQs.Commands.Upload.Factory
{
    public class CreateRfqFactory : ICreateRfqFactory
    {
        private readonly IDatabaseService _database;
        public CreateRfqFactory(IDatabaseService database)
        {
            _database = database;
        }
        public ProjectRfq Create(CreateRfqModel rfqModel)
        {
            var user = _database.Users.FirstOrDefault(u => u.UserId == rfqModel.UserId);
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == rfqModel.ProjectId);

            var rfq = new ProjectRfq()
            {
                Comment = rfqModel.Comment,
                Name = rfqModel.Name,
                Project = project,
                PublishDate = rfqModel.PublishDate,
                Status = rfqModel.Status,
                User = user
            };
            return rfq;
        }
    }
}
