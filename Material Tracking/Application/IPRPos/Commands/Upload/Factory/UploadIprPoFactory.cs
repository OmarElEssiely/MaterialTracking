using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Domain;

namespace MT.Application.IPRPos.Commands.Upload.Factory
{
    public class UploadIprPoFactory:IUploadIprPoFactory
    {
        private readonly IDatabaseService _database;
        public UploadIprPoFactory(IDatabaseService database)
        {
            _database = database;
        }
        public ProjectIprPo Create(UploadIprPoModel iprPoModel)
        {
            var ipr = _database.ProjectIprs.FirstOrDefault(i => i.ProjectIprId == iprPoModel.ProjectIprId);
            var iprPo= new ProjectIprPo()
            {
                ProjectIpr = ipr,
                Path = iprPoModel.Path,
                PublishDate = iprPoModel.PublishDate
            };
            return iprPo;
        }
    }
}
