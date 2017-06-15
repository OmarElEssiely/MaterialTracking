using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MT.Application.ProjectUsersRoles.Commands.AddUserRole;
using MT.Application.ProjectUsersRoles.Commands.DeleteUserRole;
using MT.Application.ProjectUsersRoles.Commands.UpdateUserRole;
using MT.Application.ProjectUsersRoles.Queries;

namespace Service.Controllers
{
    public class ProjectUserRoleController : ApiController
    {
        #region Properties 
        private readonly IGetProjectUsersRolesQuery _getProjectUsersRoles;
        private readonly IUpdateUserRoleCommand _updateUserRole;
        private readonly IAddUserRoleCommand _addUserRole;
        private readonly IDeleteUserRoleCommand _deleteUserRole;
        #endregion

        #region Constructor
        public ProjectUserRoleController(
         IGetProjectUsersRolesQuery getProjectUsersRoles,
         IUpdateUserRoleCommand updateUserRole,
         IAddUserRoleCommand addUserRole,
         IDeleteUserRoleCommand deleteUserRole)
        {
            _getProjectUsersRoles = getProjectUsersRoles;
            _updateUserRole = updateUserRole;
            _addUserRole = addUserRole;
            _deleteUserRole = deleteUserRole;
        }
        #endregion

        #region GetAPIs

        // GET: api/Admin/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var projectusersroles = _getProjectUsersRoles.Execute(id);
            if (projectusersroles != null)
                result = Ok(projectusersroles);
            else
                result = NotFound();
            return result;
        }
        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]AddUserRoleModel addUserRole)
        {
            IHttpActionResult result = null;
            try
            {
                _addUserRole.Execute(addUserRole);
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
        public IHttpActionResult Put([FromBody]UpdateUserRoleModel updateUserRole)
        {
            IHttpActionResult result = null;
            try
            {
                _updateUserRole.Execute(updateUserRole);
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
        public IHttpActionResult Delete(DeleteUserRoleModel userRole)
        {
            IHttpActionResult result = null;
            try
            {
                _deleteUserRole.Execute(userRole);
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
