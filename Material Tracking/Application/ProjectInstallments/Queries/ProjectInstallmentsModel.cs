using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace MT.Application.ProjectInstallments.Queries
{
    public class ProjectInstallmentsModel
    {
        public int InstallmentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string Comments { get; set; }
    }
}
