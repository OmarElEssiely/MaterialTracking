using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Application.IPRs.Commands.Upload
{
    public interface IUploadIprCommand
    {
        void Execute(UploadIprModel iprModel);
    }
}
