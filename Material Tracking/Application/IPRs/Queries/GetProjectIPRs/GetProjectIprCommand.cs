using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.IPRs.Queries.GetProjectIPRs
{
    public class GetProjectIprCommand:IGetProjectIprCommand
    {
        private readonly IDatabaseService _database;
        public GetProjectIprCommand(IDatabaseService database)
        {
            _database = database;
        }
        public List<GetProjectIprModel> Execute(int projectId)
        {
            var iprs = _database.ProjectIprs.Where(i => i.Project.ProjectId == projectId).Select(i => new GetProjectIprModel()
            {
                Path = i.Path,
                Status = i.Status,
                Comment = i.Comment,
                ProjectIprId = i.ProjectIprId,
                RfqName = i.ProjectRfq.Name
            }).ToList();
            return iprs;
        }
    }
}
