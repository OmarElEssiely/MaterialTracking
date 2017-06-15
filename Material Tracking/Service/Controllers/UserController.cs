using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Users.Commands.CreateUser;
using Application.Users.Commands.DeleteUser;
using Application.Users.Commands.UpdateUser;
using Application.Users.Queries.GetUserList;
using MT.Application.Users.Queries.GetUserByPassword;

namespace Service.Controllers
{
    public class UserController : ApiController
    {
        #region Properties 
        private readonly IGetUserListQuery _getUserListQuery;
        private readonly IGetUserByPasswordQuery _getUserByPassword;
        private readonly IUpdateUserCommand _updateUserCommand;
        private readonly ICreateUserCommand _createUserCommand;
        private readonly IDeleteUserCommand _deleteUserCommand;
        #endregion

        #region Constructor
        public UserController(
         IGetUserListQuery getUserListQuery,
         IGetUserByPasswordQuery getUserByPassword,
         IUpdateUserCommand updateUserCommand,
         ICreateUserCommand createUserCommand,
         IDeleteUserCommand deleteUserCommand)
        {
            _getUserListQuery = getUserListQuery;
            _getUserByPassword = getUserByPassword;
            _updateUserCommand = updateUserCommand;
            _createUserCommand = createUserCommand;
            _deleteUserCommand = deleteUserCommand;
        }
        #endregion

        #region GetAPIs

        // GET: api/Admin
        public IHttpActionResult Get()
        {
            IHttpActionResult result = null;
            var userList = _getUserListQuery.Execute();
            if (userList != null)
                result = Ok(userList);
            else
                result = NotFound();
            return result;
        }

        // GET: api/Admin/5
        public IHttpActionResult Get(string id)
        {
            IHttpActionResult result = null;
            var user = _getUserByPassword.Execute(id);
            if (user != null)
                result = Ok(user);
            else
                result = NotFound();
            return result;
        }
        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]CreateUserModel createUserModel)
        {
            IHttpActionResult result = null;
            try
            {
                _createUserCommand.Execute(createUserModel);
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
        public IHttpActionResult Put([FromBody]UpdateUserModel updateUserModel)
        {
            IHttpActionResult result = null;
            try
            {
                _updateUserCommand.Execute(updateUserModel);
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
                _deleteUserCommand.Execute(id);
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
