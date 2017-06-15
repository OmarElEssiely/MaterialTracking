using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Application.RFQItems.Commands.Create.Factory
{
    public interface IRfqItemFactory
    {
        RfqItem Create(CreateRfqItemModel itemModel);
    }
}
