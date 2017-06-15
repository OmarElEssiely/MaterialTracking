using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQOffers.Commands.Delete
{
    public interface IDeleteOfferCommand
    {
        void Execute(int offerid);
    }
}
