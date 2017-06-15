using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MT.Application.RFQs.Commands.Delete;
using MT.Application.RFQs.Commands.Update;
using MT.Application.RFQs.Commands.Upload;
using MT.Application.RFQs.Queries.GetRfqsQuery;

namespace Service.Controllers
{
    public class RfqController : ApiController
    {
        #region Properties 
        private readonly IGetRfqQuery _getRfqQuery;
        private readonly IUpdateRfqCommand _updateRfq;
        private readonly ICreateRfqCommand _createRfq;
        private readonly IDeleteRfqCommand _deleteRfq;
        #endregion

        #region Constructor
        public RfqController(
         IGetRfqQuery getRfqQuery,
         IUpdateRfqCommand updateRfq,
         ICreateRfqCommand createRfq,
         IDeleteRfqCommand deleteRfq)
        {
            _getRfqQuery = getRfqQuery;
            _updateRfq = updateRfq;
            _createRfq = createRfq;
            _deleteRfq = deleteRfq;
        }
        #endregion

        #region GetAPIs

        [HttpGet]
        // GET: api/Admin/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var rfqs = _getRfqQuery.Execute(id);
            if (rfqs != null)
                result = Ok(rfqs);
            else
                result = NotFound();
            return result;
        }

        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]CreateRfqModel rfqModel)
        {
            IHttpActionResult result = null;
            try
            {
                _createRfq.Execute(rfqModel);
                result = Ok();
            }
            catch (Exception e)
            {
                result = NotFound();
            }
            return result;
        }


        #endregion

        #region UpdateAPI
        // PUT: api/Admin/5
        public IHttpActionResult Put([FromBody]UpdateRfqModel rfqModel)
        {
            IHttpActionResult result = null;
            try
            {
                _updateRfq.Execute(rfqModel);
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
                _deleteRfq.Execute(id);
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
