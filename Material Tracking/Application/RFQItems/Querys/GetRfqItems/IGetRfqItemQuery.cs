using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQItems.Querys.GetRfqItems
{
    public interface IGetRfqItemQuery
    {
        List<RfqItemModel> Execute(int rfqId);
    }
}
