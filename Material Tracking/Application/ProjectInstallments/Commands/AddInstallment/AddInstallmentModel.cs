﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.ProjectInstallments.Commands.AddInstallment
{
    public class AddInstallmentModel
    {
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string Comments { get; set; }
        public int ProjectId { get; set; }
    }
}
