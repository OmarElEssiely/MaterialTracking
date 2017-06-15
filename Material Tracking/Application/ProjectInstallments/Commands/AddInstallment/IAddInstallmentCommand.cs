using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectInstallments.Commands.AddInstallment
{
    public interface IAddInstallmentCommand
    {
        void Execute(AddInstallmentModel installmentModel);
    }
}
