using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.RFQItems.Commands.Delete
{
    public class DeleteRqfItemCommand:IDeleteRqfItemCommand
    {
        private readonly IDatabaseService _database;
        public DeleteRqfItemCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(int rfqItemId)
        {
            var rfqItem = _database.RfqItems.FirstOrDefault(r => r.RfqItemId == rfqItemId);
            if(rfqItem ==null)return;
            _database.RfqItems.Remove(rfqItem);
            _database.Save();
        }
    }
}
