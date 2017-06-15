using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.RFQs.Queries.GetRfqsQuery
{
    public class GetRfqQuery:IGetRfqQuery
    {
        private readonly IDatabaseService _database;
        public GetRfqQuery(IDatabaseService database)
        {
            _database = database;
        }
        public List<RfqModel> Execute(int projectId)
        {
            var rfqs = _database.ProjectRfqs.Where(p => p.Project.ProjectId == projectId)
                .Select(p => new RfqModel()
                {
                    RfqId = p.RfqId,
                    Name = p.Name,
                    PublishDate = p.PublishDate,
                    Status = p.Status,
                    Comment = p.Comment,
                    ProjectName = p.Project.CustomerName,
                    UserName = p.User.UserName
                }).ToList();
            return rfqs;
        }
    }
}
