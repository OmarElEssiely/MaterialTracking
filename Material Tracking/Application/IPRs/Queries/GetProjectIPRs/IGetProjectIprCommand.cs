using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRs.Queries.GetProjectIPRs
{
    public interface IGetProjectIprCommand
    {
        List<GetProjectIprModel> Execute(int projectId);
    }
}
