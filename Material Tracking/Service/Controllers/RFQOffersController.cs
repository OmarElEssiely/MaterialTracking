using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MT.Application.RFQOffers.Commands.Delete;
using MT.Application.RFQOffers.Commands.Upload;
using MT.Application.RFQOffers.Queries.GetRFQOffers;

namespace Service.Controllers
{
    public class RfqOffersController : ApiController
    {
        #region Properties 
        private readonly IGetRfqOfferCommand _getRfqOffer;
        private readonly IUploadOfferCommand _uploadOffer;
        private readonly IDeleteOfferCommand _deleteOffer;
        #endregion

        #region Constructor
        public RfqOffersController(
         IGetRfqOfferCommand getRfqOffer,
         IUploadOfferCommand uploadOffer,
         IDeleteOfferCommand deleteOffer)
        {
            _getRfqOffer = getRfqOffer;
            _uploadOffer = uploadOffer;
            _deleteOffer = deleteOffer;
        }
        #endregion

        #region GetAPIs

        [HttpGet]
        // GET: api/Admin/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var rfqOffers = _getRfqOffer.Execute(id);
            if (rfqOffers != null)
                result = Ok(rfqOffers);
            else
                result = NotFound();
            return result;
        }

        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]UploadOfferModel offerModel)
        {
            IHttpActionResult result = null;
            try
            {
                _uploadOffer.Execute(offerModel);
                result = Ok();
            }
            catch (Exception e)
            {
                result = NotFound();
            }
            return result;
        }


        #endregion

        #region DeleteAPI
        // DELETE: api/Admin/5
        public IHttpActionResult Delete(int id)
        {
            IHttpActionResult result = null;
            try
            {
                _deleteOffer.Execute(id);
                result = Ok();
            }
            catch (Exception e)
            {
                result = NotFound();
            }
            return result;
        }
        #endregion
    }
}
