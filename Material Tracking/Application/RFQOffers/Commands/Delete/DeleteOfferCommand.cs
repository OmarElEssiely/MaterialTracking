using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.RFQOffers.Commands.Delete
{
    public class DeleteOfferCommand:IDeleteOfferCommand
    {
        private readonly IDatabaseService _database;
        public DeleteOfferCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(int offerid)
        {
            //Delete File From Server 
            var offer = _database.RfqOffers.FirstOrDefault(f => f.RfqOfferId == offerid);
            if (offer != null) File.Delete(offer.Path);

            //Delete File From DB 
            _database.RfqOffers.Remove(offer);
            _database.Save();
        }
    }
}
