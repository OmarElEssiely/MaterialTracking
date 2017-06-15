using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Domain;

namespace MT.Application.IPRs.Commands.Upload.Factory
{
    public class UploadIprFactory:IUploadIprFactory
    {
        private readonly IDatabaseService _database;
        public UploadIprFactory(IDatabaseService database)
        {
            _database = database;
        }

        public ProjectIpr Create(UploadIprModel iprModel)
        {
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == iprModel.ProjectId);
            var rfq = _database.ProjectRfqs.FirstOrDefault(r => r.RfqId == iprModel.ProjectRfqId);
            var ipr = new ProjectIpr()
            {
                ProjectRfq = rfq,
                Path = iprModel.Path,
                Status = iprModel.Status,
                Project = project
            };
            return ipr;
        }
    }
}
