using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Application.RFQOffers.Commands.Upload.Factory
{
    public interface IUploadOfferFactory
    {
        RfqOffer Create(UploadOfferModel offerModel);
    }
}
