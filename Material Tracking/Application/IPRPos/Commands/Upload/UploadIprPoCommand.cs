using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.IPRPos.Commands.Upload.Factory;

namespace MT.Application.IPRPos.Commands.Upload
{
    public class UploadIprPoCommand:IUploadIprPoCommand
    {
        private readonly IDatabaseService _database;
        private readonly IUploadIprPoFactory _factory;
        public UploadIprPoCommand(IDatabaseService database, IUploadIprPoFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(UploadIprPoModel iprPoModel)
        {
            //Upload File To Server
            var subfolderpath =
                _database.ProjectSubFolders.FirstOrDefault(s => s.ProjectSubFolderId == iprPoModel.ProjectSubFolderId)?
                    .Path;
            if (subfolderpath != null)
            {
                string targetPath = Path.Combine(subfolderpath, iprPoModel.Name);
                File.Copy(iprPoModel.Path, targetPath, true);
            }

            //Save Path To Database
            var iprPo = _factory.Create(iprPoModel);
            _database.ProjectIprPos.Add(iprPo);
            _database.Save();
        }
    }
}
