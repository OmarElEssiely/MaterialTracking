using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Application.ProjectInstallments.Queries
{
    public interface IGetProjectInstallmentsQuery
    {
        List<ProjectInstallmentsModel> Execute(int projectId);
    }
}
