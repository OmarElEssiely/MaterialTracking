using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRs.Queries.GetIPRs
{
    public interface IGetRfqIprCommand
    {
        List<GetRfqIprModel> Execute(int rfqId);
    }
}
