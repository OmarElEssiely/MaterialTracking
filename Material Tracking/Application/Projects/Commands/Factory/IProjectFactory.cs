using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Projects.Commands.Factory
{
    public interface IProjectFactory
    {
        Project Create(
            string customerName,
            string projectSapNumber,
            DateTime startDate,
            DateTime endDate,
            DateTime creationDate,
            string description,
            string status,
            decimal budget);

    }
}
