using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Application.RFQs.Commands.Upload.Factory
{
    public interface ICreateRfqFactory
    {
        ProjectRfq Create(CreateRfqModel rfqModel);
    }
}
