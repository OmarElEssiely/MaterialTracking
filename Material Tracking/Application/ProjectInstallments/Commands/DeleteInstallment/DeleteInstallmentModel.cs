using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectInstallments.Commands.DeleteInstallment
{
    public class DeleteInstallmentModel
    {
        public int InstallmentId { get; set; }
        public int ProjectId { get; set; }
    }
}
