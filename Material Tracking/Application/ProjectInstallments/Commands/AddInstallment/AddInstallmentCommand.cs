using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.ProjectInstallments.Commands.AddInstallment.Factory;

namespace MT.Application.ProjectInstallments.Commands.AddInstallment
{
    public class AddInstallmentCommand:IAddInstallmentCommand
    {
        private readonly IDatabaseService _database;
        private readonly IInstallmentFactory _factory;
        public AddInstallmentCommand(IDatabaseService database, IInstallmentFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(AddInstallmentModel installmentModel)
        {
            var installment = _factory.Create(installmentModel);
            var project = _database.Projects.FirstOrDefault(p => p.ProjectId == installmentModel.ProjectId);
            project?.Installments.Add(installment);
            _database.Save();
        }
    }
}
