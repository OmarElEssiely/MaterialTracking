using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQItems.Commands.Update
{
    public interface IUpdateRfqItemCommand
    {
        void Execute(UpdateRfqItemModel rfqItemModel);
    }
}
