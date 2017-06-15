using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQs.Queries.GetRfqsQuery
{
    public interface IGetRfqQuery
    {
        List<RfqModel> Execute(int projectId);
    }
}
