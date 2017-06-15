using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Role.Commands.CreateRole;
using Application.Role.Commands.DeleteRole;
using Application.Role.Commands.UpdateRole;
using Application.Role.Queries.GetRoleList;
using MT.Application.Role.Queries.GetRoleById;

namespace Service.Controllers
{
    public class RoleController : ApiController
    {
        #region Properties 
        private readonly IGetRoleListQuery _getRoleListQuery;
        private readonly IGetRoleByIdQuery _getRoleByIdQuery;
        private readonly IUpdateRoleCommand _updateRoleCommand;
        private readonly ICreateRoleCommand _createRoleCommand;
        private readonly IDeleteRoleCommand _deleteRoleCommand;
        #endregion

        #region Constructor
        public RoleController(
         IGetRoleListQuery getRoleListQuery,
         IGetRoleByIdQuery getRoleByIdQuery,
         IUpdateRoleCommand updateRoleCommand,
         ICreateRoleCommand createRoleCommand,
         IDeleteRoleCommand deleteRoleCommand)
        {
            _getRoleListQuery = getRoleListQuery;
            _getRoleByIdQuery = getRoleByIdQuery;
            _updateRoleCommand = updateRoleCommand;
            _createRoleCommand = createRoleCommand;
            _deleteRoleCommand = deleteRoleCommand;
        }
        #endregion

        #region GetAPIs

        // GET: api/Admin
        public IHttpActionResult Get()
        {
            IHttpActionResult result = null;
            var roleList = _getRoleListQuery.Execute();
            if (roleList != null)
                result = Ok(roleList);
            else
                result = NotFound();
            return result;
        }

        // GET: api/Admin/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var role = _getRoleByIdQuery.Execute(id);
            if (role != null)
                result = Ok(role);
            else
                result = NotFound();
            return result;
        }
        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]CreateRoleModel createRoleModel)
        {
            IHttpActionResult result = null;
            try
            {
                _createRoleCommand.Execute(createRoleModel);
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
        public IHttpActionResult Put([FromBody]UpdateRoleModel updateRoleModel)
        {
            IHttpActionResult result = null;
            try
            {
                _updateRoleCommand.Execute(updateRoleModel);
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
                _deleteRoleCommand.Execute(id);
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
