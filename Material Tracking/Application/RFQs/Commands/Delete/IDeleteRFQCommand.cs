using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQs.Commands.Delete
{
    public interface IDeleteRfqCommand
    {
        void Execute(int rfqId);
    }
}
