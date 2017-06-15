using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.RFQItems.Querys.GetRfqItems
{
    public class GetRfqItemQuery:IGetRfqItemQuery
    {
        private readonly IDatabaseService _database;
        public GetRfqItemQuery(IDatabaseService database)
        {
            _database = database;
        }
        public List<RfqItemModel> Execute(int rfqId)
        {
            var rfqItems = _database.RfqItems.Where(r => r.ProjectRfq.RfqId == rfqId)
                .Select(r => new RfqItemModel()
                {
                    Quantity = r.Quantity,
                    DelivaryDate = r.DelivaryDate,
                    PartNumber = r.PartNumber,
                    Description = r.Description,
                    RfqItemId = r.RfqItemId,
                    ProjectRfqName = r.ProjectRfq.Name
                }).ToList();
            return rfqItems;
        }
    }
}
