using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQs.Commands.Upload
{
    public interface ICreateRfqCommand
    {
        int Execute(CreateRfqModel rfqModel);
    }
}
