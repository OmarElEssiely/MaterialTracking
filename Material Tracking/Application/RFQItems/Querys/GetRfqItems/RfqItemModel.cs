using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQItems.Querys.GetRfqItems
{
    public class RfqItemModel
    {
        public int RfqItemId { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime DelivaryDate { get; set; }
        public string ProjectRfqName { get; set; }
    }
}
