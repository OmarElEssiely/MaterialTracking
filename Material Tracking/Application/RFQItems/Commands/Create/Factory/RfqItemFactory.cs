using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Domain;

namespace MT.Application.RFQItems.Commands.Create.Factory
{
    public class RfqItemFactory:IRfqItemFactory
    {
        private readonly IDatabaseService _database;
        public RfqItemFactory(IDatabaseService database)
        {
            _database = database;
        }
        public RfqItem Create(CreateRfqItemModel itemModel)
        {
            var rfq = _database.ProjectRfqs.FirstOrDefault(r => r.RfqId == itemModel.ProjectRfqId);
            var rfqItem = new RfqItem()
            {
                ProjectRfq = rfq,
                PartNumber = itemModel.PartNumber,
                DelivaryDate = itemModel.DelivaryDate,
                Description = itemModel.Description,
                Quantity = itemModel.Quantity
            };
            return rfqItem;
        }
    }
}
