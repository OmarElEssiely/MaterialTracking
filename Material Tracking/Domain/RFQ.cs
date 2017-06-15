using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace MT.Domain
{
    public class ProjectRfq
    {
        public int RfqId { get; set; }
        public Project Project { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public User User { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public ICollection<RfqItem> RfqItems { get; set; }
        public ICollection<RfqOffer> RfqOffers { get; set; }
        public ICollection<ProjectIpr> ProjectIprs { get; set; }
    }
}
