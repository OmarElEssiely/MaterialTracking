using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace MT.Domain
{
    public class Installment
    {
        public Project Project { get; set; }
        public int InstallmentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string Comments { get; set; }
    }
}
