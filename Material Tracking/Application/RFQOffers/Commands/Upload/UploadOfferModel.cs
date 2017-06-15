using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQOffers.Commands.Upload
{
    public class UploadOfferModel
    {
        public int ProjectRfqId { get; set; }
        public DateTime PublishDate { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int ProjectSubFolderId { get; set; }
    }
}
