using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQs.Commands.Update
{
    public interface IUpdateRfqCommand
    {
        void Execute(UpdateRfqModel rfqModel);
    }
}
