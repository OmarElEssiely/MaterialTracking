using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRPos.Commands.Upload
{
    public interface IUploadIprPoCommand
    {
        void Execute(UploadIprPoModel iprPoModel);
    }
}
