using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Application.ProjectInstallments.Commands.UpdateInstallment.Factory
{
    public interface IUpdateInstallmentFactory
    {
        Installment Create(UpdateInstallmentModel installment);
    }
}
