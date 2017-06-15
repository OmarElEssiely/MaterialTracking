using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Domain;

namespace MT.Application.ProjectInstallments.Commands.AddInstallment.Factory
{
    public class InstallmentFactory: IInstallmentFactory
    {
        private readonly IDatabaseService _database;
        public InstallmentFactory(IDatabaseService database)
        {
            _database = database;
        }
        public Installment Create(AddInstallmentModel installmentModel)
        {
           var installment = new Installment()
           {
               Project = _database.Projects.FirstOrDefault(p=>p.ProjectId==installmentModel.ProjectId),
               DueDate = installmentModel.DueDate,
               Amount = installmentModel.Amount,
               Comments = installmentModel.Comments
           };
            return installment;
        }
    }
}
