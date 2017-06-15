using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Domain
{
    public class RfqOffer
    {
        public int  RfqOfferId { get; set; }
        public ProjectRfq ProjectRfq { get; set; }
        public DateTime PublishDate { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
    }
}
