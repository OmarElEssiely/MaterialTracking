using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MT.Domain;

namespace MT.Application.RFQOffers.Commands.Upload.Factory
{
    public class UploadOfferFactory:IUploadOfferFactory
    {
        private readonly IDatabaseService _database;
        public UploadOfferFactory(IDatabaseService database)
        {
            _database = database;
        }
        public RfqOffer Create(UploadOfferModel offerModel)
        {
            var subfolderPath =
                _database.ProjectSubFolders.FirstOrDefault(p => p.ProjectSubFolderId == offerModel.ProjectSubFolderId)?.Path;
            var rfq = _database.ProjectRfqs.FirstOrDefault(r => r.RfqId == offerModel.ProjectRfqId);
            var fileExtention = System.IO.Path.GetExtension(offerModel.Path);

            var rfqOffer = new RfqOffer()
            {
                ProjectRfq = rfq,
                Path = subfolderPath + "/" + offerModel.Name+fileExtention,
                Status = offerModel.Status,
                PublishDate = offerModel.PublishDate,
            };
            return rfqOffer;
        }
    }
}
