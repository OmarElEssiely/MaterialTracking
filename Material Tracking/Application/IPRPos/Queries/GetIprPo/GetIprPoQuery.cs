using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.IPRPos.Queries.GetIprPo
{
    public class GetIprPoQuery:IGetIprPoQuery
    {
        private readonly IDatabaseService _database;
        public GetIprPoQuery(IDatabaseService database)
        {
            _database = database;
        }
        public List<GetIprPoModel> Execute(int iprId)
        {
            var iprPos =
                _database.ProjectIprPos.Where(i => i.ProjectIpr.ProjectIprId == iprId).Select(i => new GetIprPoModel()
                {
                    Path = i.Path,
                    PublishDate = i.PublishDate,
                    ProjectIprPoId = i.ProjectIprPoId
                }).ToList();
            return iprPos;
        }
    }
}
