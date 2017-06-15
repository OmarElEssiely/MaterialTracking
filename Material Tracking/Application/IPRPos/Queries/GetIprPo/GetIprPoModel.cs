using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRPos.Queries.GetIprPo
{
    public class GetIprPoModel
    {
        public int ProjectIprPoId { get; set; }
        public DateTime PublishDate { get; set; }
        public string Path { get; set; }
    }
}
