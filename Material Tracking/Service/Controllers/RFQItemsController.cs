using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MT.Application.RFQItems.Commands.Create;
using MT.Application.RFQItems.Commands.Delete;
using MT.Application.RFQItems.Commands.Update;
using MT.Application.RFQItems.Querys.GetRfqItems;

namespace Service.Controllers
{
    public class RfqItemsController : ApiController
    {
        #region Properties 
        private readonly IGetRfqItemQuery _getRfqItem;
        private readonly IUpdateRfqItemCommand _updateRfqItem;
        private readonly ICreateRfqItemCommand _createRfqItem;
        private readonly IDeleteRqfItemCommand _deleteRqfItem;
        #endregion

        #region Constructor
        public RfqItemsController(
         IGetRfqItemQuery getRfqItem,
         IUpdateRfqItemCommand updateRfqItem,
         ICreateRfqItemCommand createRfqItem,
         IDeleteRqfItemCommand deleteRqfItem)
        {
            _getRfqItem = getRfqItem;
            _updateRfqItem = updateRfqItem;
            _createRfqItem = createRfqItem;
            _deleteRqfItem = deleteRqfItem;
        }
        #endregion

        #region GetAPIs

        [HttpGet]
        // GET: api/Admin/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var rfqItems = _getRfqItem.Execute(id);
            if (rfqItems != null)
                result = Ok(rfqItems);
            else
                result = NotFound();
            return result;
        }

        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]CreateRfqItemModel rfqItemModel)
        {
            IHttpActionResult result = null;
            try
            {
                _createRfqItem.Execute(rfqItemModel);
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
        public IHttpActionResult Put([FromBody]UpdateRfqItemModel rfqItemModel)
        {
            IHttpActionResult result = null;
            try
            {
                _updateRfqItem.Execute(rfqItemModel);
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
                _deleteRqfItem.Execute(id);
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
