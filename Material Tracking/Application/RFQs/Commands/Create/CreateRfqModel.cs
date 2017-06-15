using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.RFQs.Commands.Upload
{
    public class CreateRfqModel
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}
