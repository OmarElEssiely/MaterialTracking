using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.RFQs.Commands.Delete
{
    public class DeleteRfqCommand:IDeleteRfqCommand
    {
        private readonly IDatabaseService _database;
        public DeleteRfqCommand(IDatabaseService database)
        {
            _database = database;
        }

        public void Execute(int rfqId)
        {
            //Delete Offers 
            DeleteOffers(rfqId);
            //Delete Items
            DeleteItems(rfqId);
            //Delete IPRs
            DeleteIprs(rfqId);
            //Delete Rfq
            DeleteRfq(rfqId);
        }

        private void DeleteRfq(int rfqId)
        {
            var rfq = _database.ProjectRfqs.FirstOrDefault(r => r.RfqId == rfqId);
            if (rfq == null) return;
            _database.ProjectRfqs.Remove(rfq);
            _database.Save();
        }

        private void DeleteIprs(int rfqId)
        {
            var iprs = _database.ProjectIprs.Where(i => i.ProjectRfq.RfqId == rfqId).ToList();
            foreach (var projectIpr in iprs)
            {
                _database.ProjectIprs.Remove(projectIpr);
                _database.Save();
            }
        }

        private void DeleteItems(int rfqId)
        {
            var items = _database.RfqItems.Where(i => i.ProjectRfq.RfqId == rfqId).ToList();
            foreach (var item in items)
            {
                _database.RfqItems.Remove(item);
                _database.Save();
            }
        }

        private void DeleteOffers(int rfqId)
        {
            var offers = _database.RfqOffers.Where(r => r.ProjectRfq.RfqId == rfqId).ToList();
            foreach (var offer in offers)
            {
                _database.RfqOffers.Remove(offer);
                _database.Save();
            }
        }
    }
}
