using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MT.Application.IPRs.Commands.Delete;
using MT.Application.IPRs.Commands.Upload;
using MT.Application.IPRs.Queries.GetIPRs;
using MT.Application.IPRs.Queries.GetProjectIPRs;

namespace Service.Controllers
{
    public class IprController : ApiController
    {
        #region Properties 
        private readonly IGetProjectIprCommand _getProjectIpr;
        private readonly IGetRfqIprCommand _getRfqIpr;
        private readonly IUploadIprCommand _uploadIpr;
        private readonly IDeleteIprCommand _deleteIpr;
        #endregion

        #region Constructor
        public IprController(
         IGetProjectIprCommand getProjectIpr,
         IGetRfqIprCommand getRfqIpr,
         IUploadIprCommand uploadIpr,
         IDeleteIprCommand deleteIpr)
        {
            _getProjectIpr = getProjectIpr;
            _getRfqIpr = getRfqIpr;
            _uploadIpr = uploadIpr;
            _deleteIpr = deleteIpr;
        }
        #endregion

        #region GetAPIs

        [HttpGet]
        // GET: api/Admin/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var rfqIprs = _getRfqIpr.Execute(id);
            if (rfqIprs != null)
                result = Ok(rfqIprs);
            else
                result = NotFound();
            return result;
        }
        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]UploadIprModel iprModel)
        {
            IHttpActionResult result = null;
            try
            {
                _uploadIpr.Execute(iprModel);
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
                _deleteIpr.Execute(id);
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
