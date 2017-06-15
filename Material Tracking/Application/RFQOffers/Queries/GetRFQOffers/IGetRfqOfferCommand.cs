using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQOffers.Queries.GetRFQOffers
{
    public interface IGetRfqOfferCommand
    {
        List<GetRfqOfferModel> Execute(int rfqId);
    }
}
