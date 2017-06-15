using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.RFQs.Commands.Upload.Factory;

namespace MT.Application.RFQs.Commands.Upload
{
    public class CreateRfqCommand : ICreateRfqCommand
    {
        private readonly IDatabaseService _database;
        private readonly ICreateRfqFactory _factory;
        public CreateRfqCommand(IDatabaseService database, ICreateRfqFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public int Execute(CreateRfqModel rfqModel)
        {
            var rfq = _factory.Create(rfqModel);
            _database.ProjectRfqs.Add(rfq);
            _database.Save();
            return _database.ProjectRfqs.FirstOrDefault(p => p.Name == rfqModel.Name).RfqId;
        }
    }
}
