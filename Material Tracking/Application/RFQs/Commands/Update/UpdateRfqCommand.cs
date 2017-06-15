using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.RFQs.Commands.Update
{
    public class UpdateRfqCommand:IUpdateRfqCommand
    {
        private readonly IDatabaseService _database;
        public UpdateRfqCommand(IDatabaseService database)
        {
            _database = database;
        }

        public void Execute(UpdateRfqModel rfqModel)
        {
            var rfq = _database.ProjectRfqs.FirstOrDefault(r => r.RfqId == rfqModel.RfqId);
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == rfqModel.ProjectId);
            if (rfq != null)
            {
                rfq.PublishDate = rfqModel.PublishDate;
                rfq.Status = rfqModel.Status;
                rfq.Comment = rfqModel.Comment;
                rfq.Name = rfqModel.Name;
                if (project != null)
                    rfq.Project = project;
                _database.Save();
            }
        }
    }
}
