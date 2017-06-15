using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Application.ProjectInstallments.Commands.AddInstallment.Factory
{
    public interface IInstallmentFactory
    {
        Installment Create(AddInstallmentModel installmentModel);
    }
}
