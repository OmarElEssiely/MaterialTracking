using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQOffers.Commands.Upload
{
    public interface IUploadOfferCommand
    {
        void Execute(UploadOfferModel offerModel);
    }
}
