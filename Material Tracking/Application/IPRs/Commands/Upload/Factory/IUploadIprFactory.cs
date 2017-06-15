using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Application.IPRs.Commands.Upload.Factory
{
    public interface IUploadIprFactory
    {
        ProjectIpr Create(UploadIprModel iprModel);
    }
}
