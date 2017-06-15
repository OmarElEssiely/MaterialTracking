using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MT.Application.IPRPos.Commands.Delete;
using MT.Application.IPRPos.Commands.Upload;
using MT.Application.IPRPos.Queries.GetIprPo;
using MT.Application.IPRs.Commands.Delete;
using MT.Application.IPRs.Commands.Upload;
using MT.Application.IPRs.Queries.GetIPRs;
using MT.Application.IPRs.Queries.GetProjectIPRs;

namespace Service.Controllers
{
    public class IprPoController : ApiController
    {
        #region Properties 
        private readonly IGetIprPoQuery _getIprPo;
        private readonly IUploadIprPoCommand _uploadIprPo;
        private readonly IDeleteIprPoCommand _deleteIprPo;
        #endregion

        #region Constructor
        public IprPoController(
         IGetIprPoQuery getIprPo,
         IUploadIprPoCommand uploadIprPo,
         IDeleteIprPoCommand deleteIprPo)
        {
            _getIprPo = getIprPo;
            _uploadIprPo = uploadIprPo;
            _deleteIprPo = deleteIprPo;
        }
        #endregion

        #region GetAPIs

        [HttpGet]
        // GET: api/Admin/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var iprPos = _getIprPo.Execute(id);
            if (iprPos != null)
                result = Ok(iprPos);
            else
                result = NotFound();
            return result;
        }
        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]UploadIprPoModel iprPoModel)
        {
            IHttpActionResult result = null;
            try
            {
                _uploadIprPo.Execute(iprPoModel);
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
                _deleteIprPo.Execute(id);
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
