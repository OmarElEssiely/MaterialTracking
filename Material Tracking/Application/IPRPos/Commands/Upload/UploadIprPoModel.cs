using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRPos.Commands.Upload
{
    public class UploadIprPoModel
    {
        public DateTime PublishDate { get; set; }
        public string Path { get; set; }
        public int ProjectIprId { get; set; }
        public int ProjectSubFolderId { get; set; }
        public string Name { get; set; }

    }
}
