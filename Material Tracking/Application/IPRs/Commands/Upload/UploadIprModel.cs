using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRs.Commands.Upload
{
    public class UploadIprModel
    {
        public int ProjectId { get; set; }
        public int ProjectRfqId { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int ProjectSubFolderId { get; set; }

    }
}
