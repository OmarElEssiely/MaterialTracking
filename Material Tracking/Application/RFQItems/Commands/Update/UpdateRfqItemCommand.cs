using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.RFQItems.Commands.Update
{
    public class UpdateRfqItemCommand:IUpdateRfqItemCommand
    {
        private readonly IDatabaseService _database;
        public UpdateRfqItemCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(UpdateRfqItemModel rfqItemModel)
        {
            var rfqItem = _database.RfqItems.FirstOrDefault(r => r.ProjectRfq.RfqId == rfqItemModel.ProjectRfqId);
            if(rfqItem == null)return;
            rfqItem.DelivaryDate = rfqItemModel.DelivaryDate;
            rfqItem.Description = rfqItemModel.Description;
            rfqItem.PartNumber = rfqItemModel.PartNumber;
            rfqItem.Quantity = rfqItemModel.Quantity;
            _database.Save();
        }
    }
}
