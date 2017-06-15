using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.RFQItems.Commands.Create.Factory;

namespace MT.Application.RFQItems.Commands.Create
{
    public class CreateRfqItemCommand:ICreateRfqItemCommand
    {
        private readonly IDatabaseService _database;
        private readonly IRfqItemFactory _factory;
        public CreateRfqItemCommand(IDatabaseService database, IRfqItemFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(CreateRfqItemModel rfqItemModel)
        {
            var rfqItem = _factory.Create(rfqItemModel);
            _database.RfqItems.Add(rfqItem);
            _database.Save();
        }
    }
}
