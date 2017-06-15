using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRPos.Queries.GetIprPo
{
    public interface IGetIprPoQuery
    {
        List<GetIprPoModel> Execute(int iprId);
    }
}
