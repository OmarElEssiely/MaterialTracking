using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Admins.Commands.CreateAdmin;
using Application.Admins.Commands.DeleteAdmin;
using Application.Admins.Commands.UpdateAdmin;
using Application.Admins.Queries.GetAdminList;
using MT.Application.Admins.Queries.GetAdminByPassword;

namespace Service.Controllers
{
    public class AdminController : ApiController
    {
        #region Properties 
        private readonly IGetAdminListQuery _getAdminListQuery;
        private readonly IGetAdminByPasswordQuery _getAdminByPasswordQuery;
        private readonly IUpdateAdminCommand _updateAdminCommand;
        private readonly ICreateAdminCommand _createAdminCommand;
        private readonly IDeleteAdminCommand _deleteAdminCommand;
        #endregion

        #region Constructor
        public AdminController(
         IGetAdminListQuery getAdminListQuery,
         IGetAdminByPasswordQuery getAdminByPassword,
         IUpdateAdminCommand updateAdminCommand,
         ICreateAdminCommand createAdminCommand,
         IDeleteAdminCommand deleteAdminCommand)
        {
            _getAdminListQuery = getAdminListQuery;
            _getAdminByPasswordQuery = getAdminByPassword;
            _updateAdminCommand = updateAdminCommand;
            _createAdminCommand = createAdminCommand;
            _deleteAdminCommand = deleteAdminCommand;
        }
        #endregion

        #region GetAPIs

        [HttpGet]
        // GET: api/Admin/5
        public IHttpActionResult Get(string id)
        {
            IHttpActionResult result = null;
            var admin = _getAdminByPasswordQuery.Execute(id);
            if (admin != null)
                result = Ok(admin);
            else
                result = NotFound();
            return result;
        }

        [HttpGet]
        // GET: api/Admin
        public IHttpActionResult Get()
        {
            IHttpActionResult result = null;
            var adminList = _getAdminListQuery.Execute();
            if (adminList !=null)
                result = Ok(adminList);
            else
                result = NotFound();
            return result;
        }
        
        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]CreateAdminModel createAdminModel)
        {
            IHttpActionResult result = null;
            try
            {
                _createAdminCommand.Execute(createAdminModel);
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
        public IHttpActionResult Put([FromBody]UpdateAdminModel updateAdminModel)
        {
            IHttpActionResult result = null;
            try
            {
                _updateAdminCommand.Execute(updateAdminModel);
                result= Ok();
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
                _deleteAdminCommand.Execute(id);
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
