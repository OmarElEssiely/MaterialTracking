using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Domain;

namespace MT.Application.ProjectInstallments.Commands.UpdateInstallment.Factory
{
    public class UpdateInstallmentFactory:IUpdateInstallmentFactory
    {
        private readonly IDatabaseService _database;
        public UpdateInstallmentFactory(IDatabaseService database)
        {
            _database = database;
        }
        public Installment Create(UpdateInstallmentModel installmentModel)
        {
            var installment = new Installment()
            {
                Project = _database.Projects.FirstOrDefault(p => p.ProjectId == installmentModel.ProjectId),
                DueDate = installmentModel.DueDate,
                Amount = installmentModel.Amount,
                Comments = installmentModel.Comments,
                InstallmentId = installmentModel.InstallmentId
            };
            return installment;
        }
    }
}
