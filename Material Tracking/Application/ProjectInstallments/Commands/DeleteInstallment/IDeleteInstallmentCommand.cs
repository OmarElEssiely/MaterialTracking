using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectInstallments.Commands.DeleteInstallment
{
    public interface IDeleteInstallmentCommand
    {
        void Execute(DeleteInstallmentModel installmentModel);

    }
}
