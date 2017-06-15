using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.RFQOffers.Queries.GetRFQOffers
{
    public class GetRfqOfferCommand:IGetRfqOfferCommand
    {
        private readonly IDatabaseService _database;
        public GetRfqOfferCommand(IDatabaseService database)
        {
            _database = database;
        }
        public List<GetRfqOfferModel> Execute(int rfqId)
        {
            var offers = _database.RfqOffers.Where(r => r.ProjectRfq.RfqId == rfqId).Select(o => new GetRfqOfferModel()
            {
                Path = o.Path,
                Status = o.Status,
                PublishDate = o.PublishDate,
                RfqOfferId = o.RfqOfferId
            }).ToList();
            return offers;
        }
    }
}