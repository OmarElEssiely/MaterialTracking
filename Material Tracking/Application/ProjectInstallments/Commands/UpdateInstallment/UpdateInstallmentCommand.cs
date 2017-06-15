using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.ProjectInstallments.Commands.UpdateInstallment.Factory;

namespace MT.Application.ProjectInstallments.Commands.UpdateInstallment
{
    public class UpdateInstallmentCommand:IUpdateInstallmentCommand
    {
        private readonly IDatabaseService _database;
        private readonly IUpdateInstallmentFactory _factory;
        public UpdateInstallmentCommand(IDatabaseService database, IUpdateInstallmentFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(UpdateInstallmentModel installmentModel)
        {
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == installmentModel.ProjectId);
            if (project != null)
            {
                var installment = project.Installments.FirstOrDefault(x => x.InstallmentId == installmentModel.InstallmentId);
                var updatedInstallment = _factory.Create(installmentModel);
                if (installment != null)
                {
                    installment.Project = updatedInstallment.Project;
                    installment.Amount = updatedInstallment.Amount;
                    installment.Comments = updatedInstallment.Comments;
                    installment.DueDate = updatedInstallment.DueDate;
                    installment.InstallmentId = updatedInstallment.InstallmentId;
                    _database.Save();
                }
            }
        }
    }
}
