using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Domain;

namespace MT.Application.IPRPos.Commands.Upload.Factory
{
    public interface IUploadIprPoFactory
    {
        ProjectIprPo Create(UploadIprPoModel iprPoModel);
    }
}
