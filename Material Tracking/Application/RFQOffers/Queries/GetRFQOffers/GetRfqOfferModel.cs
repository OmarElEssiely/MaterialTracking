using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MT.Application.RFQOffers.Queries.GetRFQOffers
{
    public class GetRfqOfferModel
    {
        public int RfqOfferId { get; set; }
        public DateTime PublishDate { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
    }
}
