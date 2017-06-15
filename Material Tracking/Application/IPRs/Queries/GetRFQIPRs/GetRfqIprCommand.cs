using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.IPRs.Queries.GetIPRs;

namespace MT.Application.IPRs.Queries.GetRFQIPRs
{
    public class GetRfqIprCommand:IGetRfqIprCommand
    {
        private readonly IDatabaseService _database;
        public GetRfqIprCommand(IDatabaseService database)
        {
            _database = database;
        }

        public List<GetRfqIprModel> Execute(int rfqId)
        {
            var iprs = _database.ProjectIprs.Where(i => i.ProjectRfq.RfqId == rfqId).Select(i => new GetRfqIprModel()
            {
                Path = i.Path,
                Status = i.Status,
                Comment = i.Comment,
                ProjectIprId = i.ProjectIprId
            }).ToList();
            return iprs;
        }
    }
}
