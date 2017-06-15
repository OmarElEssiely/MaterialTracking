using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Application.RFQOffers.Commands.Upload.Factory;

namespace MT.Application.RFQOffers.Commands.Upload
{
    public class UploadOfferCommand:IUploadOfferCommand
    {
        private readonly IDatabaseService _database;
        private readonly IUploadOfferFactory _factory;
        public UploadOfferCommand(IDatabaseService database, IUploadOfferFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(UploadOfferModel offerModel)
        {
            //Upload File To Server
            var subfolderpath =
                _database.ProjectSubFolders.FirstOrDefault(s => s.ProjectSubFolderId == offerModel.ProjectSubFolderId)?
                    .Path;
            if (subfolderpath != null)
            {
                string targetPath = Path.Combine(subfolderpath, offerModel.Name);
                File.Copy(offerModel.Path,targetPath,true);
            }
            //Save Path To Database
            var rfqOffer = _factory.Create(offerModel);
            _database.RfqOffers.Add(rfqOffer);
            _database.Save();
        }
    }
}