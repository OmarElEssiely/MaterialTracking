using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQItems.Commands.Create
{
    public class CreateRfqItemModel
    {
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime DelivaryDate { get; set; }
        public int ProjectRfqId { get; set; }
    }
}
