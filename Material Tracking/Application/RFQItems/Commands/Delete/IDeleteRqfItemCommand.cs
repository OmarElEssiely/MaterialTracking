using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQItems.Commands.Delete
{
    public interface IDeleteRqfItemCommand
    {
        void Execute(int rfqItemId);
    }
}
