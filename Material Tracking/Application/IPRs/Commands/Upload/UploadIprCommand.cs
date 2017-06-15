using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.IPRs.Commands.Upload.Factory;

namespace MT.Application.IPRs.Commands.Upload
{
    public class UploadIprCommand:IUploadIprCommand
    {
        private readonly IDatabaseService _database;
        private readonly IUploadIprFactory _factory;
        public UploadIprCommand(IDatabaseService database, IUploadIprFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(UploadIprModel iprModel)
        {
            //Upload File To Server
            var subfolderpath =
                _database.ProjectSubFolders.FirstOrDefault(s => s.ProjectSubFolderId == iprModel.ProjectSubFolderId)?
                    .Path;
            if (subfolderpath != null)
            {
                string targetPath = Path.Combine(subfolderpath, iprModel.Name);
                File.Copy(iprModel.Path, targetPath, true);
            }

            //Save Path To Database
            var ipr = _factory.Create(iprModel);
            _database.ProjectIprs.Add(ipr);
            _database.Save();
        }
    }
}
