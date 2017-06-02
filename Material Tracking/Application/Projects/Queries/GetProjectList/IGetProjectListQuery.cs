using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Projects.Queries.GetProjectList
{
    public interface IGetProjectListQuery
    {
        List<ProjectModel> Execute();

    }
}
