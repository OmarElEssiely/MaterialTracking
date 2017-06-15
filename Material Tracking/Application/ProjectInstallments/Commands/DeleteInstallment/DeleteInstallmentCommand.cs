using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.ProjectInstallments.Commands.DeleteInstallment
{
    public class DeleteInstallmentCommand:IDeleteInstallmentCommand
    {
        private readonly IDatabaseService _database;
        public DeleteInstallmentCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(DeleteInstallmentModel installmentModel)
        {
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == installmentModel.ProjectId);
            if (project != null)
            {
                var installment =
                    project.Installments.FirstOrDefault(x => x.InstallmentId == installmentModel.ProjectId);
                project.Installments.Remove(installment);
                _database.Save();
            }
        }
    }
}
